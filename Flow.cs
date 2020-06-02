using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConfirmar_click( object Send, EventArgs e){

            if(this.txtNome.Text.Length < 1){
                this.nomeError.SetError(this.txtNome, "Campo obrigatório!");
            }else{
                this.nomeError.SetError(this.txtNome, string.Empty);
            }
        }

    }
}
