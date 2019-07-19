using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITestProject
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                //System.IO.Directory.SetCurrentDirectory(@"C:\Users\dmitry.ordenov");

                return ConfigureApp
                    .Android
                    .InstalledApp("com.dmitryordenov.TestApplication")
                    .Debug()
                    .EnableLocalScreenshots()
                    .DeviceSerial("d999fec8")
                    .StartApp();
            }

            return ConfigureApp.iOS.StartApp();
        }
    }
}