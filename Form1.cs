using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01BASIC
{
    public partial class winform : Form
    {
        public winform()
        {
            InitializeComponent();
        }

        private void ComBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
        }

        private void coon_btn_Click_1(object sender, EventArgs e)
        {
            Console.WriteLine(this.Message.Text = this.ComBox.Items[this.ComBox.SelectedIndex].ToString() + " CONN");

          //  Console.WriteLine(this.ComBox.Items[this.ComBox.SelectedIndex].ToString()+" CONN");
         //  this.textBox1.Text= this.ComBox.Items[this.ComBox.SelectedIndex].ToString() + " CONN";

        }

        private void button1_ON_Click(object sender, EventArgs e)
        {
            Console.WriteLine("LED_01_ON");

            this.Message.Text = "LED_01_ON SUCCESS";

        }

        private void button1_OFF_Click(object sender, EventArgs e)
        {
            Console.WriteLine("LED_01_OFF");
            this.Message.Text = "LED_01_OFF SUCCESS";
        }

        private void button2_ON_Click(object sender, EventArgs e)
        {
            Console.WriteLine("LED_02_ON");
            this.Message.Text = "LED_02_ON SUCCESS";
        }
        private void button2_OFF_Click(object sender, EventArgs e)
        {
            Console.WriteLine("LED_02_OFF");
            this.Message.Text = "LED_02_OFF SUCCESS";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
