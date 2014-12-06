#include <EtherCard.h>

// ethernet mac address - must be unique on your network
static byte mymac[] = { 0x74, 0x69, 0x69, 0x2D, 0x30, 0x31 };

// Buffer
byte Ethernet::buffer[500];
BufferFiller bfill;

// Colors
byte red, newRed = 0;
byte green, newGreen = 0;
byte blue, newBlue = 0;

// Relay
byte relay = 0;

// Loop slow
byte loopID = 0;

// Status page
static word statusPage() {
	bfill = ether.tcpOffset();
	bfill.emit_p(PSTR(
		"HTTP/1.0 200 OK\r\n"
		"\r\n"
		"{\"r\":\"$D\",\"g\":\"$D\",\"b\":\"$D\",\"d\":\"$D\"}"),
		newRed, newGreen, newBlue, relay);
	return bfill.position();
}

// Setup
void setup() {
	// Pins
	pinMode(2, OUTPUT);
	pinMode(3, OUTPUT);
	pinMode(5, OUTPUT);
	pinMode(6, OUTPUT);
	pinMode(A0, INPUT);
	
    // PWM Frequency
    // Not sure if this is a good idea, it kinda messed up the ethernet
    TCCR2A = _BV(COM2A0) | _BV(COM2B1) | _BV(WGM21) | _BV(WGM20);
    TCCR2B = _BV(WGM22) | _BV(CS22);
    OCR2A = 180;
    OCR2B = 50;

	// Prepare external devics
	setColors();
	setRelay();

	if (ether.begin(sizeof Ethernet::buffer, mymac, 10) == 0) {
		red = 125;
		setColors();
	}
	if (!ether.dhcpSetup()) {
		red = 125;
		setColors();
	}

	//ether.printIp("IP:  ", ether.myip);
	//ether.printIp("GW:  ", ether.gwip);  
	//ether.printIp("DNS: ", ether.dnsip);
}

void setColors() {
	if (loopID == 100) {
		loopID = 0;

		// Red
		if (newRed > red) {
			red++;
			analogWrite(5, red);
		}
		else if (newRed < red) {
			red--;
			analogWrite(5, red);
		}

		// Green
		if (newGreen > green) {
			green++;
			analogWrite(6, green);
		}
		else if (newGreen < green) {
			green--;
			analogWrite(6, green);
		}

		// Blue
		if (newBlue > blue) {
			blue++;
			analogWrite(3, blue);
		}
		else if (newBlue < blue) {
			blue--;
			analogWrite(3, blue);
		}
	} else loopID++;
	
}

void setRelay() {
	if (relay != 0) digitalWrite(2, HIGH);
	else digitalWrite(2, LOW);
}

void loop(){
	setColors();
	// wait for an incoming TCP packet, but ignore its contents
	word len = ether.packetReceive();
	word pos = ether.packetLoop(len);
	if (pos) {
		char* data = (char *)Ethernet::buffer + pos;
		if (strncmp("GET /", data, 5) == 0){
			char *token = strtok(data, "H"); // Get everything up to the /
			char * pch;
            
            // Get everything after the /
            pch = strtok(token, "/");
            pch = strtok(NULL, "/");

            if (strlen(pch) > 1) {
                // Convert our input to a long
                unsigned long n = atol(pch);

                // Extract colour data from the long
                // Each long is 4 bytes, one for each color and one
                // for the relay.
                newRed = (byte) (n >> 24) & 0xFF;
                newGreen = (byte) (n >> 16) & 0xFF;
                newBlue = (byte) (n >> 8) & 0xFF;
                relay = (byte) n & 0xFF;
                
                // Set the new relay state
                setRelay();
            }
            
			ether.httpServerReply(statusPage());
		}
	}
}


