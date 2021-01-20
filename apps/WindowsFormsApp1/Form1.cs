using RemoteServiceExample.Entities;
using RemoteServiceExample.Entities.Dtos;
using System;
using System.Linq;
using System.Windows.Forms;
using Volo.Abp.Application.Dtos;
using Volo.Abp.DependencyInjection;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form, ITransientDependency
    {
        private readonly IBookAppService _bookAppService;
        private readonly HelloWorldService _helloWorldService;

        public Form1(IBookAppService bookAppService, HelloWorldService helloWorldService)
        {
            _bookAppService = bookAppService;
            InitializeComponent();
            _helloWorldService = helloWorldService;
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
            var input = new PagedAndSortedResultRequestDto();
            input.SkipCount = 0;
            input.MaxResultCount = 1000;
            var result = await _bookAppService.GetListAsync(input);
            var list = result.Items.ToList();
            var dataTable = list.ToDataTable<BookDto>();
            dataGridView1.DataSource = dataTable;
        }
    }
}