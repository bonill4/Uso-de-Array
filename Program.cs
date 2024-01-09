using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace UsoArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //arraySimple();
            //arraySimplificada();
            //arrayImplicito();
            //arrayObjetos();
            arrayTipoClaseAnonimas();
        }

        static void arraySimple()
        {
            //Declaracion de array
            int[] edades;
            //Inicializacion de array
            edades = new int[4];
            //Asignacion de valores
            try
            {
                edades[0] = 15;
                edades[1] = 27;
                edades[2] = 19;
                edades[3] = 80;

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine(edades[2]);
        }

        static void arraySimplificada()
        {
            int[] edades = { 15, 27, 19, 80 };

            Console.WriteLine(edades[2]);
        }

        static void arrayImplicito()
        {
            //Estos arrays no se especifica el tipo de dato ni cuantos elemento tendran 

            //Genera error ya que no sabe si el valor de de tipo String o Int
            //var datos = new[] { "Juan", "Diaz", 18 };

            //No genera error porque lo pasa todos los datos a Double
            var valores = new[] { 15, 27, 19, 12.5, 22.4, 88 };

            //Imprimier valores de array en un ciclo "For"
            //Con "valores.Length" indicamos que recorra todos los valores del array
            /*for (int i = 0; i < valores.Length; i++)
            {
                Console.WriteLine(valores[i]);
            }*/

            foreach (double i in valores)
            {
                Console.WriteLine(i);
            }
        }

        static void arrayObjetos()
        {
            Empleados[] arrayEmpleados = new Empleados[3];

            Empleados Ana = new Empleados("Ana", 22);

            arrayEmpleados[0] = new Empleados("Williams", 23);

            arrayEmpleados[1] = Ana;

            arrayEmpleados[2] = new Empleados("Manuel", 31);

            /*for (int i = 0; i<arrayEmpleados.Length; i++)
            {
                Console.WriteLine(arrayEmpleados[i].getInfo());
            }*/

            //El bucle "foreach" solo sirve para recorrer todos los elemnetos de un array
            //No permite la modificacion dentro del array
            foreach (Empleados i in arrayEmpleados)
            {
                Console.WriteLine(i.getInfo());
            }
        }

        static void arrayTipoClaseAnonimas()
        {
            var personas = new[]
            {
                new{Nombre="Juan", Edad = 19},
                new{Nombre="Maria", Edad = 49},
                new{Nombre="Diana", Edad = 35}
            };

            foreach (var i in personas)
            {
                Console.WriteLine(i);
            }
        }

    }

    class Empleados
    {
        private String nombre;
        private int edad;

        public Empleados(String nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public String getInfo()
        {
            return $"Nombre del empleado: {nombre} Edad: {edad}";
        }
    }
}
