using System;
using System.Collections.Generic;

namespace Roteiro.Data.EF
{
    public partial class LogInteresse
    {
        public int Id { get; set; }
        public int IInteresse { get; set; }
        public int ICadAdm { get; set; }
        public DateTime? DInicio { get; set; }
        public DateTime? DFim { get; set; }
        public int? XDestino { get; set; }
        public int? XInteresse { get; set; }
        public DateTime? DAlteracao { get; set; }
        public short? TAlteracao { get; set; }
        public int? ICadAlt { get; set; }
    }
}
