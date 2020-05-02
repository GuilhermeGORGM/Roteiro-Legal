using Roteiro.Domain;
using System;
using System.Collections.Generic;

namespace Roteiro.Data.EF
{
    public partial class Dscr : Entity
    {
        public int Id { get; set; }
        public string NTabela { get; set; }
        public string NCampo { get; set; }
        public string NCod { get; set; }
        public string Descricao { get; set; }

        public override void MergeFrom(object other)
        {
            throw new NotImplementedException();
        }
    }
}
