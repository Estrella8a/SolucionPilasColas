using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    public class Pilas
    {
        private List<string> lista;
        public Pilas()
        {
            lista = new List<string>();
        }


        public void Agregar(string dato)
            {
             lista.Add(dato);
            }

        private bool EstaVacio()
        {
            return (lista.Count == 0);
        }

        public void Eliminar()
        {
            if (EstaVacio())
            {
                throw new Exception("Lista vacía");
            }

            lista.RemoveAt(lista.Count - 1);
        }

        public string Imprimir()
        {
            string datos = string.Empty;

            if (EstaVacio())
            {
                return "Lista vacía";
            }

            int listaCount = lista.Count;
            for (int i = 0; i < listaCount; i++)
            {
                if (i > 0)
                {
                    datos += "\n";
                }

                datos += lista[i];
            }

            return datos;
        }

    }
}