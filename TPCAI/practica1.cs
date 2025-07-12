using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TPCai
{
    class practical
    {
        static void Main(string[] args)
        {
            // Call the static DeclararVariables method directly
            DeclararVariables();
        }

        // Change 'private void' to 'private static void'
        private static void DeclararVariables()
        {
            string nombre;
            string apellido;

            nombre = "nahuel";
            apellido = "namur";

            Console.WriteLine(nombre);
        }
    }
}

