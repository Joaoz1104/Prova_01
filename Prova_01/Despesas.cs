using System;
using System.Collections.Generic;
using System.Text;

namespace Prova_01
{
    class Despesas
    {
        public string CPF { get; set; }
        public float Valores { get; set; }

        public Despesas(string cpf, float valores)
        {
            CPF = cpf;
            Valores = valores;
        }
        public string getCPF ()
        {
            return CPF;
        }
        public float totalizaMes ()
        {
            return
        }
    }
}
