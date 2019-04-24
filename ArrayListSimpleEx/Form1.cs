using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;


namespace ArrayListSimpleEx
{
    public partial class Form1 : Form
    {
        private ArrayList sentence = new ArrayList();

        public Form1()
        {
            InitializeComponent();
            sentence.Add("I");
            sentence.Add("love");
            sentence.Add("programming");
            sentence.Add("so");
            sentence.Add("much");

        }

        private void btnShowMsg_Click(object sender, EventArgs e)
        {
            lblMessage.Text = string.Empty;
            for(int i = 0; i<sentence.Count; i++)
            {
                lblMessage.Text += sentence[i].ToString();
                lblMessage.Text += " ";
            }
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            lblMessage.Text = string.Empty;

            sentence.Reverse();
            for (int i = 0; i < sentence.Count; i++)
            {
                lblMessage.Text += sentence[i].ToString();
                lblMessage.Text += " ";
            }
            sentence.Reverse();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            sentence.Insert(1, txtSecondPos.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sentence.RemoveAt(1);
        }
    }
}
