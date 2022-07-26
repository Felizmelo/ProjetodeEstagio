
using Primavera.Extensibility.BusinessEntities;
using Primavera.Extensibility.CustomForm;
using StdBE100;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtensibilityEmpresa
{
    public partial class ExtensibilityEmpresa : CustomForm
    {
        public ExtensibilityEmpresa()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-IBGKBJR\\V10;Initial Catalog=PRITESTE; User ID = 'sa';" +
         " Password = '123';MultipleActiveResultSets=True;Max Pool Size=50000;Pooling=True");


        private void ExtensibilityEmpresa_Load(object sender, EventArgs e)
        {
            forneced();
            company();
            spending();
            //    try
            //    {
            //        string connetionString = PSO.BaseDados.DaConnectionStringNET(PSO.BaseDados.DaNomeBDdaEmpresa(this.BSO.Contexto.CodEmp), "Default");
            //        string priBDemprea = PSO.BaseDados.DaNomeBDdoPRIEMPRE();
            //        connetionString = Habanero.DB.DatabaseConnection.GetConnection(priBDemprea.Remove(0, 3)); //remove pri

            //        //  SqlConnection con = new SqlConnection(connetionString);
            //      connetionString.Open();
            //        command.Connection = connetionString;
            //        string query = "select Codigo from Empresas";
            //        command.CommandText = query;
            //        return command.ExecuteReader();
            //        using(SqlDataReader reader = GetCompaniesCode())
            //        {
            //            while (reader.Read())
            //            {
            //                string company = Convert.ToString(reader[0]);
            //                DataTable pendingsData = GetPendingsByCompany(company, cbDocumentCode.Text, selectedEntity[0],
            //                    pendingsByFilter: filtersGroup.SelectedIndex == 1);
            //                List<(string, double)> pendings = new List<(string, double)>();
            //                foreach(DataRow row in pendingsData.Rows)
            //                {
            //                    string entityCode = Convert.ToString(row[0]);
            //                    string entityName = Convert.ToString(row[1]);
            //                    string nif = GetEntityNifByCode(company, entityCode, SelectedEntity);
            //                    if (!entities.Keys.Contains(nif)) entities.Add(nif, (entityCode, entityName));
            //                    double totalValue = Convert.ToDouble(row[2]);
            //                    double pendingValue = Convert.ToDouble(row[3]);
            //                    string docDate = Convert.ToString(row[4].Split("")[0]);
            //                    string docType = Convert.ToString(row[5]);
            //                    string paymentMode = Convert.ToString(row[6]);
            //                    string state = Convert.ToString(row[7]);
            //                    pendings(reader[0], entityCode, entityName, totalValue, pendingValue, 0.0, paymentMode, state, nif);

            //                }
            //                companiesPendings.Add(company, pendings);
            //                pendingsData.Resert();
            //            }

            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.ToString());
            //    }

            //}

            //private void label1_Click(object sender, EventArgs e)
            //{

           }
            public void forneced()
            {

            try {
                //string connetionString = PSO.BaseDados.DaConnectionStringNET(PSO.BaseDados.DaNomeBDdaEmpresa(this.BSO.Contexto.CodEmp), "Default");
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-IBGKBJR\\V10;Initial Catalog=PRITESTE; User ID = 'sa';" +" Password = '123';MultipleActiveResultSets=True;Max Pool Size=50000;Pooling=True");
                con.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select Codigo  FROM Empresas", con);
                
            SqlCommand cm = new SqlCommand();

            }catch (Exception ex)
                {

                   MessageBox.Show(ex.ToString());
               }





    }
            public void company()
            {
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select Codigo  FROM Empresas", con);

                SqlCommand cm = new SqlCommand();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }

        public void spending()
            {
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select Codigo  FROM Empresas", con);

                SqlCommand cm = new SqlCommand();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

    }

    }
