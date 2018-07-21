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
    public partial class Form2 : Form
    {   Form1  f1;
        public Form2(Form1 ff1)
        {
            InitializeComponent();
            f1 = ff1;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Text = "Find";
            this.button1.Text = "Find";
            this.label1.Text = "Enter text to find:";

            this.button1.Text = "Replace";
            this.button2.Text = "Cancel";


            this.AcceptButton = button1;
            this.CancelButton = button2;


            this.StartPosition = FormStartPosition.CenterScreen;
            this.ShowIcon = false;
            
            

            this.MaximizeBox = false;
            this.MinimizeBox = false;


            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }
    }
}
