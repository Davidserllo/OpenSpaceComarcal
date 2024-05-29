using OpenSpaceComarcal.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenSpaceComarcal
{
    public partial class FormControlAsistencia : Form
    {
        public FormControlAsistencia()
        {
            InitializeComponent();
        }

        private void FormControlAsistencia_Load(object sender, EventArgs e)
        {
            bindingSourceInstancia.DataSource = InstanciaOrm.Select();
        }
    }
}
