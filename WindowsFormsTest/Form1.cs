using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Threading;

namespace WindowsFormsTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private async void button1_Click(object sender, EventArgs e)
        {
            do
            {
                await Run();

                do
                {
                    await Timer();
                }
                while (DateTime.Now.Minute != 13 && DateTime.Now.Second != 0);
            }
            while(true);
                
        }

        private async Task Run()
        {
            label1.Text = "1";
            await Go1();
            label1.Text = "2";
            await Go1();
        }

        private async Task<string> Go1()
        {

            return await Task.Run(() =>
            {
                Thread.Sleep(2000);
                return string.Empty;
            });
        }
        private async Task<string> Timer()
        {

            return await Task.Run(() =>
            {
                Thread.Sleep(1000);
                return string.Empty;
            });
        }

    }
}
