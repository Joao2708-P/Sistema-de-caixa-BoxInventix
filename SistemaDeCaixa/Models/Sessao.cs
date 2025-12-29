using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCaixa.Models
{
    public static class Sessao
    {
        public static Funcionario UsuarioLogado { get; set; }
        public static int LojaId { get; set; }

        public static bool Ativa => UsuarioLogado != null;

        public static void Limpar()
        {
            UsuarioLogado = null;
            LojaId = 0;
        }
    }

}
