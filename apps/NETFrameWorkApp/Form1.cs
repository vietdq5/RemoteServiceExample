using System;
using System.Windows.Forms;
using Volo.Abp.DependencyInjection;

namespace NETFrameWorkApp
{
    public partial class Form1 : Form, ITransientDependency
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}