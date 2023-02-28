using Microsoft.Extensions.Logging;
using Maui.GoogleMaps.Hosting;

namespace MauiGoogleMapsSample;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
#if ANDROID
			.UseGoogleMaps()
#elif IOS
			.UseGoogleMaps("AIzaSyCknqcvIuTm7pbJAb0Tx3S4buw5XfhSgUg")
#endif
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
