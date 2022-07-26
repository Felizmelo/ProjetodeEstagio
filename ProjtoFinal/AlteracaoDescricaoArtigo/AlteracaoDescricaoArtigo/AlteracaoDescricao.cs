using Primavera.Extensibility.BusinessEntities;
using Primavera.Extensibility.CustomForm;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ErpBS100;
using StdBE100;
using System.Windows.Forms;

namespace AlteracaoDescricaoArtigo
{
    public partial class AlteracaoDescricao : CustomForm
    {

      
        public AlteracaoDescricao()
        {
            InitializeComponent();
           
        }
        //Button para gravar Alteracao
        private void Bt_Gravar(object sender, EventArgs e)
        {
            string textocodaArtigo;
            String textoDescricao;
            for (int i =0; i< dataGridView1.Rows.Count;i++)
            {
                textocodaArtigo = Convert.ToString(dataGridView1.Rows[i].Cells[0].Value);
                textoDescricao = Convert.ToString( dataGridView1.Rows[i].Cells[1].Value);
            }
        }
        //Button para Pesquisar Artigo por codigo de artigo ou Descricao
        private void seach_TextChanged(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand();
            StdBELista list = BSO.Base.Artigos.LstArtigos();
            string textocodaArtigo = seach.Text;
            string textoDescricao =seach.Text;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            
            for (int n = 0; list.NumLinhas() > n; n++)
            {
                string CodArtigo = list.DaValor<string>("Artigo");
                string descricaoArtigo = list.DaValor<string>("Descricao");
                if (CodArtigo.Contains(textocodaArtigo) || descricaoArtigo.Contains(textoDescricao))
                {
                    //Adicionar os campos nos dataGridView
                    dataGridView1.Rows.Add(new object[] { CodArtigo, descricaoArtigo });
                    dataGridView1.BeginEdit(true);
              

                }

                list.Seguinte();
            }

        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // centralizar dados
      
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           //pegar linhas 
            //String asc;
            //asc = dataGridView1.Rows[e.RowIndex].Cells["Artigo"].Value.ToString();
            //// verificar o coluna o que foi clicada
            //if (dataGridView1.Columns[e.ColumnIndex] == dataGridView1.Columns["Descricao"])
            //{

            //}

        }
        //Button para Editar Artigos
        private void Bt_Ediatr_Click(object sender, EventArgs e)
        {
        

        }

        
    }
}
