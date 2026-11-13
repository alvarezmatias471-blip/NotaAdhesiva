using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace NotaAdhesiva
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CrearAccesoDirectoInicio();
            Application.Run(new NotaAdhesivaForm());
        }

        private static void CrearAccesoDirectoInicio()
        {
            object shell = null;
            object accesoDirecto = null;

            try
            {
                string carpetaInicio = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
                string rutaAccesoDirecto = Path.Combine(carpetaInicio, "Nota adhesiva.lnk");
                Type tipoShell = Type.GetTypeFromProgID("WScript.Shell");

                if (tipoShell == null)
                {
                    throw new InvalidOperationException("No está disponible Windows Script Host.");
                }

                shell = Activator.CreateInstance(tipoShell);
                dynamic objetoShell = shell;
                accesoDirecto = objetoShell.CreateShortcut(rutaAccesoDirecto);
                dynamic acceso = accesoDirecto;
                acceso.TargetPath = Application.ExecutablePath;
                acceso.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory;
                acceso.Description = "Mostrar la nota adhesiva al iniciar sesión";
                acceso.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo configurar el inicio automático de la nota: " + ex.Message,
                    "Nota adhesiva",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            finally
            {
                if (accesoDirecto != null && Marshal.IsComObject(accesoDirecto))
                {
                    Marshal.ReleaseComObject(accesoDirecto);
                }

                if (shell != null && Marshal.IsComObject(shell))
                {
                    Marshal.ReleaseComObject(shell);
                }
            }
        }
    }
}
