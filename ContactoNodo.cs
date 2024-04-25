using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_de_catedra
{
    internal class ContactoNodo
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Pais { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int IdGrupo { get; set; }
        public int IdOrganizacion { get; set; }
        public int IdUsuario { get; set; }

        public ContactoNodo(string nombre, string apellido, string correo, string telefono, string direccion, string ciudad, string pais, DateTime fechaNacimiento, int idGrupo, int idOrganizacion, int idUsuario)
        {
            Nombre = nombre;
            Apellido = apellido;
            Correo = correo;
            Telefono = telefono;
            Direccion = direccion;
            Ciudad = ciudad;
            Pais = pais;
            FechaNacimiento = fechaNacimiento;
            IdGrupo = idGrupo;
            IdOrganizacion = idOrganizacion;
            IdUsuario = idUsuario;
        }
    }
}