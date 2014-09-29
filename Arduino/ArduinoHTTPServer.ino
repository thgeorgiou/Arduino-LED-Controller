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

// Desklamp
byte deskLamp = 0;

// Loop slow
byte loopID = 0;

// Status page
static word statusPage() {
	bfill = ether.tcpOffset();
	bfill.emit_p(PSTR(
		"HTTP/1.0 200 OK\r\n"
		"\r\n"
		"{\"r\":\"$D\",\"g\":\"$D\",\"b\":\"$D\",\"d\":\"$D\"}"),
		newRed, newGreen, newBlue, deskLamp);
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
	TCCR2B = TCCR2B & 0b11111000 | 0x02;

	// Prepare external devics
	setColors();
	setLamp();

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

void setLamp() {
	if (deskLamp != 0) digitalWrite(2, HIGH);
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
			String str;

			char *token = strtok(data, "H"); // Get everything up to the /
			char * pch;

			pch = strtok(token, "?");
			while (pch != NULL) {
				if (strncmp(pch, "r=", 2) == 0) {
					newRed = atoi(pch + 2);

					// Sanitize input
					if (newRed > 255) newRed = 255;
					else if (newRed < 0) newRed = 0;

				} else if (strncmp(pch, "g=", 2) == 0) {
					newGreen = atoi(pch + 2);

					// Sanitize input
					if (newGreen > 255) newGreen = 255;
					else if (newGreen < 0) newGreen = 0;

				} else if (strncmp(pch, "b=", 2) == 0) {
					newBlue = atoi(pch + 2);

					// Sanitize input
					if (newBlue > 255) newBlue = 255;
					else if (newBlue < 0) newBlue = 0;

				} else if (strncmp(pch, "d=", 2) == 0) {
					deskLamp = atoi(pch + 2);

					setLamp();
				}
				pch = strtok(NULL, "?");
			}
			ether.httpServerReply(statusPage());
		}
	}
}


