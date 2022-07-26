
namespace FormularioFamilia
{
    partial class ArtigosFamilias
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
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.stdBSTabelasUtilizadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.seach = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.stdBSTabelasUtilizadorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox
            // 
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(99, 39);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(245, 30);
            this.comboBox.TabIndex = 0;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // stdBSTabelasUtilizadorBindingSource
            // 
            this.stdBSTabelasUtilizadorBindingSource.DataSource = typeof(ErpBS100.StdBSTabelasUtilizador);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(99, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(669, 246);
            this.dataGridView1.TabIndex = 1;
            // 
            // seach
            // 
            this.seach.Location = new System.Drawing.Point(507, 43);
            this.seach.Name = "seach";
            this.seach.Size = new System.Drawing.Size(261, 26);
            this.seach.TabIndex = 2;
            this.seach.TextChanged += new System.EventHandler(this.seach_TextChanged);
            // 
            // ArtigosFamilias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.seach);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox);
            this.Name = "ArtigosFamilias";
            this.Size = new System.Drawing.Size(800, 450);
            this.Text = "ArtigosFamilias";
            this.Load += new System.EventHandler(this.ArtigosFamilias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stdBSTabelasUtilizadorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.BindingSource stdBSTabelasUtilizadorBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox seach;
    }
}