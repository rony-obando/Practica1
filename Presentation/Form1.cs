using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Microsoft.VisualBasic;

namespace Presentation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int a;
        DataGridView data;
        public Form1(int a,double v)
        {
            this.a = a;
            this.v = v;
            InitializeComponent();
        }
        double v;
        
        public void ExportarDatos(DataGridView data)
        {
            Microsoft.Office.Interop.Excel.Application application = new Microsoft.Office.Interop.Excel.Application();
            application.Application.Workbooks.Add(true);
            int indice = 0;
            foreach(DataGridViewColumn i in data.Columns)
            {
                indice++;
                application.Cells[1, indice] = i.Name;
            }
            int indicefila = 0;
            foreach (DataGridViewRow fila in data.Rows)
            {
                indicefila++;
                if (indicefila == 1)
                {
                    //indicefila++;
                }
                indice = 0;
                foreach (DataGridViewColumn columna in data.Columns)
                {
                    indice++;
                    application.Cells[indicefila + 1, indice] = fila.Cells[columna.Name].Value;
                }
                
            }
            application.Visible = true;


        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (a == 1) 
            {
                dataGridView1 = data;
            }
        }
        private void selectedCellsButton_Click(object sender, System.EventArgs e)
        {
            
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*if (e.KeyChar == (char)Keys.Enter)
            {
                int selectedCellCount =
                dataGridView1.GetCellCount(DataGridViewElementStates.Selected);
                List<string> si = new List<string>();
                List<int> filas = new List<int>();
                List<int> Columnas = new List<int>();
                if (selectedCellCount > 0)
                {
                    if (dataGridView1.AreAllCellsSelected(true))
                    {
                        MessageBox.Show("All cells are selected", "Selected Cells");
                    }
                    else
                    {
                        System.Text.StringBuilder sb =
                            new System.Text.StringBuilder();

                        for (int i = 0;
                            i < selectedCellCount; i++)
                        {


                            filas.Add(dataGridView1.SelectedCells[i].RowIndex);



                            Columnas.Add(dataGridView1.SelectedCells[i].ColumnIndex);
                                
                            sb.Append(Environment.NewLine);
                        }

                        sb.Append("Total: " + selectedCellCount.ToString());
                        MessageBox.Show(filas.Count.ToString());
                    }
                }
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
        int fila;
        int columna;
        private void btnFunction_Click(object sender, EventArgs e)
        {
            int selectedCellCount =
                dataGridView1.GetCellCount(DataGridViewElementStates.Selected);
            if (selectedCellCount == 1)
            {
                for (int i = 0;
                        i < selectedCellCount; i++)
                {
                   fila= dataGridView1.SelectedCells[i].RowIndex;
                   columna=dataGridView1.SelectedCells[i].ColumnIndex;
                }
                Form2 form = new Form2(dataGridView1);
                form.ShowDialog();
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue==(int)Keys.Enter)
            {
                int selectedCellCount =
               dataGridView1.GetCellCount(DataGridViewElementStates.Selected);
                List<string> si = new List<string>();
                HashSet<int> filas = new HashSet<int>();
                HashSet<int> Columnas = new HashSet<int>();
                if (selectedCellCount > 0)
                {
                    if (dataGridView1.AreAllCellsSelected(true))
                    {
                        MessageBox.Show("All cells are selected", "Selected Cells");
                    }
                    else
                    {
                        System.Text.StringBuilder sb =
                            new System.Text.StringBuilder();

                        for (int i = 0;
                            i < selectedCellCount; i++)
                        {

                            filas.Add(dataGridView1.SelectedCells[i].RowIndex);



                            Columnas.Add(dataGridView1.SelectedCells[i].ColumnIndex);

                            sb.Append(Environment.NewLine);
                        }
                        foreach (int i in filas.Reverse())
                        {
                            foreach (int j in Columnas.Reverse())
                            {
                                si.Add(dataGridView1.Rows[i].Cells[j].Value.ToString());
                            }
                        }
                        
                        List<double> no = new List<double>();
                        foreach (string b in si)
                        {
                            no.Add(double.Parse(b));
                        }
                        SingletonList singleton = SingletonList.instance1;
                        singleton.vs = no;
                        double[] noo = no.ToArray();
                        dataGridView1.Rows[fila].Cells[columna].Value =Financial.IRR(ref noo);
                        /* sb.Append("Total: " + selectedCellCount.ToString());
                         MessageBox.Show(sb.ToString());*/

                    }
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string a = dataGridView1.Rows[fila].Cells[columna].Value.ToString();
            if (!double.TryParse(a,out double b))
            {
                a = a.Substring(0, a.Length - 1);
            }
            
            double valor = double.Parse(a);
            a = (Math.Round(valor,2)).ToString() + "%";
            dataGridView1.Rows[fila].Cells[columna].Value = a;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a = dataGridView1.Rows[fila].Cells[columna].Value.ToString();
            if (!double.TryParse(a, out double b))
            {
                a = a.Substring(0, a.Length - 1);
            }
            dataGridView1.Rows[fila].Cells[columna].Value = Math.Ceiling(double.Parse(a));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string a = dataGridView1.Rows[fila].Cells[columna].Value.ToString();
            if (!double.TryParse(a, out double b))
            {
                a = a.Substring(0, a.Length - 1);
            }
            dataGridView1.Rows[fila].Cells[columna].Value = Math.Floor(double.Parse(a));
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            ExportarDatos(dataGridView1);
        }
    }
}
