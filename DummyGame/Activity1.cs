ing Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;

namespace DummyGame.Android
{
    [Activity(Label = "DummyGame.Android"
        , MainLauncher = true
        , Icon = "@drawable/icon"
        , Theme = "@style/Theme.Splash"
        , AlwaysRetainTaskState = true
        /*, LaunchMode = Android.Content.PM.LaunchMode.SingleInstance*/
        , ScreenOrientation = ScreenOrientation.FullUser
        , ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.Keyboard | ConfigChanges.KeyboardHidden | ConfigChanges.ScreenSize)]
    public class Activity1 : Microsoft.Xna.Framework.AndroidGameActivity
    {
        Game1 g;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            string contentDir = "Content";
            if (Intent.HasExtra("CONTENT_DIR"))
            {
                contentDir = Intent.GetStringExtra("CONTENT_DIR");
            }

            var g = new Game1(contentDir);
            SetContentView((View)g.Services.GetService(typeof(View)));
            g.Run();
        }

        protected override bool onBackPressed()
        {
            System.Diagnostic.Debug.WriteLine("I'm here.");
            g.Exit();
            this.Finish();
        }
    }
}