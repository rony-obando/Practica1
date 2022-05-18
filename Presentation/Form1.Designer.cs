
namespace Presentation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ce = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFunction = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ca,
            this.Cb,
            this.Cc,
            this.Cd,
            this.Ce,
            this.Cf,
            this.Cg});
            this.dataGridView1.Location = new System.Drawing.Point(12, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(797, 384);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            this.dataGridView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView1_KeyPress);
            // 
            // Ca
            // 
            this.Ca.HeaderText = "A";
            this.Ca.MinimumWidth = 6;
            this.Ca.Name = "Ca";
            this.Ca.Width = 125;
            // 
            // Cb
            // 
            this.Cb.HeaderText = "B";
            this.Cb.MinimumWidth = 6;
            this.Cb.Name = "Cb";
            this.Cb.Width = 125;
            // 
            // Cc
            // 
            this.Cc.HeaderText = "C";
            this.Cc.MinimumWidth = 6;
            this.Cc.Name = "Cc";
            this.Cc.Width = 125;
            // 
            // Cd
            // 
            this.Cd.HeaderText = "D";
            this.Cd.MinimumWidth = 6;
            this.Cd.Name = "Cd";
            this.Cd.Width = 125;
            // 
            // Ce
            // 
            this.Ce.HeaderText = "E";
            this.Ce.MinimumWidth = 6;
            this.Ce.Name = "Ce";
            this.Ce.Width = 125;
            // 
            // Cf
            // 
            this.Cf.HeaderText = "F";
            this.Cf.MinimumWidth = 6;
            this.Cf.Name = "Cf";
            this.Cf.Width = 125;
            // 
            // Cg
            // 
            this.Cg.HeaderText = "G";
            this.Cg.MinimumWidth = 6;
            this.Cg.Name = "Cg";
            this.Cg.Width = 125;
            // 
            // btnFunction
            // 
            this.btnFunction.Location = new System.Drawing.Point(3, 3);
            this.btnFunction.Name = "btnFunction";
            this.btnFunction.Size = new System.Drawing.Size(94, 29);
            this.btnFunction.TabIndex = 1;
            this.btnFunction.Text = "Fx";
            this.btnFunction.UseVisualStyleBackColor = true;
            this.btnFunction.Click += new System.EventHandler(this.btnFunction_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Formula:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(482, 27);
            this.textBox1.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnFunction);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(775, 74);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Exportal a Excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 543);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ce;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cg;
        private System.Windows.Forms.Button btnFunction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
    }
}

