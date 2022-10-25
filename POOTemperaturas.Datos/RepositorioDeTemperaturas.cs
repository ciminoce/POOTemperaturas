using POOTemperaturas.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOTemperaturas.Datos
{
    public class RepositorioDeTemperaturas
    {
        private List<Temperatura> listaTemperaturas;
        public RepositorioDeTemperaturas()
        {
            listaTemperaturas = new List<Temperatura>();
        }

        public void Borrar(Temperatura temperatura)
        {
            listaTemperaturas.Remove(temperatura);
        }
        public double GetTemperaturaMaxima() => listaTemperaturas.Max(t => t.Valor);
        public double GetTemperaturaMinima()
        {
            return listaTemperaturas.Min(t => t.Valor);
        }

        public double GetPromedio()
        {
            return listaTemperaturas.Average(t => t.Valor);
        }
        public void Agregar(Temperatura temperatura)
        {
            listaTemperaturas.Add(temperatura);
        }

        public int GetCantidad()
        {
            return listaTemperaturas.Count;
        }
        public List<Temperatura> GetLista()
        {
            return listaTemperaturas;
        }


    }
}
