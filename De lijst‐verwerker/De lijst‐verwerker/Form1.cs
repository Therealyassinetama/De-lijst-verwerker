using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De_lijst_verwerker
{
    public partial class Form1 : Form
    {
        List<int> lijst = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        public string berekeningen (List<int> lijst1, string type)
        {
            int ans = 0;
            if(type == "tellen")
            {
                foreach(int x in lijst1)
                {
                    ans += x;
                }
            }
            if(type == "keer")
            {
                ans = 1;
                foreach (int x in lijst1)
                {
                    ans *= x;
                }
            }
            if(type == "gemmideld")
            {
                ans = 1;
                foreach (int x in lijst1)
                {
                    ans += x;
                }
                ans /= lijst1.Count;
            }
            return ans.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lijst.Add(Convert.ToInt32(numericUpDown1.Value));
            listBox1.Items.Clear();
            foreach (int x in lijst)
            {
                listBox1.Items.Add(x.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lijst.Clear();
            listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = berekeningen(lijst, "tellen");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = berekeningen(lijst, "keer");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = berekeningen(lijst, "gemmideld");
        }
    }
}
