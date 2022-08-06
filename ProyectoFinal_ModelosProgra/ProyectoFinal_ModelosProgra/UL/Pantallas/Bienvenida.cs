using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UL.Pantallas
{
    public partial class Bienvenida : MaterialSkin.Controls.MaterialForm
    {
        public Bienvenida()
        {
            InitializeComponent();
        }

        private void PantallaInicio_Load(object sender, EventArgs e)
        {
            SkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;

        }

        private void btn_Iniciar_Click(object sender, EventArgs e)
        {
            Form formulario = new PantallaInicio();
            formulario.Show();
            this.Hide();

        }
    }
}
