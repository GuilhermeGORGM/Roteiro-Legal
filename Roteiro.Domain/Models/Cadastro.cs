using Roteiro.Domain;
using System;
using System.Collections.Generic;

namespace Roteiro.Data.EF
{
    public class Cadastro : Entity
    {
        public Cadastro()
        {
            Interesse = new HashSet<Interesse>();
        }

        public int Id { get; set; }
        public int? IInteresse { get; set; }
        public string Nome { get; set; }
        public int? XClasse { get; set; }
        public short? Idade { get; set; }
        public string Email { get; set; }
        public string NTelefone { get; set; }
        public DateTime? DNasc { get; set; }
        public string Sexo { get; set; }
        public string Rua { get; set; }
        public int? NRua { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Cep { get; set; }
        public int? Pais { get; set; }
        public DateTime? DAlteracao { get; set; }
        public string CpfCnpj { get; set; }
        public int? ICadAlt { get; set; }

        public virtual Interesse IInteresseNavigation { get; set; }
        public virtual ICollection<Interesse> Interesse { get; set; }

        public override void MergeFrom(object other)
        {
            throw new NotImplementedException();
        }
    }
}
