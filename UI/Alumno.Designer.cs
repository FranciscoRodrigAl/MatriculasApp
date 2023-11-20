namespace UI
{
    partial class Alumno
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
            this.dtPickerNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbIdAlumno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCarrera = new System.Windows.Forms.TextBox();
            this.tbEstadoAcademico = new System.Windows.Forms.TextBox();
            this.dataGridAlumnos = new System.Windows.Forms.DataGridView();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.btnMostrarMatriculas = new System.Windows.Forms.Button();
            this.btCerrar = new System.Windows.Forms.Button();
            this.AlumnoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarreraActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoAcademico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtPickerNacimiento
            // 
            this.dtPickerNacimiento.Enabled = false;
            this.dtPickerNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickerNacimiento.Location = new System.Drawing.Point(127, 64);
            this.dtPickerNacimiento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtPickerNacimiento.Name = "dtPickerNacimiento";
            this.dtPickerNacimiento.Size = new System.Drawing.Size(127, 20);
            this.dtPickerNacimiento.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Estado Academico";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Fecha de Ingreso";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.tbIdAlumno);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtPickerNacimiento);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbCarrera);
            this.groupBox1.Controls.Add(this.tbEstadoAcademico);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(4, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(451, 211);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alumno";
            // 
            // tbIdAlumno
            // 
            this.tbIdAlumno.Enabled = false;
            this.tbIdAlumno.Location = new System.Drawing.Point(127, 33);
            this.tbIdAlumno.Name = "tbIdAlumno";
            this.tbIdAlumno.Size = new System.Drawing.Size(127, 20);
            this.tbIdAlumno.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Id Alumno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Carrera Actual";
            // 
            // tbCarrera
            // 
            this.tbCarrera.Enabled = false;
            this.tbCarrera.Location = new System.Drawing.Point(127, 94);
            this.tbCarrera.Name = "tbCarrera";
            this.tbCarrera.Size = new System.Drawing.Size(296, 20);
            this.tbCarrera.TabIndex = 12;
            // 
            // tbEstadoAcademico
            // 
            this.tbEstadoAcademico.Enabled = false;
            this.tbEstadoAcademico.Location = new System.Drawing.Point(127, 123);
            this.tbEstadoAcademico.Name = "tbEstadoAcademico";
            this.tbEstadoAcademico.Size = new System.Drawing.Size(296, 20);
            this.tbEstadoAcademico.TabIndex = 8;
            // 
            // dataGridAlumnos
            // 
            this.dataGridAlumnos.BackgroundColor = System.Drawing.Color.White;
            this.dataGridAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AlumnoId,
            this.FechaIngreso,
            this.CarreraActual,
            this.EstadoAcademico});
            this.dataGridAlumnos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridAlumnos.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dataGridAlumnos.Location = new System.Drawing.Point(4, 280);
            this.dataGridAlumnos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridAlumnos.MultiSelect = false;
            this.dataGridAlumnos.Name = "dataGridAlumnos";
            this.dataGridAlumnos.RowHeadersWidth = 51;
            this.dataGridAlumnos.RowTemplate.Height = 24;
            this.dataGridAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridAlumnos.Size = new System.Drawing.Size(750, 186);
            this.dataGridAlumnos.TabIndex = 2;
            this.dataGridAlumnos.SelectionChanged += new System.EventHandler(this.dataGridAlumnos_SelectionChanged);
            // 
            // btLimpiar
            // 
            this.btLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpiar.Image = global::UI.Properties.Resources.clean;
            this.btLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btLimpiar.Location = new System.Drawing.Point(505, 68);
            this.btLimpiar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btLimpiar.MaximumSize = new System.Drawing.Size(200, 29);
            this.btLimpiar.MinimumSize = new System.Drawing.Size(102, 29);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(146, 29);
            this.btLimpiar.TabIndex = 7;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // btnMostrarMatriculas
            // 
            this.btnMostrarMatriculas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarMatriculas.Image = global::UI.Properties.Resources.share;
            this.btnMostrarMatriculas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMostrarMatriculas.Location = new System.Drawing.Point(505, 27);
            this.btnMostrarMatriculas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMostrarMatriculas.MaximumSize = new System.Drawing.Size(200, 29);
            this.btnMostrarMatriculas.MinimumSize = new System.Drawing.Size(102, 29);
            this.btnMostrarMatriculas.Name = "btnMostrarMatriculas";
            this.btnMostrarMatriculas.Size = new System.Drawing.Size(146, 29);
            this.btnMostrarMatriculas.TabIndex = 5;
            this.btnMostrarMatriculas.Text = "Ver Matriculas";
            this.btnMostrarMatriculas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMostrarMatriculas.UseVisualStyleBackColor = true;
            this.btnMostrarMatriculas.Click += new System.EventHandler(this.btnMostrarMatriculas_Click);
            // 
            // btCerrar
            // 
            this.btCerrar.Image = global::UI.Properties.Resources.exit;
            this.btCerrar.Location = new System.Drawing.Point(794, 353);
            this.btCerrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(56, 60);
            this.btCerrar.TabIndex = 8;
            this.btCerrar.UseVisualStyleBackColor = true;
            this.btCerrar.Click += new System.EventHandler(this.btCerrar_Click);
            // 
            // AlumnoId
            // 
            this.AlumnoId.DataPropertyName = "AlumnoId";
            this.AlumnoId.HeaderText = "AlumnoId";
            this.AlumnoId.Name = "AlumnoId";
            // 
            // FechaIngreso
            // 
            this.FechaIngreso.DataPropertyName = "FechaIngreso";
            this.FechaIngreso.HeaderText = "Fecha de Ingreso";
            this.FechaIngreso.Name = "FechaIngreso";
            // 
            // CarreraActual
            // 
            this.CarreraActual.DataPropertyName = "CarreraActual";
            this.CarreraActual.HeaderText = "Carrera Actual";
            this.CarreraActual.Name = "CarreraActual";
            // 
            // EstadoAcademico
            // 
            this.EstadoAcademico.DataPropertyName = "EstadoAcademico";
            this.EstadoAcademico.HeaderText = "Estado Academico";
            this.EstadoAcademico.Name = "EstadoAcademico";
            // 
            // Alumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UI.Properties.Resources.logo_3;
            this.ClientSize = new System.Drawing.Size(893, 561);
            this.Controls.Add(this.btCerrar);
            this.Controls.Add(this.btLimpiar);
            this.Controls.Add(this.btnMostrarMatriculas);
            this.Controls.Add(this.dataGridAlumnos);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(909, 600);
            this.MinimumSize = new System.Drawing.Size(909, 600);
            this.Name = "Alumno";
            this.Text = "Alumno";
            this.Load += new System.EventHandler(this.Alumno_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlumnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtPickerNacimiento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbIdAlumno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCarrera;
        private System.Windows.Forms.TextBox tbEstadoAcademico;
        private System.Windows.Forms.DataGridView dataGridAlumnos;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Button btnMostrarMatriculas;
        private System.Windows.Forms.Button btCerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlumnoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarreraActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoAcademico;
    }
}