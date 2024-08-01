using System;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OpenSpaceComarcal
{
    public partial class FormInicio : Form
    {
        private FormLoading loading;

        // Sobreescribe la propiedad CreateParams para personalizar los parámetros de creación del formulario
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        public FormInicio()
        {
            InitializeComponent();

            Version version = Assembly.GetExecutingAssembly().GetName().Version;
            string versionText = $"v{version.Major}.{version.Minor}.{version.Build}";
            string releaseStage = "Alpha";
            labelVersion.Text = $"{versionText} {releaseStage}";
        }



        private async void buttonAlumnos_Click(object sender, EventArgs e)
        {
            OpenForm<FormAlumnos>();
        }

        private void buttonEmpresas_Click(object sender, EventArgs e)
        {
            OpenForm<FormEmpresas>();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            OpenForm<FormCursos>();
        }

        private void buttonInstancia_Click(object sender, EventArgs e)
        {
            OpenForm<FormInstancia>();
        }

        private void buttonInscripcion_Click(object sender, EventArgs e)
        {
            OpenForm<FormInscripcion>();
        }

        // Método para mostrar la ventana de carga
        private void ShowLoading()
        {
            loading = new FormLoading();
            loading.Show(this);
        }

        // Método para ocultar la ventana de carga
        private void HideLoading()
        {
            if (loading != null && !loading.IsDisposed)
            {
                loading.Close();
                loading.Dispose();
            }
        }

        // Método genérico para abrir formas
        private async void OpenForm<T>() where T : Form, new()
        {
            ShowLoading();

            await Task.Delay(50);

            T form = new T();

            form.Load += (sender, e) =>
            {
                HideLoading();
            };

            form.Show();
        }
    }
}