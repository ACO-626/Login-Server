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
    public partial class FormConsulta : Form
    {
        IFirebaseConfig configuracion = new FirebaseConfig()
        {
            AuthSecret = "",
            BasePath = ""

        };

        IFirebaseClient cliente;

        public FormConsulta(string ruta,string secreto)
        {
            InitializeComponent();
            cliente = new FireSharp.FirebaseClient(configuracion);
            configuracion.AuthSecret = secreto;
            configuracion.BasePath = ruta;
        }

        private async void btnConsulta_Click(object sender, EventArgs e)
        {
            panelDown.Visible = true;
            FirebaseResponse respuesta = await cliente.GetTaskAsync("Registros/"+textUser.Text);
            Data obj = respuesta.ResultAs<Data>();
            lbSimpleName.Text = obj.name;
            lbSimpleContra.Text = obj.passwd;
            lbSimpleUser.Text = obj.user;
            lbNatalicio.Text = obj.date;
            lbSexo.Text = obj.sexo;
            lbTel.Text = obj.tel.ToString();
            

            textName.Text = obj.name;
            textPass.Text = obj.passwd;
            textSexo.Text = obj.sexo;
            textUsuario.Text = obj.user;
            textTel.Text = obj.tel.ToString();
            textNata.Text = obj.date;
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (btnModifica.Text == "Modificar")
            {
                btnModifica.Text = "Cancelar";
                btnEnviar.Visible = true;

                textName.Visible = true;
                textUsuario.Enabled = false;
                textPass.Visible = true;
                textSexo.Visible = true;
                textTel.Visible = true;
                textNata.Visible = true;
                textUsuario.Visible = true;

                lbSimpleName.Visible = false;
                lbSimpleContra.Visible = false;
                lbTel.Visible = false;
                lbSimpleUser.Visible = false;
                lbNatalicio.Visible = false;
                lbSexo.Visible = false;

            }
            else
            {
                btnEnviar.Visible = false;
                btnModifica.Text = "Modificar";

                textName.Visible = false;
                textPass.Visible = false;
                textSexo.Visible = false;
                textTel.Visible = false;
                textNata.Visible = false;
                textUsuario.Visible = false;

                lbSimpleName.Visible = true;
                lbSimpleContra.Visible = true;
                lbTel.Visible = true;
                lbSimpleUser.Visible = true;
                lbNatalicio.Visible = true;
                lbSexo.Visible = true;
            }
        }

        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            var data = new Data()
            {
                name = textName.Text,
                date = textNata.Text,
                passwd = textPass.Text,
                sexo = textSexo.Text,
                tel = int.Parse(textTel.Text),
                user = textUser.Text              
            };

            FirebaseResponse response = await cliente.UpdateTaskAsync("Registros/" + textUsuario.Text, data);
            Data result = response.ResultAs<Data>();
            MessageBox.Show("Datos actualizados para el usuario: " + result.user);


            btnEnviar.Visible = false;
            btnModifica.Text = "Modificar";

            textName.Visible = false;
            textPass.Visible = false;
            textSexo.Visible = false;
            textTel.Visible = false;
            textNata.Visible = false;
            textUsuario.Visible = false;

            lbSimpleName.Visible = true;
            lbSimpleContra.Visible = true;
            lbTel.Visible = true;
            lbSimpleUser.Visible = true;
            lbNatalicio.Visible = true;
            lbSexo.Visible = true;
        }
    }
}
