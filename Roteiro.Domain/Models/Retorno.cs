using System;
using System.Collections.Generic;
using System.Text;

namespace Roteiro.Domain.Models
{
    public class Retorno
    {
        public bool Sucesso { get; set; }
        public int Codigo { get; set; }
        public string Mensagem { get; set; }
        public dynamic Data { get; set; }

        public Retorno()
        {
            Sucesso = true;
        }
    }
}
