using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Pasajero
    {
        private int idPasajero;
        private string nombre;
        private string apellido;
        private int edad;
        private DateTime fechaNacimiento;

        public int IdPasajero
        {
            get
            {
                return idPasajero;
            }


        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return apellido;
            }

            set
            {
                apellido = value;
            }
        }

        public int Edad
        {
            get
            {
                return edad;
            }

            set
            {
                edad = value;
            }
        }

        public DateTime FechaNacimiento
        {
            get
            {
                return fechaNacimiento;
            }

            set
            {
                fechaNacimiento = value;
            }
        }

        public Pasajero(int idPasajero, string nombre, string apellido, int edad, DateTime fechaNacimiento)
        {
            this.idPasajero = idPasajero;
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.fechaNacimiento = fechaNacimiento;
        }

        public Pasajero()
        {
        }




    }
}
