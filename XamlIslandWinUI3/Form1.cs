using Microsoft.UI.Xaml.Hosting;
using Microsoft.UI;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Content;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Dispatching;

namespace XamlIslandTest
{
    public partial class Form1 : Form
    {

        private DesktopWindowXamlSource? _desktopWindowXamlSource;

        public Form1()
        {
            InitializeComponent();

            DispatcherQueue.GetForCurrentThread().TryEnqueue(() =>
            {
                _desktopWindowXamlSource = new DesktopWindowXamlSource();
                var windowId = Win32Interop.GetWindowIdFromWindow(panel2.Handle);
                _desktopWindowXamlSource.Initialize(windowId);
                _desktopWindowXamlSource.Content = new MainWindowUserControl();
                _desktopWindowXamlSource.SystemBackdrop = new MicaBackdrop();
                _desktopWindowXamlSource.SiteBridge.ResizePolicy = ContentSizePolicy.ResizeContentToParentWindow;
            });

            button1.Click += (s, e) => {
                MessageBox.Show("Button Clicked");
            };
        }
    }
}