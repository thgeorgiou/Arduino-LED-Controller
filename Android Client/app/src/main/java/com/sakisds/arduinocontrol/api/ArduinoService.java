package com.sakisds.arduinocontrol.api;

import retrofit.Callback;
import retrofit.http.GET;
import retrofit.http.Path;
import retrofit.http.Query;

public interface ArduinoService {
    @GET("/{data}")
    void send(@Path("data") long data,
            Callback<JSONResponse> callback
    );

    @GET("/")
    void read(
            Callback<JSONResponse> callback
    );
}