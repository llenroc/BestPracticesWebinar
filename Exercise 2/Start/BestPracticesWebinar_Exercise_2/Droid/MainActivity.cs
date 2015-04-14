﻿using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace BestPracticesWebinar_Exercise_2.Droid
{
	[Activity (Label = "BestPracticesWebinar_Exercise_2.Droid", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			global::Xamarin.Forms.Forms.Init (this, bundle);

			//Need to determine the Device Independent Pixels to utilize with Forms
			var pixels = Resources.DisplayMetrics.WidthPixels; // real pixels
			var scale = Resources.DisplayMetrics.Density;
			int dps = (int)((pixels-0.5f)/scale);

			App.ScreenWidth = dps;

			pixels = Resources.DisplayMetrics.HeightPixels; // real pixels
			dps = (int)((pixels-0.5f)/scale);

			App.ScreenHeight = dps;

			LoadApplication (new App ());
		}
	}
}