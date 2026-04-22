using Microsoft.Extensions.Logging;

namespace Practica02DDAMAmo1015
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Bold.ttf", "OpenSansBold");
                    fonts.AddFont("CourierPrime-Regular.ttf", "CourierPrime");
                    fonts.AddFont("Konthen.otf", "Konthen");
                    fonts.AddFont("OrangeGumdrop-PersonalUse-Regular.otf", "OrangeGumdrop");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
