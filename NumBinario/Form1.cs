using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumBinario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String binario = "";
            binario = textBox1.Text;
            int l = binario.Length;
            int result = 0;

            for(int i = 0; i < binario.Length; i++)
            {
                String x = binario.Substring(l-1, 1);
                l--;
                int bin = Convert.ToInt32(x);
                int z = Convert.ToInt32(Math.Pow(2,i));
                
                int r = bin * z;
                result += r;

            }

           
            label1.Text= "Resultado: " + result;

        }
    }
}
