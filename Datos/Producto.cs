using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Producto
    {
        readonly Entidades.AdministracionEntities db = new Entidades.AdministracionEntities();

        //CRUD : C, Create : Crear
        public void Agregar(Entidades.Producto producto)
        {
            db.Productos.Add(producto);
            db.SaveChanges();
        }

        // CRUD : Read : Traer
        public List<Entidades.Producto> TraerLista()
        {
            return db.Productos.ToList();
        }

        public Entidades.Producto TraerPorId(int id)
        {
            var producto = db.Productos.Find(id);
            return producto;
        }

        public Entidades.Producto TraerPorNombre(string nombre)
        {
            var producto = db.Productos.Find(nombre);
            return producto;
        }

        public List<Entidades.Producto> TraerPorCategoria(Entidades.Categoria categoria)
        {
            var productos = (from l in db.Productos
                             where l.CategoriaId == categoria.Id
                             select l).ToList<Entidades.Producto>();
            return productos;
        }

        // CRUD : Update , Modificar
        public void Modificar(Entidades.Producto producto)
        {
            var productoAmodificar = db.Productos.Find(producto.Id);
            productoAmodificar.Id = producto.Id;
            productoAmodificar.Nombre = producto.Nombre;
            productoAmodificar.Descripcion = producto.Descripcion;
            productoAmodificar.Precio = producto.Precio;
            productoAmodificar.CategoriaId = producto.CategoriaId;
            productoAmodificar.ProveedorId = producto.ProveedorId;
            db.SaveChanges();
        }

        // CRUD DELETE
        public void Borrar(int id)
        {
            var productoABorrar = db.Productos.Find(id);
            db.Productos.Remove(productoABorrar);
            db.SaveChanges();
        }
    }
}
