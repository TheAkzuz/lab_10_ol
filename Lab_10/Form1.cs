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


namespace Lab_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string put;

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
           openFileDialog1.ShowDialog();

            put = openFileDialog1.FileName;
            StreamReader text_txt = new StreamReader(put);


            string lo = text_txt.ReadLine();

            while (lo != null)
            {
               
                textBox1.AppendText(lo);
                textBox1.AppendText(Environment.NewLine);

                lo = text_txt.ReadLine();
            }
            text_txt.Close();
            
        }
    }
}
