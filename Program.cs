/*
 * Autor: Jhon Sebastian Zuñiga
 * Grupo: 71
 * Programa: Ingenieria en Sistemas
 * Curso: Programacion
 * Link video: https://www.loom.com/share/88fee8d8bf2b4f39a76e364536ffde6e?sharedAppSource=personal_library
 */

namespace CajeroAutomatico
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Banco banco = new Banco();
            ApplicationConfiguration.Initialize();
            Application.Run(new Autentificacion());
        }
    }
}