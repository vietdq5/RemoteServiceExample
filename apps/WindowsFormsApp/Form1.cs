using RemoteServiceExample.Entities;
using System;
using System.Windows.Forms;
using Volo.Abp.DependencyInjection;

namespace WindowsFormsApp
{
    public partial class Form1 : Form, ITransientDependency
    {
        private readonly HelloWorldService _helloWorldService;
        private readonly IBookAppService _bookAppService;

        public Form1(HelloWorldService helloWorldService, IBookAppService bookAppService)
        {
            _helloWorldService = helloWorldService;
            _bookAppService = bookAppService;
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            var aasd = await _helloWorldService.GetDemadsfas();
            label1.Text = aasd.name1;
            label2.Text = aasd.name2;
            label3.Text = aasd.name3;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var id = textBox1.Text;
            var guidId = Guid.Parse(id);
            var book = await _bookAppService.GetAsync(guidId);
            label5.Text = book.Name;
            label7.Text = book.Price.ToString();
        }
    }
}