using Microsoft.UI.Dispatching;
using Microsoft.UI.Xaml.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamlIslandTest
{
    public partial class App : Microsoft.UI.Xaml.Application
    {
        private DispatcherQueueController _dispatcherQueueController;
        private WindowsXamlManager _windowsXamlManager;
        public App()
        {
            _dispatcherQueueController = DispatcherQueueController.CreateOnCurrentThread();
            _windowsXamlManager = WindowsXamlManager.InitializeForCurrentThread();

            this.InitializeComponent();
        }
    }
}
