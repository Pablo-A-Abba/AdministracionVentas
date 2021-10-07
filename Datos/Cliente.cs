using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Cliente
    {
        readonly Entidades.AdministracionEntities db = new Entidades.AdministracionEntities();

        //CRUD : C, Create : Crear
        public void Agregar(Entidades.Cliente cliente)
        {
            db.Clientes.Add(cliente);
            db.SaveChanges();
        }
        // CRUD : Read : Traer
        public List<Entidades.Cliente> TraerLista()
        {
            return db.Clientes.ToList();
        }

        public Entidades.Cliente TraerPorNombre(string nombre)
        {
            var cliente = db.Clientes.Find(nombre);
            return cliente;
        }

    // CRUD : Update , Modificar
    public void Modificar(Entidades.Cliente cliente)
        {
            var clienteAmodificar = db.Clientes.Find(cliente.Id);
            clienteAmodificar.Id = cliente.Id;
            clienteAmodificar.Persona.Nombre = cliente.Persona.Nombre;
            clienteAmodificar.Persona.Apellido = cliente.Persona.Apellido;
            clienteAmodificar.Persona.DatosContacto.Email = cliente.Persona.DatosContacto.Email;
            clienteAmodificar.Persona.DatosContacto.Telefono = cliente.Persona.DatosContacto.Telefono;
            clienteAmodificar.Persona.DatosContacto.Direccion = cliente.Persona.DatosContacto.Direccion;
            db.SaveChanges();
        }

        // CRUD DELETE
        public void Borrar(int id)
        {
            var clienteABorrar = db.Clientes.Find(id);
            db.Clientes.Remove(clienteABorrar);
            db.SaveChanges();
        }
    }
}
