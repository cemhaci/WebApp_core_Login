namespace DataGridWiev_Ornek
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunTanimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resimYolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunresimDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.urunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.urunTanimDataGridViewTextBoxColumn,
            this.resimYolDataGridViewTextBoxColumn,
            this.urunresimDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.urunBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(871, 473);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 40;
            // 
            // urunTanimDataGridViewTextBoxColumn
            // 
            this.urunTanimDataGridViewTextBoxColumn.DataPropertyName = "UrunTanim";
            this.urunTanimDataGridViewTextBoxColumn.HeaderText = "Ürün Tanım";
            this.urunTanimDataGridViewTextBoxColumn.Name = "urunTanimDataGridViewTextBoxColumn";
            this.urunTanimDataGridViewTextBoxColumn.Width = 87;
            // 
            // resimYolDataGridViewTextBoxColumn
            // 
            this.resimYolDataGridViewTextBoxColumn.DataPropertyName = "ResimYol";
            this.resimYolDataGridViewTextBoxColumn.HeaderText = "Resim Yol";
            this.resimYolDataGridViewTextBoxColumn.Name = "resimYolDataGridViewTextBoxColumn";
            this.resimYolDataGridViewTextBoxColumn.Width = 79;
            // 
            // urunresimDataGridViewImageColumn
            // 
            this.urunresimDataGridViewImageColumn.DataPropertyName = "Urunresim";
            this.urunresimDataGridViewImageColumn.HeaderText = "Ürün Resmi";
            this.urunresimDataGridViewImageColumn.Name = "urunresimDataGridViewImageColumn";
            this.urunresimDataGridViewImageColumn.ReadOnly = true;
            this.urunresimDataGridViewImageColumn.Width = 68;
            // 
            // urunBindingSource
            // 
            this.urunBindingSource.DataSource = typeof(DataGridWiev_Ornek.Urun);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 473);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource urunBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunTanimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resimYolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn urunresimDataGridViewImageColumn;
    }
}

