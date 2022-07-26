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

namespace ExtensibilityProjectArtigo
{
    public partial class pesquisarArtigo : CustomForm
    {
        public pesquisarArtigo()
        {
            InitializeComponent();
        }

        

        private void seach_TextChanged(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand();
            StdBELista list = BSO.Base.Artigos.LstArtigos();
            String textocodigoArtigo = seach.Text;
            String textocodiDescricao = seach.Text;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            for(int n = 0; list.NumLinhas() > n; n++)
            {
                String codArtigo = list.DaValor<string>("Artigo");
                String DescricaoArtigo = list.DaValor<string>("Descricao");

                if (codArtigo.Contains(textocodigoArtigo)|| DescricaoArtigo.Contains(textocodiDescricao))
                {
                    //Adicionar os campos nos dataGridView
                    dataGridView1.Rows.Add(new object[] { codArtigo, DescricaoArtigo });
                    dataGridView1.BeginEdit(true);
                }
                list.Seguinte();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            String textocodigoArtigo;
            String textocodiDescricao;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                textocodigoArtigo = Convert.ToString(dataGridView1.Rows[i].Cells[0].Value);
                textocodiDescricao = Convert.ToString(dataGridView1.Rows[i].Cells[1].Value);
            }
        }
    }
    }

