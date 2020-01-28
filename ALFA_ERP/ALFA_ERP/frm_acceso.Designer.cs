namespace ALFA_ERP
{
    partial class frm_acceso
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
            this.LBL_USER = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_USER = new System.Windows.Forms.TextBox();
            this.TXT_PASSWORD = new System.Windows.Forms.TextBox();
            this.BTN_INGRESAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBL_USER
            // 
            this.LBL_USER.AutoSize = true;
            this.LBL_USER.BackColor = System.Drawing.Color.Transparent;
            this.LBL_USER.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_USER.ForeColor = System.Drawing.SystemColors.Control;
            this.LBL_USER.Location = new System.Drawing.Point(125, 48);
            this.LBL_USER.Name = "LBL_USER";
            this.LBL_USER.Size = new System.Drawing.Size(68, 20);
            this.LBL_USER.TabIndex = 0;
            this.LBL_USER.Text = "USUARIO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(112, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "CONTRASEÑA:";
            // 
            // TXT_USER
            // 
            this.TXT_USER.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_USER.Location = new System.Drawing.Point(68, 82);
            this.TXT_USER.Name = "TXT_USER";
            this.TXT_USER.Size = new System.Drawing.Size(190, 27);
            this.TXT_USER.TabIndex = 2;
            // 
            // TXT_PASSWORD
            // 
            this.TXT_PASSWORD.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_PASSWORD.Location = new System.Drawing.Point(68, 176);
            this.TXT_PASSWORD.Name = "TXT_PASSWORD";
            this.TXT_PASSWORD.Size = new System.Drawing.Size(190, 27);
            this.TXT_PASSWORD.TabIndex = 3;
            this.TXT_PASSWORD.UseSystemPasswordChar = true;
            this.TXT_PASSWORD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_PASSWORD_KeyPress);
            // 
            // BTN_INGRESAR
            // 
            this.BTN_INGRESAR.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_INGRESAR.Location = new System.Drawing.Point(118, 231);
            this.BTN_INGRESAR.Name = "BTN_INGRESAR";
            this.BTN_INGRESAR.Size = new System.Drawing.Size(87, 39);
            this.BTN_INGRESAR.TabIndex = 4;
            this.BTN_INGRESAR.Text = "INGRESAR";
            this.BTN_INGRESAR.UseVisualStyleBackColor = true;
            this.BTN_INGRESAR.Click += new System.EventHandler(this.BTN_INGRESAR_Click);
            // 
            // frm_acceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::ALFA_ERP.Properties.Resources.loginFondo;
            this.ClientSize = new System.Drawing.Size(319, 335);
            this.Controls.Add(this.BTN_INGRESAR);
            this.Controls.Add(this.TXT_PASSWORD);
            this.Controls.Add(this.TXT_USER);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBL_USER);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_acceso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acceso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_USER;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_USER;
        private System.Windows.Forms.TextBox TXT_PASSWORD;
        private System.Windows.Forms.Button BTN_INGRESAR;
    }
}

