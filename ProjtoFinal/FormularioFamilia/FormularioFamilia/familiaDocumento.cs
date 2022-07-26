using Primavera.Extensibility.BusinessEntities;
using Primavera.Extensibility.CustomForm;
using StdBE100;
using ErpBS100;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;


namespace FormularioFamilia
{
    public partial class familiaDocumento : CustomForm
    {
      
        public familiaDocumento()
        {
            InitializeComponent();
            
    }

        private void FamiliaDocumento_Load(object sender, EventArgs e)
        {
        }

        private void listView_Familia_SelectedIndexChanged_1(object sender, EventArgs e) 
        {
       }
        //Button para caregar todas as familias de artigo
        private void button_Click(object sender, EventArgs e)
        {
            {
                //Conextion a base de dados
                SqlConnection cn = new SqlConnection("Data Source=DESKTOP-IBGKBJR\\V10;Initial Catalog=PRITESTE; User ID = 'sa'; " +
                    "Password = '123';MultipleActiveResultSets=True;Max Pool Size=50000;Pooling=True");
                SqlCommand cm = new SqlCommand("Select Familia,Descricao FROM Familias", cn);

                try
                {   //Abrir a conexecao 
                    cn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cm);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        ListViewItem item = new ListViewItem(dr["Familia"].ToString());
                        item.SubItems.Add(dr["Descricao"].ToString());
                        listView_Familia.Items.Add(item);
                       
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
        }
    }
}





