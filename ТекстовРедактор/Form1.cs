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

namespace ТекстовРедактор
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                string line;
                textBox1.Text = "";
                while ((line = sr.ReadLine()) != null)
                    textBox1.Text = textBox1.Text + line + "\r\n";
                sr.Close();
                Text = "My Editor" + openFileDialog1.FileName;
                saveFileDialog1.FileName = openFileDialog1.FileName;
                saveFileDialog1.FileName = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.OverwritePrompt = false;
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.WriteLine(textBox1.Text);
                sw.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
                saveFileDialog1.OverwritePrompt = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter a = new StreamWriter(saveFileDialog1.FileName);
                    a.WriteLine(textBox1.Text);
                    a.Close();
                    MessageBox.Show("Saved");
                }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
