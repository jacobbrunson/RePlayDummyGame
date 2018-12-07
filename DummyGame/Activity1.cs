using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;

namespace DummyGame.Android
{
    [Activity(Label = "DummyGame.Android")]
    public class Activity1 : Microsoft.Xna.Framework.AndroidGameActivity
    {              
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            

            string contentDir = Intent.GetStringExtra("CONTENT_DIR"); //Set Content.RootDirectory to this
            int duration = Intent.GetIntExtra("duration", 300); //Units of seconds

            var g = new Game1(contentDir);
            SetContentView((View)g.Services.GetService(typeof(View)));
            g.Run();
        }
    }
}
