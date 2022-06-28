using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudiante.formularios
{
    public partial class FrmLogin : Form
    {
        bool valido = true; // si el usuario  es valido
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            // obtener el directorio base del proyecto app  
            string rutaBase = Directory.GetCurrentDirectory();
            // Establcer el directorio de archivos 
            string rutArch = rutaBase.Replace(@"\bin\Debug",@"ficheros\Usuario");
            //definir una variable de objeto de procesar del archivo
            StreamReader Leer; // lee el contenido del archivo linea * linea
            Leer = new StreamReader(rutArch); // crea el objeto para leer 
            // bandera para determinar si se encontro un registro

            bool encontrado = false;
            string usuario; // 
            string clave; // clave de usuario en l archivo

            usuario = Leer.ReadLine(); // leer la primeras linea
            clave = Leer.ReadLine(); // leer la segunda linea

            while (!encontrado && usuario != null) 
            {
                if (txtUsuario.Text.Equals(usuario) && txtClave.Text.Equals(clave))
                {
                    encontrado = true;
                }//fin del if
                else 
                {
                    usuario = Leer.ReadLine(); // seguir leyendo el archivo
                    clave = Leer.ReadLine();
                }//fin del ciclo
                //cerrar la lectura del archivo
            }

            if (encontrado)
            {
                FrmComandos frmNav = new FrmComandos();
                frmNav.MdiParent = this.MdiParent;
                frmNav.Show();
                this.Close();
            }
            else 
            {
                MessageBox.Show("El usuario no existe");
            }


        }
    }
}
