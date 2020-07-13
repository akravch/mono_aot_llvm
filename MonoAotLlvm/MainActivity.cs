﻿using System.Collections.Generic;
using Android.App;
using Android.OS;
using Android.Support.V7.App;

namespace MonoAotLlvm
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        public struct CustomStruct { }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var comparer = EqualityComparer<CustomStruct>.Default;
        }
    }
}