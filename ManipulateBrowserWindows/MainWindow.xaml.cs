using System.Windows;
using Tick42;
using Tick42.StickyWindows;

namespace ManipulateBrowserWindows
{

    public partial class MainWindow : Window
    {
        private Glue42 glue;
        private IWindowMgmtInterop windowMgmtSvc;
        private int windowId = -1;

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
            this.loadUrl("https://docs.glue42.com");
        }

        private void loadUrl(string url)
        {
            if (this.windowId == -1)
            {
                this.windowId = this.windowMgmtSvc.Create("myWindow", url);
            } else
            {
                //TODO: Implement the navigation!
                this.windowMgmtSvc.Execute("navigate", this.windowId.ToString(), string.Format("{{\"url\":\"{0}\"}}", url));
            }
        }
    }
}
