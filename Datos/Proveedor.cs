using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Proveedor
    {
        readonly Entidades.AdministracionEntities db = new Entidades.AdministracionEntities();

        //CRUD : C, Create : Crear
        public void Agregar(Entidades.Proveedor proveedor)
        {
            db.Proveedors.Add(proveedor);
            db.SaveChanges();
        }
        // CRUD : Read : Traer
        public List<Entidades.Proveedor> TraerLista()
        {
            return db.Proveedors.ToList();
        }

        public Entidades.Proveedor TraerPorId(int id)
        {
            var proveedor = db.Proveedors.Find(id);
            return proveedor;
        }

        public Entidades.Proveedor TraerPorNombre(string nombre)
        {
            var proveedor = db.Proveedors.Find(nombre);
            return proveedor;
        }

        public List<Entidades.Producto> TraerProductos(Entidades.Proveedor proveedor)
        {
            List<Entidades.Producto> productos_proveedor = new List<Entidades.Producto>();
            foreach (Entidades.Producto producto in proveedor.Productos){
                productos_proveedor.Add(producto);
            }
            return productos_proveedor;
        }

        // CRUD : Update , Modificar
        public void Modificar(Entidades.Proveedor proveedor)
        {
            var proveedorAmodificar = db.Proveedors.Find(proveedor.Id);
            proveedorAmodificar.Id = proveedor.Id;
            proveedorAmodificar.Nombre = proveedor.Nombre;
            proveedorAmodificar.Cuit = proveedor.Cuit;
            proveedorAmodificar.Productos = proveedor.Productos;
            db.SaveChanges();
        }

        // CRUD DELETE
        public void Borrar(int id)
        {
            var proveedorABorrar = db.Proveedors.Find(id);
            db.Proveedors.Remove(proveedorABorrar);
            db.SaveChanges();
        }
    }
}
