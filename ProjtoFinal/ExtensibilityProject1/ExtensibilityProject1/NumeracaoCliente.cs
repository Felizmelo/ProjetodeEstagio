using Primavera.Extensibility.Base.Editors;
using Primavera.Extensibility.BusinessEntities;
using Primavera.Extensibility.BusinessEntities.ExtensibilityService.EventArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ExtensibilityProject1
{
    public class NumeracaoCliente : FichaClientes
    {
        public override void AntesDeGravar(ref bool Cancel, ExtensibilityEventArgs e)
        {
            int NumClient;
             NumClient = BSO.Base.Clientes.LstClientes().NumLinhas() +1;
             this.Cliente.Cliente = "C00"; 0xxx
            string codigo = this.Cliente.Cliente;
            if (codigo[0] == '0' && codigo.Length == 4)
            {
                PSO.Dialogos.MostraMensagem(StdPlatBS100.StdBSTipos.TipoMsg.PRI_SimplesOk, "certo");
            }
            else
            {
                Cancel = true;
                PSO.Dialogos.MostraMensagem(StdPlatBS100.StdBSTipos.TipoMsg.PRI_SimplesOk, "Codigo invalido");
            }

            base.AntesDeGravar(ref Cancel, e);
        }
       
    }
}
