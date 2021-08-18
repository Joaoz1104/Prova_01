using System;
using System.Collections.Generic;
using System.Text;

namespace Prova_01
{
    public class DespesaMes
    {
        private int Mes;
        private float Valor;
        float soma;

        public DespesaMes (int mes, float valor)
        {
            Mes = mes;
            Valor = valor;
        }

        public int getMes ()
        {
            return Mes;
        }

        public float getValor ()
        {
            return Valor;
        }
    }
}
