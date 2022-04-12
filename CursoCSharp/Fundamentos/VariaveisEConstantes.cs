﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {

    internal class VariaveisEConstantes {

        public static void Executar() {

            // area da circunferencia

            double raio = 4.5;
            const double PI = 3.14;

            double area = PI * raio * raio;

            Console.WriteLine("Área é " + area);

            //Tipos internos

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo " + estaChovendo);

            byte idade = 45;
            Console.WriteLine("Idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de gols " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salário " + salario);

            int menorValorInt = int.MinValue;
            Console.WriteLine("Menor int " + menorValorInt);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("População brasileira " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor long " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População Mundial " + populacaoMundial);

            float precoComputador = 1299.99F;
            Console.WriteLine("Preço Computador " + precoComputador);

            double valorDeMercadoDaApple = 1_000_000_000_000.00;
            Console.WriteLine("Valor Apple " + valorDeMercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distância entre estrelas " + distanciaEntreEstrelas);

            char letra = 'b';
            Console.WriteLine("Letra " + letra);

            string texto = "Seja bem vinda ao curso de C#!";
            Console.WriteLine(texto);
        }
    }
}
