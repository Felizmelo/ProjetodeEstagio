using Primavera.Extensibility.Base.Editors;
using Primavera.Extensibility.BusinessEntities;
using Primavera.Extensibility.BusinessEntities.ExtensibilityService.EventArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtensibilityProject10.Base
{
    public class UiFichaClientes : FichaClientes
    {
        public override void AntesDeGravar(ref bool Cancel, ExtensibilityEventArgs e)

        {
           if ((Cliente.Morada == "" || Cliente.Morada == null) || (Cliente.Telefone == "" || Cliente.Telefone == null))
            {
                PSO.Dialogos.MostraMensagem(StdPlatBS100.StdBSTipos.TipoMsg.PRI_SimplesOk, " por favor preenche o compo morada e telefone");
                Cancel = true;
            }
            else
            {
                MessageBox.Show("Os campos morada e Telefone preenchido com sucesso");
            }
           
        }
    }
}
