using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    class Carro {
        public string Modelo;
        public string Fabricante;
        public int Ano;

        public Carro() { }

        public Carro(string modelo, string fabricante, int ano) {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
        }
    }
    internal class Construtores {

        public static void Executar() {

            var carro1 = new Carro();
            carro1.Modelo = "3251";
            carro1.Fabricante = "BMW";
            carro1.Ano = 2022;
            Console.WriteLine(
                $"{carro1.Fabricante} {carro1.Modelo} {carro1.Ano}");

            var carro2 = new Carro("Ka", "Ford", 1979);
            Console.WriteLine(
                $"{carro2.Fabricante} {carro2.Modelo} {carro2.Ano}");

            var carro3 = new Carro() {
                Modelo = "Uno",
                Fabricante = "Fiat",
                Ano = 2020
            };
            Console.WriteLine(
                $"{carro3.Fabricante} {carro3.Modelo} {carro3.Ano}");
        }
    }
}
