using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IscrizioneEsami
{
    class Corso
    {
        public string Nome { get; }
        public int CFU { get; }
        public Corso( string nome, int cfu)
        {
            Nome = nome;
            CFU = cfu;
        }
    }
}