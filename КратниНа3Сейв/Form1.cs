using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace КратниНа3Сейв
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
                while ((line = sr.ReadLine()) != null)
                    listBox1.Items.Add(line);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i;
            string line;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                for (i = 0; i < listBox2.Items.Count; i++)
                {
                    line = listBox2.Items[i].ToString();
                    sw.WriteLine(line);
                }
                sw.Close();
                MessageBox.Show("Saved!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i < listBox1.Items.Count; i++)
                if (int.Parse(listBox1.Items[i].ToString()) % 3 == 0)
                    listBox2.Items.Add(int.Parse(listBox1.Items[i].ToString()));
        }
    }
}
