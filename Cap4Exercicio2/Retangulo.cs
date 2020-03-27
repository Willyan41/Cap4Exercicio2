using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Cap4Exercicio2
{
    public class Retangulo
    {
        public double Largura;
        public double Altura;



        public double Area()
        {
            return Largura * Altura;

        }

        public double Perimetro()
        {
            return (2 * (Largura + Altura));

        }

        public double Diagonal()
        {
            return Math.Sqrt((Largura * Largura) + (Altura * Altura));

        }



    }
}
