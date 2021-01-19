using System;
using System.Windows;
using Volo.Abp.Identity;

namespace WPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly HelloWorldService _helloWorldService;
        private readonly IProfileAppService _profileAppService;

        public MainWindow(HelloWorldService helloWorldService, IProfileAppService profileAppService)
        {
            _helloWorldService = helloWorldService;
            _profileAppService = profileAppService;
            InitializeComponent();
        }

        protected override void OnContentRendered(EventArgs e)
        {
            HelloLabel.Content = _helloWorldService.SayHello();
            label1.Content = "1";
            label2.Content = "2";
            label3.Content = "3";
        }
    }
}