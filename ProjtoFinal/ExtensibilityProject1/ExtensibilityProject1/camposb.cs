using Primavera.Extensibility.Base.Editors;
using Primavera.Extensibility.BusinessEntities;
using Primavera.Extensibility.BusinessEntities.ExtensibilityService.EventArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ExtensibilityProject1
{
    public class camposb : FichaClientes
    {

        public override void AntesDeGravar(ref bool Cancel, ExtensibilityEventArgs e)
        {
            // os 2 campos obrigatorios 

            if ((Cliente.Morada=="" || Cliente.Morada == null) || (Cliente.Telefone == "" || Cliente.Telefone == null))
               
                {
                PSO.Dialogos.MostraMensagem(StdPlatBS100.StdBSTipos.TipoMsg.PRI_SimplesOk, "Por favor preenche o Campo morada e telefone");
                Cancel = true;

            }
            else
            {
                //PSO.Dialogos.MostraMensagem(StdPlatBS100.StdBSTipos.TipoMsg.PRI_SimplesOk, "Os Campos Morada e Telefone preenchida com Sucesso");
                MessageBox.Show("Os Campos Morada e Telefone preenchida com Sucesso");
            }
           




        }
    }
}
