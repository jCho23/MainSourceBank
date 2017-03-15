using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using System.Threading;

namespace MainSourceBank
{
	[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]
	public class Tests
	{
		IApp app;
		Platform platform;

		public Tests(Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest()
		{
			app = AppInitializer.StartApp(platform);
			app.Screenshot("App Launched");
		}

		[Test]
		public void Repl()
		{
			app.Repl();
		}

		[Test]
		public void FirstTest()
		{
			app.Tap("Edt_UserId");
			app.Screenshot("Let's start by Tapping on the 'Login ID' Texy Field");

			app.EnterText("MainSource");
			app.Screenshot("We entered in our login");

			app.DismissKeyboard();
			app.Screenshot("Dismissed Keyboard");
			app.Tap("Btn_Login");
			app.Screenshot("Then, we Tapped on the 'Log In' Button");

			app.EnterText("Microsoft");
			app.Screenshot("Next, we enterted in our password");

			app.DismissKeyboard();
			app.Screenshot("Dismissed Keyboard");
			app.Tap("Btn_Login");
			app.Screenshot("Then, we Tapped on the 'Log In' Button again");

			app.Tap("button1");
			app.Screenshot("We Tapped 'OK' to dismiss the message");

			app.Tap("more_link");
			app.Screenshot("Next, we Tapped the 'More' Button");

			Thread.Sleep(8000);
			app.Back();
			app.Screenshot("We Tapped the 'Back' Button");

			app.Tap("locations_link");
			app.Screenshot("Then, we Tapped on the 'Locations' Button");

			app.Tap("map_action_location_search");
			app.Screenshot("We Tapped on the 'Current Location' Text Field");

			app.EnterText("94111");
			app.Screenshot("We entered in our Zip-Code");

			app.PressEnter();
			app.Screenshot("We searched our location");
		}

	}
}
