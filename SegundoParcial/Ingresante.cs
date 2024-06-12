using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingresantes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Ingresantes
    {
        public class Ingresante
        {
            public string[] cursos { get; set; }
            public string direccion { get; set; }
            public int edad { get; set; }
            public string genero { get; set; }
            public string nombre { get; set; }
            public string pais { get; set; }
            public string cuit { get; set; }

            public Ingresante(string[] cursos, string direccion, int edad, string genero, string nombre, string pais, string cuit)
            {
                this.cursos = cursos;
                this.direccion = direccion;
                this.edad = edad;
                this.genero = genero;
                this.nombre = nombre;
                this.pais = pais;
                this.cuit = cuit;
            }
            public string Mostrar()
            {
                StringBuilder sb = new StringBuilder($"Curso:{cursos} + Direccion:{direccion} + Edad: {edad}" +
                    $"Genero: {genero}+nombre: {nombre} + pais: {pais} + cuit: {cuit}");
                return sb.ToString();


            }
        }
    }
}
