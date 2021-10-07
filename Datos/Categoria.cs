using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Categoria
    {
        readonly Entidades.AdministracionEntities db = new Entidades.AdministracionEntities();

        //CRUD : C, Create : Crear
        public void Agregar(Entidades.Categoria categoria)
        {
            db.Categorias.Add(categoria);
            db.SaveChanges();
        }

        // CRUD : Read : Traer
        public List<Entidades.Categoria> TraerLista()
        {
            return db.Categorias.ToList();
        }

        public Entidades.Categoria TraerPorNombre(string nombre)
        {
            var categoria = db.Categorias.Find(nombre);
            return categoria;
        }

        // CRUD : Update , Modificar
        public void Modificar(Entidades.Categoria categoria)
        {
            var categoriaAmodificar = db.Categorias.Find(categoria.Id);
            categoriaAmodificar.Id = categoria.Id;
            categoriaAmodificar.Nombre = categoria.Nombre;

            db.SaveChanges();
        }

        // CRUD DELETE 
        public void Borrar(int id)
        {
            var categoriaABorrar = db.Categorias.Find(id);
            db.Categorias.Remove(categoriaABorrar);
            db.SaveChanges();
        }
    }
}
