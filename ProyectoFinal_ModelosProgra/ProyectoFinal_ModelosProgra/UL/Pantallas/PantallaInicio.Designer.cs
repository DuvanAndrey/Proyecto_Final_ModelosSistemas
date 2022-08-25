namespace UL.Pantallas
{
    partial class PantallaInicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaInicio));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonResultado = new System.Windows.Forms.Button();
            this.buttonBorrarDatos = new System.Windows.Forms.Button();
            this.buttonBorrarOperacion = new System.Windows.Forms.Button();
            this.buttonDivision = new System.Windows.Forms.Button();
            this.buttonMultiplicar = new System.Windows.Forms.Button();
            this.buttonResta = new System.Windows.Forms.Button();
            this.textResultado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvRegistro = new System.Windows.Forms.DataGridView();
            this.buttonSuma = new System.Windows.Forms.Button();
            this.textValor2 = new System.Windows.Forms.TextBox();
            this.textValor1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnValidar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.RadioButtonId = new MaterialSkin.Controls.MaterialRadioButton();
            this.RadioButtonFecha = new MaterialSkin.Controls.MaterialRadioButton();
            this.RadioButtonCorreo = new MaterialSkin.Controls.MaterialRadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.btn_Inicio = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistro)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(1, 64);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(888, 480);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonResultado);
            this.tabPage1.Controls.Add(this.buttonBorrarDatos);
            this.tabPage1.Controls.Add(this.buttonBorrarOperacion);
            this.tabPage1.Controls.Add(this.buttonDivision);
            this.tabPage1.Controls.Add(this.buttonMultiplicar);
            this.tabPage1.Controls.Add(this.buttonResta);
            this.tabPage1.Controls.Add(this.textResultado);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.dgvRegistro);
            this.tabPage1.Controls.Add(this.buttonSuma);
            this.tabPage1.Controls.Add(this.textValor2);
            this.tabPage1.Controls.Add(this.textValor1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 45);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(880, 431);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Calculadora";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonResultado
            // 
            this.buttonResultado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResultado.Location = new System.Drawing.Point(38, 344);
            this.buttonResultado.Name = "buttonResultado";
            this.buttonResultado.Size = new System.Drawing.Size(342, 44);
            this.buttonResultado.TabIndex = 15;
            this.buttonResultado.Text = "Resultado";
            this.buttonResultado.UseVisualStyleBackColor = true;
            this.buttonResultado.Click += new System.EventHandler(this.buttonResultado_Click);
            // 
            // buttonBorrarDatos
            // 
            this.buttonBorrarDatos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBorrarDatos.Location = new System.Drawing.Point(221, 278);
            this.buttonBorrarDatos.Name = "buttonBorrarDatos";
            this.buttonBorrarDatos.Size = new System.Drawing.Size(159, 44);
            this.buttonBorrarDatos.TabIndex = 14;
            this.buttonBorrarDatos.Text = "Borrar Datos";
            this.buttonBorrarDatos.UseVisualStyleBackColor = true;
            this.buttonBorrarDatos.Click += new System.EventHandler(this.buttonBorrarDatos_Click);
            // 
            // buttonBorrarOperacion
            // 
            this.buttonBorrarOperacion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBorrarOperacion.Location = new System.Drawing.Point(38, 278);
            this.buttonBorrarOperacion.Name = "buttonBorrarOperacion";
            this.buttonBorrarOperacion.Size = new System.Drawing.Size(159, 44);
            this.buttonBorrarOperacion.TabIndex = 13;
            this.buttonBorrarOperacion.Text = "Borrar Operación";
            this.buttonBorrarOperacion.UseVisualStyleBackColor = true;
            this.buttonBorrarOperacion.Click += new System.EventHandler(this.buttonBorrarOperacion_Click);
            // 
            // buttonDivision
            // 
            this.buttonDivision.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDivision.Location = new System.Drawing.Point(221, 210);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(159, 44);
            this.buttonDivision.TabIndex = 12;
            this.buttonDivision.Text = "División";
            this.buttonDivision.UseVisualStyleBackColor = true;
            this.buttonDivision.Click += new System.EventHandler(this.buttonDivision_Click);
            // 
            // buttonMultiplicar
            // 
            this.buttonMultiplicar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMultiplicar.Location = new System.Drawing.Point(38, 210);
            this.buttonMultiplicar.Name = "buttonMultiplicar";
            this.buttonMultiplicar.Size = new System.Drawing.Size(159, 44);
            this.buttonMultiplicar.TabIndex = 11;
            this.buttonMultiplicar.Text = "Multiplicar";
            this.buttonMultiplicar.UseVisualStyleBackColor = true;
            this.buttonMultiplicar.Click += new System.EventHandler(this.buttonMultiplicar_Click);
            // 
            // buttonResta
            // 
            this.buttonResta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResta.Location = new System.Drawing.Point(221, 145);
            this.buttonResta.Name = "buttonResta";
            this.buttonResta.Size = new System.Drawing.Size(159, 44);
            this.buttonResta.TabIndex = 10;
            this.buttonResta.Text = "Resta";
            this.buttonResta.UseVisualStyleBackColor = true;
            this.buttonResta.Click += new System.EventHandler(this.buttonResta_Click);
            // 
            // textResultado
            // 
            this.textResultado.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textResultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textResultado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textResultado.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textResultado.Location = new System.Drawing.Point(415, 345);
            this.textResultado.Name = "textResultado";
            this.textResultado.ReadOnly = true;
            this.textResultado.Size = new System.Drawing.Size(169, 54);
            this.textResultado.TabIndex = 9;
            this.textResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(420, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Resultado:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(820, 380);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "";
            this.toolTip1.SetToolTip(this.pictureBox1, "Hola! Gracias a Dios ya casi termina el cuatri! jajaja");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(411, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Historial de Resultados";
            // 
            // dgvRegistro
            // 
            this.dgvRegistro.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistro.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvRegistro.Location = new System.Drawing.Point(415, 57);
            this.dgvRegistro.Name = "dgvRegistro";
            this.dgvRegistro.RowHeadersWidth = 51;
            this.dgvRegistro.Size = new System.Drawing.Size(448, 214);
            this.dgvRegistro.TabIndex = 6;
            // 
            // buttonSuma
            // 
            this.buttonSuma.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSuma.Location = new System.Drawing.Point(38, 145);
            this.buttonSuma.Name = "buttonSuma";
            this.buttonSuma.Size = new System.Drawing.Size(159, 44);
            this.buttonSuma.TabIndex = 5;
            this.buttonSuma.Text = "Suma";
            this.buttonSuma.UseVisualStyleBackColor = true;
            this.buttonSuma.Click += new System.EventHandler(this.buttonSuma_Click);
            // 
            // textValor2
            // 
            this.textValor2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textValor2.Location = new System.Drawing.Point(221, 87);
            this.textValor2.Name = "textValor2";
            this.textValor2.Size = new System.Drawing.Size(117, 37);
            this.textValor2.TabIndex = 4;
            // 
            // textValor1
            // 
            this.textValor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textValor1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textValor1.Location = new System.Drawing.Point(221, 45);
            this.textValor1.Name = "textValor1";
            this.textValor1.Size = new System.Drawing.Size(117, 37);
            this.textValor1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "B) Ingrese otro numero";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "A) Ingrese un numero";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage2.Location = new System.Drawing.Point(4, 45);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(880, 431);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Validador ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.btnValidar);
            this.groupBox1.Controls.Add(this.RadioButtonId);
            this.groupBox1.Controls.Add(this.RadioButtonFecha);
            this.groupBox1.Controls.Add(this.RadioButtonCorreo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDato);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(-4, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(888, 441);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingreso de información";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(822, 375);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 53);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "";
            this.toolTip1.SetToolTip(this.pictureBox2, "Hola! Gracias a Dios ya casi termina el cuatri! jajaja");
            // 
            // btnValidar
            // 
            this.btnValidar.Depth = 0;
            this.btnValidar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidar.Location = new System.Drawing.Point(693, 206);
            this.btnValidar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Primary = true;
            this.btnValidar.Size = new System.Drawing.Size(87, 44);
            this.btnValidar.TabIndex = 9;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // RadioButtonId
            // 
            this.RadioButtonId.AutoSize = true;
            this.RadioButtonId.BackColor = System.Drawing.Color.Gainsboro;
            this.RadioButtonId.Depth = 0;
            this.RadioButtonId.Font = new System.Drawing.Font("Roboto", 10F);
            this.RadioButtonId.Location = new System.Drawing.Point(610, 77);
            this.RadioButtonId.Margin = new System.Windows.Forms.Padding(0);
            this.RadioButtonId.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RadioButtonId.MouseState = MaterialSkin.MouseState.HOVER;
            this.RadioButtonId.Name = "RadioButtonId";
            this.RadioButtonId.Ripple = true;
            this.RadioButtonId.Size = new System.Drawing.Size(207, 30);
            this.RadioButtonId.TabIndex = 8;
            this.RadioButtonId.TabStop = true;
            this.RadioButtonId.Text = "Identificacion Nacional";
            this.RadioButtonId.UseVisualStyleBackColor = false;
            this.RadioButtonId.CheckedChanged += new System.EventHandler(this.materialRadioButton3_CheckedChanged);
            // 
            // RadioButtonFecha
            // 
            this.RadioButtonFecha.AutoSize = true;
            this.RadioButtonFecha.Depth = 0;
            this.RadioButtonFecha.Font = new System.Drawing.Font("Roboto", 10F);
            this.RadioButtonFecha.Location = new System.Drawing.Point(346, 77);
            this.RadioButtonFecha.Margin = new System.Windows.Forms.Padding(0);
            this.RadioButtonFecha.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RadioButtonFecha.MouseState = MaterialSkin.MouseState.HOVER;
            this.RadioButtonFecha.Name = "RadioButtonFecha";
            this.RadioButtonFecha.Ripple = true;
            this.RadioButtonFecha.Size = new System.Drawing.Size(189, 30);
            this.RadioButtonFecha.TabIndex = 7;
            this.RadioButtonFecha.TabStop = true;
            this.RadioButtonFecha.Text = "Fecha (dd/MM/yyyy)";
            this.RadioButtonFecha.UseVisualStyleBackColor = true;
            this.RadioButtonFecha.CheckedChanged += new System.EventHandler(this.materialRadioButton2_CheckedChanged);
            // 
            // RadioButtonCorreo
            // 
            this.RadioButtonCorreo.Appearance = System.Windows.Forms.Appearance.Button;
            this.RadioButtonCorreo.AutoSize = true;
            this.RadioButtonCorreo.Depth = 0;
            this.RadioButtonCorreo.Font = new System.Drawing.Font("Roboto", 10F);
            this.RadioButtonCorreo.Location = new System.Drawing.Point(96, 77);
            this.RadioButtonCorreo.Margin = new System.Windows.Forms.Padding(0);
            this.RadioButtonCorreo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RadioButtonCorreo.MouseState = MaterialSkin.MouseState.HOVER;
            this.RadioButtonCorreo.Name = "RadioButtonCorreo";
            this.RadioButtonCorreo.Ripple = true;
            this.RadioButtonCorreo.Size = new System.Drawing.Size(173, 30);
            this.RadioButtonCorreo.TabIndex = 6;
            this.RadioButtonCorreo.TabStop = true;
            this.RadioButtonCorreo.Text = "Correo Electrónico";
            this.RadioButtonCorreo.UseVisualStyleBackColor = true;
            this.RadioButtonCorreo.CheckedChanged += new System.EventHandler(this.materialRadioButton1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dato Ingresado";
            // 
            // txtDato
            // 
            this.txtDato.BackColor = System.Drawing.Color.Gainsboro;
            this.txtDato.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDato.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDato.Location = new System.Drawing.Point(214, 219);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(441, 39);
            this.txtDato.TabIndex = 5;
            this.txtDato.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Inicio
            // 
            this.btn_Inicio.BackColor = System.Drawing.Color.Transparent;
            this.btn_Inicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Inicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Inicio.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Inicio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Inicio.Location = new System.Drawing.Point(5, 26);
            this.btn_Inicio.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Inicio.Name = "btn_Inicio";
            this.btn_Inicio.Size = new System.Drawing.Size(87, 35);
            this.btn_Inicio.TabIndex = 6;
            this.btn_Inicio.Text = "Inicio";
            this.btn_Inicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Inicio.UseVisualStyleBackColor = false;
            this.btn_Inicio.Click += new System.EventHandler(this.btn_Inicio_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.CadetBlue;
            // 
            // PantallaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 542);
            this.Controls.Add(this.btn_Inicio);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PantallaInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.PantallaInicio_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistro)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textValor2;
        private System.Windows.Forms.TextBox textValor1;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSuma;
        private System.Windows.Forms.Button btn_Inicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvRegistro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textResultado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonResultado;
        private System.Windows.Forms.Button buttonBorrarDatos;
        private System.Windows.Forms.Button buttonBorrarOperacion;
        private System.Windows.Forms.Button buttonDivision;
        private System.Windows.Forms.Button buttonMultiplicar;
        private System.Windows.Forms.Button buttonResta;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialRaisedButton btnValidar;
        private MaterialSkin.Controls.MaterialRadioButton RadioButtonId;
        private MaterialSkin.Controls.MaterialRadioButton RadioButtonFecha;
        private MaterialSkin.Controls.MaterialRadioButton RadioButtonCorreo;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}