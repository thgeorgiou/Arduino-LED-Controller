package com.sakisds.arduinocontrol.api;

import android.util.Log;

/**
 * Created by Thanasis Georgiou on 15/10/2014.
 */
public class Utils {
    public static long StoreInInteger(int red, int green, int blue, int relay) {
        long rgbr = red;

        rgbr = (rgbr << 8) + green;
        rgbr = (rgbr << 8) + blue;
        rgbr = (rgbr << 8) + relay;

        return rgbr;
    }
}
