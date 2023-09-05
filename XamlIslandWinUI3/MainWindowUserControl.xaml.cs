using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;

namespace XamlIslandTest
{
    public sealed partial class MainWindowUserControl : Microsoft.UI.Xaml.Controls.UserControl
    {
        public MainWindowUserControl()
        {
            this.InitializeComponent();

            this.btn2.Click += async (s, e) =>
            {
                StringBuilder builder = new();
                builder.AppendLine($"Runtime: {RuntimeInformation.FrameworkDescription}");
                builder.AppendLine($"OS: {RuntimeInformation.OSDescription}");
                builder.Append($"ProcessArchitecture: {RuntimeInformation.ProcessArchitecture.ToString()}");
                var contentDialog = new ContentDialog
                {
                    Title = "About",
                    Content = builder.ToString(),
                    CloseButtonText = "OK",
                    XamlRoot = (s as UIElement)?.XamlRoot
                };
                await contentDialog.ShowAsync();
            };
        }
    }
}
