package com.sakisds.arduinocontrol;

import com.sakisds.arduinocontrol.api.JSONResponse;

import retrofit.Callback;
import retrofit.RetrofitError;
import retrofit.client.Response;

/**
 * Created by Thanasis Georgiou on 04/07/2014.
 */
public class EmptyCallback implements Callback<JSONResponse> {
    @Override
    public void success(JSONResponse jsonResponse, Response response) {

    }

    @Override
    public void failure(RetrofitError error) {

    }
}
