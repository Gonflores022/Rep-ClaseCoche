using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Class_Coche
{
    public class ProgramTest{
        public static void Main(String[] args)
        {
            //crear objeto
            Coche coche1 = new Coche("Tesla", "Model 3", "Blanco", "9933-HYX", 5, 270);
            Coche coche2 = new Coche("Toyota", "Yaris", "Azul", "5233-LKM", 3, 75);
          
            //Objeto coche cambio color.
            coche1.color = "Verde";

            Messanges.Hola();
            Console.ReadKey();
            Console.WriteLine("Nuestro Inventario Actual: " + " " + coche1.marca + " " + coche1.modelo + " " + coche1.color + " " + coche1.matricula + " " + coche1.numeroPuertas + " " + coche1.numeroHp);
                        
            //Llamo los metodos de la clase Messenges.
           
            Messanges.Esperando();
            Console.ReadKey();


            Messanges.Adios();
            Console.ReadKey();
        }
    }
}