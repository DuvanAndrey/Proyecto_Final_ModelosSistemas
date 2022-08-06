namespace UL.Pantallas
{
    partial class Bienvenida
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
            this.btn_Iniciar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Iniciar
            // 
            this.btn_Iniciar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Iniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Iniciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Iniciar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Iniciar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Iniciar.Location = new System.Drawing.Point(84, 344);
            this.btn_Iniciar.Name = "btn_Iniciar";
            this.btn_Iniciar.Size = new System.Drawing.Size(214, 37);
            this.btn_Iniciar.TabIndex = 0;
            this.btn_Iniciar.Text = "Iniciar ";
            this.btn_Iniciar.UseVisualStyleBackColor = false;
            this.btn_Iniciar.Click += new System.EventHandler(this.btn_Iniciar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Proyecto Final ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Modelos de Sistemas";
            // 
            // Bienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Iniciar);
            this.MaximizeBox = false;
            this.Name = "Bienvenida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Iniciar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}