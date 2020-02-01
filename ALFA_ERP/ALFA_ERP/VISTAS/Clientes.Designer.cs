namespace ALFA_ERP.VISTAS
{
    partial class Clientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BTN_SALIR = new System.Windows.Forms.PictureBox();
            this.LBL_TITULO = new System.Windows.Forms.Label();
            this.LBL_NOMBRE = new System.Windows.Forms.Label();
            this.LBL_RS = new System.Windows.Forms.Label();
            this.LBL_NOM_COMERCIAL = new System.Windows.Forms.Label();
            this.LBL_RFC = new System.Windows.Forms.Label();
            this.LBL_CALLE = new System.Windows.Forms.Label();
            this.LBL_NUM_INT = new System.Windows.Forms.Label();
            this.LBL_COLONIA = new System.Windows.Forms.Label();
            this.LBL_CP = new System.Windows.Forms.Label();
            this.LBL_NUM_EXT = new System.Windows.Forms.Label();
            this.LBL_PAIS = new System.Windows.Forms.Label();
            this.LBL_ESTADO = new System.Windows.Forms.Label();
            this.LBL_MUNICIPIO = new System.Windows.Forms.Label();
            this.LBL_TELEFONO = new System.Windows.Forms.Label();
            this.LBL_CORREO = new System.Windows.Forms.Label();
            this.DGV_CLIENTES = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.TXT_ID = new System.Windows.Forms.TextBox();
            this.TXT_NOMBRE = new System.Windows.Forms.TextBox();
            this.TXT_CALLE = new System.Windows.Forms.TextBox();
            this.TXT_CP = new System.Windows.Forms.TextBox();
            this.TXT_COLONIA = new System.Windows.Forms.TextBox();
            this.TXT_NUM_EXT = new System.Windows.Forms.TextBox();
            this.TXT_NUM_INT = new System.Windows.Forms.TextBox();
            this.TXT_RFC = new System.Windows.Forms.TextBox();
            this.TXT_TELEFONO = new System.Windows.Forms.TextBox();
            this.TXT_CORREO = new System.Windows.Forms.TextBox();
            this.TXT_RAZON_SOCIAL = new System.Windows.Forms.TextBox();
            this.CMB_PAIS = new System.Windows.Forms.ComboBox();
            this.CMB_ESTADO = new System.Windows.Forms.ComboBox();
            this.CMB_MUNICIPIO = new System.Windows.Forms.ComboBox();
            this.TXT_NOMBRE_COMERCIAL = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_SALIR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CLIENTES)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_SALIR
            // 
            this.BTN_SALIR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_SALIR.BackColor = System.Drawing.Color.Transparent;
            this.BTN_SALIR.Image = global::ALFA_ERP.Properties.Resources.appbar_3d_x;
            this.BTN_SALIR.Location = new System.Drawing.Point(636, 12);
            this.BTN_SALIR.Name = "BTN_SALIR";
            this.BTN_SALIR.Size = new System.Drawing.Size(20, 24);
            this.BTN_SALIR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BTN_SALIR.TabIndex = 3;
            this.BTN_SALIR.TabStop = false;
            this.BTN_SALIR.Click += new System.EventHandler(this.BTN_SALIR_Click);
            // 
            // LBL_TITULO
            // 
            this.LBL_TITULO.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LBL_TITULO.AutoSize = true;
            this.LBL_TITULO.BackColor = System.Drawing.Color.Transparent;
            this.LBL_TITULO.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_TITULO.Location = new System.Drawing.Point(275, 10);
            this.LBL_TITULO.Name = "LBL_TITULO";
            this.LBL_TITULO.Size = new System.Drawing.Size(88, 26);
            this.LBL_TITULO.TabIndex = 4;
            this.LBL_TITULO.Text = "CLIENTES";
            // 
            // LBL_NOMBRE
            // 
            this.LBL_NOMBRE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_NOMBRE.AutoSize = true;
            this.LBL_NOMBRE.BackColor = System.Drawing.Color.Transparent;
            this.LBL_NOMBRE.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_NOMBRE.Location = new System.Drawing.Point(390, 47);
            this.LBL_NOMBRE.Name = "LBL_NOMBRE";
            this.LBL_NOMBRE.Size = new System.Drawing.Size(61, 19);
            this.LBL_NOMBRE.TabIndex = 5;
            this.LBL_NOMBRE.Text = "Nombre:";
            // 
            // LBL_RS
            // 
            this.LBL_RS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_RS.AutoSize = true;
            this.LBL_RS.BackColor = System.Drawing.Color.Transparent;
            this.LBL_RS.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_RS.Location = new System.Drawing.Point(360, 283);
            this.LBL_RS.Name = "LBL_RS";
            this.LBL_RS.Size = new System.Drawing.Size(91, 19);
            this.LBL_RS.TabIndex = 6;
            this.LBL_RS.Text = "Razon Social:";
            // 
            // LBL_NOM_COMERCIAL
            // 
            this.LBL_NOM_COMERCIAL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_NOM_COMERCIAL.AutoSize = true;
            this.LBL_NOM_COMERCIAL.BackColor = System.Drawing.Color.Transparent;
            this.LBL_NOM_COMERCIAL.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_NOM_COMERCIAL.Location = new System.Drawing.Point(360, 390);
            this.LBL_NOM_COMERCIAL.Name = "LBL_NOM_COMERCIAL";
            this.LBL_NOM_COMERCIAL.Size = new System.Drawing.Size(128, 19);
            this.LBL_NOM_COMERCIAL.TabIndex = 7;
            this.LBL_NOM_COMERCIAL.Text = "Nombre Comercial:";
            // 
            // LBL_RFC
            // 
            this.LBL_RFC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_RFC.AutoSize = true;
            this.LBL_RFC.BackColor = System.Drawing.Color.Transparent;
            this.LBL_RFC.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_RFC.Location = new System.Drawing.Point(415, 206);
            this.LBL_RFC.Name = "LBL_RFC";
            this.LBL_RFC.Size = new System.Drawing.Size(34, 19);
            this.LBL_RFC.TabIndex = 8;
            this.LBL_RFC.Text = "RFC:";
            // 
            // LBL_CALLE
            // 
            this.LBL_CALLE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_CALLE.AutoSize = true;
            this.LBL_CALLE.BackColor = System.Drawing.Color.Transparent;
            this.LBL_CALLE.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_CALLE.Location = new System.Drawing.Point(407, 75);
            this.LBL_CALLE.Name = "LBL_CALLE";
            this.LBL_CALLE.Size = new System.Drawing.Size(44, 19);
            this.LBL_CALLE.TabIndex = 9;
            this.LBL_CALLE.Text = "Calle:";
            // 
            // LBL_NUM_INT
            // 
            this.LBL_NUM_INT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_NUM_INT.AutoSize = true;
            this.LBL_NUM_INT.BackColor = System.Drawing.Color.Transparent;
            this.LBL_NUM_INT.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_NUM_INT.Location = new System.Drawing.Point(380, 180);
            this.LBL_NUM_INT.Name = "LBL_NUM_INT";
            this.LBL_NUM_INT.Size = new System.Drawing.Size(71, 19);
            this.LBL_NUM_INT.TabIndex = 10;
            this.LBL_NUM_INT.Text = "# Interior:";
            // 
            // LBL_COLONIA
            // 
            this.LBL_COLONIA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_COLONIA.AutoSize = true;
            this.LBL_COLONIA.BackColor = System.Drawing.Color.Transparent;
            this.LBL_COLONIA.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_COLONIA.Location = new System.Drawing.Point(391, 128);
            this.LBL_COLONIA.Name = "LBL_COLONIA";
            this.LBL_COLONIA.Size = new System.Drawing.Size(60, 19);
            this.LBL_COLONIA.TabIndex = 11;
            this.LBL_COLONIA.Text = "Colonia:";
            // 
            // LBL_CP
            // 
            this.LBL_CP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_CP.AutoSize = true;
            this.LBL_CP.BackColor = System.Drawing.Color.Transparent;
            this.LBL_CP.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_CP.Location = new System.Drawing.Point(423, 102);
            this.LBL_CP.Name = "LBL_CP";
            this.LBL_CP.Size = new System.Drawing.Size(28, 19);
            this.LBL_CP.TabIndex = 12;
            this.LBL_CP.Text = "CP:";
            // 
            // LBL_NUM_EXT
            // 
            this.LBL_NUM_EXT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_NUM_EXT.AutoSize = true;
            this.LBL_NUM_EXT.BackColor = System.Drawing.Color.Transparent;
            this.LBL_NUM_EXT.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_NUM_EXT.Location = new System.Drawing.Point(379, 154);
            this.LBL_NUM_EXT.Name = "LBL_NUM_EXT";
            this.LBL_NUM_EXT.Size = new System.Drawing.Size(72, 19);
            this.LBL_NUM_EXT.TabIndex = 21;
            this.LBL_NUM_EXT.Text = "# Exterior:";
            // 
            // LBL_PAIS
            // 
            this.LBL_PAIS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_PAIS.AutoSize = true;
            this.LBL_PAIS.BackColor = System.Drawing.Color.Transparent;
            this.LBL_PAIS.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_PAIS.Location = new System.Drawing.Point(410, 309);
            this.LBL_PAIS.Name = "LBL_PAIS";
            this.LBL_PAIS.Size = new System.Drawing.Size(39, 19);
            this.LBL_PAIS.TabIndex = 23;
            this.LBL_PAIS.Text = "Pais:";
            // 
            // LBL_ESTADO
            // 
            this.LBL_ESTADO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_ESTADO.AutoSize = true;
            this.LBL_ESTADO.BackColor = System.Drawing.Color.Transparent;
            this.LBL_ESTADO.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_ESTADO.Location = new System.Drawing.Point(397, 337);
            this.LBL_ESTADO.Name = "LBL_ESTADO";
            this.LBL_ESTADO.Size = new System.Drawing.Size(54, 19);
            this.LBL_ESTADO.TabIndex = 24;
            this.LBL_ESTADO.Text = "Estado:";
            // 
            // LBL_MUNICIPIO
            // 
            this.LBL_MUNICIPIO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_MUNICIPIO.AutoSize = true;
            this.LBL_MUNICIPIO.BackColor = System.Drawing.Color.Transparent;
            this.LBL_MUNICIPIO.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_MUNICIPIO.Location = new System.Drawing.Point(379, 362);
            this.LBL_MUNICIPIO.Name = "LBL_MUNICIPIO";
            this.LBL_MUNICIPIO.Size = new System.Drawing.Size(74, 19);
            this.LBL_MUNICIPIO.TabIndex = 25;
            this.LBL_MUNICIPIO.Text = "Municipio:";
            // 
            // LBL_TELEFONO
            // 
            this.LBL_TELEFONO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_TELEFONO.AutoSize = true;
            this.LBL_TELEFONO.BackColor = System.Drawing.Color.Transparent;
            this.LBL_TELEFONO.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_TELEFONO.Location = new System.Drawing.Point(387, 231);
            this.LBL_TELEFONO.Name = "LBL_TELEFONO";
            this.LBL_TELEFONO.Size = new System.Drawing.Size(66, 19);
            this.LBL_TELEFONO.TabIndex = 29;
            this.LBL_TELEFONO.Text = "Telefono:";
            // 
            // LBL_CORREO
            // 
            this.LBL_CORREO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_CORREO.AutoSize = true;
            this.LBL_CORREO.BackColor = System.Drawing.Color.Transparent;
            this.LBL_CORREO.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_CORREO.Location = new System.Drawing.Point(397, 258);
            this.LBL_CORREO.Name = "LBL_CORREO";
            this.LBL_CORREO.Size = new System.Drawing.Size(54, 19);
            this.LBL_CORREO.TabIndex = 31;
            this.LBL_CORREO.Text = "Correo:";
            // 
            // DGV_CLIENTES
            // 
            this.DGV_CLIENTES.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_CLIENTES.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGV_CLIENTES.BackgroundColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_CLIENTES.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_CLIENTES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_CLIENTES.EnableHeadersVisualStyles = false;
            this.DGV_CLIENTES.GridColor = System.Drawing.Color.Teal;
            this.DGV_CLIENTES.Location = new System.Drawing.Point(2, 47);
            this.DGV_CLIENTES.Name = "DGV_CLIENTES";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Olive;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.DGV_CLIENTES.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGV_CLIENTES.Size = new System.Drawing.Size(352, 471);
            this.DGV_CLIENTES.TabIndex = 35;
            this.DGV_CLIENTES.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CLIENTES_CellDoubleClick);
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
            this.btnGuardar.Location = new System.Drawing.Point(364, 422);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(76, 27);
            this.btnGuardar.TabIndex = 36;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
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
            this.btnActualizar.Location = new System.Drawing.Point(446, 422);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(81, 27);
            this.btnActualizar.TabIndex = 37;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.Color.DarkRed;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(533, 422);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(76, 27);
            this.btnEliminar.TabIndex = 38;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // TXT_ID
            // 
            this.TXT_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_ID.Cursor = System.Windows.Forms.Cursors.No;
            this.TXT_ID.Location = new System.Drawing.Point(585, 20);
            this.TXT_ID.Name = "TXT_ID";
            this.TXT_ID.ReadOnly = true;
            this.TXT_ID.Size = new System.Drawing.Size(43, 20);
            this.TXT_ID.TabIndex = 39;
            // 
            // TXT_NOMBRE
            // 
            this.TXT_NOMBRE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_NOMBRE.Location = new System.Drawing.Point(446, 49);
            this.TXT_NOMBRE.Name = "TXT_NOMBRE";
            this.TXT_NOMBRE.Size = new System.Drawing.Size(182, 20);
            this.TXT_NOMBRE.TabIndex = 40;
            // 
            // TXT_CALLE
            // 
            this.TXT_CALLE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_CALLE.Location = new System.Drawing.Point(446, 75);
            this.TXT_CALLE.Name = "TXT_CALLE";
            this.TXT_CALLE.Size = new System.Drawing.Size(182, 20);
            this.TXT_CALLE.TabIndex = 41;
            // 
            // TXT_CP
            // 
            this.TXT_CP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_CP.Location = new System.Drawing.Point(446, 102);
            this.TXT_CP.Name = "TXT_CP";
            this.TXT_CP.Size = new System.Drawing.Size(182, 20);
            this.TXT_CP.TabIndex = 42;
            // 
            // TXT_COLONIA
            // 
            this.TXT_COLONIA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_COLONIA.Location = new System.Drawing.Point(446, 130);
            this.TXT_COLONIA.Name = "TXT_COLONIA";
            this.TXT_COLONIA.Size = new System.Drawing.Size(182, 20);
            this.TXT_COLONIA.TabIndex = 43;
            // 
            // TXT_NUM_EXT
            // 
            this.TXT_NUM_EXT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_NUM_EXT.Location = new System.Drawing.Point(446, 154);
            this.TXT_NUM_EXT.Name = "TXT_NUM_EXT";
            this.TXT_NUM_EXT.Size = new System.Drawing.Size(182, 20);
            this.TXT_NUM_EXT.TabIndex = 44;
            // 
            // TXT_NUM_INT
            // 
            this.TXT_NUM_INT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_NUM_INT.Location = new System.Drawing.Point(446, 180);
            this.TXT_NUM_INT.Name = "TXT_NUM_INT";
            this.TXT_NUM_INT.Size = new System.Drawing.Size(182, 20);
            this.TXT_NUM_INT.TabIndex = 45;
            // 
            // TXT_RFC
            // 
            this.TXT_RFC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_RFC.Location = new System.Drawing.Point(446, 208);
            this.TXT_RFC.Name = "TXT_RFC";
            this.TXT_RFC.Size = new System.Drawing.Size(182, 20);
            this.TXT_RFC.TabIndex = 46;
            // 
            // TXT_TELEFONO
            // 
            this.TXT_TELEFONO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_TELEFONO.Location = new System.Drawing.Point(446, 234);
            this.TXT_TELEFONO.Name = "TXT_TELEFONO";
            this.TXT_TELEFONO.Size = new System.Drawing.Size(182, 20);
            this.TXT_TELEFONO.TabIndex = 47;
            // 
            // TXT_CORREO
            // 
            this.TXT_CORREO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_CORREO.Location = new System.Drawing.Point(446, 258);
            this.TXT_CORREO.Name = "TXT_CORREO";
            this.TXT_CORREO.Size = new System.Drawing.Size(182, 20);
            this.TXT_CORREO.TabIndex = 48;
            // 
            // TXT_RAZON_SOCIAL
            // 
            this.TXT_RAZON_SOCIAL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_RAZON_SOCIAL.Location = new System.Drawing.Point(446, 283);
            this.TXT_RAZON_SOCIAL.Name = "TXT_RAZON_SOCIAL";
            this.TXT_RAZON_SOCIAL.Size = new System.Drawing.Size(182, 20);
            this.TXT_RAZON_SOCIAL.TabIndex = 49;
            // 
            // CMB_PAIS
            // 
            this.CMB_PAIS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CMB_PAIS.FormattingEnabled = true;
            this.CMB_PAIS.Location = new System.Drawing.Point(446, 309);
            this.CMB_PAIS.Name = "CMB_PAIS";
            this.CMB_PAIS.Size = new System.Drawing.Size(182, 21);
            this.CMB_PAIS.TabIndex = 50;
            this.CMB_PAIS.SelectedIndexChanged += new System.EventHandler(this.CMB_PAIS_SelectedIndexChanged);
            // 
            // CMB_ESTADO
            // 
            this.CMB_ESTADO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CMB_ESTADO.FormattingEnabled = true;
            this.CMB_ESTADO.Location = new System.Drawing.Point(446, 336);
            this.CMB_ESTADO.Name = "CMB_ESTADO";
            this.CMB_ESTADO.Size = new System.Drawing.Size(182, 21);
            this.CMB_ESTADO.TabIndex = 51;
            this.CMB_ESTADO.SelectedIndexChanged += new System.EventHandler(this.CMB_ESTADO_SelectedIndexChanged);
            // 
            // CMB_MUNICIPIO
            // 
            this.CMB_MUNICIPIO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CMB_MUNICIPIO.FormattingEnabled = true;
            this.CMB_MUNICIPIO.Location = new System.Drawing.Point(446, 362);
            this.CMB_MUNICIPIO.Name = "CMB_MUNICIPIO";
            this.CMB_MUNICIPIO.Size = new System.Drawing.Size(182, 21);
            this.CMB_MUNICIPIO.TabIndex = 52;
            // 
            // TXT_NOMBRE_COMERCIAL
            // 
            this.TXT_NOMBRE_COMERCIAL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_NOMBRE_COMERCIAL.Location = new System.Drawing.Point(485, 389);
            this.TXT_NOMBRE_COMERCIAL.Name = "TXT_NOMBRE_COMERCIAL";
            this.TXT_NOMBRE_COMERCIAL.Size = new System.Drawing.Size(143, 20);
            this.TXT_NOMBRE_COMERCIAL.TabIndex = 53;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ALFA_ERP.Properties.Resources.FONDO_SUBMENUS;
            this.ClientSize = new System.Drawing.Size(668, 522);
            this.Controls.Add(this.TXT_NOMBRE_COMERCIAL);
            this.Controls.Add(this.CMB_MUNICIPIO);
            this.Controls.Add(this.CMB_ESTADO);
            this.Controls.Add(this.CMB_PAIS);
            this.Controls.Add(this.TXT_RAZON_SOCIAL);
            this.Controls.Add(this.TXT_CORREO);
            this.Controls.Add(this.TXT_TELEFONO);
            this.Controls.Add(this.TXT_RFC);
            this.Controls.Add(this.TXT_NUM_INT);
            this.Controls.Add(this.TXT_NUM_EXT);
            this.Controls.Add(this.TXT_COLONIA);
            this.Controls.Add(this.TXT_CP);
            this.Controls.Add(this.TXT_CALLE);
            this.Controls.Add(this.TXT_NOMBRE);
            this.Controls.Add(this.TXT_ID);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.DGV_CLIENTES);
            this.Controls.Add(this.LBL_CORREO);
            this.Controls.Add(this.LBL_TELEFONO);
            this.Controls.Add(this.LBL_MUNICIPIO);
            this.Controls.Add(this.LBL_ESTADO);
            this.Controls.Add(this.LBL_PAIS);
            this.Controls.Add(this.LBL_NUM_EXT);
            this.Controls.Add(this.LBL_CP);
            this.Controls.Add(this.LBL_COLONIA);
            this.Controls.Add(this.LBL_NUM_INT);
            this.Controls.Add(this.LBL_CALLE);
            this.Controls.Add(this.LBL_RFC);
            this.Controls.Add(this.LBL_NOM_COMERCIAL);
            this.Controls.Add(this.LBL_RS);
            this.Controls.Add(this.LBL_NOMBRE);
            this.Controls.Add(this.LBL_TITULO);
            this.Controls.Add(this.BTN_SALIR);
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BTN_SALIR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CLIENTES)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox BTN_SALIR;
        private System.Windows.Forms.Label LBL_TITULO;
        private System.Windows.Forms.Label LBL_NOMBRE;
        private System.Windows.Forms.Label LBL_RS;
        private System.Windows.Forms.Label LBL_NOM_COMERCIAL;
        private System.Windows.Forms.Label LBL_RFC;
        private System.Windows.Forms.Label LBL_CALLE;
        private System.Windows.Forms.Label LBL_NUM_INT;
        private System.Windows.Forms.Label LBL_COLONIA;
        private System.Windows.Forms.Label LBL_CP;
        private System.Windows.Forms.Label LBL_NUM_EXT;
        private System.Windows.Forms.Label LBL_PAIS;
        private System.Windows.Forms.Label LBL_ESTADO;
        private System.Windows.Forms.Label LBL_MUNICIPIO;
        private System.Windows.Forms.Label LBL_TELEFONO;
        private System.Windows.Forms.Label LBL_CORREO;
        private System.Windows.Forms.DataGridView DGV_CLIENTES;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox TXT_ID;
        private System.Windows.Forms.TextBox TXT_NOMBRE;
        private System.Windows.Forms.TextBox TXT_CALLE;
        private System.Windows.Forms.TextBox TXT_CP;
        private System.Windows.Forms.TextBox TXT_COLONIA;
        private System.Windows.Forms.TextBox TXT_NUM_EXT;
        private System.Windows.Forms.TextBox TXT_NUM_INT;
        private System.Windows.Forms.TextBox TXT_RFC;
        private System.Windows.Forms.TextBox TXT_TELEFONO;
        private System.Windows.Forms.TextBox TXT_CORREO;
        private System.Windows.Forms.TextBox TXT_RAZON_SOCIAL;
        private System.Windows.Forms.ComboBox CMB_PAIS;
        private System.Windows.Forms.ComboBox CMB_ESTADO;
        private System.Windows.Forms.ComboBox CMB_MUNICIPIO;
        private System.Windows.Forms.TextBox TXT_NOMBRE_COMERCIAL;
    }
}