using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Aluno___POO
{
    class Aluno
    {

        public string Nome;
        public double N1, N2, N3;

        public double NotaFinal()
        {
            double notafinal = N1 + N2 + N3;
            return notafinal;
        }

        public bool Aprovado()
        {
            if (NotaFinal() >= 60.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double NotaRestante()
        {
            if (Aprovado())
            {
                return 0.0;
            }
            else
            {
                return 60.0 - NotaFinal();
            }
        }






    }
}
