﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ControlBox = false;
            PbxLogoEdulab.BorderRadius = 25;

        }

        private void BtnCerrarAplicacion_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
