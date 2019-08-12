using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadoresDeAcceso
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();

            cliente.Nombre = "Alberto";
            cliente.Telefono = "6664206913";

            Console.WriteLine("Nombre: " + cliente.Nombre);
            Console.WriteLine("Telefono: " + cliente.Telefono);

            try
            {
                cliente.Curp = "1234567891234567899";
                Console.WriteLine("Curp: " + cliente.Curp);
            }
            catch (Exception e)
            {
                Console.WriteLine("La curp debe ser de 18 caracteres");
            }

            Console.Read();
        }
    }
}
