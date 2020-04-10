using System;
using System.Collections.Generic;
using System.Linq;

namespace TAREA
{
    class Program
    {
        static void Main(string[] args)
        {
            //Persona juan = new Persona();
            //Banco banco = new Banco();           
            //banco.Personas.Add(juan);          
            //banco.Personas.First().Cuenta.Agregar(2000);
            //banco.Personas.First().Cuenta.Mostrar();
            
            for (int i = 0; i <1000000 ; i++)
            {
                
                Persona Usuario = new Persona();
                Usuario.Cuenta.Agregar(10*i);
                Usuario.Cuenta.Mostrar();
            }
            Console.ReadKey();
        }
    }
    class Cuenta
    {
        
        public float Dinero;
        public void Retirar(float retirar)
        {
            Dinero = Dinero - retirar;
        }
        public void Mostrar()
        {
            Console.WriteLine(Dinero);
           
        }
        public void Agregar(float agregar)
        {
            Dinero = agregar + Dinero;
        }
    }

    class Banco
    {
        public Banco()
        {
            Personas = new List<Persona>();
        }
        public List<Persona> Personas;
    }
    class Persona
    {
        public Persona()
        {
            Cuenta = new Cuenta();
        }
        public Cuenta Cuenta;      
    }
}
