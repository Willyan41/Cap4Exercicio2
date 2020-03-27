using System;
using System.Collections.Generic;
using System.Text;

namespace Cap4Exercicio2
{
    public class Estudante
    {

        public string Nome;
        public double PrimeiroTrimestre;
        public double SegundoTrimestre;
        public double TerceiroTrismestre;

        public double NotaFinal()
        {
            double notaFinal = PrimeiroTrimestre + SegundoTrimestre + TerceiroTrismestre;
            return notaFinal;

        }


    }
}
