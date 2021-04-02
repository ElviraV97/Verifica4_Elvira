using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IscrizioneEsami
{
    class Immatricolazione
    {
        private static int _matricola = 0;
        public int Matricola { get; }

        public DateTime DataInizio { get; }
        public CorsoLaurea CorsoDiLaurea { get; }

        public Immatricolazione(DateTime today, CorsoLaurea corsoLaurea)
        {
            DataInizio = today;
            CorsoDiLaurea = corsoLaurea;

            Matricola = ++_matricola;
        }


        public bool FuoriCorso { get; }
        public int CFUAccumulati { get; }

    }
}