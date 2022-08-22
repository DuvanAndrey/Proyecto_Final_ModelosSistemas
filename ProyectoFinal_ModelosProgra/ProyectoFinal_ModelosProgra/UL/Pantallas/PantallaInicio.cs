using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Variables;
using BLL.Logica;

namespace UL.Pantallas
{
    public partial class PantallaInicio : MaterialSkin.Controls.MaterialForm
    {
        cls_Variables_Calculadora_DAL ObjDAL = new cls_Variables_Calculadora_DAL();
        cls_Logica_Calculadora_BLL ObjBLL = new cls_Logica_Calculadora_BLL();

        public PantallaInicio()
        {
            InitializeComponent();
        }

        private void PantallaInicio_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btn_Inicio_Click(object sender, EventArgs e)
        {
            Form formulario = new Bienvenida();
            formulario.Show();
            this.Hide();
        }

        private void buttonSuma_Click(object sender, EventArgs e)
        {
            ObjDAL.Valor1 = textValor1.Text;
            ObjDAL.Valor2 = textValor2.Text;

            ObjBLL.Sumar(ObjDAL);
        }

        private void buttonResultado_Click(object sender, EventArgs e)
        {
            ObjDAL.Operador1 = "+";
            ObjDAL.Observacion1 = "Test";


            if ((string.IsNullOrEmpty(textValor1.Text)) || (string.IsNullOrEmpty(textValor2.Text)))
            {
                MessageBox.Show("No pueden quedar campos vacíos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                ObjBLL.InsertarRegistro(ref ObjDAL);

                if (ObjDAL.sMsj_Error == string.Empty)
                {
                    MessageBox.Show("El registro fue creado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Se produjo un error a la hora de insertar o crear el Estado.\n\nERROR = [ " + ObjDAL.sMsj_Error + " ].",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            textResultado.Text = ObjDAL.Resultado1;

            CargarDatos();

            textValor1.Text = string.Empty;
            textValor2.Text = string.Empty;
        }

        private void buttonResta_Click(object sender, EventArgs e)
        {
            ObjDAL.Valor1 = textValor1.Text;
            ObjDAL.Valor2 = textValor2.Text;

            ObjBLL.Restar(ObjDAL);
        }

        private void buttonMultiplicar_Click(object sender, EventArgs e)
        {
            ObjDAL.Valor1 = textValor1.Text;
            ObjDAL.Valor2 = textValor2.Text;

            ObjBLL.Multiplicar(ObjDAL);
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            ObjDAL.Valor1 = textValor1.Text;
            ObjDAL.Valor2 = textValor2.Text;

            ObjBLL.Division(ObjDAL);
        }

        private void buttonBorrarDatos_Click(object sender, EventArgs e)
        {
            textValor1.Text = string.Empty;
            textValor2.Text = string.Empty;
        }

        private void CargarDatos()
        {
            ObjBLL.ListarRegistro(ref ObjDAL);

            if (ObjDAL.sMsj_Error == string.Empty)
            {
                dgvRegistro.DataSource = null;
                dgvRegistro.DataSource = ObjDAL.dt_PARAMETROS;
            }
            else
            {
                dgvRegistro.DataSource = null;
                MessageBox.Show("Se presentó un error a la hora de cargar los datos de los Estados. \n\nERROR = [ " + ObjDAL.sMsj_Error + " ].",
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
