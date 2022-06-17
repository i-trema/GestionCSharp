namespace UrInfo
{
    partial class DetailsPreparateur
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.qte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dimension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Poids = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(12, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(888, 184);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(906, 240);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 48);
            this.button3.TabIndex = 9;
            this.button3.Text = "Expédié";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(906, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 48);
            this.button2.TabIndex = 8;
            this.button2.Text = "En cours de traitement";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(906, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 45);
            this.button1.TabIndex = 7;
            this.button1.Text = "Retour";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.qte,
            this.Dimension,
            this.Poids,
            this.Prix});
            this.dataGridView1.Location = new System.Drawing.Point(12, 314);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(888, 230);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // qte
            // 
            this.qte.DataPropertyName = "qte";
            this.qte.HeaderText = "Quantité";
            this.qte.MinimumWidth = 6;
            this.qte.Name = "qte";
            this.qte.Width = 95;
            // 
            // Dimension
            // 
            this.Dimension.DataPropertyName = "dimension";
            this.Dimension.HeaderText = "Dimension";
            this.Dimension.MinimumWidth = 6;
            this.Dimension.Name = "Dimension";
            this.Dimension.Visible = false;
            this.Dimension.Width = 109;
            // 
            // Poids
            // 
            this.Poids.DataPropertyName = "poids";
            this.Poids.HeaderText = "Poids";
            this.Poids.MinimumWidth = 6;
            this.Poids.Name = "Poids";
            this.Poids.Visible = false;
            this.Poids.Width = 73;
            // 
            // Prix
            // 
            this.Prix.DataPropertyName = "prix";
            this.Prix.HeaderText = "Prix";
            this.Prix.MinimumWidth = 6;
            this.Prix.Name = "Prix";
            this.Prix.Visible = false;
            this.Prix.Width = 62;
            // 
            // DetailsPreparateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 556);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "DetailsPreparateur";
            this.Text = "DetailsPreparateur";
            this.Load += new System.EventHandler(this.DetailsPreparateur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private Label label1;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn qte;
        private DataGridViewTextBoxColumn Dimension;
        private DataGridViewTextBoxColumn Poids;
        private DataGridViewTextBoxColumn Prix;
    }
}