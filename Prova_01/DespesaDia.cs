using System;
using System.Collections.Generic;
using System.Text;

namespace Prova_01
{
    public class DespesaDia
    {
        private int Dia;

        public DespesaDia(int dia, float valor)
        {
            Dia = dia;
        }

        public int getDia()
        {
            return Dia;
        }
    }
}
