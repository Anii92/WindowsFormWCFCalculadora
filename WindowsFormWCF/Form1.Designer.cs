namespace WindowsFormWCF
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnMultiplicacion = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.textBoxNum1 = new System.Windows.Forms.TextBox();
            this.textBoxNum2 = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblSolucion = new System.Windows.Forms.Label();
            this.radioButtonHttp = new System.Windows.Forms.RadioButton();
            this.radioButtonTcp = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(283, 62);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(46, 38);
            this.btnSuma.TabIndex = 10;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnResta
            // 
            this.btnResta.Location = new System.Drawing.Point(360, 62);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(46, 38);
            this.btnResta.TabIndex = 11;
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // btnMultiplicacion
            // 
            this.btnMultiplicacion.Location = new System.Drawing.Point(283, 126);
            this.btnMultiplicacion.Name = "btnMultiplicacion";
            this.btnMultiplicacion.Size = new System.Drawing.Size(46, 38);
            this.btnMultiplicacion.TabIndex = 12;
            this.btnMultiplicacion.Text = "*";
            this.btnMultiplicacion.UseVisualStyleBackColor = true;
            this.btnMultiplicacion.Click += new System.EventHandler(this.btnMultiplicacion_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.Location = new System.Drawing.Point(360, 126);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(46, 38);
            this.btnDivision.TabIndex = 13;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // textBoxNum1
            // 
            this.textBoxNum1.Location = new System.Drawing.Point(54, 62);
            this.textBoxNum1.Name = "textBoxNum1";
            this.textBoxNum1.Size = new System.Drawing.Size(100, 26);
            this.textBoxNum1.TabIndex = 14;
            // 
            // textBoxNum2
            // 
            this.textBoxNum2.Location = new System.Drawing.Point(54, 126);
            this.textBoxNum2.Name = "textBoxNum2";
            this.textBoxNum2.Size = new System.Drawing.Size(100, 26);
            this.textBoxNum2.TabIndex = 15;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(54, 231);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(86, 20);
            this.lblResultado.TabIndex = 16;
            this.lblResultado.Text = "Resultado:";
            // 
            // lblSolucion
            // 
            this.lblSolucion.AutoSize = true;
            this.lblSolucion.Location = new System.Drawing.Point(172, 231);
            this.lblSolucion.Name = "lblSolucion";
            this.lblSolucion.Size = new System.Drawing.Size(0, 20);
            this.lblSolucion.TabIndex = 17;
            // 
            // radioButtonHttp
            // 
            this.radioButtonHttp.AutoSize = true;
            this.radioButtonHttp.Location = new System.Drawing.Point(561, 90);
            this.radioButtonHttp.Name = "radioButtonHttp";
            this.radioButtonHttp.Size = new System.Drawing.Size(65, 24);
            this.radioButtonHttp.TabIndex = 18;
            this.radioButtonHttp.TabStop = true;
            this.radioButtonHttp.Text = "Http";
            this.radioButtonHttp.UseVisualStyleBackColor = true;
            this.radioButtonHttp.CheckedChanged += new System.EventHandler(this.radioButtonHttp_CheckedChanged);
            // 
            // radioButtonTcp
            // 
            this.radioButtonTcp.AutoSize = true;
            this.radioButtonTcp.Checked = true;
            this.radioButtonTcp.Location = new System.Drawing.Point(561, 127);
            this.radioButtonTcp.Name = "radioButtonTcp";
            this.radioButtonTcp.Size = new System.Drawing.Size(60, 24);
            this.radioButtonTcp.TabIndex = 19;
            this.radioButtonTcp.TabStop = true;
            this.radioButtonTcp.Text = "Tcp";
            this.radioButtonTcp.UseVisualStyleBackColor = true;
            this.radioButtonTcp.CheckedChanged += new System.EventHandler(this.radioButtonTcp_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButtonTcp);
            this.Controls.Add(this.radioButtonHttp);
            this.Controls.Add(this.lblSolucion);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.textBoxNum2);
            this.Controls.Add(this.textBoxNum1);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnMultiplicacion);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnSuma);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnMultiplicacion;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.TextBox textBoxNum1;
        private System.Windows.Forms.TextBox textBoxNum2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblSolucion;
        private System.Windows.Forms.RadioButton radioButtonHttp;
        private System.Windows.Forms.RadioButton radioButtonTcp;
    }
}

