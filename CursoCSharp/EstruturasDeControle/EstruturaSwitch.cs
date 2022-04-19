﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {

    internal class EstruturaSwitch {

        public static void Executar() {

            Console.WriteLine("Avalie meu atendimento com uma nota de 1 a 5: ");
            int.TryParse(Console.ReadLine(), out int nota);

            switch (nota) {
                case 1:
                    Console.WriteLine("Péssimo");
                    break;
                case 2:
                    Console.WriteLine("Ruim");
                    break;
                case 3:
                    Console.WriteLine("Regular");
                    break;
                case 4:
                    Console.WriteLine("Bom");
                    break;
                case 5:
                    Console.WriteLine("Ótimo");
                    break;
                default:
                    Console.WriteLine("Nota inválida");
                    Console.WriteLine("Parabéns!");
                    break;
            }

            Console.WriteLine("Muito obrigada por responder!");
        }
    }
}
