namespace SearchAThing.NextCloudUtils;

public static partial class Extensions
{

    public static void SetupAppSettings(this IHostBuilder builder)
    {        
        builder.ConfigureAppConfiguration((context, config) =>
        {                        
            var appsettingsBase = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "appsettings.json");

            var appsettingsEnv = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                $"appsettings.{context.HostingEnvironment.EnvironmentName}.json");

            config
                .AddUserSecrets(Assembly.GetExecutingAssembly())                
                
                .AddJsonFile(
                    appsettingsBase,
                    optional: false,
                    reloadOnChange: true)

                .AddJsonFile(
                    appsettingsEnv,
                    optional: true,
                    reloadOnChange: true)

                .AddEnvironmentVariables();                          
        });
    }

}