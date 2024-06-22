var builder = Host.CreateDefaultBuilder(args);

builder.SetupAppSettings();

builder.ConfigureServices(services => services    
    .AddDbContext<CloudContext>()
    .AddHostedService<Worker>()
);

using var host = builder.Build();

host.Run();
