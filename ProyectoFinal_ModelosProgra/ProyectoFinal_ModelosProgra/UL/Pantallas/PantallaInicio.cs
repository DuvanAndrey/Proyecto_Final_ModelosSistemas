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
    public partial class PantallaInicio : MaterialSkin.Controls.MaterialForm
    {
        public PantallaInicio()
        {
            InitializeComponent();
        }

        private void PantallaInicio_Load(object sender, EventArgs e)
        {
            SkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
           
        }

        private void btn_Inicio_Click(object sender, EventArgs e)
        {
            Form formulario = new Bienvenida();
            formulario.Show();
            this.Hide();
        }
    }
}
