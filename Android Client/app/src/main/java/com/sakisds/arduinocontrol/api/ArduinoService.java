package com.sakisds.arduinocontrol.api;

import retrofit.Callback;
import retrofit.http.GET;
import retrofit.http.Path;
import retrofit.http.Query;

public interface ArduinoService {
    @GET("/")
    void read(
            Callback<JSONResponse> callback
    );

    @GET("/")
    void setRed(
            @Query("r") Integer value,
            Callback<JSONResponse> callback
    );

    @GET("/")
    void setGreen(
            @Query("g") Integer value,
            Callback<JSONResponse> callback
    );

    @GET("/")
    void setBlue(
            @Query("b") Integer value,
            Callback<JSONResponse> callback
    );

    @GET("/")
    void setDeskLamp(
            @Query("d") Integer value,
            Callback<JSONResponse> callback
    );
}