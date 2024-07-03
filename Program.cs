using System.Diagnostics;
using System.Globalization;

namespace WpfApp1;

public static class Program
{
    [STAThread]
    public static void Main()
    {
        var backgroundThread = new Thread(RefreshTraceSourcesInEndlessLoop)
        {
            IsBackground = true
        };

        backgroundThread.Start();

        var app = new App();
        app.InitializeComponent();
        app.Run();
    }

    private static void RefreshTraceSourcesInEndlessLoop()
    {
        while (true)
        {
            PresentationTraceSources.Refresh();
        }
    }
}
