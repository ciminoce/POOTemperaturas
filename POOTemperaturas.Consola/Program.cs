using POOTemperaturas.Datos;
using POOTemperaturas.Entidades;
using System;
using System.Collections.Generic;

namespace POOTemperaturas.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            RepositorioDeTemperaturas repo = new RepositorioDeTemperaturas();
            Temperatura temperatura = new Temperatura();
            temperatura.Valor = 27;
            Console.WriteLine($"{temperatura.Valor} equivalen a {temperatura.GetEquivalenteFahrenheit()} grados F");
            repo.Agregar(temperatura);
            var temperatura2 = new Temperatura() { Valor = 15 };
            var temperatura3 = new Temperatura() { Valor = -10 };
            var temperatura4 = new Temperatura() { Valor = 5 };
            repo.Agregar(temperatura4);
            repo.Agregar(temperatura3);

            repo.Agregar(temperatura2);
            Console.WriteLine($"Se almacenaron {repo.GetCantidad()} temperaturas");
            var lista = repo.GetLista();
            Console.Write("Ingrese el valor de la temperatura:");
            var valorTemp = float.Parse(Console.ReadLine());
            var nuevaTemperatura = new Temperatura();
            nuevaTemperatura.Valor = valorTemp;
            repo.Agregar(nuevaTemperatura);
            var minimo = repo.GetTemperaturaMinima();
            Console.WriteLine($"Temp. mínima: {minimo}");
            var temperatura5 = new Temperatura(24);
            repo.Agregar(temperatura5);
            MostrarDatosDeTemperaturas(lista);
            repo.Borrar(temperatura3);
            Console.WriteLine("Muestro después de borrar");
            MostrarDatosDeTemperaturas(lista);

            Console.ReadLine();
        }

        private static void MostrarDatosDeTemperaturas(List<Temperatura> lista)
        {
            foreach (var temp in lista)
            {
                Console.WriteLine($"{temp.Valor} - {temp.GetEquivalenteFahrenheit()} -{temp.GetEquivalenteReaumur()}");
            }
        }
    }
}
