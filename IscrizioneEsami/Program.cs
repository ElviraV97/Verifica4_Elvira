using System;
using System.Collections.Generic;

namespace IscrizioneEsami
{
    class Program
    {
        static void Main(string[] args)
        {
            Corso analisi1 = new Corso("Analisi1", 12);
            Corso analisi2 = new Corso("Analisi2", 6);

            CorsoLaurea ingegneria = new CorsoLaurea(NomeLaurea.Ingegneria, 3, 180, new List<Corso> { analisi1, analisi2 });

            Immatricolazione imm1 = new Immatricolazione(DateTime.Today, ingegneria);

            Studente tina = new Studente("Tina", "Tini", 1997, imm1);

            Esame e1 = tina.RichiestaEsame("Analisi1");
            tina.EsamePassato(e1);
        }
    }
}
