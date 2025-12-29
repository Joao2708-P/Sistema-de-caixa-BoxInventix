using SistemaDeCaixa.Services;
using SistemaDeCaixa.Telas;
using System;

namespace SistemaDeCaixa
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            LojaRepository service = new LojaRepository();

            ApplicationConfiguration.Initialize();

            LocalDB.InicializarBanco();

            var loja_Listada = service.listaLoja();

            if (loja_Listada != null)
            {
                //Lógica para verificar se a loja existe na nuvem,
                //se não criar na nuvem e adicionar o id da loja na nuvem
                Application.Run(new Login(loja_Listada.id));
            }
            else
            {
                MessageBox.Show("Você ainda não  possui uma Loja! Cadastre a sua!",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Application.Run(new Telas.CadastroDeEmpresa());
            }
        }
    }
}