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
                    panelRegistro.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Faltan campos por llenar");
            }
        }

        #endregion

        #region Desconectar
        private void btnDesconectar_Click(object sender, EventArgs e)
        {           
            lbSimpleConexion.Text = "";            
            textRuta.Enabled = true;
            textSecret.Enabled = true;
            btnConectar.Enabled = true;
            btnDesconectar.Enabled = false;
           
            LimpiarTexts();
            panelRegistro.Visible = false;
        }
        #endregion

        #region Registro
        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            if(textName.Text!=""&&textName.Text!=""&&textPasswd.Text!=""&&textPass2.Text!="")
            {
                if(textPass2.Text==textPasswd.Text)
                {
                    var datos = new Data
                    {
                        user = textUser.Text,
                        name = textName.Text,
                        passwd = textPasswd.Text
                    };

                    SetResponse response = await cliente.SetTaskAsync("Registros/" + textUser.Text, datos);
                    Data result = response.ResultAs<Data>();
                    MessageBox.Show("Usuario guardado exitosamente");
                    LimpiarTexts();
                }else
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                    textPasswd.Text = "";
                    textPass2.Text = "";
                }
                

            }else
            {
                MessageBox.Show("Faltan campos por llenar");
            }
        }
        #endregion

        #region LimpiarRegistro
        private void LimpiarTexts()
        {
            textName.Clear();
            textPasswd.Clear();
            textUser.Clear();
            textPass2.Clear();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            LimpiarTexts();
        }
        #endregion
    }


}
