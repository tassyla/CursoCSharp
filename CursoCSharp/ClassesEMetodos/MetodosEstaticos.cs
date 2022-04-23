using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    public class CalculadoraEstatica {

        public int Somar(int a, int b) {
            return a + b;
        }

        public static int Multiplicar(int a, int b) {
            return a * b;
        }

    }

    internal class MetodosEstaticos {

        public static void Executar() {

            var resultado = CalculadoraEstatica.Multiplicar(3, 4);
            Console.WriteLine("Resultado: " + resultado);

            CalculadoraEstatica calc = new CalculadoraEstatica();
            Console.WriteLine("Resultado: " + calc.Somar(3, 4));

        }
    }
}
