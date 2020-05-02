using Roteiro.Data.EF;
using Roteiro.Data.EF.Context;
using Roteiro.Data.EF.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Roteiro.Application
{
    public class CadastroService : GenericService<Cadastro>
    {
        public CadastroService(AppDbContext context) : base(context)
        {
            repository = new GenericRepository<Cadastro>(context);
        }

        public override IEnumerable<Cadastro> BuscarPor(Cadastro filter)
        {
            throw new NotImplementedException();
        }
    }
}
