using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotaAdhesiva
{
    public partial class NotaAdhesivaForm : Form
    {
        private bool arrastrando;
        private Point posicionInicial;
        private Point cursorInicial;
        private System.Windows.Forms.Timer temporizadorGuardado;
        private string rutaArchivoNota;
        private bool avisoErrorGuardadoMostrado;

        public NotaAdhesivaForm()
        {
            InitializeComponent();
            PrepararArrastre(barraTitulo);
            PrepararArrastre(tituloNota);
            InicializarGuardadoAutomatico();
            Rectangle areaTrabajo = Screen.PrimaryScreen.WorkingArea;
            Location = new Point(
                Math.Max(areaTrabajo.Left, areaTrabajo.Right - Width - 20),
                areaTrabajo.Top + 40);
        }

        private void botonCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PrepararArrastre(Control control)
        {
            control.MouseDown += IniciarArrastre;
            control.MouseMove += ArrastrarNota;
            control.MouseUp += TerminarArrastre;
        }

        private void IniciarArrastre(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }

            arrastrando = true;
            posicionInicial = Location;
            cursorInicial = Cursor.Position;
        }

        private void ArrastrarNota(object sender, MouseEventArgs e)
        {
            if (!arrastrando)
            {
                return;
            }

            Point cursorActual = Cursor.Position;
            Location = new Point(
                posicionInicial.X + cursorActual.X - cursorInicial.X,
                posicionInicial.Y + cursorActual.Y - cursorInicial.Y);
        }

        private void TerminarArrastre(object sender, MouseEventArgs e)
        {
            arrastrando = false;
        }

        private void InicializarGuardadoAutomatico()
        {
            string carpetaNotas = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "Blocc_de__la_nota_wacho");
            rutaArchivoNota = Path.Combine(carpetaNotas, "NotaEscritorio.txt");

            if (File.Exists(rutaArchivoNota))
            {
                try
                {
                    editorNota.Text = File.ReadAllText(rutaArchivoNota);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "No se pudo cargar la nota: " + ex.Message,
                        "Nota adhesiva",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }

            temporizadorGuardado = new System.Windows.Forms.Timer
            {
                Interval = 500
            };
            temporizadorGuardado.Tick += temporizadorGuardado_Tick;
            editorNota.TextChanged += editorNota_TextChanged;
            FormClosing += NotaAdhesivaForm_FormClosing;
        }

        private void editorNota_TextChanged(object sender, EventArgs e)
        {
            temporizadorGuardado.Stop();
            temporizadorGuardado.Start();
        }

        private void temporizadorGuardado_Tick(object sender, EventArgs e)
        {
            temporizadorGuardado.Stop();
            GuardarContenidoNota();
        }

        private bool GuardarContenidoNota()
        {
            try
            {
                string carpetaNotas = Path.GetDirectoryName(rutaArchivoNota);
                Directory.CreateDirectory(carpetaNotas);
                File.WriteAllText(rutaArchivoNota, editorNota.Text);
                avisoErrorGuardadoMostrado = false;
                return true;
            }
            catch (Exception ex)
            {
                if (!avisoErrorGuardadoMostrado)
                {
                    avisoErrorGuardadoMostrado = true;
                    MessageBox.Show(
                        "No se pudo guardar la nota automáticamente: " + ex.Message,
                        "Nota adhesiva",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                return false;
            }
        }

        private void NotaAdhesivaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            temporizadorGuardado.Stop();
            if (!GuardarContenidoNota())
            {
                e.Cancel = true;
            }
        }

    }
}
