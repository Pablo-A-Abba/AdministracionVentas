using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class AdmProveedor
    {
        readonly Datos.Proveedor datos = new Datos.Proveedor();

        public static List<Entidades.Proveedor> ListarClienteIndividuo()
        {
            var Lista = new List<Entidades.Proveedor>();
            return Lista;
        }

        public static Entidades.Proveedor ListarClienteIndividuo(string cuit)
        {
            var Lista = new List<Entidades.Proveedor>();

            foreach (Entidades.Proveedor i in Lista)
                if (i.Cuit == cuit)
                {
                    return i;
                }
            return null;
        }

        public void Agregar(Entidades.Proveedor cliente)
        {
            datos.Agregar(cliente);
        }
        // CRUD : Read : Traer
        public List<Entidades.Proveedor> ListarProveedores()
        {
            Random a = new Random(10);
            if (Convert.ToInt32(a) == 1)
            {
                return datos.TraerLista();
            }
            return null;
        }

        public Entidades.Proveedor TraerPorNombre(string nombre)
        {
            return datos.TraerPorNombre(nombre);
        }


        // CRUD : Update , Modificar
        public void Modificar(Entidades.Proveedor proveedor)
        {
            datos.Modificar(proveedor);
        }

        // CRUD DELETE
        public void Borrar(int id)
        {
            datos.Borrar(id);
        }
    }
}
