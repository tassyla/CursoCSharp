using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    internal class Membros {

        public static void Executar() {

            Pessoa pessoa1 = new Pessoa();
            pessoa1.Nome = "Renato";
            pessoa1.Idade = 21;

            pessoa1.ApresentarNoConsole();
            pessoa1.Zerar();
            pessoa1.ApresentarNoConsole();
             
            var pessoa2 = new Pessoa();
            pessoa2.Nome = "Bia";
            pessoa2.Idade = 18;

            var apresentacaoDaPessoa2 = pessoa2.Apresentar();

        }
    }
}
