using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppCadastro.Domain.Consulta
{
    public abstract class ConsultaPaiFilho: ConsultaSimples
    {
        public Object Pai { get; set; }

        public abstract void RecebePai();
    }
}