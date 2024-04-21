using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    public class Colas
    {
        private List<string> cola;

        public Colas()
        {
            cola = new List<string>();
        }

        public void Agregar(string dato)
        {
            cola.Add(dato);
        }

        private bool EstaVacio()
        {
            return (cola.Count == 0);
        }

        public void Eliminar()
        {
            if (EstaVacio())
            {
                throw new Exception("La Lista esta vacía");
            }

            cola.RemoveAt(0);
        }

        public string Imprimir()
        {
            string datos = string.Empty;

            if (EstaVacio())
            {
                return "Lista vacía";
            }

            int listaCount = cola.Count;
            for (int i = 0; i < listaCount; i++)
            {
                if (i > 0)
                {
                    datos += "\n";
                }

                datos += cola[i];
            }

            return datos;
        }

    }
}