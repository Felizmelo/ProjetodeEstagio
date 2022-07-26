using Primavera.Extensibility.Base.Editors;
using Primavera.Extensibility.BusinessEntities;
using Primavera.Extensibility.BusinessEntities.ExtensibilityService.EventArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ExtensibilityProject1.Base
{
    public class UiFichaClientes : FichaClientes
    {
      
        public override void DepoisDeGravar(string Cliente, ExtensibilityEventArgs e)
        {
           
            PSO.Dialogos.MostraMensagem(StdPlatBS100.StdBSTipos.TipoMsg.PRI_SimplesOk, "Gravado Com Sucesso");

      
        }
        
    }
}
