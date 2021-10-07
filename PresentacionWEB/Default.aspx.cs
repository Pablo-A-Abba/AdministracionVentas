using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentacionWEB
{
    public partial class _Default : Page
    {
        readonly Logica.AdmProveedor admProv = new Logica.AdmProveedor();
        protected void Page_Load(object sender, EventArgs e)
        {
            Exception exc = Server.GetLastError();
            List<Entidades.Proveedor> proveedor = admProv.ListarProveedores();
            if(proveedor != null)    
                foreach(Entidades.Proveedor i in proveedor)
                {
                    BLProveedor.Items.Add(i.Nombre);
                }
            else if(exc is HttpUnhandledException)
            {
                Server.Transfer("No existen proveedores actualmente", true);
            }
        }
    }
}