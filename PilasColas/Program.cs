using Arreglos;

namespace PilasColas
{
    class Program
    {
        public static void Main(string[] args)
        {
            ArregloPila();
            ArregloColas();
        }




        static void ArregloPila()
        {
            Console.WriteLine("**************Arreglo Pila**************");
            Arreglos.Pila pila = new Arreglos.Pila(5);
            void Imprimir(string[] elementos)
            {
                //Console.Clear();
                Console.WriteLine();
                foreach (string elemento in elementos)
                {
                    Console.WriteLine(elemento);
                }
            }

            try
            {
                pila.Agregar("Pepe0");
                pila.Agregar("Pepe1");
                pila.Agregar("Pepe2");
                pila.Agregar("Pepe3");
                pila.Agregar("Pepe4");

                Imprimir(pila.ObtenerArreglo());
                pila.Eliminar();
                Imprimir(pila.ObtenerArreglo());
                pila.Eliminar();
                Imprimir(pila.ObtenerArreglo());
                pila.Eliminar();
                Imprimir(pila.ObtenerArreglo());
                pila.Eliminar();
                Imprimir(pila.ObtenerArreglo());
                pila.Eliminar();
                Imprimir(pila.ObtenerArreglo());
                pila.Eliminar();
                Imprimir(pila.ObtenerArreglo());
                pila.Eliminar();
                Imprimir(pila.ObtenerArreglo());
            }
            catch (Exception ex)
            {
             Console.WriteLine(ex.Message);
            }
        }


        static void ArregloColas()
        {
                Console.WriteLine("**************Arreglo Cola**************");
                Arreglos.Colas colas = new Arreglos.Colas(5);
                void Imprimir(string[] elementos)
                {
                    //Console.Clear();
                    Console.WriteLine();
                    foreach (string elemento in elementos)
                    {
                        Console.WriteLine(elemento);
                    }
                }

                try
                {
                    colas.Agregar("Pepe0");
                    colas.Agregar("Pepe1");
                    colas.Agregar("Pepe2");
                    colas.Agregar("Pepe3");
                    colas.Agregar("Pepe4");

                    Imprimir(colas.ObtenerArreglo());
                    colas.Eliminar();
                    Imprimir(colas.ObtenerArreglo());
                    colas.Eliminar();
                    Imprimir(colas.ObtenerArreglo());
                    colas.Eliminar();
                    Imprimir(colas.ObtenerArreglo());
                    colas.Eliminar();
                    Imprimir(colas.ObtenerArreglo());
                    colas.Eliminar();
                    Imprimir(colas.ObtenerArreglo());
                    colas.Eliminar();
                    Imprimir(colas.ObtenerArreglo());
                    colas.Eliminar();
                    Imprimir(colas.ObtenerArreglo());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
        }
       

   
    
    
    
    
    
    
    
    }
}