using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IscrizioneEsami
{
    class Esame
    {
        public Corso Corso;
        public bool EsamePassato;

        public Esame(Corso corso)
        {
            Corso = corso;
            EsamePassato = false;
        }
    }
}