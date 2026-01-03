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
            ApplicationConfiguration.Initialize();
            LocalDB.InicializarBanco();

            Application.Run(new BoodStrap());
        }
    }
}