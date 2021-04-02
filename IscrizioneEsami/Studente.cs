using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IscrizioneEsami
{
    class Studente
    {
        public string Nome { get; }
        public string Cognome { get; }
        public int AnnoDiNascita { get; }

        public Studente(string nome, string cognome, int annoNascita, Immatricolazione imm1)
        {
            Nome = nome;
            Cognome = cognome;
            AnnoDiNascita = annoNascita;
            Immatricolaz = imm1;
        }

        private List<Esame> _esami = new List<Esame>();

        public Esame RichiestaEsame(string nomeesame)
        {
            Esame esame;
            foreach (Corso c in Immatricolaz.CorsoDiLaurea._corsi)
                if (c.Nome == nomeesame && Immatricolaz.CFUAccumulati + c.CFU <= Immatricolaz.CorsoDiLaurea.CFUNecessari && RichiestaLaurea is false)
                {
                    esame = new Esame(c);
                    _esami.Add(esame);
                    return esame;
                }
            return null;
        }

        internal void EsamePassato(Esame e1)
        {
            e1.EsamePassato = true;
        }

        public Immatricolazione Immatricolaz { get; }
        public bool RichiestaLaurea { get; }

    }
}