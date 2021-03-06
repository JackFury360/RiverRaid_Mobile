﻿using Android.App;
using Android.Widget;
using Android.OS;

namespace XamarinDemo
{
    [Activity(Label = "InGame")]
    public class InGame : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            RequestedOrientation = Android.Content.PM.ScreenOrientation.Portrait;

            SetContentView(new GameView(this, this));

        }
        
        protected override void OnPause()
        {
            base.OnPause();
            GameView.isPaused = true;
        }

        protected override void OnResume()
        {
            base.OnResume();
            GameView.isPaused = false;
        }

        protected override void OnStop()
        {
            base.OnStop();
            GameView.isPaused = true;
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
            GameView.isUpdating = false;
        }
    }
}