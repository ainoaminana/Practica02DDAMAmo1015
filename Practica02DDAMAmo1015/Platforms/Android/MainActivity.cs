using Android.App;
using Android.Content.PM;
using Android.OS;
using Plugin.Fingerprint;                 // necesario
using Plugin.Fingerprint.Abstractions;    // necesario

namespace Practica02DDAMAmo1015
{
    [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true,
        LaunchMode = LaunchMode.SingleTop,
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation |
                               ConfigChanges.UiMode | ConfigChanges.ScreenLayout |
                               ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
    public class MainActivity : MauiAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // 🔥 ESTA ES LA LÍNEA CORRECTA
            CrossFingerprint.SetCurrentActivityResolver(() => this);
        }
    }
}
