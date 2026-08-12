// ALT, SHIFT + F --> Identação
// Comentário teste commit Aula 03

using System;

namespace ATV1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Observe o meno abaixo e digite o número referente a opção desejada: ");
            Console.WriteLine("1- Concatenar Palavras ");
            Console.WriteLine("2- Verificar Dia Da Semana");
            Console.WriteLine("3- Calcular Média");
            Console.WriteLine("4- Calcular Tabuada");

            int opcaoEscolhida = int.Parse(Console.ReadLine());

            switch (opcaoEscolhida)
            {
                case 1:
                ConcatenarPalavras();
                break;

                case 2:
                VerificarAulaEtec();
                break;

                case 3 :
                CalcularMedia();
                break;

                case 4:
                CalcularTabuada();
                break;
                
                default:
                Console.WriteLine("Opção Inválida ");
                break;
            }
         
        }



        public static void VerificarAulaEtec()
        {
            Console.WriteLine("Digite a data:");
            DateTime data = DateTime.Parse(Console.ReadLine());

            if (data.DayOfWeek == DayOfWeek.Saturday || data.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine("final de semana! Hoje nao tem aula! Revisarei exercicios.");
            }
            else
            {
                Console.WriteLine("Dia da semana! Bora pra etec!");
            }
        }
        public static void CalcularTabuada()
        {
            Console.WriteLine("Digite a tabuada de sua preferencia para efetivar os calculos:");
            int tabuada = int.Parse(Console.ReadLine());
            int contador = 0;

            while (contador <= 10)
            {
                string mensagem = string.Format("{0} x {1} = {2}", tabuada, contador, tabuada * contador);

                Console.WriteLine(mensagem);
                contador++;
            }
        }


        public static void ConcatenarPalavras()
        {
            Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine();

            string frase1 = ($"ola {nome}, hoje é {DateTime.Now}");
            Console.WriteLine(frase1);
            Console.WriteLine("=====================================================");

            Console.WriteLine("quanto custa um dolár em reais?");
            decimal valorDolarReais = decimal.Parse(Console.ReadLine());
            string frase2 = string.Format("Hoje é {0: dd/MM/yyyy},o dolár está custando {1:c2}", DateTime.Now, valorDolarReais);
            Console.WriteLine(frase2);
            Console.WriteLine("==========================================");

            string cabecalho = string.Format("{0:dddd}, {0:dd} de {0:MMMM} de {0:yy} - {0:HH:mm;ss}", DateTime.Now);
            Console.WriteLine(cabecalho);
        }

        public static void CalcularMedia()
        {
            Console.WriteLine("Digite sua primeira nota:");
            decimal nota1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua 2 nota:");
            decimal nota2 = decimal.Parse(Console.ReadLine());

            decimal media = (nota1 + nota2) / 2;
            Console.WriteLine($"A media é {media}");
            if (media >= 7)
                Console.WriteLine("Aprovado");
            else if (media < 7 && media >= 4)
                Console.WriteLine("Recuperacao");
            else
                Console.WriteLine("Reprovado");
        }


    }
}

