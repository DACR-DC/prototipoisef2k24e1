using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControladorPrototipo;

namespace CapaVistaPrototipo.Procesos
{
    public partial class frmEliminacionAlumnos : Form
    {

        Controlador cn = new Controlador();

        public frmEliminacionAlumnos()
        {
            InitializeComponent();
            ComboCarrera();
            ComboSede();
            ComboJornada();
            ComboSeccion();
            ComboAula();
            ComboCurso();
        }

        public void ComboCarrera()
        {
            List<string> concepto = cn.llenarCombo("codigo_carrera", "carreras");
            cb_Carrera.Items.Clear();
            cb_Carrera.Items.AddRange(concepto.ToArray());
        }

        public void ComboSede()
        {
            List<string> concepto = cn.llenarCombo("codigo_sede", "sedes");
            cb_Sede.Items.Clear();
            cb_Sede.Items.AddRange(concepto.ToArray());
        }

        public void ComboJornada()
        {
            List<string> concepto = cn.llenarCombo("codigo_jornada", "jornadas");
            cb_Jornada.Items.Clear();
            cb_Jornada.Items.AddRange(concepto.ToArray());
        }

        public void ComboSeccion()
        {
            List<string> concepto = cn.llenarCombo("codigo_seccion", "secciones");
            cb_Seccion.Items.Clear();
            cb_Seccion.Items.AddRange(concepto.ToArray());
        }

        public void ComboAula()
        {
            List<string> concepto = cn.llenarCombo("codigo_aula", "aulas");
            cb_Seccion.Items.Clear();
            cb_Seccion.Items.AddRange(concepto.ToArray());
        }

        public void ComboCurso()
        {
            List<string> concepto = cn.llenarCombo("codigo_curso", "cursos");
            cb_Seccion.Items.Clear();
            cb_Seccion.Items.AddRange(concepto.ToArray());
        }
    }
}
