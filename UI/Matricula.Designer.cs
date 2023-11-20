namespace UI
{
    partial class Matricula
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbAnio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtPickerIngreso = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.tbCarrera = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSegmento = new System.Windows.Forms.TextBox();
            this.dataGridMatriculas = new System.Windows.Forms.DataGridView();
            this.btnLimpiarMatricula = new System.Windows.Forms.Button();
            this.btnGuardarMatricula = new System.Windows.Forms.Button();
            this.btCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAlumnoId = new System.Windows.Forms.TextBox();
            this.btSelectEdit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMatriculas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.tbAlumnoId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbAnio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtPickerIngreso);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbCodigo);
            this.groupBox1.Controls.Add(this.tbCarrera);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbSegmento);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(16, 24);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(464, 237);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Matricula";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Año Matricula";
            // 
            // tbAnio
            // 
            this.tbAnio.Location = new System.Drawing.Point(134, 172);
            this.tbAnio.Name = "tbAnio";
            this.tbAnio.Size = new System.Drawing.Size(84, 20);
            this.tbAnio.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Codigo";
            // 
            // dtPickerIngreso
            // 
            this.dtPickerIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickerIngreso.Location = new System.Drawing.Point(134, 90);
            this.dtPickerIngreso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtPickerIngreso.Name = "dtPickerIngreso";
            this.dtPickerIngreso.Size = new System.Drawing.Size(174, 20);
            this.dtPickerIngreso.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Segmento Academico";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Carrera";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(134, 120);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(174, 20);
            this.tbCodigo.TabIndex = 12;
            // 
            // tbCarrera
            // 
            this.tbCarrera.Location = new System.Drawing.Point(134, 146);
            this.tbCarrera.Name = "tbCarrera";
            this.tbCarrera.Size = new System.Drawing.Size(296, 20);
            this.tbCarrera.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Fecha de Ingreso";
            // 
            // tbSegmento
            // 
            this.tbSegmento.Location = new System.Drawing.Point(134, 203);
            this.tbSegmento.Name = "tbSegmento";
            this.tbSegmento.Size = new System.Drawing.Size(296, 20);
            this.tbSegmento.TabIndex = 9;
            // 
            // dataGridMatriculas
            // 
            this.dataGridMatriculas.BackgroundColor = System.Drawing.Color.White;
            this.dataGridMatriculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMatriculas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridMatriculas.Location = new System.Drawing.Point(16, 293);
            this.dataGridMatriculas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridMatriculas.MultiSelect = false;
            this.dataGridMatriculas.Name = "dataGridMatriculas";
            this.dataGridMatriculas.RowHeadersWidth = 51;
            this.dataGridMatriculas.RowTemplate.Height = 24;
            this.dataGridMatriculas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridMatriculas.Size = new System.Drawing.Size(734, 211);
            this.dataGridMatriculas.TabIndex = 3;
            this.dataGridMatriculas.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridMatriculas_DataBindingComplete);
            this.dataGridMatriculas.SelectionChanged += new System.EventHandler(this.dataGridMatriculas_SelectionChanged);
            // 
            // btnLimpiarMatricula
            // 
            this.btnLimpiarMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarMatricula.Image = global::UI.Properties.Resources.clean;
            this.btnLimpiarMatricula.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarMatricula.Location = new System.Drawing.Point(497, 79);
            this.btnLimpiarMatricula.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimpiarMatricula.MaximumSize = new System.Drawing.Size(102, 29);
            this.btnLimpiarMatricula.MinimumSize = new System.Drawing.Size(102, 29);
            this.btnLimpiarMatricula.Name = "btnLimpiarMatricula";
            this.btnLimpiarMatricula.Size = new System.Drawing.Size(102, 29);
            this.btnLimpiarMatricula.TabIndex = 7;
            this.btnLimpiarMatricula.Text = "Limpiar";
            this.btnLimpiarMatricula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarMatricula.UseVisualStyleBackColor = true;
            this.btnLimpiarMatricula.Click += new System.EventHandler(this.btnLimpiarMatricula_Click);
            // 
            // btnGuardarMatricula
            // 
            this.btnGuardarMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarMatricula.Image = global::UI.Properties.Resources.save;
            this.btnGuardarMatricula.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarMatricula.Location = new System.Drawing.Point(497, 33);
            this.btnGuardarMatricula.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGuardarMatricula.MaximumSize = new System.Drawing.Size(102, 29);
            this.btnGuardarMatricula.MinimumSize = new System.Drawing.Size(102, 29);
            this.btnGuardarMatricula.Name = "btnGuardarMatricula";
            this.btnGuardarMatricula.Size = new System.Drawing.Size(102, 29);
            this.btnGuardarMatricula.TabIndex = 6;
            this.btnGuardarMatricula.Text = "Guardar";
            this.btnGuardarMatricula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarMatricula.UseVisualStyleBackColor = true;
            this.btnGuardarMatricula.Click += new System.EventHandler(this.btnGuardarMatricula_Click);
            // 
            // btCerrar
            // 
            this.btCerrar.Image = global::UI.Properties.Resources.exit;
            this.btCerrar.Location = new System.Drawing.Point(810, 370);
            this.btCerrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(56, 60);
            this.btCerrar.TabIndex = 8;
            this.btCerrar.UseVisualStyleBackColor = true;
            this.btCerrar.Click += new System.EventHandler(this.btCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Id Alumno";
            // 
            // tbAlumnoId
            // 
            this.tbAlumnoId.Enabled = false;
            this.tbAlumnoId.Location = new System.Drawing.Point(134, 25);
            this.tbAlumnoId.Name = "tbAlumnoId";
            this.tbAlumnoId.Size = new System.Drawing.Size(174, 20);
            this.tbAlumnoId.TabIndex = 25;
            // 
            // btSelectEdit
            // 
            this.btSelectEdit.Location = new System.Drawing.Point(779, 293);
            this.btSelectEdit.MinimumSize = new System.Drawing.Size(0, 29);
            this.btSelectEdit.Name = "btSelectEdit";
            this.btSelectEdit.Size = new System.Drawing.Size(102, 29);
            this.btSelectEdit.TabIndex = 9;
            this.btSelectEdit.Text = "Seleccionar";
            this.btSelectEdit.UseVisualStyleBackColor = true;
            this.btSelectEdit.Click += new System.EventHandler(this.btSelectEdit_Click);
            // 
            // Matricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UI.Properties.Resources.logo_3;
            this.ClientSize = new System.Drawing.Size(893, 561);
            this.Controls.Add(this.btSelectEdit);
            this.Controls.Add(this.btCerrar);
            this.Controls.Add(this.btnLimpiarMatricula);
            this.Controls.Add(this.btnGuardarMatricula);
            this.Controls.Add(this.dataGridMatriculas);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(909, 600);
            this.MinimumSize = new System.Drawing.Size(909, 600);
            this.Name = "Matricula";
            this.Text = "Matricula";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMatriculas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtPickerIngreso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.TextBox tbCarrera;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSegmento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbAnio;
        private System.Windows.Forms.DataGridView dataGridMatriculas;
        private System.Windows.Forms.Button btnLimpiarMatricula;
        private System.Windows.Forms.Button btnGuardarMatricula;
        private System.Windows.Forms.Button btCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAlumnoId;
        private System.Windows.Forms.Button btSelectEdit;
    }
}