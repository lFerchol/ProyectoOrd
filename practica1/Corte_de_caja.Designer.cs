namespace practica1
{
    partial class Corte_de_caja
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
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.txt_fecha = new System.Windows.Forms.DateTimePicker();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ver_efectivo = new System.Windows.Forms.Button();
            this.btn_confirmar_efectivo = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_ingresar_efectivo = new System.Windows.Forms.Label();
            this.lbl_seleccionar_caja = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_corte_de_caja = new System.Windows.Forms.Button();
            this.btn_abrir_caja = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Location = new System.Drawing.Point(35, 48);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(40, 13);
            this.lbl_fecha.TabIndex = 0;
            this.lbl_fecha.Text = "Fecha:";
            // 
            // txt_fecha
            // 
            this.txt_fecha.Enabled = false;
            this.txt_fecha.Location = new System.Drawing.Point(76, 42);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(200, 20);
            this.txt_fecha.TabIndex = 1;
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_pass.Location = new System.Drawing.Point(11, 117);
            this.lbl_pass.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(64, 13);
            this.lbl_pass.TabIndex = 11;
            this.lbl_pass.Text = "Contraseña:";
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Location = new System.Drawing.Point(29, 88);
            this.lbl_usuario.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(46, 13);
            this.lbl_usuario.TabIndex = 9;
            this.lbl_usuario.Text = "Usuario:";
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(76, 114);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(5);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(164, 20);
            this.txt_pass.TabIndex = 1;
            this.txt_pass.UseSystemPasswordChar = true;
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(76, 81);
            this.txt_usuario.Margin = new System.Windows.Forms.Padding(5);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(164, 20);
            this.txt_usuario.TabIndex = 0;
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.BackColor = System.Drawing.Color.LightGreen;
            this.btn_confirmar.Location = new System.Drawing.Point(91, 144);
            this.btn_confirmar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(125, 35);
            this.btn_confirmar.TabIndex = 2;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = false;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_ver_efectivo);
            this.groupBox1.Controls.Add(this.btn_confirmar_efectivo);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.lbl_ingresar_efectivo);
            this.groupBox1.Location = new System.Drawing.Point(341, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 160);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Corte de Caja";
            this.groupBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "label1";
            // 
            // btn_ver_efectivo
            // 
            this.btn_ver_efectivo.Location = new System.Drawing.Point(11, 108);
            this.btn_ver_efectivo.Name = "btn_ver_efectivo";
            this.btn_ver_efectivo.Size = new System.Drawing.Size(100, 34);
            this.btn_ver_efectivo.TabIndex = 7;
            this.btn_ver_efectivo.Text = "Ver efectivo faltante";
            this.btn_ver_efectivo.UseVisualStyleBackColor = true;
            // 
            // btn_confirmar_efectivo
            // 
            this.btn_confirmar_efectivo.Location = new System.Drawing.Point(116, 54);
            this.btn_confirmar_efectivo.Name = "btn_confirmar_efectivo";
            this.btn_confirmar_efectivo.Size = new System.Drawing.Size(100, 34);
            this.btn_confirmar_efectivo.TabIndex = 8;
            this.btn_confirmar_efectivo.Text = "Confirmar efectivo a entregar";
            this.btn_confirmar_efectivo.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(116, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // lbl_ingresar_efectivo
            // 
            this.lbl_ingresar_efectivo.AutoSize = true;
            this.lbl_ingresar_efectivo.Location = new System.Drawing.Point(8, 22);
            this.lbl_ingresar_efectivo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_ingresar_efectivo.Name = "lbl_ingresar_efectivo";
            this.lbl_ingresar_efectivo.Size = new System.Drawing.Size(103, 13);
            this.lbl_ingresar_efectivo.TabIndex = 16;
            this.lbl_ingresar_efectivo.Text = "Ingresar EFECTIVO:";
            this.lbl_ingresar_efectivo.Visible = false;
            // 
            // lbl_seleccionar_caja
            // 
            this.lbl_seleccionar_caja.AutoSize = true;
            this.lbl_seleccionar_caja.Location = new System.Drawing.Point(338, 88);
            this.lbl_seleccionar_caja.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_seleccionar_caja.Name = "lbl_seleccionar_caja";
            this.lbl_seleccionar_caja.Size = new System.Drawing.Size(90, 13);
            this.lbl_seleccionar_caja.TabIndex = 13;
            this.lbl_seleccionar_caja.Text = "Seleccionar Caja:";
            this.lbl_seleccionar_caja.Click += new System.EventHandler(this.lbl_seleccionar_caja_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(436, 81);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // btn_corte_de_caja
            // 
            this.btn_corte_de_caja.Location = new System.Drawing.Point(593, 208);
            this.btn_corte_de_caja.Name = "btn_corte_de_caja";
            this.btn_corte_de_caja.Size = new System.Drawing.Size(100, 34);
            this.btn_corte_de_caja.TabIndex = 9;
            this.btn_corte_de_caja.Text = "Corte de caja";
            this.btn_corte_de_caja.UseVisualStyleBackColor = true;
            this.btn_corte_de_caja.Visible = false;
            // 
            // btn_abrir_caja
            // 
            this.btn_abrir_caja.Location = new System.Drawing.Point(14, 208);
            this.btn_abrir_caja.Name = "btn_abrir_caja";
            this.btn_abrir_caja.Size = new System.Drawing.Size(100, 34);
            this.btn_abrir_caja.TabIndex = 3;
            this.btn_abrir_caja.Text = "Abrir Caja";
            this.btn_abrir_caja.UseVisualStyleBackColor = true;
            this.btn_abrir_caja.Visible = false;
            this.btn_abrir_caja.Click += new System.EventHandler(this.btn_abrir_caja_Click);
            // 
            // Corte_de_caja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 348);
            this.Controls.Add(this.btn_abrir_caja);
            this.Controls.Add(this.btn_corte_de_caja);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbl_seleccionar_caja);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.txt_fecha);
            this.Controls.Add(this.lbl_fecha);
            this.Name = "Corte_de_caja";
            this.Text = "Corte de caja";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Corte_de_caja_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.DateTimePicker txt_fecha;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_seleccionar_caja;
        private System.Windows.Forms.Label lbl_ingresar_efectivo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_confirmar_efectivo;
        private System.Windows.Forms.Button btn_ver_efectivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_corte_de_caja;
        public System.Windows.Forms.Button btn_abrir_caja;
        public System.Windows.Forms.ComboBox comboBox1;
    }
}