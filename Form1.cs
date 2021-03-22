using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Работа_с_рядами
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            string strok = (string)listBox1.Items[index];
            int dlin = strok.Length;
            int count = 0;
            int i = 0;
            while (i < dlin)
            {
                if (strok[i] == 'а' || strok[i]=='А')
                    count++;
                i++;
            }
            label1.Text = "Количество букв а = " + count.ToString();
           
        }
    }
}
