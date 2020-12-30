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

        #region Firebase
        IFirebaseConfig configuracion = new FirebaseConfig()
        {
            AuthSecret = "",
            BasePath = ""

        };

        IFirebaseClient cliente;
        #endregion

        #region Inicalización
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            

        }

        #endregion

        #region Conectar
        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (textRuta.Text != "" && textSecret.Text != "")
            {
                configuracion.AuthSecret = textSecret.Text;
                configuracion.BasePath = textRuta.Text;
                cliente = new FireSharp.FirebaseClient(configuracion);
                if(cliente!=null)
                {
                    lbSimpleConexion.Text = "REGISTRO EXITOSO";
                    lbSimpleConexion.Visible=true;
                    textRuta.Enabled = false;
                    textSecret.Enabled = false;
                    btnConectar.Enabled = false;
                    btnDesconectar.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Faltan campos por llenar");
            }
        }

        #endregion

        private void btnDesconectar_Click(object sender, EventArgs e)
        {           
            lbSimpleConexion.Text = "";            
            textRuta.Enabled = true;
            textSecret.Enabled = true;
            btnConectar.Enabled = true;
            btnDesconectar.Enabled = false;
        }
    }
}
