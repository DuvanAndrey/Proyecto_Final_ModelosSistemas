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
        string estado;

        cls_Variables_Calculadora_DAL ObjDAL = new cls_Variables_Calculadora_DAL();
        cls_Logica_Calculadora_BLL ObjBLL = new cls_Logica_Calculadora_BLL();

        cls_Variables_Validador_DAL ObjDAL2 = new cls_Variables_Validador_DAL();
        cls_Logica_Validador_BLL ObjBLL2 = new cls_Logica_Validador_BLL();

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
            estado = "SUMA";
            ObjDAL.Operador1 = "+";
            ObjDAL.Valor1 = textValor1.Text;
            ObjDAL.Valor2 = textValor2.Text;

            buttonResta.Enabled = false;
            buttonMultiplicar.Enabled = false;
            buttonDivision.Enabled = false;

        }

        private void buttonResultado_Click(object sender, EventArgs e)
        {

            if ((string.IsNullOrEmpty(textValor1.Text)) || (string.IsNullOrEmpty(textValor2.Text)))
            {
                MessageBox.Show("No pueden quedar campos vacíos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if ((string.IsNullOrEmpty(ObjDAL.Operador1)))
            {
                MessageBox.Show("Debe seleccionar una operación", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (estado == "SUMA")
                {
                    ObjBLL.Sumar(ObjDAL);
                }
                if (estado == "RESTA")
                {
                    ObjBLL.Restar(ObjDAL);
                }
                if (estado == "MULTIPLICACION")
                {
                    ObjBLL.Multiplicar(ObjDAL);
                }
                if (estado == "DIVISION")
                {
                    ObjBLL.Division(ObjDAL);
                }

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
            ObjDAL.Operador1 = string.Empty;

            buttonResta.Enabled = true;
            buttonSuma.Enabled = true;
            buttonMultiplicar.Enabled = true;
            buttonDivision.Enabled = true;
        }

        private void buttonResta_Click(object sender, EventArgs e)
        {
            estado = "RESTA";
            ObjDAL.Operador1 = "-";
            ObjDAL.Valor1 = textValor1.Text;
            ObjDAL.Valor2 = textValor2.Text;

            buttonResta.Enabled = false;
            buttonMultiplicar.Enabled = false;
            buttonDivision.Enabled = false;
        }

        private void buttonMultiplicar_Click(object sender, EventArgs e)
        {
            estado = "MULTIPLICACION";
            ObjDAL.Operador1 = "*";
            ObjDAL.Valor1 = textValor1.Text;
            ObjDAL.Valor2 = textValor2.Text;

            buttonResta.Enabled = false;
            buttonSuma.Enabled = false;
            buttonDivision.Enabled = false;
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            estado = "DIVISIÓN";

            ObjDAL.Operador1 = "/";
            ObjDAL.Valor1 = textValor1.Text;
            ObjDAL.Valor2 = textValor2.Text;

            ObjBLL.Division(ObjDAL);
            buttonResta.Enabled = false;
            buttonSuma.Enabled = false;
            buttonMultiplicar.Enabled = false;
        }

        private void buttonBorrarDatos_Click(object sender, EventArgs e)
        {
            estado = string.Empty;
            ObjDAL.Operador1 = string.Empty;
            textValor1.Text = string.Empty;
            textValor2.Text = string.Empty;
            ObjDAL.Resultado1 = string.Empty;
            ObjDAL.Observacion1 = string.Empty;
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

        private void buttonBorrarOperacion_Click(object sender, EventArgs e)
        {
            ObjDAL.Operador1 = string.Empty;
            ObjDAL.Valor1 = textValor1.Text;
            ObjDAL.Valor2 = textValor2.Text;
            ObjDAL.Observacion1 = string.Empty;

            buttonResta.Enabled = true;
            buttonSuma.Enabled = true;
            buttonMultiplicar.Enabled = true;
            buttonDivision.Enabled = true;
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            ObjDAL2.sFrase = txtDato.Text;

            if (string.IsNullOrEmpty(txtDato.Text))
            {
                MessageBox.Show("No puede quedar el campo vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (RadioButtonCorreo.Checked == false && RadioButtonFecha.Checked == false && RadioButtonId.Checked == false)
            {
                MessageBox.Show("Por favor seleccione una opcion valida para poder realizar la validacion", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(RadioButtonCorreo.Checked == true)
            {
                    ObjBLL2.Correo(ObjDAL2);
                    MessageBox.Show(ObjDAL2.sMsj, "Detalles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
            }
            if (RadioButtonFecha.Checked == true)
            {
                ObjBLL2.Fecha(ObjDAL2);
                MessageBox.Show(ObjDAL2.sMsj, "Detalles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (RadioButtonId.Checked == true)
            {
                ObjBLL2.ID(ObjDAL2);
                MessageBox.Show(ObjDAL2.sMsj, "Detalles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void buttonExportacion_Click(object sender, EventArgs e)
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\SSequeira\Desktop\BitacoraGeneral.txt");
            try
            {
                string sLine = "";
                //This for loop loops through each row in the table
                for (int r = 0; r <= dgvRegistro.Rows.Count - 1; r++)
                {
                    //This for loop loops through each column, and the row number
                    //is passed from the for loop above.
                    for (int c = 0; c <= dgvRegistro.Columns.Count - 1; c++)
                    {
                        sLine = sLine + dgvRegistro.Rows[r].Cells[c].Value;
                        if (c != dgvRegistro.Columns.Count - 1)
                        {
                            //A comma is added as a text delimiter in order
                            //to separate each field in the text file.
                            //You can choose another character as a delimiter.
                            sLine = sLine + ";";
                        }
                    }
                    //The exported text is written to the text file, one line at a time.
                    file.WriteLine(sLine);
                    sLine = "";
                }

                file.Close();
                System.Windows.Forms.MessageBox.Show("Exportación completa.", "Detalles", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Exception err)
            {
                System.Windows.Forms.MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                file.Close();
            }
        }
    }
}
