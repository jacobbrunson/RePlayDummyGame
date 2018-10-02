using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;

namespace DummyGame.Android
{
    [Activity(Label = "DummyGame.Android")]
    public class Activity1 : Microsoft.Xna.Framework.AndroidGameActivity
    {
        Game1 g;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            string contentDir = Intent.GetStringExtra("CONTENT_DIR");

            g = new Game1(contentDir);
            SetContentView((View)g.Services.GetService(typeof(View)));
            g.Run();
        }

        protected override void OnStart()
        {
            System.Console.WriteLine("In the OnStart() DummyGame event");
            base.OnStart();
        }
        protected override void OnRestart()
        {
            System.Console.WriteLine("In the OnRestart() DummyGame event");
            base.OnRestart();
        }
        protected override void OnResume()
        {
            System.Console.WriteLine("In the OnResume() DummyGame event");
            base.OnResume();
        }
        protected override void OnPause()
        {
            g.IsActive = false;
            System.Console.WriteLine("In the OnPause() DummyGame event");
            base.OnPause();
        }
        protected override void OnStop()
        {
            System.Console.WriteLine("In the OnStop() DummyGame event");
            base.OnStop();
        }
        protected override void OnDestroy()
        {
            System.Console.WriteLine("In the OnDestroy() DummyGame event");
            base.OnDestroy();
        }
    }
}