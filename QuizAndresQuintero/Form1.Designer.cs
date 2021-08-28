
namespace QuizAndresQuintero
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblSeguro = new System.Windows.Forms.Label();
            this.rbnBasico = new System.Windows.Forms.RadioButton();
            this.rbnTerceros = new System.Windows.Forms.RadioButton();
            this.rbnTotal = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblEquipo = new System.Windows.Forms.Label();
            this.chkAire = new System.Windows.Forms.CheckBox();
            this.chkAudio = new System.Windows.Forms.CheckBox();
            this.lblCosto = new System.Windows.Forms.Label();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.btnCotizar = new System.Windows.Forms.Button();
            this.txtCotizacion = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(26, 22);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(107, 22);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(263, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblSeguro
            // 
            this.lblSeguro.AutoSize = true;
            this.lblSeguro.Location = new System.Drawing.Point(6, 24);
            this.lblSeguro.Name = "lblSeguro";
            this.lblSeguro.Size = new System.Drawing.Size(41, 13);
            this.lblSeguro.TabIndex = 2;
            this.lblSeguro.Text = "Seguro";
            this.lblSeguro.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // rbnBasico
            // 
            this.rbnBasico.AutoSize = true;
            this.rbnBasico.Checked = true;
            this.rbnBasico.Location = new System.Drawing.Point(78, 24);
            this.rbnBasico.Name = "rbnBasico";
            this.rbnBasico.Size = new System.Drawing.Size(57, 17);
            this.rbnBasico.TabIndex = 3;
            this.rbnBasico.TabStop = true;
            this.rbnBasico.Text = "Basico";
            this.rbnBasico.UseVisualStyleBackColor = true;
            this.rbnBasico.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbnTerceros
            // 
            this.rbnTerceros.AutoSize = true;
            this.rbnTerceros.Location = new System.Drawing.Point(78, 47);
            this.rbnTerceros.Name = "rbnTerceros";
            this.rbnTerceros.Size = new System.Drawing.Size(67, 17);
            this.rbnTerceros.TabIndex = 4;
            this.rbnTerceros.Text = "Terceros";
            this.rbnTerceros.UseVisualStyleBackColor = true;
            // 
            // rbnTotal
            // 
            this.rbnTotal.AutoSize = true;
            this.rbnTotal.Location = new System.Drawing.Point(78, 70);
            this.rbnTotal.Name = "rbnTotal";
            this.rbnTotal.Size = new System.Drawing.Size(49, 17);
            this.rbnTotal.TabIndex = 5;
            this.rbnTotal.Text = "Total";
            this.rbnTotal.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSeguro);
            this.groupBox1.Controls.Add(this.rbnTotal);
            this.groupBox1.Controls.Add(this.rbnBasico);
            this.groupBox1.Controls.Add(this.rbnTerceros);
            this.groupBox1.Location = new System.Drawing.Point(29, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 113);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seguro a seleccionar";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkAudio);
            this.groupBox2.Controls.Add(this.chkAire);
            this.groupBox2.Controls.Add(this.lblEquipo);
            this.groupBox2.Location = new System.Drawing.Point(295, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(208, 113);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Equipamiento ";
            // 
            // lblEquipo
            // 
            this.lblEquipo.AutoSize = true;
            this.lblEquipo.Location = new System.Drawing.Point(7, 24);
            this.lblEquipo.Name = "lblEquipo";
            this.lblEquipo.Size = new System.Drawing.Size(40, 13);
            this.lblEquipo.TabIndex = 0;
            this.lblEquipo.Text = "Equipo";
            // 
            // chkAire
            // 
            this.chkAire.AutoSize = true;
            this.chkAire.Location = new System.Drawing.Point(71, 24);
            this.chkAire.Name = "chkAire";
            this.chkAire.Size = new System.Drawing.Size(118, 17);
            this.chkAire.TabIndex = 1;
            this.chkAire.Text = "Aire Acondicionado";
            this.chkAire.UseVisualStyleBackColor = true;
            // 
            // chkAudio
            // 
            this.chkAudio.AutoSize = true;
            this.chkAudio.Location = new System.Drawing.Point(71, 48);
            this.chkAudio.Name = "chkAudio";
            this.chkAudio.Size = new System.Drawing.Size(113, 17);
            this.chkAudio.TabIndex = 2;
            this.chkAudio.Text = "Sistemas de Audio";
            this.chkAudio.UseVisualStyleBackColor = true;
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(26, 211);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(34, 13);
            this.lblCosto.TabIndex = 9;
            this.lblCosto.Text = "Costo";
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(79, 208);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(136, 20);
            this.txtCosto.TabIndex = 10;
            this.txtCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCotizar
            // 
            this.btnCotizar.Location = new System.Drawing.Point(276, 205);
            this.btnCotizar.Name = "btnCotizar";
            this.btnCotizar.Size = new System.Drawing.Size(75, 23);
            this.btnCotizar.TabIndex = 11;
            this.btnCotizar.Text = "Cotizar";
            this.btnCotizar.UseVisualStyleBackColor = true;
            this.btnCotizar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCotizacion
            // 
            this.txtCotizacion.Location = new System.Drawing.Point(38, 247);
            this.txtCotizacion.Multiline = true;
            this.txtCotizacion.Name = "txtCotizacion";
            this.txtCotizacion.Size = new System.Drawing.Size(455, 191);
            this.txtCotizacion.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 450);
            this.Controls.Add(this.txtCotizacion);
            this.Controls.Add(this.btnCotizar);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = ".: Cotizacion de de seguro :.";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblSeguro;
        private System.Windows.Forms.RadioButton rbnBasico;
        private System.Windows.Forms.RadioButton rbnTerceros;
        private System.Windows.Forms.RadioButton rbnTotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkAudio;
        private System.Windows.Forms.CheckBox chkAire;
        private System.Windows.Forms.Label lblEquipo;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Button btnCotizar;
        private System.Windows.Forms.TextBox txtCotizacion;
    }
}

