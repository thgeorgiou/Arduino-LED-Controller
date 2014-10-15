package com.sakisds.arduinocontrol.activities;

import android.animation.Animator;
import android.animation.ObjectAnimator;
import android.animation.ValueAnimator;
import android.app.Activity;
import android.graphics.Color;
import android.graphics.Outline;
import android.os.Bundle;
import android.renderscript.Sampler;
import android.util.Log;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.view.ViewGroup;
import android.view.animation.ScaleAnimation;
import android.view.animation.Transformation;
import android.widget.ImageButton;
import android.widget.LinearLayout;
import android.widget.SeekBar;
import android.widget.TextView;
import android.widget.Toast;

import com.larswerkman.holocolorpicker.ColorPicker;
import com.larswerkman.holocolorpicker.SaturationBar;
import com.larswerkman.holocolorpicker.ValueBar;
import com.sakisds.arduinocontrol.EmptyCallback;
import com.sakisds.arduinocontrol.R;
import com.sakisds.arduinocontrol.api.ArduinoService;
import com.sakisds.arduinocontrol.api.JSONResponse;
import com.sakisds.arduinocontrol.api.Utils;

import retrofit.Callback;
import retrofit.RestAdapter;
import retrofit.RetrofitError;
import retrofit.client.Response;


public class MainActivity extends Activity implements View.OnClickListener, Callback<JSONResponse>,
        ColorPicker.OnColorChangedListener, ValueAnimator.AnimatorUpdateListener, SeekBar.OnSeekBarChangeListener {

    boolean mDeskLamp = false;

    ImageButton mFAB, mMoreOpen, mMoreClose;
    LinearLayout mRGBLayout;
    SeekBar mRedSeekBar, mGreenSeekBar, mBlueSeekBar;
    TextView mRedTextView, mGreenTextView, mBlueTextView;

    ColorPicker mColorPicker;
    SaturationBar mSaturationBar;
    ValueBar mValueBar;

    ArduinoService mService;

    EmptyCallback mEmptyCallback = new EmptyCallback();

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        //Prepare views
        mFAB = (ImageButton) findViewById(R.id.fab);
        mMoreOpen = (ImageButton) findViewById(R.id.button_more_open);
        mMoreClose = (ImageButton) findViewById(R.id.button_more_close);

        mColorPicker = (ColorPicker) findViewById(R.id.colorpicker);
        mSaturationBar = (SaturationBar) findViewById(R.id.saturationbar);
        mValueBar = (ValueBar) findViewById(R.id.valuebar);

        mRGBLayout = (LinearLayout) findViewById(R.id.layout_rgb);

        mRedSeekBar = (SeekBar) findViewById(R.id.seekBar_red);
        mGreenSeekBar = (SeekBar) findViewById(R.id.seekBar_green);
        mBlueSeekBar = (SeekBar) findViewById(R.id.seekBar_blue);

        mRedTextView = (TextView) findViewById(R.id.editText_redValue);
        mGreenTextView = (TextView) findViewById(R.id.editText_greenValue);
        mBlueTextView = (TextView) findViewById(R.id.editText_blueValue);

        // Listeners
        mRedSeekBar.setOnSeekBarChangeListener(this);
        mGreenSeekBar.setOnSeekBarChangeListener(this);
        mBlueSeekBar.setOnSeekBarChangeListener(this);
        mFAB.setOnClickListener(this);
        mMoreOpen.setOnClickListener(this);
        mMoreClose.setOnClickListener(this);

        // FAB
        int size = getResources().getDimensionPixelSize(R.dimen.fab_size);
        Outline outline = new Outline();
        outline.setOval(0, 0, size, size);
        mFAB.setOutline(outline);

        // Color picker
        mColorPicker.addSaturationBar(mSaturationBar);
        mColorPicker.addValueBar(mValueBar);
        mColorPicker.setShowOldCenterColor(false);
        mColorPicker.setOnColorChangedListener(this);

        // Service
        RestAdapter restAdapter = new RestAdapter.Builder()
                .setEndpoint("http://192.168.1.112")
                .build();
        mService = restAdapter.create(ArduinoService.class);
        mService.read(this);
    }


    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.main, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        // Handle action bar item clicks here. The action bar will
        // automatically handle clicks on the Home/Up button, so long
        // as you specify a parent activity in AndroidManifest.xml.
        int id = item.getItemId();
        if (id == R.id.action_refresh) {
            mService.read(this);
            return true;
        } else if (id == R.id.action_power) {
            mService.send(Utils.StoreInInteger(0, 0, 0, 0),
                    mEmptyCallback);

            JSONResponse jsonResponse = new JSONResponse("0", "0", "0", "0", "0");
            success(jsonResponse, null);

            return true;
        } else if (id == R.id.action_lamp) {
            mDeskLamp = !mDeskLamp;
            int color = mColorPicker.getColor();

            mService.send(
                    Utils.StoreInInteger(Color.red(color), Color.green(color), Color.blue(color), mDeskLamp ? 1 : 0),
                    mEmptyCallback);
        }
        return super.onOptionsItemSelected(item);
    }

    @Override
    public void onClick(View view) {
        int color = mColorPicker.getColor();

        switch (view.getId()) {
            case R.id.fab:
                mService.send(
                        Utils.StoreInInteger(Color.red(color), Color.green(color), Color.blue(color), mDeskLamp ? 1 : 0),
                        mEmptyCallback);
                break;

            case R.id.button_more_open:
                mRedSeekBar.setProgress(Color.red(color));
                mGreenSeekBar.setProgress(Color.green(color));
                mBlueSeekBar.setProgress(Color.blue(color));

                mRGBLayout.setVisibility(View.VISIBLE);
                break;
            case R.id.button_more_close:
                mRGBLayout.setVisibility(View.GONE);
                break;
        }
    }

    @Override
    public void success(JSONResponse json, Response response) {
        int color = Color.argb(255,
                Integer.valueOf(json.r),
                Integer.valueOf(json.g),
                Integer.valueOf(json.b));

        ValueAnimator colorAnimator = ValueAnimator.ofArgb(mColorPicker.getColor(), color);
        colorAnimator.setDuration(1000);
        colorAnimator.addUpdateListener(this);
        colorAnimator.start();

        mDeskLamp = json.d.equals("1");
    }

    @Override
    public void failure(RetrofitError error) {
        Toast.makeText(this, "Failed to refresh: " + error.getMessage(), Toast.LENGTH_LONG).show();
        Log.w("Network", "Failed to refresh." + error.getMessage());
    }

    public void setActivityBackgroundColor(int color) {
        View view = this.getWindow().getDecorView();
        view.setBackgroundColor(color);
    }

    @Override
    public void onColorChanged(int color) {
        float[] hsv = new float[3];
        Color.colorToHSV(color, hsv);

        hsv[1] = 0.3f;
        hsv[2] = 0.9f;

        setActivityBackgroundColor(Color.HSVToColor(hsv));

        if (mRGBLayout.getVisibility() == View.VISIBLE) {
            mRedSeekBar.setProgress(Color.red(color));
            mGreenSeekBar .setProgress(Color.green(color));
            mBlueSeekBar.setProgress(Color.blue(color));
        }
    }

    @Override
    public void onAnimationUpdate(ValueAnimator valueAnimator) {
        mColorPicker.setColor((Integer) valueAnimator.getAnimatedValue());
    }

    @Override
    public void onProgressChanged(SeekBar seekBar, int value, boolean fromUser) {
            switch (seekBar.getId()) {
                case R.id.seekBar_red:
                    mRedTextView.setText(String.valueOf(value));
                    break;
                case R.id.seekBar_green:
                    mGreenTextView.setText(String.valueOf(value));
                    break;
                case R.id.seekBar_blue:
                    mBlueTextView.setText(String.valueOf(value));
                    break;
            }
        if (fromUser) mColorPicker.setColor(Color.rgb(mRedSeekBar.getProgress(),
                mGreenSeekBar.getProgress(), mBlueSeekBar.getProgress()));
    }

    @Override
    public void onStartTrackingTouch(SeekBar seekBar) { }

    @Override
    public void onStopTrackingTouch(SeekBar seekBar) { }
}