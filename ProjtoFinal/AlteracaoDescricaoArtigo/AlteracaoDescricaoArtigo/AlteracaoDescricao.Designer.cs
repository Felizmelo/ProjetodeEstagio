
namespace AlteracaoDescricaoArtigo
{
    partial class AlteracaoDescricao
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Bt_Ediatr = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CodArtigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DesArtigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seach = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.Location = new System.Drawing.Point(430, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Gravar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Bt_Gravar);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 1;
            // 
            // Bt_Ediatr
            // 
            this.Bt_Ediatr.ForeColor = System.Drawing.Color.Green;
            this.Bt_Ediatr.Location = new System.Drawing.Point(210, 376);
            this.Bt_Ediatr.Name = "Bt_Ediatr";
            this.Bt_Ediatr.Size = new System.Drawing.Size(111, 43);
            this.Bt_Ediatr.TabIndex = 4;
            this.Bt_Ediatr.Text = "Editar";
            this.Bt_Ediatr.UseVisualStyleBackColor = true;
            this.Bt_Ediatr.Click += new System.EventHandler(this.Bt_Ediatr_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Descricao";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodArtigo,
            this.DesArtigo});
            this.dataGridView1.Location = new System.Drawing.Point(143, 168);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(519, 175);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // CodArtigo
            // 
            this.CodArtigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CodArtigo.HeaderText = "Artigo";
            this.CodArtigo.MinimumWidth = 8;
            this.CodArtigo.Name = "CodArtigo";
            this.CodArtigo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DesArtigo
            // 
            this.DesArtigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DesArtigo.HeaderText = "Descricao";
            this.DesArtigo.MinimumWidth = 8;
            this.DesArtigo.Name = "DesArtigo";
            // 
            // seach
            // 
            this.seach.Location = new System.Drawing.Point(319, 91);
            this.seach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.seach.Name = "seach";
            this.seach.Size = new System.Drawing.Size(163, 26);
            this.seach.TabIndex = 9;
            this.seach.TextChanged += new System.EventHandler(this.seach_TextChanged);
            // 
            // AlteracaoDescricao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.seach);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Bt_Ediatr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3);
            this.Name = "AlteracaoDescricao";
            this.Size = new System.Drawing.Size(802, 442);
            this.Text = "AlteracaoDescricao";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Bt_Ediatr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox seach;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodArtigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesArtigo;
    }
}