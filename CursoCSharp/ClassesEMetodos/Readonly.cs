using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    internal class Readonly {

        public class Cliente {
            
            public string Nome;
            readonly DateTime Nascimento;

            public Cliente(string nome, DateTime nascimento) {
                Nome = nome;
                Nascimento = nascimento;
            }

            public string GetDataNascimento() {
                return String.Format("{0}/{1}/{2}", Nascimento.Day,
                    Nascimento.Month, Nascimento.Year);
            }

        }

        public static void Executar() {

            var novoCliente = new Cliente("Aninha Maria",
                new DateTime(2003, 10, 31));

            Console.WriteLine(novoCliente.Nome);
            Console.WriteLine(novoCliente.GetDataNascimento());

        }
    }
}
