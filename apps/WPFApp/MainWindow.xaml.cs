using System;
using System.Threading.Tasks;
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


        public MainWindow(HelloWorldService helloWorldService)
        {
            _helloWorldService = helloWorldService;
            InitializeComponent();
        }

        protected override async void OnContentRendered(EventArgs e)
        {
            HelloLabel.Content = _helloWorldService.SayHello();
            var demo = await _helloWorldService.GetDemadsfas();
            label1.Content = demo.name1;
            label2.Content = demo.name2;
            label3.Content = demo.name3;
        }
    }
}