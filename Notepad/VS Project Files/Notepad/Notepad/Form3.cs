using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class Form3 : Form
    {


        Form1 f1;
        public Form3(Form1 ff3)
        {
            InitializeComponent();
            f1 = ff3;
        }
        public static string tbx2;
        private void Form3_Load(object sender, EventArgs e)
        {
            this.Text = "Replace";
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            this.button1.Text = "Replace";
            this.button2.Text = "Cancel";
            this.label1.Text = "Find what:";
         
            this.label2.Text = "Replace with:";

            this.AcceptButton = button1;
            this.CancelButton = button2;

            

        }

        private void button1_Click(object sender, EventArgs e)
        {

              string text = f1.textBox1.Text.Replace(this.textBox1.Text, this.textBox2.Text);
              f1.textBox1.Text = text;
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
 