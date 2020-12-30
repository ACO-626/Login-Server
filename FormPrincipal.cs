using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Biblioteca para API-FireBase
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace Login_Server
{
    public partial class FormPrincipal : Form
    {
        IFirebaseConfig configuracion = new FirebaseConfig()
        {
            AuthSecret = "",
            BasePath = ""

        };

        public FormPrincipal()
        {
            InitializeComponent();
        }

        #region Conectar
        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (textRuta.Text != "" && textSecret.Text != "")
            {
                configuracion.AuthSecret = textSecret.Text;
                configuracion.BasePath = textRuta.Text;
            }
            else
            {
                MessageBox.Show("Faltan campos por llenar");
            }
        }
        #endregion
    }
}
