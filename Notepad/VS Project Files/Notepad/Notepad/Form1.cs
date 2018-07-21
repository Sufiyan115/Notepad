using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Notepad
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Sufiyan";
            this.textBox1.Dock = DockStyle.Fill;

            

            this.textBox1.Font = new Font(TextBox.DefaultFont.FontFamily, 14);

            this.blueToolStripMenuItem.Checked = true;
            this.textBox1.BackColor = Color.LightBlue;
            this.textBox1.ForeColor = Color.Navy;
            this.menuStrip1.BackColor = Color.Navy;
            this.menuStrip1.ForeColor = Color.Cyan;

            this.wordWrapToolStripMenuItem.Checked = true;



            //Shortcut Keys
            this.newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            this.openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            this.saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            this.newToolStripMenuItem.ShortcutKeys = Keys.Control |Keys.Shift| Keys.S;
            this.exitToolStripMenuItem.ShortcutKeys = Keys.Alt| Keys.F4;
            this.selectAllToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            this.cutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            this.copyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            this.pasteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            this.deleteToolStripMenuItem.ShortcutKeys = Keys.Delete;
            this.fIndToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F;
            this.replaceToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.R;
            this.selectAllToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            this.wordWrapToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.W;
            this.fontToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.F;
            this.undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            this.backColorToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.B;
           

           

            

        

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void deToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            
            Form3 rf = new Form3(this);
            rf.Show();
           

            
            
           
        }

        private void gotoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fIndToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            Form2 find = new Form2(this);
            find.Show();
        }

        private void tImeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = System.DateTime.Today.ToString();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;
            DialogResult dr = fontDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.textBox1.Font = this.fontDialog1.Font;
                this.textBox1.ForeColor = this.fontDialog1.Color;
            }
        }
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
                //MessageBox.Show("Are you sure?")
            this.textBox1.Clear();

        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.SelectAll();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Undo();
        }

        private void upperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (upperToolStripMenuItem.Checked==false)
            {
                upperToolStripMenuItem.Checked = true;
                lowerToolStripMenuItem.Checked = false;
                this.textBox1.CharacterCasing = CharacterCasing.Upper;
            }
            else
            {
                this.textBox1.CharacterCasing = CharacterCasing.Normal; 
                this.upperToolStripMenuItem.Checked = false;
            }
        }

        private void lowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lowerToolStripMenuItem.Checked == false)
            {
                lowerToolStripMenuItem.Checked = true;
                upperToolStripMenuItem.Checked = false;
                this.textBox1.CharacterCasing = CharacterCasing.Lower;
            }
            else
            {
                this.textBox1.CharacterCasing = CharacterCasing.Normal;
                this.lowerToolStripMenuItem.Checked = false;
            }
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(wordWrapToolStripMenuItem.Checked==false)
            {
                wordWrapToolStripMenuItem.Checked = true;
                this.textBox1.WordWrap = true;
            }
            else
            {
                wordWrapToolStripMenuItem.Checked = false;
                this.textBox1.WordWrap = false;
            }
        }

       

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
             SaveFileDialog SaveFileDialog1 = new SaveFileDialog();
            SaveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)

                {
                    File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);

                 
                }


            
        }

        private void aboutNotepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developed by Muhammad Sufiyan", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void backColorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult dr = colorDialog1.ShowDialog();
            
            if(dr==DialogResult.OK)
            {
                this.textBox1.BackColor = this.colorDialog1.Color;
            }
        }

        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
             if(pinkToolStripMenuItem.Checked==false)
            {
                this.pinkToolStripMenuItem.Checked = true;
                this.darkToolStripMenuItem.Checked = false;
                this.blueToolStripMenuItem.Checked = false;

                this.textBox1.BackColor = Color.LightPink;
                this.textBox1.ForeColor = Color.DarkMagenta;
                this.menuStrip1.BackColor = Color.DarkMagenta;
                this.menuStrip1.ForeColor = Color.Violet;

            }
            else
            {
                this.pinkToolStripMenuItem.Checked = false;
                this.textBox1.ForeColor = DefaultForeColor;
                this.textBox1.BackColor = DefaultBackColor;
                this.menuStrip1.ForeColor = DefaultForeColor;
                this.menuStrip1.BackColor = DefaultBackColor;
            }
        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (darkToolStripMenuItem.Checked == false)
            {
                this.pinkToolStripMenuItem.Checked = false;
                this.darkToolStripMenuItem.Checked = true;
                this.blueToolStripMenuItem.Checked = false;

                this.textBox1.BackColor = Color.Black;
                this.textBox1.ForeColor = Color.Silver;
                this.menuStrip1.BackColor = Color.Silver;
                this.menuStrip1.ForeColor = Color.Black;

            }
            else
            {
                this.darkToolStripMenuItem.Checked = false;
                this.textBox1.ForeColor = DefaultForeColor;
                this.textBox1.BackColor = DefaultBackColor;
                this.menuStrip1.ForeColor = DefaultForeColor;
                this.menuStrip1.BackColor = DefaultBackColor;
            }
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(blueToolStripMenuItem.Checked==false)
            {
                this.blueToolStripMenuItem.Checked = true;
                this.darkToolStripMenuItem.Checked = false;
                this.pinkToolStripMenuItem.Checked = false;

                this.textBox1.BackColor = Color.LightBlue;
                this.textBox1.ForeColor = Color.Navy;
                this.menuStrip1.BackColor = Color.Navy;
                this.menuStrip1.ForeColor = Color.Cyan;
            }
            else
            {
                this.blueToolStripMenuItem.Checked = false;
                this.textBox1.ForeColor = DefaultForeColor;
                this.textBox1.BackColor = DefaultBackColor;
                this.menuStrip1.ForeColor = DefaultForeColor;
                this.menuStrip1.BackColor = DefaultBackColor;
                
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)

            {
                string s = File.ReadAllText(openFileDialog1.FileName);
                textBox1.Text = s;

            }
        }

        private void formatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SaveFileDialog SaveFileDialog1 = new SaveFileDialog();
            SaveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)

            {
                File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);


            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(textBox1.Text=="")
            {
                Application.Exit();
            }
            else
            {
                SaveFileDialog SaveFileDialog1 = new SaveFileDialog();
                SaveFileDialog1.DefaultExt = "txt";
                saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)

                {
                    File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);


                }
            }
        }
    }
}
