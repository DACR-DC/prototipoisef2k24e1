
namespace CapaVistaPrototipo.Procesos
{
    partial class frmEliminacionAlumnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEliminacionAlumnos));
            this.dgv_eliminacion = new System.Windows.Forms.DataGridView();
            this.cb_Curso = new System.Windows.Forms.ComboBox();
            this.cb_aula = new System.Windows.Forms.ComboBox();
            this.cb_Seccion = new System.Windows.Forms.ComboBox();
            this.cb_Jornada = new System.Windows.Forms.ComboBox();
            this.cb_Sede = new System.Windows.Forms.ComboBox();
            this.cb_Carrera = new System.Windows.Forms.ComboBox();
            this.txt_carnetAlumno = new System.Windows.Forms.TextBox();
            this.txt_NotaCurso = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_refrescar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_ayudas = new System.Windows.Forms.Button();
            this.btn_reporte = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_eliminacion)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_eliminacion
            // 
            this.dgv_eliminacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_eliminacion.Location = new System.Drawing.Point(23, 473);
            this.dgv_eliminacion.Name = "dgv_eliminacion";
            this.dgv_eliminacion.RowHeadersWidth = 51;
            this.dgv_eliminacion.RowTemplate.Height = 24;
            this.dgv_eliminacion.Size = new System.Drawing.Size(755, 179);
            this.dgv_eliminacion.TabIndex = 69;
            this.dgv_eliminacion.Tag = "asignacioncursosalumnos";
            // 
            // cb_Curso
            // 
            this.cb_Curso.FormattingEnabled = true;
            this.cb_Curso.Location = new System.Drawing.Point(496, 295);
            this.cb_Curso.Name = "cb_Curso";
            this.cb_Curso.Size = new System.Drawing.Size(172, 24);
            this.cb_Curso.TabIndex = 68;
            this.cb_Curso.Tag = "codigo_curso";
            // 
            // cb_aula
            // 
            this.cb_aula.FormattingEnabled = true;
            this.cb_aula.Location = new System.Drawing.Point(496, 236);
            this.cb_aula.Name = "cb_aula";
            this.cb_aula.Size = new System.Drawing.Size(172, 24);
            this.cb_aula.TabIndex = 67;
            this.cb_aula.Tag = "codigo_aula";
            // 
            // cb_Seccion
            // 
            this.cb_Seccion.FormattingEnabled = true;
            this.cb_Seccion.Location = new System.Drawing.Point(154, 405);
            this.cb_Seccion.Name = "cb_Seccion";
            this.cb_Seccion.Size = new System.Drawing.Size(178, 24);
            this.cb_Seccion.TabIndex = 66;
            this.cb_Seccion.Tag = "codigo_seccion";
            // 
            // cb_Jornada
            // 
            this.cb_Jornada.FormattingEnabled = true;
            this.cb_Jornada.Location = new System.Drawing.Point(154, 347);
            this.cb_Jornada.Name = "cb_Jornada";
            this.cb_Jornada.Size = new System.Drawing.Size(178, 24);
            this.cb_Jornada.TabIndex = 65;
            this.cb_Jornada.Tag = "codigo_jornada";
            // 
            // cb_Sede
            // 
            this.cb_Sede.FormattingEnabled = true;
            this.cb_Sede.Location = new System.Drawing.Point(154, 293);
            this.cb_Sede.Name = "cb_Sede";
            this.cb_Sede.Size = new System.Drawing.Size(178, 24);
            this.cb_Sede.TabIndex = 64;
            this.cb_Sede.Tag = "codigo_sede";
            // 
            // cb_Carrera
            // 
            this.cb_Carrera.FormattingEnabled = true;
            this.cb_Carrera.Location = new System.Drawing.Point(154, 233);
            this.cb_Carrera.Name = "cb_Carrera";
            this.cb_Carrera.Size = new System.Drawing.Size(178, 24);
            this.cb_Carrera.TabIndex = 63;
            this.cb_Carrera.Tag = "codigo_carrera";
            // 
            // txt_carnetAlumno
            // 
            this.txt_carnetAlumno.Location = new System.Drawing.Point(496, 349);
            this.txt_carnetAlumno.Name = "txt_carnetAlumno";
            this.txt_carnetAlumno.Size = new System.Drawing.Size(172, 22);
            this.txt_carnetAlumno.TabIndex = 62;
            this.txt_carnetAlumno.Tag = "carnet_alumno";
            // 
            // txt_NotaCurso
            // 
            this.txt_NotaCurso.Location = new System.Drawing.Point(536, 405);
            this.txt_NotaCurso.Name = "txt_NotaCurso";
            this.txt_NotaCurso.Size = new System.Drawing.Size(132, 22);
            this.txt_NotaCurso.TabIndex = 61;
            this.txt_NotaCurso.Tag = "nota_asignacioncursoalumno";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label9.Location = new System.Drawing.Point(415, 406);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 21);
            this.label9.TabIndex = 60;
            this.label9.Text = "Nota Curso";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label8.Location = new System.Drawing.Point(415, 348);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 21);
            this.label8.TabIndex = 59;
            this.label8.Text = "Carné";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label7.Location = new System.Drawing.Point(415, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 21);
            this.label7.TabIndex = 58;
            this.label7.Text = "Curso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label6.Location = new System.Drawing.Point(415, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 21);
            this.label6.TabIndex = 57;
            this.label6.Text = "Aula";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label5.Location = new System.Drawing.Point(61, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 21);
            this.label5.TabIndex = 56;
            this.label5.Text = "Sección";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label4.Location = new System.Drawing.Point(62, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 21);
            this.label4.TabIndex = 55;
            this.label4.Text = "Jornada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label3.Location = new System.Drawing.Point(62, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 54;
            this.label3.Text = "Sede";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label2.Location = new System.Drawing.Point(62, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 53;
            this.label2.Text = "Carrera";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 23);
            this.label1.TabIndex = 52;
            this.label1.Text = "ELIMINACIÓN DE ALUMNO A UN CURSO";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(3)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.btn_refrescar);
            this.panel1.Controls.Add(this.btn_salir);
            this.panel1.Controls.Add(this.btn_ayudas);
            this.panel1.Controls.Add(this.btn_reporte);
            this.panel1.Controls.Add(this.btn_eliminar);
            this.panel1.Controls.Add(this.btn_guardar);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.panel1.Location = new System.Drawing.Point(97, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 101);
            this.panel1.TabIndex = 51;
            // 
            // btn_refrescar
            // 
            this.btn_refrescar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(113)))));
            this.btn_refrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refrescar.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btn_refrescar.ForeColor = System.Drawing.Color.Snow;
            //this.btn_refrescar.Image = ((System.Drawing.Image)(resources.GetObject("btn_refrescar.Image")));
            this.btn_refrescar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_refrescar.Location = new System.Drawing.Point(119, 15);
            this.btn_refrescar.Name = "btn_refrescar";
            this.btn_refrescar.Size = new System.Drawing.Size(106, 71);
            this.btn_refrescar.TabIndex = 16;
            this.btn_refrescar.Text = "Refrescar";
            this.btn_refrescar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_refrescar.UseVisualStyleBackColor = false;
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(113)))));
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btn_salir.ForeColor = System.Drawing.Color.Snow;
            //this.btn_salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_salir.Image")));
            this.btn_salir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_salir.Location = new System.Drawing.Point(513, 15);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(88, 71);
            this.btn_salir.TabIndex = 6;
            this.btn_salir.Text = "Salir";
            this.btn_salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_salir.UseVisualStyleBackColor = false;
            // 
            // btn_ayudas
            // 
            this.btn_ayudas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(113)))));
            this.btn_ayudas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ayudas.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btn_ayudas.ForeColor = System.Drawing.Color.Snow;
           // this.btn_ayudas.Image = ((System.Drawing.Image)(resources.GetObject("btn_ayudas.Image")));
            this.btn_ayudas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_ayudas.Location = new System.Drawing.Point(422, 15);
            this.btn_ayudas.Name = "btn_ayudas";
            this.btn_ayudas.Size = new System.Drawing.Size(85, 71);
            this.btn_ayudas.TabIndex = 5;
            this.btn_ayudas.Text = "Ayuda";
            this.btn_ayudas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ayudas.UseVisualStyleBackColor = false;
            // 
            // btn_reporte
            // 
            this.btn_reporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(113)))));
            this.btn_reporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reporte.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btn_reporte.ForeColor = System.Drawing.Color.Snow;
          //  this.btn_reporte.Image = ((System.Drawing.Image)(resources.GetObject("btn_reporte.Image")));
            this.btn_reporte.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_reporte.Location = new System.Drawing.Point(322, 15);
            this.btn_reporte.Name = "btn_reporte";
            this.btn_reporte.Size = new System.Drawing.Size(94, 71);
            this.btn_reporte.TabIndex = 4;
            this.btn_reporte.Text = "Reporte";
            this.btn_reporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_reporte.UseVisualStyleBackColor = false;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(113)))));
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btn_eliminar.ForeColor = System.Drawing.Color.Snow;
            //this.btn_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("btn_eliminar.Image")));
            this.btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_eliminar.Location = new System.Drawing.Point(231, 15);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(85, 71);
            this.btn_eliminar.TabIndex = 2;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_eliminar.UseVisualStyleBackColor = false;
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(113)))));
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btn_guardar.ForeColor = System.Drawing.Color.Snow;
           // this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_guardar.Location = new System.Drawing.Point(12, 15);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(101, 71);
            this.btn_guardar.TabIndex = 0;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_guardar.UseVisualStyleBackColor = false;
            // 
            // frmEliminacionAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 686);
            this.Controls.Add(this.dgv_eliminacion);
            this.Controls.Add(this.cb_Curso);
            this.Controls.Add(this.cb_aula);
            this.Controls.Add(this.cb_Seccion);
            this.Controls.Add(this.cb_Jornada);
            this.Controls.Add(this.cb_Sede);
            this.Controls.Add(this.cb_Carrera);
            this.Controls.Add(this.txt_carnetAlumno);
            this.Controls.Add(this.txt_NotaCurso);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "frmEliminacionAlumnos";
            this.Text = "frmEliminacionAlumnos";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_eliminacion)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_eliminacion;
        private System.Windows.Forms.ComboBox cb_Curso;
        private System.Windows.Forms.ComboBox cb_aula;
        private System.Windows.Forms.ComboBox cb_Seccion;
        private System.Windows.Forms.ComboBox cb_Jornada;
        private System.Windows.Forms.ComboBox cb_Sede;
        private System.Windows.Forms.ComboBox cb_Carrera;
        private System.Windows.Forms.TextBox txt_carnetAlumno;
        private System.Windows.Forms.TextBox txt_NotaCurso;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_refrescar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_ayudas;
        private System.Windows.Forms.Button btn_reporte;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_guardar;
    }
}