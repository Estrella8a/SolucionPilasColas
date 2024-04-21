using Arreglos;
using Listas;

namespace PilasColas
{
    class Program
    {
        public static void Main(string[] args)
        {
            ArregloPila();
            ArregloColas();
            ListasPilas();
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
                    colas.Agregar("Peep0");
                    colas.Agregar("Peep1");
                    colas.Agregar("Peep2");
                    colas.Agregar("Peep3");
                    colas.Agregar("Peep4");

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



        static void ListasPilas()
        {

            Console.WriteLine("**************Listas Pilas**************");
            try

            {
                Listas.Pilas pila = new Listas.Pilas();
            
       
          
                pila.Agregar("Pp0");
                pila.Imprimir();
                pila.Agregar("Pp1");
                pila.Imprimir();
                pila.Agregar("Pp2");
                pila.Imprimir();
                pila.Agregar("Pp3");
                pila.Imprimir();
                pila.Agregar("Pp4");
                pila.Imprimir();
                pila.Agregar("Pp5");
                pila.Imprimir();


                Console.WriteLine();
                pila.Eliminar();
                Console.WriteLine(pila.Imprimir());

                Console.WriteLine();
                pila.Eliminar();
                Console.WriteLine(pila.Imprimir());

                Console.WriteLine();
                pila.Eliminar();
                Console.WriteLine(pila.Imprimir());

                Console.WriteLine();
                pila.Eliminar();
                Console.WriteLine(pila.Imprimir());


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void ListasColas()
        {
            Console.WriteLine("**************Listas Colas**************");
            try
            {

                Listas.Colas cola = new Listas.Colas();

                cola.Agregar(" Epep0");
                cola.Imprimir();
                cola.Agregar("Epep1");
                cola.Imprimir(); ;
                cola.Agregar("Epep2");
                cola.Imprimir();
                cola.Agregar("Epep3");
                cola.Imprimir();
                cola.Agregar("Epep4");
                Console.WriteLine(cola.Imprimir());

                Console.WriteLine();
                cola.Eliminar();
                Console.WriteLine(cola.Imprimir());

                Console.WriteLine();
                cola.Eliminar();
                Console.WriteLine(cola.Imprimir());

                Console.WriteLine();
                cola.Eliminar();
                Console.WriteLine(cola.Imprimir());

                Console.WriteLine();
                cola.Eliminar();
                Console.WriteLine(cola.Imprimir());

                Console.WriteLine();
                cola.Eliminar();
                Console.WriteLine(cola.Imprimir());
            }
             catch (Exception ex)
            {
             Console.WriteLine(ex.Message);
            }

        }




    }
}