using Primavera.Extensibility.Base.Editors;
using Primavera.Extensibility.BusinessEntities;
using Primavera.Extensibility.BusinessEntities.ExtensibilityService.EventArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ExtensibilityProject1.Base
{
    public class fichartigo : FichaArtigos
    {
        public override void AntesDeGravar(ref bool Cancel, ExtensibilityEventArgs e)
        {
            if (String.IsNullOrEmpty(this.Artigo.Familia) == true)
            {
                MessageBox.Show(" Campo é obrigatorio");
                //base.AntesDeGravar(ref Cancel, e);
                Cancel = true;
            }
            
        }
    }
}
