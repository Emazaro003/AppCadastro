using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppCadastro.Domain.Consulta
{
    public abstract class ConsultaSimples
    {
        public abstract void Filtrar(Object o);

        public abstract void Alterar();

        public abstract void Incluir();
    }
}