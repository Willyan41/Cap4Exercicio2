using System;
using System.Globalization;

namespace Cap4Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {

            // Exercicio 01
            Retangulo r;
            r = new Retangulo();

            Console.WriteLine("Entre com as medidas do retangulo:");
            Console.Write("Largura: ");
            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Altura: ");
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Area: {0}", r.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro: {0}", r.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal: {0}", r.Diagonal().ToString("F2", CultureInfo.InvariantCulture));


            // Exercicio 02

            Colaborador c;
            c = new Colaborador();

            Console.Write("Nome: ");
            c.Nome = Console.ReadLine();

            Console.Write("Salário Bruto: ");
            c.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            c.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Colaborador: {0}", c);

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.AumentarSalario(porcentagem);

            Console.WriteLine(c.SalarioBruto);
            Console.WriteLine("Dados Atualizados: {0}", c);

            //Exercicio 03

            Estudante e;
            e = new Estudante();

            Console.Write("Nome estudante: ");
            e.Nome = Console.ReadLine();
            Console.Write("Nota primeiro trimestre: ");
            e.PrimeiroTrimestre = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Nota segundo trimestre: ");
            e.SegundoTrimestre = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Nota terceiro trimestre: ");
            e.TerceiroTrismestre = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Nota Final: {0}", e.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
            if (e.NotaFinal() >= 60.00)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
                Console.WriteLine("Faltaram {0} Pontos", (60.00 - e.NotaFinal()));
            }

        }
    }
}
