
namespace FormularioFamilia
{
    partial class familiaDocumento
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
            this.listView_Familia = new System.Windows.Forms.ListView();
            this.Familia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView_Familia
            // 
            this.listView_Familia.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Familia,
            this.Descricao});
            this.listView_Familia.FullRowSelect = true;
            this.listView_Familia.GridLines = true;
            this.listView_Familia.HideSelection = false;
            this.listView_Familia.Location = new System.Drawing.Point(162, 86);
            this.listView_Familia.MultiSelect = false;
            this.listView_Familia.Name = "listView_Familia";
            this.listView_Familia.Size = new System.Drawing.Size(456, 242);
            this.listView_Familia.TabIndex = 2;
            this.listView_Familia.UseCompatibleStateImageBehavior = false;
            this.listView_Familia.View = System.Windows.Forms.View.Details;
            this.listView_Familia.SelectedIndexChanged += new System.EventHandler(this.listView_Familia_SelectedIndexChanged_1);
            // 
            // Familia
            // 
            this.Familia.Text = "Familia";
            this.Familia.Width = 172;
            // 
            // Descricao
            // 
            this.Descricao.Text = "Descricao";
            this.Descricao.Width = 300;
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button.Location = new System.Drawing.Point(306, 334);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(119, 31);
            this.button.TabIndex = 3;
            this.button.Text = "Carregar";
            this.button.UseVisualStyleBackColor = false;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // familiaDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button);
            this.Controls.Add(this.listView_Familia);
            this.Margin = new System.Windows.Forms.Padding(3);
            this.Name = "familiaDocumento";
            this.Size = new System.Drawing.Size(752, 429);
            this.Text = "familiaDocumento";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listView_Familia;
        private System.Windows.Forms.ColumnHeader Familia;
        private System.Windows.Forms.ColumnHeader Descricao;
        private System.Windows.Forms.Button button;
    }
}