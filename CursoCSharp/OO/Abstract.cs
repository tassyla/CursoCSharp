using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO {

    public abstract class Celular {

        public abstract string Assistente();

        public string Tocar() {
            return "Trim trim trim...";
        }
    }

    public class SamsungS20 : Celular {

        public override string Assistente() {
            return "Olá, meu nome é Bixby!";
        }

    }

    public class IPhone : Celular {
        public override string Assistente() {
            return "Hey there! You can call me Siri :)";
        }
    }

    internal class Abstract {

        public static void Executar() {

            var celulares = new List<Celular> {
                new IPhone(),
                new SamsungS20()
            };

            foreach (var celular in celulares) {
                Console.WriteLine(celular.Assistente());
            }

        }
    }
}
