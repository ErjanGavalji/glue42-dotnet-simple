using System.Windows;
using Tick42;
using Tick42.StickyWindows;

namespace ManipulateBrowserWindows
{

    public partial class MainWindow : Window
    {
        private Glue42 glue;
        private IWindowMgmtInterop windowMgmtSvc;

        public MainWindow()
        {
            InitializeComponent();

            //Initialize Glue42 and register the current app:
            var applicationName = "manipulateBrowserWindows";
            this.glue = new Glue42();
            this.glue.Initialize(applicationName);

            var swOptions = glue.StickyWindows?.GetStartupOptions() ?? new SwOptions();
            glue.StickyWindows?.RegisterWindow(this, swOptions);

            this.windowMgmtSvc = this.glue.Interop.CreateServiceProxy<IWindowMgmtInterop>();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.loadUrl("https://www.glue42.com");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void loadUrl(string url)
        {
            this.windowMgmtSvc.Create("myWindow", url);
        }
    }
}
