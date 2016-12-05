using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ComidasYa_Winforms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ComidasYaWebService.ComidasYaWebServiceSoap ws = new ComidasYaWebService.ComidasYaWebServiceSoapClient();
            if (ws.Ingreso(this.tbxUsuario.Text, this.tbxPassword.Text))
            {
                VentanaPrincipal vVentanaPrincipal = new VentanaPrincipal();
                this.Hide();
                vVentanaPrincipal.FormClosed += (s, args) => this.Close();
                vVentanaPrincipal.Show();
            }
            else
            {
                MessageBox.Show("Ususario o contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
