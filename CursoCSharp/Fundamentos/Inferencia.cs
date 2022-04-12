using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {

    internal class Inferencia {

        public static void Executar() {

            var nome = "Leonardo";
            // nome = 123 <-- a váriável já tem o tipo string detectado por inferência
            Console.WriteLine(nome);

            var idade = 32;
            Console.WriteLine(idade);

            // não podemos declarar uma variável com var sem inicializá-la

            int a;
            a = 3;

            int b = 2;

            Console.WriteLine(a + b);

        }

    }
}
