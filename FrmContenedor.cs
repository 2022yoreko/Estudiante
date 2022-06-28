using Estudiante.formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudiante
{
    public partial class FrmContenedor : Form
    {
        public FrmContenedor()
        {
            InitializeComponent();
        }// Fin del constructor

        private void FrmContenedor_Load(object sender, EventArgs e)
        {

           FrmLogin frmLog = new FrmLogin(); // Crea una instancia de login
            frmLog.MdiParent = this; //Mostrar en estte formulario
            frmLog.Show(); //PARA VISUALIZARLO




        }

    } // Fin de la clase

}//Fin del espacio de nombres
