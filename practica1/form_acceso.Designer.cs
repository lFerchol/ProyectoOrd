namespace practica1
{
    partial class form_acceso
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.txt_cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.BackColor = System.Drawing.Color.LightGreen;
            this.btn_ingresar.Location = new System.Drawing.Point(28, 254);
            this.btn_ingresar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(125, 35);
            this.btn_ingresar.TabIndex = 2;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.UseVisualStyleBackColor = false;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(82, 95);
            this.txt_usuario.Margin = new System.Windows.Forms.Padding(5);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(164, 27);
            this.txt_usuario.TabIndex = 0;
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(82, 174);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(5);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(164, 27);
            this.txt_pass.TabIndex = 1;
            this.txt_pass.UseSystemPasswordChar = true;
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Location = new System.Drawing.Point(82, 66);
            this.lbl_usuario.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(77, 22);
            this.lbl_usuario.TabIndex = 3;
            this.lbl_usuario.Text = "Usuario:";
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_pass.Location = new System.Drawing.Point(82, 145);
            this.lbl_pass.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(108, 22);
            this.lbl_pass.TabIndex = 4;
            this.lbl_pass.Text = "Contraseña:";
            // 
            // txt_cancel
            // 
            this.txt_cancel.BackColor = System.Drawing.Color.LightCoral;
            this.txt_cancel.Location = new System.Drawing.Point(182, 254);
            this.txt_cancel.Margin = new System.Windows.Forms.Padding(5);
            this.txt_cancel.Name = "txt_cancel";
            this.txt_cancel.Size = new System.Drawing.Size(125, 35);
            this.txt_cancel.TabIndex = 4;
            this.txt_cancel.Text = "Salir";
            this.txt_cancel.UseVisualStyleBackColor = false;
            this.txt_cancel.Click += new System.EventHandler(this.txt_cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Image = global::practica1.Properties.Resources.icons_pass;
            this.label1.Location = new System.Drawing.Point(61, 176);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "  ";
            // 
            // form_acceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(327, 340);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_cancel);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.btn_ingresar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "form_acceso";
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_acceso_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ingresar;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Button txt_cancel;
        private System.Windows.Forms.Label label1;
    }
}

