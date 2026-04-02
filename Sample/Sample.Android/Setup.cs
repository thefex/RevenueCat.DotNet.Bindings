using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.Logging;
using MvvmCross.IoC;
using MvvmCross.Platforms.Android.Core;
using MvvmCross.Platforms.Android.Presenters;
using Sample.Core;
using Sample.Core.Services;
using Sample.Android.Services;
using Serilog;
using Serilog.Events;
using Serilog.Extensions.Logging;

namespace Sample.Android;

public class Setup : MvxAndroidSetup<App>
{
    protected override ILoggerProvider CreateLogProvider() => new SerilogLoggerProvider();

    protected override ILoggerFactory CreateLogFactory()
    {
        string[] excludedLoggerSources =
        [
#if !DEBUG
            "MvxPlugin.Messenger"
#endif
        ];

        Log.Logger = new LoggerConfiguration()
#if DEBUG
            .MinimumLevel.Verbose()
#else
            .MinimumLevel.Warning()
#endif
            .MinimumLevel.Override("MvxBind", LogEventLevel.Warning)
            .Filter.ByExcluding(logEvent =>
            {
                if (logEvent.Properties.TryGetValue("SourceContext", out var sourceContext) &&
                    excludedLoggerSources.Contains(sourceContext.ToString().Trim('"')))
                    return true;

                return false;
            })
            .WriteTo.AndroidLog()
            .CreateLogger();

        return new SerilogLoggerFactory();
    }

    protected override IMvxAndroidViewPresenter CreateViewPresenter()
        => new PaywallPresenter(AndroidViewAssemblies);

    [SuppressMessage("Trimming", "IL2046")]
    protected override void InitializeLastChance(IMvxIoCProvider iocProvider)
    {
        base.InitializeLastChance(iocProvider);
        iocProvider.RegisterSingleton<IRevenueCatService>(new RevenueCatService());
    }
}
