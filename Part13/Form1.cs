using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            await ShowMessage();
        }

        private async Task ShowMessage()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(10000);
                MessageBox.Show("Hello After 10 seconds");
            });
        }
    }
}
