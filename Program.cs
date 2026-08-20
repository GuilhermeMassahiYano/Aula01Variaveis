using System;
using Microsoft.VisualBasic;

namespace ATV1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Observe o menu abaixo e digite o número referente a opção desejada: ");
            Console.WriteLine("1- Concatenar Palavras ");
            Console.WriteLine("2- Verificar Dia Da Semana");
            Console.WriteLine("3- Calcular Média");
            Console.WriteLine("4- Calcular Tabuada");
            Console.WriteLine("5- Detalhar Data");
            Console.WriteLine("6- Calcular Desconto INSS");

            int opcaoEscolhida = int.Parse(Console.ReadLine());

            switch (opcaoEscolhida)
            {
                case 1:
                    ConcatenarPalavras();
                    break;

                case 2:
                    VerificarAulaEtec();
                    break;

                case 3:
                    CalcularMedia();
                    break;

                case 4:
                    CalcularTabuada();
                    break;

                case 5:
                    DetalharData();
                    break;

                case 6:
                    CalcularDescontoINSS();
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
                Console.WriteLine("Final de semana! Hoje nao tem aula! Revisarei exercicios.");
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

            Console.WriteLine("Quanto custa um dólar em reais?");
            decimal valorDolarReais = decimal.Parse(Console.ReadLine());
            string frase2 = string.Format("Hoje é {0:dd/MM/yyyy}, o dólar está custando {1:c2}", DateTime.Now, valorDolarReais);
            Console.WriteLine(frase2);
            Console.WriteLine("==========================================");

            string cabecalho = string.Format("{0:dddd}, {0:dd} de {0:MMMM} de {0:yy} - {0:HH:mm:ss}", DateTime.Now);
            Console.WriteLine(cabecalho);
        }

        public static void CalcularMedia()
        {
            Console.WriteLine("Digite sua primeira nota:");
            decimal nota1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua 2ª nota:");
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

        public static void DetalharData()
        {
            Console.WriteLine("Digite uma data (ex: DD/MM/AAAA):");
            DateTime dataInformada = DateTime.Parse(Console.ReadLine());

            string resultadoData = string.Format("Dia da semana: {0:dddd} | Mês: {0:MMMM}", dataInformada);
            Console.WriteLine(resultadoData);

            if (dataInformada.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine($"É domingo! Hora atual: {DateTime.Now:HH:mm}");
            }
        }

        public static void CalcularDescontoINSS()
        {
            Console.WriteLine("Digite o valor do salário:");
            decimal salario = decimal.Parse(Console.ReadLine());
            decimal aliquota = 0;
            decimal valorInss = 0;

            if (salario <= 1412.00m)
            {
                aliquota = 0.075m; // 7.5%
            }
            else if (salario <= 2666.68m)
            {
                aliquota = 0.09m; // 9%
            }
            else if (salario <= 4000.03m)
            {
                aliquota = 0.12m; // 12%
            }
            else
            {
                aliquota = 0.14m; // 14%
            }

            valorInss = salario * aliquota;
            decimal salarioLiquido = salario - valorInss;

            Console.WriteLine($"Valor do INSS a pagar: {valorInss:c2}");
            Console.WriteLine($"Salário com o desconto do INSS: {salarioLiquido:c2}");
        }
    }
}