using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Producto
    {
        readonly Datos.Producto datos = new Datos.Producto();
        public static List<Entidades. Producto> Listar()
        {
            var Lista = new List<Entidades.Producto>();
            return Lista;
        }
        public List<Entidades.Producto> Listar(Entidades.Categoria categoria)
        {
            var Lista = new List<Entidades.Producto>();
            return Lista;
        }
        public Entidades.Producto Listar(string nombre)
        {
            var Lista = new List<Entidades.Producto>();

            foreach (Entidades.Producto i in Lista)
                if (i.Nombre == nombre)
                {
                    return i;
                }
            return null;
        }
        public void Agregar(Entidades.Producto producto)
        {
            datos.Agregar(producto);
        }
        public List<Entidades.Producto> TraerLista()
        {
            return datos.TraerLista();
        }
        public Entidades.Producto TraerPorId(int id)
        {
            return datos.TraerPorId(id);
        }
        public Entidades.Producto TraerPorNombre(string nombre)
        {
            return datos.TraerPorNombre(nombre);
        }

        public List<Entidades.Producto> TraerPorCategoria(Entidades.Categoria categoria)
        {
            return datos.TraerPorCategoria(categoria);
        }

        public void Modificar(Entidades.Producto producto)
        {
            datos.Modificar(producto);
        }

        public void Borrar(int id)
        {
            datos.Borrar(id);
        }
    }
}
