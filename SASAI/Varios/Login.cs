using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace SASAI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void Txt_Contra_TextChanged(object sender, EventArgs e)
        {
            

            
        }

        private void Txt_Contra_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

          

        private void Login_Load(object sender, EventArgs e)
        {
            Formularios.enviarFormulario().ShowDialog();
            this.Close();
        }

        private void Txt_Usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
