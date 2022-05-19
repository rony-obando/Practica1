using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Presentation
{
    public partial class Form3 : Form
    {
        List<double> Valores;
        DataGridView da;
        public Form3(DataGridView data)
        {
            da = data;
            InitializeComponent();
        }
        public Form3(List<double> Valores)
        {
            this.Valores = Valores;
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if (Valores != null)
            {
                //double[] si = Valores.ToArray();
                //Close();

            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            /*Form1 form = new Form1(1,0) ;
            form.Show();*/
            SingletonList singletonList = SingletonList.instance1;

            foreach (double dou in singletonList.vs)
            {
                MessageBox.Show(dou.ToString());
            }
        }
    }
}
