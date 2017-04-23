using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace SafetyFirst.Droid
{
    [Activity(Label = "SplashScreenActivity", Icon = "@drawable/icon", Theme = "@style/Theme.AppCompat.Light.NoActionBar", MainLauncher = true)]
    public class SplashScreenActivity : Activity
    {
        private ImageView splashScreen;
        private ProgressBar progressBar;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.SplashScreen);
            splashScreen = FindViewById<ImageView>(Resource.Id.image);
            progressBar = FindViewById<ProgressBar>(Resource.Id.progressBar);

            Timer timer = new Timer();
            timer.Interval = 3000;
            timer.AutoReset = false;
            timer.Elapsed += TimerOnElapsed;
            timer.Start();
        }

        private void TimerOnElapsed(object sender, ElapsedEventArgs e)
        {
            StartActivity(new Intent(this, typeof(MainActivity)));
        }
    }
}