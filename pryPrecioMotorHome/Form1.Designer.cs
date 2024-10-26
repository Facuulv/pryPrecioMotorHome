namespace pryPrecioMotorHome
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chbEquipo = new System.Windows.Forms.CheckBox();
            this.chbInternet = new System.Windows.Forms.CheckBox();
            this.chbTelevision = new System.Windows.Forms.CheckBox();
            this.cmbModelo = new System.Windows.Forms.ComboBox();
            this.cmbPersonas = new System.Windows.Forms.ComboBox();
            this.lblError = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbSi = new System.Windows.Forms.RadioButton();
            this.rdbNo = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(134, 172);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(63, 32);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(212, 172);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(63, 32);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtResultado.Enabled = false;
            this.txtResultado.Location = new System.Drawing.Point(160, 246);
            this.txtResultado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(91, 20);
            this.txtResultado.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 223);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "El total a pagar es:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 149);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "EXTRAS";
            // 
            // chbEquipo
            // 
            this.chbEquipo.AutoSize = true;
            this.chbEquipo.Location = new System.Drawing.Point(10, 172);
            this.chbEquipo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chbEquipo.Name = "chbEquipo";
            this.chbEquipo.Size = new System.Drawing.Size(110, 17);
            this.chbEquipo.TabIndex = 5;
            this.chbEquipo.Text = "Equipo de Cocina";
            this.chbEquipo.UseVisualStyleBackColor = true;
            this.chbEquipo.CheckedChanged += new System.EventHandler(this.chbEquipo_CheckedChanged);
            // 
            // chbInternet
            // 
            this.chbInternet.AutoSize = true;
            this.chbInternet.Location = new System.Drawing.Point(9, 206);
            this.chbInternet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chbInternet.Name = "chbInternet";
            this.chbInternet.Size = new System.Drawing.Size(62, 17);
            this.chbInternet.TabIndex = 6;
            this.chbInternet.Text = "Internet";
            this.chbInternet.UseVisualStyleBackColor = true;
            this.chbInternet.CheckedChanged += new System.EventHandler(this.chbInternet_CheckedChanged);
            // 
            // chbTelevision
            // 
            this.chbTelevision.AutoSize = true;
            this.chbTelevision.Location = new System.Drawing.Point(9, 238);
            this.chbTelevision.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chbTelevision.Name = "chbTelevision";
            this.chbTelevision.Size = new System.Drawing.Size(74, 17);
            this.chbTelevision.TabIndex = 7;
            this.chbTelevision.Text = "Television";
            this.chbTelevision.UseVisualStyleBackColor = true;
            this.chbTelevision.CheckedChanged += new System.EventHandler(this.chbTelevision_CheckedChanged);
            // 
            // cmbModelo
            // 
            this.cmbModelo.FormattingEnabled = true;
            this.cmbModelo.Items.AddRange(new object[] {
            "Modelo A",
            "Modelo B",
            "Modelo C"});
            this.cmbModelo.Location = new System.Drawing.Point(29, 35);
            this.cmbModelo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbModelo.Name = "cmbModelo";
            this.cmbModelo.Size = new System.Drawing.Size(109, 21);
            this.cmbModelo.TabIndex = 8;
            this.cmbModelo.SelectedIndexChanged += new System.EventHandler(this.cmbModelo_SelectedIndexChanged);
            // 
            // cmbPersonas
            // 
            this.cmbPersonas.FormattingEnabled = true;
            this.cmbPersonas.Location = new System.Drawing.Point(166, 35);
            this.cmbPersonas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbPersonas.Name = "cmbPersonas";
            this.cmbPersonas.Size = new System.Drawing.Size(109, 21);
            this.cmbPersonas.TabIndex = 9;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(29, 11);
            this.lblError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "¿Desea agregar seguro?";
            // 
            // rdbSi
            // 
            this.rdbSi.AutoSize = true;
            this.rdbSi.Location = new System.Drawing.Point(120, 100);
            this.rdbSi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbSi.Name = "rdbSi";
            this.rdbSi.Size = new System.Drawing.Size(34, 17);
            this.rdbSi.TabIndex = 12;
            this.rdbSi.TabStop = true;
            this.rdbSi.Text = "Si";
            this.rdbSi.UseVisualStyleBackColor = true;
            // 
            // rdbNo
            // 
            this.rdbNo.AutoSize = true;
            this.rdbNo.Location = new System.Drawing.Point(120, 121);
            this.rdbNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbNo.Name = "rdbNo";
            this.rdbNo.Size = new System.Drawing.Size(39, 17);
            this.rdbNo.TabIndex = 13;
            this.rdbNo.TabStop = true;
            this.rdbNo.Text = "No";
            this.rdbNo.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Modelos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(162, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Cantidad de personas:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(297, 288);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rdbNo);
            this.Controls.Add(this.rdbSi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.cmbPersonas);
            this.Controls.Add(this.cmbModelo);
            this.Controls.Add(this.chbTelevision);
            this.Controls.Add(this.chbInternet);
            this.Controls.Add(this.chbEquipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Calculador de Precios MotorHome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chbEquipo;
        private System.Windows.Forms.CheckBox chbInternet;
        private System.Windows.Forms.CheckBox chbTelevision;
        private System.Windows.Forms.ComboBox cmbModelo;
        private System.Windows.Forms.ComboBox cmbPersonas;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbSi;
        private System.Windows.Forms.RadioButton rdbNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

