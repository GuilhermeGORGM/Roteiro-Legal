using Roteiro.Domain;
using System;
using System.Collections.Generic;

namespace Roteiro.Data.EF
{
    public partial class Interesse : Entity
    {
        public Interesse()
        {
            Cadastro = new HashSet<Cadastro>();
        }

        public int Id { get; set; }
        public int? ICadAdm { get; set; }
        public DateTime? DInicio { get; set; }
        public DateTime? DFim { get; set; }
        public int? XDestino { get; set; }
        public int? XInteresse { get; set; }
        public DateTime? DAlteracao { get; set; }
        public int? ICadAlt { get; set; }

        public virtual Cadastro ICadAdmNavigation { get; set; }
        public virtual ICollection<Cadastro> Cadastro { get; set; }

        public override void MergeFrom(object other)
        {
            throw new NotImplementedException();
        }
    }
}
