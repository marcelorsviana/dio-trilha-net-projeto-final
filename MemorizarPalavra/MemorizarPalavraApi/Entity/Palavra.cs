using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MemorizarPalavraApi.Entity
{
    public class Palavra
    {
        public int Id { get; set; }
        public string PalavraLinguaEstrangeira { get; set; }
        public string PalavraTraduzida { get; set; }
        public bool Aprendido { get; set; }
        public DateTime DiaAtual { get; set; }
        public DateTime ProximaRevisao { get; set; }
        public int NivelRevisao { get; set; }
    }
}