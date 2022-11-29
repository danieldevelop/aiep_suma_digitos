using System;
using System.Reflection.Emit;

namespace suma_digitos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String digitos;
            int suma = 0; // Acumulador para sumar los numeros transformados a enteros
            String[] longitud;

            #region Variables de presentación de resultados al usuario
            String prefijo = "";
            String formato_suma = ""; // Concadenara con el prefijo '+' los numeros
            #endregion

            try
            {
                Console.Write("Ingrese numeros para sumar Ej.(465 = 15): ");
                digitos = Console.ReadLine();
                
                if (int.Parse(digitos) > 0)
                {
                    longitud = new String[digitos.Length];

                    for (int i=0; i<longitud.Length; i++)
                    {
                        longitud[i] = digitos.Substring(i, 1); // Separamos el string, en digitos indivuales
                        suma = suma + int.Parse(longitud[i]);

                        #region Le damos formato a la suma de los numeros
                        formato_suma = formato_suma + (prefijo + longitud[i]); // == con_simbolo += prefijo + longitud[i]
                        prefijo = "+";
                        #endregion
                    }

                    Console.WriteLine($"\n >> La suma de los digitos {formato_suma} es {suma}");
                }
                else
                {
                    throw new Exception("Negative numbers are not accepted");
                }
            } 
            catch (Exception e)
            {
                Console.WriteLine($"\nWarning: {e.Message}");
            }


            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
