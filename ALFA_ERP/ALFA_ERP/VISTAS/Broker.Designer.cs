﻿namespace ALFA_ERP.VISTAS
{
    partial class Broker
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LBL_TITTULO_BROKER = new System.Windows.Forms.Label();
            this.BTN_SALIR = new System.Windows.Forms.PictureBox();
            this.TXT_NOMBRE = new System.Windows.Forms.TextBox();
            this.LBL_NOMBRE = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_RFC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXT_WEB_SITE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXT_TELEFONO = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXT_GIRO = new System.Windows.Forms.TextBox();
            this.CMB_MUNICIPIO = new System.Windows.Forms.ComboBox();
            this.CMB_ESTADO = new System.Windows.Forms.ComboBox();
            this.CMB_PAIS = new System.Windows.Forms.ComboBox();
            this.LBL_PAIS = new System.Windows.Forms.Label();
            this.LBL_ESTADO = new System.Windows.Forms.Label();
            this.LBL_MUNICIPIO = new System.Windows.Forms.Label();
            this.dgvBrokers = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.TXT_ID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_SALIR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrokers)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_TITTULO_BROKER
            // 
            this.LBL_TITTULO_BROKER.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LBL_TITTULO_BROKER.AutoSize = true;
            this.LBL_TITTULO_BROKER.BackColor = System.Drawing.Color.Transparent;
            this.LBL_TITTULO_BROKER.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_TITTULO_BROKER.Location = new System.Drawing.Point(283, 9);
            this.LBL_TITTULO_BROKER.Name = "LBL_TITTULO_BROKER";
            this.LBL_TITTULO_BROKER.Size = new System.Drawing.Size(69, 23);
            this.LBL_TITTULO_BROKER.TabIndex = 102;
            this.LBL_TITTULO_BROKER.Text = "BROKER";
            // 
            // BTN_SALIR
            // 
            this.BTN_SALIR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_SALIR.BackColor = System.Drawing.Color.Transparent;
            this.BTN_SALIR.Image = global::ALFA_ERP.Properties.Resources.appbar_3d_x;
            this.BTN_SALIR.Location = new System.Drawing.Point(639, 9);
            this.BTN_SALIR.Name = "BTN_SALIR";
            this.BTN_SALIR.Size = new System.Drawing.Size(17, 17);
            this.BTN_SALIR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BTN_SALIR.TabIndex = 103;
            this.BTN_SALIR.TabStop = false;
            this.BTN_SALIR.Click += new System.EventHandler(this.BTN_SALIR_Click);
            // 
            // TXT_NOMBRE
            // 
            this.TXT_NOMBRE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_NOMBRE.Location = new System.Drawing.Point(454, 79);
            this.TXT_NOMBRE.Name = "TXT_NOMBRE";
            this.TXT_NOMBRE.Size = new System.Drawing.Size(163, 20);
            this.TXT_NOMBRE.TabIndex = 105;
            // 
            // LBL_NOMBRE
            // 
            this.LBL_NOMBRE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_NOMBRE.AutoSize = true;
            this.LBL_NOMBRE.BackColor = System.Drawing.Color.Transparent;
            this.LBL_NOMBRE.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_NOMBRE.Location = new System.Drawing.Point(396, 83);
            this.LBL_NOMBRE.Name = "LBL_NOMBRE";
            this.LBL_NOMBRE.Size = new System.Drawing.Size(48, 16);
            this.LBL_NOMBRE.TabIndex = 104;
            this.LBL_NOMBRE.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(416, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 106;
            this.label1.Text = "RFC:";
            // 
            // TXT_RFC
            // 
            this.TXT_RFC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_RFC.Location = new System.Drawing.Point(454, 115);
            this.TXT_RFC.Name = "TXT_RFC";
            this.TXT_RFC.Size = new System.Drawing.Size(163, 20);
            this.TXT_RFC.TabIndex = 107;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(388, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 108;
            this.label2.Text = "Sitio Web:";
            // 
            // TXT_WEB_SITE
            // 
            this.TXT_WEB_SITE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_WEB_SITE.Location = new System.Drawing.Point(454, 155);
            this.TXT_WEB_SITE.Name = "TXT_WEB_SITE";
            this.TXT_WEB_SITE.Size = new System.Drawing.Size(163, 20);
            this.TXT_WEB_SITE.TabIndex = 109;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(393, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 110;
            this.label3.Text = "Telefono:";
            // 
            // TXT_TELEFONO
            // 
            this.TXT_TELEFONO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_TELEFONO.Location = new System.Drawing.Point(454, 192);
            this.TXT_TELEFONO.Name = "TXT_TELEFONO";
            this.TXT_TELEFONO.Size = new System.Drawing.Size(163, 20);
            this.TXT_TELEFONO.TabIndex = 111;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(413, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 16);
            this.label4.TabIndex = 112;
            this.label4.Text = "Giro:";
            // 
            // TXT_GIRO
            // 
            this.TXT_GIRO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_GIRO.Location = new System.Drawing.Point(454, 232);
            this.TXT_GIRO.Name = "TXT_GIRO";
            this.TXT_GIRO.Size = new System.Drawing.Size(163, 20);
            this.TXT_GIRO.TabIndex = 113;
            // 
            // CMB_MUNICIPIO
            // 
            this.CMB_MUNICIPIO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CMB_MUNICIPIO.FormattingEnabled = true;
            this.CMB_MUNICIPIO.Location = new System.Drawing.Point(454, 358);
            this.CMB_MUNICIPIO.Name = "CMB_MUNICIPIO";
            this.CMB_MUNICIPIO.Size = new System.Drawing.Size(163, 21);
            this.CMB_MUNICIPIO.TabIndex = 122;
            // 
            // CMB_ESTADO
            // 
            this.CMB_ESTADO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CMB_ESTADO.FormattingEnabled = true;
            this.CMB_ESTADO.Location = new System.Drawing.Point(454, 316);
            this.CMB_ESTADO.Name = "CMB_ESTADO";
            this.CMB_ESTADO.Size = new System.Drawing.Size(163, 21);
            this.CMB_ESTADO.TabIndex = 121;
            this.CMB_ESTADO.SelectedIndexChanged += new System.EventHandler(this.CMB_ESTADO_SelectedIndexChanged);
            // 
            // CMB_PAIS
            // 
            this.CMB_PAIS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CMB_PAIS.FormattingEnabled = true;
            this.CMB_PAIS.Location = new System.Drawing.Point(454, 271);
            this.CMB_PAIS.Name = "CMB_PAIS";
            this.CMB_PAIS.Size = new System.Drawing.Size(163, 21);
            this.CMB_PAIS.TabIndex = 120;
            this.CMB_PAIS.SelectedIndexChanged += new System.EventHandler(this.CMB_PAIS_SelectedIndexChanged);
            // 
            // LBL_PAIS
            // 
            this.LBL_PAIS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_PAIS.AutoSize = true;
            this.LBL_PAIS.BackColor = System.Drawing.Color.Transparent;
            this.LBL_PAIS.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_PAIS.Location = new System.Drawing.Point(413, 272);
            this.LBL_PAIS.Name = "LBL_PAIS";
            this.LBL_PAIS.Size = new System.Drawing.Size(31, 16);
            this.LBL_PAIS.TabIndex = 117;
            this.LBL_PAIS.Text = "Pais:";
            // 
            // LBL_ESTADO
            // 
            this.LBL_ESTADO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_ESTADO.AutoSize = true;
            this.LBL_ESTADO.BackColor = System.Drawing.Color.Transparent;
            this.LBL_ESTADO.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_ESTADO.Location = new System.Drawing.Point(402, 317);
            this.LBL_ESTADO.Name = "LBL_ESTADO";
            this.LBL_ESTADO.Size = new System.Drawing.Size(43, 16);
            this.LBL_ESTADO.TabIndex = 118;
            this.LBL_ESTADO.Text = "Estado:";
            // 
            // LBL_MUNICIPIO
            // 
            this.LBL_MUNICIPIO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_MUNICIPIO.AutoSize = true;
            this.LBL_MUNICIPIO.BackColor = System.Drawing.Color.Transparent;
            this.LBL_MUNICIPIO.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_MUNICIPIO.Location = new System.Drawing.Point(387, 358);
            this.LBL_MUNICIPIO.Name = "LBL_MUNICIPIO";
            this.LBL_MUNICIPIO.Size = new System.Drawing.Size(58, 16);
            this.LBL_MUNICIPIO.TabIndex = 119;
            this.LBL_MUNICIPIO.Text = "Municipio:";
            // 
            // dgvBrokers
            // 
            this.dgvBrokers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBrokers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBrokers.BackgroundColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBrokers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBrokers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBrokers.EnableHeadersVisualStyles = false;
            this.dgvBrokers.GridColor = System.Drawing.Color.Teal;
            this.dgvBrokers.Location = new System.Drawing.Point(12, 57);
            this.dgvBrokers.Name = "dgvBrokers";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Olive;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgvBrokers.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBrokers.Size = new System.Drawing.Size(365, 432);
            this.dgvBrokers.TabIndex = 123;
            this.dgvBrokers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBrokers_CellDoubleClick);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(536, 407);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(81, 27);
            this.btnActualizar.TabIndex = 125;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(454, 407);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(76, 27);
            this.btnGuardar.TabIndex = 124;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // TXT_ID
            // 
            this.TXT_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_ID.Cursor = System.Windows.Forms.Cursors.No;
            this.TXT_ID.Location = new System.Drawing.Point(574, 31);
            this.TXT_ID.Name = "TXT_ID";
            this.TXT_ID.ReadOnly = true;
            this.TXT_ID.Size = new System.Drawing.Size(43, 20);
            this.TXT_ID.TabIndex = 126;
            // 
            // Broker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ALFA_ERP.Properties.Resources.FONDO_SUBMENUS;
            this.ClientSize = new System.Drawing.Size(668, 522);
            this.Controls.Add(this.TXT_ID);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvBrokers);
            this.Controls.Add(this.CMB_MUNICIPIO);
            this.Controls.Add(this.CMB_ESTADO);
            this.Controls.Add(this.CMB_PAIS);
            this.Controls.Add(this.LBL_PAIS);
            this.Controls.Add(this.LBL_ESTADO);
            this.Controls.Add(this.LBL_MUNICIPIO);
            this.Controls.Add(this.TXT_GIRO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TXT_TELEFONO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXT_WEB_SITE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXT_RFC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXT_NOMBRE);
            this.Controls.Add(this.LBL_NOMBRE);
            this.Controls.Add(this.BTN_SALIR);
            this.Controls.Add(this.LBL_TITTULO_BROKER);
            this.Name = "Broker";
            this.Text = "Broker";
            this.Load += new System.EventHandler(this.Broker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BTN_SALIR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrokers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_TITTULO_BROKER;
        private System.Windows.Forms.PictureBox BTN_SALIR;
        private System.Windows.Forms.TextBox TXT_NOMBRE;
        private System.Windows.Forms.Label LBL_NOMBRE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_RFC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXT_WEB_SITE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXT_TELEFONO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXT_GIRO;
        private System.Windows.Forms.ComboBox CMB_MUNICIPIO;
        private System.Windows.Forms.ComboBox CMB_ESTADO;
        private System.Windows.Forms.ComboBox CMB_PAIS;
        private System.Windows.Forms.Label LBL_PAIS;
        private System.Windows.Forms.Label LBL_ESTADO;
        private System.Windows.Forms.Label LBL_MUNICIPIO;
        private System.Windows.Forms.DataGridView dgvBrokers;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox TXT_ID;
    }
}