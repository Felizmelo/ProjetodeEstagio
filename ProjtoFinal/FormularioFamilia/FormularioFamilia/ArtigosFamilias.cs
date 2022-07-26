using Primavera.Extensibility.BusinessEntities;
using Primavera.Extensibility.CustomForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using StdBE100;

namespace FormularioFamilia
{
    public partial class ArtigosFamilias : CustomForm
    {
        
       
        public ArtigosFamilias()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-IBGKBJR\\V10;Initial Catalog=PRITESTE; User ID = 'sa';" +
            " Password = '123';MultipleActiveResultSets=True;Max Pool Size=50000;Pooling=True");
      

        private void ArtigosFamilias_Load(object sender, EventArgs e)
        {
            
            SqlDataAdapter da = new SqlDataAdapter("Select Distinct Familia FROM Familias", con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox.DataSource = dt;
            comboBox.DisplayMember = "Familia";
            comboBox.ValueMember = "Select Familia ";
            con.Close();
        }
        //lista de artigo
        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Conexao a base de dados
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IBGKBJR\\V10;Initial Catalog=PRITESTE; " +
                "User ID = 'sa'; Password = '123';MultipleActiveResultSets=True;Max Pool Size=50000;Pooling=True");
            SqlCommand cn = new SqlCommand("Select Artigo, Descricao from Artigo where Familia = @Familia", con);
            cn.Parameters.AddWithValue("Familia", comboBox.Text.ToString());
            SqlDataAdapter da = new SqlDataAdapter(cn);
            con.Open();
            da.SelectCommand = cn;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        
        }
        //pesquisar na lista de artigo
        private void seach_TextChanged(object sender, EventArgs e)
        {
            
            con.Open();
            SqlCommand cm = new SqlCommand();
            StdBELista list = BSO.Base.Artigos.LstArtigos();
            string textoDescricao = seach.Text;
            for (int n = 0; list.NumLinhas() > n; n++)
            {
                string descricaoArtigo = list.DaValor<string>("Descricao");
                if (descricaoArtigo.Contains(textoDescricao))
                {
                    dataGridView1.Rows.Add(new object[] { descricaoArtigo });

                }

                list.Seguinte();
            }

        }
        //private void PopulateDataGridView() {
        //    string query = "SELECT Artigo, Descricao FROM Artigo";
        //    query += " WHEREFamilia = @Familia";
        //    query += " OR ISNULL(@Familia, '') = ''";
        //    string constr = @"Data Source=DESKTOP-IBGKBJR\\V10;Initial Catalog=PRITESTE; User ID = 'sa'; Password = '123';MultipleActiveResultSets=True;Max Pool Size=50000;Pooling=True";
        //    using (SqlConnection con = new SqlConnection(constr))
        //    {
        //        using (SqlCommand cmd = new SqlCommand(query, con))
        //        {
        //            cmd.Parameters.AddWithValue("@Familia",comboBox.SelectedValue);
        //            using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
        //            {
        //                DataTable dt = new DataTable();
        //                sda.Fill(dt);
        //                .DataSource = dt;
        //            }
        //        }
        //    }

        //}


    }
}
