package com.sakisds.arduinocontrol.api;

/**
 * Created by Thanasis Georgiou on 04/07/2014.
 */
public class JSONResponse {
    public String r, g, b, d;

    public JSONResponse(String red, String green, String blue, String deskLamp, String temp) {
        this.r = red;
        this.g = green;
        this.b = blue;
        this.d = deskLamp;
    }
}
