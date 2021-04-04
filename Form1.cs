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
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium_Ders1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.google.com";

            Thread.Sleep(TimeSpan.FromSeconds(5));

            var seachBox = driver.FindElement(By.Name("q"));

            if (seachBox != null)
            {
                seachBox.SendKeys("Türkiye");
                seachBox.SendKeys(OpenQA.Selenium.Keys.Enter);
            }
        }
    }
}
