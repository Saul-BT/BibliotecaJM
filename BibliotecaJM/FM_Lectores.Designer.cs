namespace BibliotecaJM
{
    partial class FM_Lectores
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nombre_lecLabel;
            System.Windows.Forms.Label domicilio_lecLabel;
            System.Windows.Forms.Label provincia_lecLabel;
            System.Windows.Forms.Label email_lecLabel;
            System.Windows.Forms.Label fecha_nacimiento_lecLabel;
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbBusqueda = new System.Windows.Forms.GroupBox();
            this.lectoresDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lectoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Lectores = new BibliotecaJM.DS_Lectores();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BBuscarNombre = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbBuscarId = new System.Windows.Forms.TextBox();
            this.bBuscarId = new System.Windows.Forms.Button();
            this.tbBuscarNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.bNuevo = new System.Windows.Forms.Button();
            this.bEliminar = new System.Windows.Forms.Button();
            this.bModificar = new System.Windows.Forms.Button();
            this.gbEdicion = new System.Windows.Forms.GroupBox();
            this.provincia_nombre_lecTextBox = new System.Windows.Forms.TextBox();
            this.bAssistProvincia = new System.Windows.Forms.Button();
            this.nombre_lecTextBox = new System.Windows.Forms.TextBox();
            this.domicilio_lecTextBox = new System.Windows.Forms.TextBox();
            this.provincia_lecTextBox = new System.Windows.Forms.TextBox();
            this.email_lecTextBox = new System.Windows.Forms.TextBox();
            this.fecha_nacimiento_lecDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bAceptar = new System.Windows.Forms.Button();
            this.lectoresTableAdapter = new BibliotecaJM.DS_LectoresTableAdapters.lectoresTableAdapter();
            this.tableAdapterManager = new BibliotecaJM.DS_LectoresTableAdapters.TableAdapterManager();
            this.dS_Provincias = new BibliotecaJM.DS_Provincias();
            this.provinciasTableAdapter = new BibliotecaJM.DS_ProvinciasTableAdapters.provinciasTableAdapter();
            nombre_lecLabel = new System.Windows.Forms.Label();
            domicilio_lecLabel = new System.Windows.Forms.Label();
            provincia_lecLabel = new System.Windows.Forms.Label();
            email_lecLabel = new System.Windows.Forms.Label();
            fecha_nacimiento_lecLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Lectores)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.gbEdicion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Provincias)).BeginInit();
            this.SuspendLayout();
            // 
            // nombre_lecLabel
            // 
            nombre_lecLabel.AutoSize = true;
            nombre_lecLabel.Location = new System.Drawing.Point(29, 40);
            nombre_lecLabel.Name = "nombre_lecLabel";
            nombre_lecLabel.Size = new System.Drawing.Size(62, 13);
            nombre_lecLabel.TabIndex = 10;
            nombre_lecLabel.Text = "nombre lec:";
            // 
            // domicilio_lecLabel
            // 
            domicilio_lecLabel.AutoSize = true;
            domicilio_lecLabel.Location = new System.Drawing.Point(29, 66);
            domicilio_lecLabel.Name = "domicilio_lecLabel";
            domicilio_lecLabel.Size = new System.Drawing.Size(67, 13);
            domicilio_lecLabel.TabIndex = 12;
            domicilio_lecLabel.Text = "domicilio lec:";
            // 
            // provincia_lecLabel
            // 
            provincia_lecLabel.AutoSize = true;
            provincia_lecLabel.Location = new System.Drawing.Point(29, 92);
            provincia_lecLabel.Name = "provincia_lecLabel";
            provincia_lecLabel.Size = new System.Drawing.Size(70, 13);
            provincia_lecLabel.TabIndex = 14;
            provincia_lecLabel.Text = "provincia lec:";
            // 
            // email_lecLabel
            // 
            email_lecLabel.AutoSize = true;
            email_lecLabel.Location = new System.Drawing.Point(29, 118);
            email_lecLabel.Name = "email_lecLabel";
            email_lecLabel.Size = new System.Drawing.Size(51, 13);
            email_lecLabel.TabIndex = 16;
            email_lecLabel.Text = "email lec:";
            // 
            // fecha_nacimiento_lecLabel
            // 
            fecha_nacimiento_lecLabel.AutoSize = true;
            fecha_nacimiento_lecLabel.Location = new System.Drawing.Point(29, 145);
            fecha_nacimiento_lecLabel.Name = "fecha_nacimiento_lecLabel";
            fecha_nacimiento_lecLabel.Size = new System.Drawing.Size(108, 13);
            fecha_nacimiento_lecLabel.TabIndex = 18;
            fecha_nacimiento_lecLabel.Text = "fecha nacimiento lec:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gbBusqueda, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbEdicion, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1010, 700);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // gbBusqueda
            // 
            this.gbBusqueda.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbBusqueda.Controls.Add(this.lectoresDataGridView);
            this.gbBusqueda.Controls.Add(this.panel1);
            this.gbBusqueda.Controls.Add(this.tableLayoutPanel2);
            this.gbBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbBusqueda.Location = new System.Drawing.Point(3, 3);
            this.gbBusqueda.Name = "gbBusqueda";
            this.gbBusqueda.Size = new System.Drawing.Size(499, 694);
            this.gbBusqueda.TabIndex = 0;
            this.gbBusqueda.TabStop = false;
            this.gbBusqueda.Text = "Buscar lector";
            // 
            // lectoresDataGridView
            // 
            this.lectoresDataGridView.AutoGenerateColumns = false;
            this.lectoresDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lectoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lectoresDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.lectoresDataGridView.DataSource = this.lectoresBindingSource;
            this.lectoresDataGridView.Location = new System.Drawing.Point(6, 134);
            this.lectoresDataGridView.Name = "lectoresDataGridView";
            this.lectoresDataGridView.ReadOnly = true;
            this.lectoresDataGridView.RowHeadersVisible = false;
            this.lectoresDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lectoresDataGridView.Size = new System.Drawing.Size(487, 461);
            this.lectoresDataGridView.TabIndex = 9;
            this.lectoresDataGridView.CurrentCellChanged += new System.EventHandler(this.lectoresDataGridView_CurrentCellChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_lec";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_lec";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre_lec";
            this.dataGridViewTextBoxColumn2.HeaderText = "nombre_lec";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // lectoresBindingSource
            // 
            this.lectoresBindingSource.DataMember = "lectores";
            this.lectoresBindingSource.DataSource = this.dS_Lectores;
            // 
            // dS_Lectores
            // 
            this.dS_Lectores.DataSetName = "DS_Lectores";
            this.dS_Lectores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BBuscarNombre);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbBuscarId);
            this.panel1.Controls.Add(this.bBuscarId);
            this.panel1.Controls.Add(this.tbBuscarNombre);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 100);
            this.panel1.TabIndex = 9;
            // 
            // BBuscarNombre
            // 
            this.BBuscarNombre.Location = new System.Drawing.Point(269, 50);
            this.BBuscarNombre.Name = "BBuscarNombre";
            this.BBuscarNombre.Size = new System.Drawing.Size(75, 23);
            this.BBuscarNombre.TabIndex = 6;
            this.BBuscarNombre.Text = "BUSCAR";
            this.BBuscarNombre.UseVisualStyleBackColor = true;
            this.BBuscarNombre.Click += new System.EventHandler(this.BBuscarNombre_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // tbBuscarId
            // 
            this.tbBuscarId.Location = new System.Drawing.Point(119, 26);
            this.tbBuscarId.Name = "tbBuscarId";
            this.tbBuscarId.Size = new System.Drawing.Size(131, 20);
            this.tbBuscarId.TabIndex = 2;
            // 
            // bBuscarId
            // 
            this.bBuscarId.Location = new System.Drawing.Point(269, 24);
            this.bBuscarId.Name = "bBuscarId";
            this.bBuscarId.Size = new System.Drawing.Size(75, 23);
            this.bBuscarId.TabIndex = 5;
            this.bBuscarId.Text = "BUSCAR";
            this.bBuscarId.UseVisualStyleBackColor = true;
            this.bBuscarId.Click += new System.EventHandler(this.bBuscarId_Click);
            // 
            // tbBuscarNombre
            // 
            this.tbBuscarNombre.Location = new System.Drawing.Point(119, 52);
            this.tbBuscarNombre.Name = "tbBuscarNombre";
            this.tbBuscarNombre.Size = new System.Drawing.Size(131, 20);
            this.tbBuscarNombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.bNuevo, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.bEliminar, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.bModificar, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 662);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(493, 29);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // bNuevo
            // 
            this.bNuevo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bNuevo.Location = new System.Drawing.Point(3, 3);
            this.bNuevo.Name = "bNuevo";
            this.bNuevo.Size = new System.Drawing.Size(158, 23);
            this.bNuevo.TabIndex = 7;
            this.bNuevo.Text = "NUEVO";
            this.bNuevo.UseVisualStyleBackColor = true;
            this.bNuevo.Click += new System.EventHandler(this.bNuevo_Click);
            // 
            // bEliminar
            // 
            this.bEliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bEliminar.Location = new System.Drawing.Point(331, 3);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(159, 23);
            this.bEliminar.TabIndex = 7;
            this.bEliminar.Text = "ELIMINAR";
            this.bEliminar.UseVisualStyleBackColor = true;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // bModificar
            // 
            this.bModificar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bModificar.Location = new System.Drawing.Point(167, 3);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(158, 23);
            this.bModificar.TabIndex = 7;
            this.bModificar.Text = "MODIFICAR";
            this.bModificar.UseVisualStyleBackColor = true;
            this.bModificar.Click += new System.EventHandler(this.bModificar_Click);
            // 
            // gbEdicion
            // 
            this.gbEdicion.AutoSize = true;
            this.gbEdicion.Controls.Add(this.provincia_nombre_lecTextBox);
            this.gbEdicion.Controls.Add(this.bAssistProvincia);
            this.gbEdicion.Controls.Add(nombre_lecLabel);
            this.gbEdicion.Controls.Add(this.nombre_lecTextBox);
            this.gbEdicion.Controls.Add(domicilio_lecLabel);
            this.gbEdicion.Controls.Add(this.domicilio_lecTextBox);
            this.gbEdicion.Controls.Add(provincia_lecLabel);
            this.gbEdicion.Controls.Add(this.provincia_lecTextBox);
            this.gbEdicion.Controls.Add(email_lecLabel);
            this.gbEdicion.Controls.Add(this.email_lecTextBox);
            this.gbEdicion.Controls.Add(fecha_nacimiento_lecLabel);
            this.gbEdicion.Controls.Add(this.fecha_nacimiento_lecDateTimePicker);
            this.gbEdicion.Controls.Add(this.bCancelar);
            this.gbEdicion.Controls.Add(this.bAceptar);
            this.gbEdicion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbEdicion.Location = new System.Drawing.Point(508, 3);
            this.gbEdicion.Name = "gbEdicion";
            this.gbEdicion.Size = new System.Drawing.Size(499, 694);
            this.gbEdicion.TabIndex = 1;
            this.gbEdicion.TabStop = false;
            this.gbEdicion.Text = "Detalle";
            // 
            // provincia_nombre_lecTextBox
            // 
            this.provincia_nombre_lecTextBox.Location = new System.Drawing.Point(189, 89);
            this.provincia_nombre_lecTextBox.Name = "provincia_nombre_lecTextBox";
            this.provincia_nombre_lecTextBox.ReadOnly = true;
            this.provincia_nombre_lecTextBox.Size = new System.Drawing.Size(242, 20);
            this.provincia_nombre_lecTextBox.TabIndex = 21;
            // 
            // bAssistProvincia
            // 
            this.bAssistProvincia.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bAssistProvincia.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAssistProvincia.Location = new System.Drawing.Point(437, 89);
            this.bAssistProvincia.Name = "bAssistProvincia";
            this.bAssistProvincia.Size = new System.Drawing.Size(33, 20);
            this.bAssistProvincia.TabIndex = 20;
            this.bAssistProvincia.Text = "...";
            this.bAssistProvincia.UseVisualStyleBackColor = false;
            this.bAssistProvincia.Click += new System.EventHandler(this.bAssistProvincia_Click);
            // 
            // nombre_lecTextBox
            // 
            this.nombre_lecTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "nombre_lec", true));
            this.nombre_lecTextBox.Location = new System.Drawing.Point(151, 37);
            this.nombre_lecTextBox.Name = "nombre_lecTextBox";
            this.nombre_lecTextBox.Size = new System.Drawing.Size(319, 20);
            this.nombre_lecTextBox.TabIndex = 11;
            // 
            // domicilio_lecTextBox
            // 
            this.domicilio_lecTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "domicilio_lec", true));
            this.domicilio_lecTextBox.Location = new System.Drawing.Point(151, 63);
            this.domicilio_lecTextBox.Name = "domicilio_lecTextBox";
            this.domicilio_lecTextBox.Size = new System.Drawing.Size(319, 20);
            this.domicilio_lecTextBox.TabIndex = 13;
            // 
            // provincia_lecTextBox
            // 
            this.provincia_lecTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "provincia_lec", true));
            this.provincia_lecTextBox.Location = new System.Drawing.Point(151, 89);
            this.provincia_lecTextBox.Name = "provincia_lecTextBox";
            this.provincia_lecTextBox.ReadOnly = true;
            this.provincia_lecTextBox.Size = new System.Drawing.Size(32, 20);
            this.provincia_lecTextBox.TabIndex = 15;
            // 
            // email_lecTextBox
            // 
            this.email_lecTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "email_lec", true));
            this.email_lecTextBox.Location = new System.Drawing.Point(151, 115);
            this.email_lecTextBox.Name = "email_lecTextBox";
            this.email_lecTextBox.Size = new System.Drawing.Size(319, 20);
            this.email_lecTextBox.TabIndex = 17;
            // 
            // fecha_nacimiento_lecDateTimePicker
            // 
            this.fecha_nacimiento_lecDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.lectoresBindingSource, "fecha_nacimiento_lec", true));
            this.fecha_nacimiento_lecDateTimePicker.Location = new System.Drawing.Point(151, 141);
            this.fecha_nacimiento_lecDateTimePicker.Name = "fecha_nacimiento_lecDateTimePicker";
            this.fecha_nacimiento_lecDateTimePicker.Size = new System.Drawing.Size(319, 20);
            this.fecha_nacimiento_lecDateTimePicker.TabIndex = 19;
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(32, 191);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(220, 474);
            this.bCancelar.TabIndex = 8;
            this.bCancelar.Text = "CANCELAR";
            this.bCancelar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(258, 191);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(212, 474);
            this.bAceptar.TabIndex = 8;
            this.bAceptar.Text = "ACEPTAR";
            this.bAceptar.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // lectoresTableAdapter
            // 
            this.lectoresTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.lectoresTableAdapter = this.lectoresTableAdapter;
            this.tableAdapterManager.UpdateOrder = BibliotecaJM.DS_LectoresTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dS_Provincias
            // 
            this.dS_Provincias.DataSetName = "DS_Provincias";
            this.dS_Provincias.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // provinciasTableAdapter
            // 
            this.provinciasTableAdapter.ClearBeforeFill = true;
            // 
            // FM_Lectores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1010, 700);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FM_Lectores";
            this.Load += new System.EventHandler(this.FM_Lectores_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.gbBusqueda.ResumeLayout(false);
            this.gbBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Lectores)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.gbEdicion.ResumeLayout(false);
            this.gbEdicion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Provincias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbBusqueda;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BBuscarNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBuscarId;
        private System.Windows.Forms.Button bBuscarId;
        private System.Windows.Forms.TextBox tbBuscarNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button bNuevo;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.Button bModificar;
        private System.Windows.Forms.GroupBox gbEdicion;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bAceptar;
        private DS_Lectores dS_Lectores;
        private System.Windows.Forms.BindingSource lectoresBindingSource;
        private DS_LectoresTableAdapters.lectoresTableAdapter lectoresTableAdapter;
        private System.Windows.Forms.DataGridView lectoresDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DS_LectoresTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nombre_lecTextBox;
        private System.Windows.Forms.TextBox domicilio_lecTextBox;
        private System.Windows.Forms.TextBox provincia_lecTextBox;
        private System.Windows.Forms.TextBox email_lecTextBox;
        private System.Windows.Forms.DateTimePicker fecha_nacimiento_lecDateTimePicker;
        private System.Windows.Forms.TextBox provincia_nombre_lecTextBox;
        private System.Windows.Forms.Button bAssistProvincia;
        private DS_Provincias dS_Provincias;
        private DS_ProvinciasTableAdapters.provinciasTableAdapter provinciasTableAdapter;
    }
}
