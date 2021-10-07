using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Categoria
    {
        readonly Datos.Categoria datos = new Datos.Categoria();
        public void Agregar(Entidades.Categoria categoria)
        {
            datos.Agregar(categoria);
        }
        public List<Entidades.Categoria> TraerLista()
        {
            return datos.TraerLista();
        }
        public Entidades.Categoria TraerPorNomre(string nombre)
        {
            return datos.TraerPorNombre(nombre);
        }
        public void Modificar(Entidades.Categoria categoria)
        {
            datos.Modificar(categoria);
        }

        // CRUD DELETE 
        public void Borrar(int id)
        {
            datos.Borrar(id);
        }
    }
}
