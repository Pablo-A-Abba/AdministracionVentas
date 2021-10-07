using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class AdmClientes
    {
        readonly Datos.Cliente datos = new Datos.Cliente();

        public void Agregar(Entidades.Cliente cliente)
        {
            datos.Agregar(cliente);
        }
        // CRUD : Read : Traer
        public List<Entidades.Cliente> ListarCliente()
        {
            return datos.TraerLista();
        }

        public Entidades.Cliente TraerPorNombre(string nombre)
        {
            return datos.TraerPorNombre(nombre);
        }

        public List<Entidades.Factura> TraerFacturas(string nombre)
        {
            Entidades.Cliente cliente = TraerPorNombre(nombre);
            return cliente.Facturas.ToList();
        }

        // CRUD : Update , Modificar
        public void Modificar(Entidades.Cliente cliente)
        {
            datos.Modificar(cliente);
        }

        // CRUD DELETE
        public void Borrar(int id)
        {
            datos.Borrar(id);
        }
    }
}
