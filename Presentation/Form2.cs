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
    public partial class Form2 : Form
    {
        DataGridView data;
        public Form2(DataGridView data)
        {
            this.data = data;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                Form3 form = new Form3(data);
                form.Show();
                Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form3 form = new Form3(data);
            form.Show();
            Close();
        }
    }
}
