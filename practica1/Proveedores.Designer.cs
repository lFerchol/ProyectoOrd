namespace practica1
{
    partial class Proveedores
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
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.txt_proveedor = new System.Windows.Forms.TextBox();
            this.lbl_rfc = new System.Windows.Forms.Label();
            this.txt_domicilio = new System.Windows.Forms.TextBox();
            this.lbl_domicilio = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.lbl_correo = new System.Windows.Forms.Label();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.txt_razon = new System.Windows.Forms.TextBox();
            this.lbl_razon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(403, 68);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 37;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(305, 332);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 36;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // txt_proveedor
            // 
            this.txt_proveedor.Location = new System.Drawing.Point(280, 276);
            this.txt_proveedor.Name = "txt_proveedor";
            this.txt_proveedor.Size = new System.Drawing.Size(100, 20);
            this.txt_proveedor.TabIndex = 35;
            // 
            // lbl_rfc
            // 
            this.lbl_rfc.AutoSize = true;
            this.lbl_rfc.Location = new System.Drawing.Point(243, 279);
            this.lbl_rfc.Name = "lbl_rfc";
            this.lbl_rfc.Size = new System.Drawing.Size(31, 13);
            this.lbl_rfc.TabIndex = 34;
            this.lbl_rfc.Text = "RFC:";
            // 
            // txt_domicilio
            // 
            this.txt_domicilio.Location = new System.Drawing.Point(280, 225);
            this.txt_domicilio.Name = "txt_domicilio";
            this.txt_domicilio.Size = new System.Drawing.Size(100, 20);
            this.txt_domicilio.TabIndex = 33;
            // 
            // lbl_domicilio
            // 
            this.lbl_domicilio.AutoSize = true;
            this.lbl_domicilio.Location = new System.Drawing.Point(192, 225);
            this.lbl_domicilio.Name = "lbl_domicilio";
            this.lbl_domicilio.Size = new System.Drawing.Size(82, 13);
            this.lbl_domicilio.TabIndex = 32;
            this.lbl_domicilio.Text = "Domicilio Fiscal:";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(280, 169);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(100, 20);
            this.txt_telefono.TabIndex = 31;
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Location = new System.Drawing.Point(225, 172);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(52, 13);
            this.lbl_telefono.TabIndex = 30;
            this.lbl_telefono.Text = "Teléfono:";
            // 
            // txt_correo
            // 
            this.txt_correo.Location = new System.Drawing.Point(280, 120);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(100, 20);
            this.txt_correo.TabIndex = 29;
            // 
            // lbl_correo
            // 
            this.lbl_correo.AutoSize = true;
            this.lbl_correo.Location = new System.Drawing.Point(180, 120);
            this.lbl_correo.Name = "lbl_correo";
            this.lbl_correo.Size = new System.Drawing.Size(97, 13);
            this.lbl_correo.TabIndex = 28;
            this.lbl_correo.Text = "Correo Electrónico:";
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(199, 332);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 27;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // txt_razon
            // 
            this.txt_razon.Location = new System.Drawing.Point(280, 70);
            this.txt_razon.Name = "txt_razon";
            this.txt_razon.Size = new System.Drawing.Size(100, 20);
            this.txt_razon.TabIndex = 26;
            // 
            // lbl_razon
            // 
            this.lbl_razon.AutoSize = true;
            this.lbl_razon.Location = new System.Drawing.Point(206, 73);
            this.lbl_razon.Name = "lbl_razon";
            this.lbl_razon.Size = new System.Drawing.Size(71, 13);
            this.lbl_razon.TabIndex = 25;
            this.lbl_razon.Text = "Razón social:";
            // 
            // Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 423);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.txt_proveedor);
            this.Controls.Add(this.lbl_rfc);
            this.Controls.Add(this.txt_domicilio);
            this.Controls.Add(this.lbl_domicilio);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.lbl_telefono);
            this.Controls.Add(this.txt_correo);
            this.Controls.Add(this.lbl_correo);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.txt_razon);
            this.Controls.Add(this.lbl_razon);
            this.Name = "Proveedores";
            this.Text = "Proveedores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_cancelar;
        public System.Windows.Forms.TextBox txt_proveedor;
        private System.Windows.Forms.Label lbl_rfc;
        public System.Windows.Forms.TextBox txt_domicilio;
        private System.Windows.Forms.Label lbl_domicilio;
        public System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Label lbl_telefono;
        public System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.Label lbl_correo;
        public System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.TextBox txt_razon;
        private System.Windows.Forms.Label lbl_razon;
    }
}