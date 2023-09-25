using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppCadastro.Domain.Cadastro
{
    public abstract class CadastroSimples
    {
        public abstract void NovoRegistro ();
        public abstract void GravarRegistro ();
        public abstract void ExcluirRegistro ();
        public abstract void BuscarRegistro ();
    }
}