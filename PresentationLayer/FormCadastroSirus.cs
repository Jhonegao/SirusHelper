using BLL;
using Common;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FormCadastroSirus : Form
    {
        public FormCadastroSirus()
        {
            InitializeComponent();
        }

        SirusBLL sirusBLL = new SirusBLL();
        private void btnInserir_Click(object sender, EventArgs e)
        {
            Sirus sirus = new Sirus();
            sirus.Nome = txtNome.Text;
            sirus.Awakener = Convert.ToByte(cbAwakenerLevel.SelectedIndex);
            sirus.Completado = chkBoxCompletado.Checked;
            FormCleaner.Clear(this);
        }

    }
}
