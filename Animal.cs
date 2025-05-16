using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Fundacion_Animales
{
    public class Animal
    {
        public int id_animal { get; set; }
        public string nombre { get; set; }
        public string especie { get; set; }
        public string raza { get; set; }
        public string sexo { get; set; }
        public DateTime fecha_nacimiento { get; set; }
        public DateTime fecha_ingreso { get; set; }
        public string estado { get; set; }
        public byte[] foto { get; set; }

        public Animal() { }

        public void GuardarDatos( int id_animal,string nombre, string especie, string raza, string sexo, DateTime fecha_nacimiento, DateTime fecha_ingreso, string estado, byte[] foto)
        {
            this.id_animal = id_animal;
            this.nombre = nombre;
            this.especie = especie;
            this.raza = raza;
            this.sexo = sexo;
            this.fecha_nacimiento = fecha_nacimiento;
            this.fecha_ingreso = fecha_ingreso;
            this.estado = estado;
            this.foto = foto;
        
        }
        public void GuardarDatos( string nombre, string especie, string raza, string sexo, DateTime fecha_nacimiento, DateTime fecha_ingreso, string estado, byte[] foto)
        {
            this.nombre = nombre;
            this.especie = especie;
            this.raza = raza;
            this.sexo = sexo;
            this.fecha_nacimiento = fecha_nacimiento;
            this.fecha_ingreso = fecha_ingreso;
            this.estado = estado;
            this.foto = foto;

        }
    }
}
