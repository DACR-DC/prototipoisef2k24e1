﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaPrototipo.Mantenimientos
{
    public partial class frmMantenimientoCursos : Form
    {
        public frmMantenimientoCursos()
        {
            InitializeComponent();
            this.navegador1.config("cursos", this, "9002");
        }
    }
}
