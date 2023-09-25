using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppCadastro.Domain.Cadastro
{
    public abstract class CadastroPaiFilho: CadastroSimples
    {
        public Object Pai { get; set; }
        public abstract void RecebePai();
    }
}