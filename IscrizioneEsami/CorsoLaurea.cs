using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IscrizioneEsami
{
    enum NomeLaurea
    {
        Matematica,
        Fisica,
        Informatica,
        Ingegneria,
        Lettere
    }
    class CorsoLaurea
    {
        public NomeLaurea Nome { get; }
        public int AnniCorso { get; }
        public int CFUNecessari { get; }
        public List<Corso> _corsi = new List<Corso>();

        public CorsoLaurea(NomeLaurea nome, int anniCorso, int cfu, List<Corso> corsi)
        {
            Nome = nome;
            AnniCorso = anniCorso;
            CFUNecessari = cfu;
            List<Corso> _corsi = corsi;
        }
    }
}