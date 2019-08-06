using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoSenova
{
    class Proyecto
    {
        #region Atributos 
        #endregion
        #region propiedades
        #endregion



        public string Nombre { get; set; }
        public double Codigo{ get; set; }
        public string Area { get; set; }
        public int Duracion { get; set; }
        #region Constructores
        public Proyecto(string nombre,double codigo,string area,int duracion)
        {
            Nombre = nombre;
            Codigo = codigo;
            Area = area;
            Duracion = duracion;

        }
        public Proyecto()
        {

        }
        public Proyecto( string area,int duracion)
        {
            Area = area;
            Duracion = duracion;

        }
        #endregion
        #region   Metodos 
        public void IngresarProyecto()
        {
            Console.WriteLine("Ingrese el nombre del proyecto");
            Nombre = Console.ReadLine();


            Console.WriteLine("Ingrese el codigo");
            Codigo = Double.Parse(Console.ReadLine());


            Console.WriteLine("Ingese el area");
            Area = Console.ReadLine();



            Console.WriteLine("Ingrese Duracion");
            Duracion = int.Parse(Console.ReadLine());
        }
        public void ImprimirProyecto()
        {
            Console.WriteLine($"el nombre es: {Nombre}");
            Console.WriteLine($"el codigo es: {Codigo }");
            Console.WriteLine($"el Area es. {Area }");
            Console.WriteLine($"la  Duracion es {Duracion}");
        }
        #endregion
    }

}

