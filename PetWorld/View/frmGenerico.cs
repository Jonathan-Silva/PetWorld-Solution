using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetWorld.View
{
    public partial class frmGenerico : Form
    {
        public frmGenerico()
        {
            InitializeComponent();
        }

        #region Controle Panel
        private void btFechar_MouseEnter(object sender, EventArgs e)
        {
            this.plFechar.BackColor = Color.DodgerBlue;
        }

        private void btFechar_MouseLeave(object sender, EventArgs e)
        {
            this.plFechar.BackColor = System.Drawing.SystemColors.Control;
        }

        private void btLimpar_MouseLeave(object sender, EventArgs e)
        {
            this.plLimpar.BackColor = System.Drawing.SystemColors.Control;
        }

        private void btLimpar_MouseEnter(object sender, EventArgs e)
        {
            this.plLimpar.BackColor = Color.DodgerBlue;
        }

        private void btExcluir_MouseLeave(object sender, EventArgs e)
        {
            this.plExcluir.BackColor = System.Drawing.SystemColors.Control;
        }

        private void btExcluir_MouseEnter(object sender, EventArgs e)
        {
            this.plExcluir.BackColor = Color.DodgerBlue;
        }

        private void btSalvar_MouseLeave(object sender, EventArgs e)
        {
            this.plSalvar.BackColor = System.Drawing.SystemColors.Control;
        }

        private void btSalvar_MouseEnter(object sender, EventArgs e)
        {
            this.plSalvar.BackColor = Color.DodgerBlue;
        }

        private void btAtualizar_MouseLeave(object sender, EventArgs e)
        {
            this.plAtualizar.BackColor = System.Drawing.SystemColors.Control;
        }

        private void btAtualizar_MouseEnter(object sender, EventArgs e)
        {
            this.plAtualizar.BackColor = Color.DodgerBlue;
        }
        private void btEditar_MouseEnter(object sender, EventArgs e)
        {
            this.plEditar.BackColor = Color.DodgerBlue;
        }

        private void btEditar_MouseLeave(object sender, EventArgs e)
        {
            this.plEditar.BackColor = System.Drawing.SystemColors.Control;

        }


        private void btBuscar_MouseLeave(object sender, EventArgs e)
        {
            btBuscar.Size = new System.Drawing.Size(35, 35);
        }

        private void btBuscar_MouseEnter(object sender, EventArgs e)
        {
            btBuscar.Size = new System.Drawing.Size(40,40);
        }


        #endregion



        private void frmGenerico_Load(object sender, EventArgs e)
        {

        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();

        }




    }
}
