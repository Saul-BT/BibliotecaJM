namespace BibliotecaJM
{
    partial class FM_Devoluciones
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
            System.Windows.Forms.Label id_lecLabel;
            System.Windows.Forms.Label fecha_penalizacion_lecLabel;
            System.Windows.Forms.Label nombre_lecLabel;
            System.Windows.Forms.Label domicilio_lecLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bBuscarLibro = new System.Windows.Forms.Button();
            this.iddLibDev = new System.Windows.Forms.TextBox();
            this.idLibDev = new System.Windows.Forms.TextBox();
            this.autorLibDev = new System.Windows.Forms.TextBox();
            this.tituloLibDev = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nombreLecDev = new System.Windows.Forms.TextBox();
            this.iddLecDiv = new System.Windows.Forms.TextBox();
            this.idLecDev = new System.Windows.Forms.TextBox();
            this.fechs_penalizacionLecDev = new System.Windows.Forms.TextBox();
            this.domicilioLecDev = new System.Windows.Forms.TextBox();
            this.dS_LibrosPrestados = new BibliotecaJM.DS_LibrosPrestados();
            this.librosPrestadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.librosPrestadosTableAdapter = new BibliotecaJM.DS_LibrosPrestadosTableAdapters.LibrosPrestadosTableAdapter();
            this.librosPrestadosDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_lec_pre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            id_lecLabel = new System.Windows.Forms.Label();
            fecha_penalizacion_lecLabel = new System.Windows.Forms.Label();
            nombre_lecLabel = new System.Windows.Forms.Label();
            domicilio_lecLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS_LibrosPrestados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosPrestadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosPrestadosDataGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_lecLabel
            // 
            id_lecLabel.AutoSize = true;
            id_lecLabel.Location = new System.Drawing.Point(33, 38);
            id_lecLabel.Name = "id_lecLabel";
            id_lecLabel.Size = new System.Drawing.Size(59, 13);
            id_lecLabel.TabIndex = 1;
            id_lecLabel.Text = "Id del Libro";
            // 
            // fecha_penalizacion_lecLabel
            // 
            fecha_penalizacion_lecLabel.AutoSize = true;
            fecha_penalizacion_lecLabel.Location = new System.Drawing.Point(57, 117);
            fecha_penalizacion_lecLabel.Name = "fecha_penalizacion_lecLabel";
            fecha_penalizacion_lecLabel.Size = new System.Drawing.Size(32, 13);
            fecha_penalizacion_lecLabel.TabIndex = 7;
            fecha_penalizacion_lecLabel.Text = "Autor";
            // 
            // nombre_lecLabel
            // 
            nombre_lecLabel.AutoSize = true;
            nombre_lecLabel.Location = new System.Drawing.Point(50, 64);
            nombre_lecLabel.Name = "nombre_lecLabel";
            nombre_lecLabel.Size = new System.Drawing.Size(42, 13);
            nombre_lecLabel.TabIndex = 3;
            nombre_lecLabel.Text = "Id Libro";
            // 
            // domicilio_lecLabel
            // 
            domicilio_lecLabel.AutoSize = true;
            domicilio_lecLabel.Location = new System.Drawing.Point(57, 90);
            domicilio_lecLabel.Name = "domicilio_lecLabel";
            domicilio_lecLabel.Size = new System.Drawing.Size(35, 13);
            domicilio_lecLabel.TabIndex = 5;
            domicilio_lecLabel.Text = "Título";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(21, 33);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(35, 13);
            label1.TabIndex = 1;
            label1.Text = "id lec:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(21, 136);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(116, 13);
            label2.TabIndex = 7;
            label2.Text = "fecha penalizacion lec:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(21, 83);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(62, 13);
            label3.TabIndex = 3;
            label3.Text = "nombre lec:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(21, 109);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(67, 13);
            label4.TabIndex = 5;
            label4.Text = "domicilio lec:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(21, 57);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(35, 13);
            label5.TabIndex = 1;
            label5.Text = "id lec:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bBuscarLibro);
            this.groupBox1.Controls.Add(this.iddLibDev);
            this.groupBox1.Controls.Add(id_lecLabel);
            this.groupBox1.Controls.Add(this.idLibDev);
            this.groupBox1.Controls.Add(fecha_penalizacion_lecLabel);
            this.groupBox1.Controls.Add(nombre_lecLabel);
            this.groupBox1.Controls.Add(this.autorLibDev);
            this.groupBox1.Controls.Add(this.tituloLibDev);
            this.groupBox1.Controls.Add(domicilio_lecLabel);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(27, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 172);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búsqueda del libro";
            // 
            // bBuscarLibro
            // 
            this.bBuscarLibro.Location = new System.Drawing.Point(421, 33);
            this.bBuscarLibro.Name = "bBuscarLibro";
            this.bBuscarLibro.Size = new System.Drawing.Size(75, 23);
            this.bBuscarLibro.TabIndex = 9;
            this.bBuscarLibro.Text = "Buscar";
            this.bBuscarLibro.UseVisualStyleBackColor = true;
            // 
            // iddLibDev
            // 
            this.iddLibDev.Location = new System.Drawing.Point(128, 61);
            this.iddLibDev.Name = "iddLibDev";
            this.iddLibDev.Size = new System.Drawing.Size(263, 20);
            this.iddLibDev.TabIndex = 4;
            // 
            // idLibDev
            // 
            this.idLibDev.Location = new System.Drawing.Point(128, 35);
            this.idLibDev.Name = "idLibDev";
            this.idLibDev.Size = new System.Drawing.Size(263, 20);
            this.idLibDev.TabIndex = 2;
            // 
            // autorLibDev
            // 
            this.autorLibDev.Location = new System.Drawing.Point(128, 114);
            this.autorLibDev.Name = "autorLibDev";
            this.autorLibDev.Size = new System.Drawing.Size(263, 20);
            this.autorLibDev.TabIndex = 6;
            // 
            // tituloLibDev
            // 
            this.tituloLibDev.Location = new System.Drawing.Point(128, 87);
            this.tituloLibDev.Name = "tituloLibDev";
            this.tituloLibDev.Size = new System.Drawing.Size(263, 20);
            this.tituloLibDev.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nombreLecDev);
            this.groupBox2.Controls.Add(label5);
            this.groupBox2.Controls.Add(label1);
            this.groupBox2.Controls.Add(this.iddLecDiv);
            this.groupBox2.Controls.Add(this.idLecDev);
            this.groupBox2.Controls.Add(label2);
            this.groupBox2.Controls.Add(label3);
            this.groupBox2.Controls.Add(this.fechs_penalizacionLecDev);
            this.groupBox2.Controls.Add(this.domicilioLecDev);
            this.groupBox2.Controls.Add(label4);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(546, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(441, 172);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Búsqueda del lector";
            // 
            // nombreLecDev
            // 
            this.nombreLecDev.Location = new System.Drawing.Point(143, 80);
            this.nombreLecDev.Name = "nombreLecDev";
            this.nombreLecDev.Size = new System.Drawing.Size(263, 20);
            this.nombreLecDev.TabIndex = 4;
            // 
            // iddLecDiv
            // 
            this.iddLecDiv.Location = new System.Drawing.Point(143, 54);
            this.iddLecDiv.Name = "iddLecDiv";
            this.iddLecDiv.Size = new System.Drawing.Size(263, 20);
            this.iddLecDiv.TabIndex = 2;
            // 
            // idLecDev
            // 
            this.idLecDev.Location = new System.Drawing.Point(143, 30);
            this.idLecDev.Name = "idLecDev";
            this.idLecDev.Size = new System.Drawing.Size(263, 20);
            this.idLecDev.TabIndex = 2;
            // 
            // fechs_penalizacionLecDev
            // 
            this.fechs_penalizacionLecDev.Location = new System.Drawing.Point(143, 133);
            this.fechs_penalizacionLecDev.Name = "fechs_penalizacionLecDev";
            this.fechs_penalizacionLecDev.Size = new System.Drawing.Size(263, 20);
            this.fechs_penalizacionLecDev.TabIndex = 6;
            // 
            // domicilioLecDev
            // 
            this.domicilioLecDev.Location = new System.Drawing.Point(143, 106);
            this.domicilioLecDev.Name = "domicilioLecDev";
            this.domicilioLecDev.Size = new System.Drawing.Size(263, 20);
            this.domicilioLecDev.TabIndex = 6;
            // 
            // dS_LibrosPrestados
            // 
            this.dS_LibrosPrestados.DataSetName = "DS_LibrosPrestados";
            this.dS_LibrosPrestados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // librosPrestadosBindingSource
            // 
            this.librosPrestadosBindingSource.DataMember = "LibrosPrestados";
            this.librosPrestadosBindingSource.DataSource = this.dS_LibrosPrestados;
            // 
            // librosPrestadosTableAdapter
            // 
            this.librosPrestadosTableAdapter.ClearBeforeFill = true;
            // 
            // librosPrestadosDataGridView
            // 
            this.librosPrestadosDataGridView.AllowUserToAddRows = false;
            this.librosPrestadosDataGridView.AllowUserToDeleteRows = false;
            this.librosPrestadosDataGridView.AutoGenerateColumns = false;
            this.librosPrestadosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.librosPrestadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.librosPrestadosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.id_lec_pre,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Column1});
            this.librosPrestadosDataGridView.DataSource = this.librosPrestadosBindingSource;
            this.librosPrestadosDataGridView.Location = new System.Drawing.Point(6, 19);
            this.librosPrestadosDataGridView.Name = "librosPrestadosDataGridView";
            this.librosPrestadosDataGridView.ReadOnly = true;
            this.librosPrestadosDataGridView.Size = new System.Drawing.Size(948, 363);
            this.librosPrestadosDataGridView.TabIndex = 18;
            this.librosPrestadosDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.librosPrestadosDataGridView_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.librosPrestadosDataGridView);
            this.groupBox3.Location = new System.Drawing.Point(27, 278);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(960, 388);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_lib";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_lib";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // id_lec_pre
            // 
            this.id_lec_pre.DataPropertyName = "id_lec_pre";
            this.id_lec_pre.HeaderText = "id_lec_pre";
            this.id_lec_pre.Name = "id_lec_pre";
            this.id_lec_pre.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "titulo_lib";
            this.dataGridViewTextBoxColumn2.HeaderText = "titulo_lib";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "fecha_presta_pre";
            this.dataGridViewTextBoxColumn3.HeaderText = "fecha_presta_pre";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "fecha_devol_pre";
            this.dataGridViewTextBoxColumn4.HeaderText = "fecha_devol_pre";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Text = "Realizar la devolución";
            this.Column1.UseColumnTextForButtonValue = true;
            // 
            // FM_Devoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1010, 700);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FM_Devoluciones";
            this.Load += new System.EventHandler(this.FM_Devoluciones_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS_LibrosPrestados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosPrestadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosPrestadosDataGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox iddLibDev;
        private System.Windows.Forms.TextBox idLibDev;
        private System.Windows.Forms.TextBox tituloLibDev;
        private System.Windows.Forms.Button bBuscarLibro;
        private System.Windows.Forms.TextBox autorLibDev;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox nombreLecDev;
        private System.Windows.Forms.TextBox iddLecDiv;
        private System.Windows.Forms.TextBox idLecDev;
        private System.Windows.Forms.TextBox fechs_penalizacionLecDev;
        private System.Windows.Forms.TextBox domicilioLecDev;
        private DS_LibrosPrestados dS_LibrosPrestados;
        private System.Windows.Forms.BindingSource librosPrestadosBindingSource;
        private DS_LibrosPrestadosTableAdapters.LibrosPrestadosTableAdapter librosPrestadosTableAdapter;
        private System.Windows.Forms.DataGridView librosPrestadosDataGridView;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_lec_pre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
    }
}
