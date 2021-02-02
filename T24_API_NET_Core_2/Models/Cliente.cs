using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace T24_API_NET_Core_2.Models
{
    public class Cliente
    {
        // ATRIBUTOS
        private int id;
        private string nombre;
        private string apellido;
        private string direccion;
        private int dni;
        private DateTime fecha = new DateTime();

        // GETTERS Y SETTERS
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Dni { get => dni; set => dni = value; }
        public DateTime Fecha { get => fecha; }

        // CONSTRUCTORES
        public ICollection<Cliente> Clientes { get; set; }

    }
}
