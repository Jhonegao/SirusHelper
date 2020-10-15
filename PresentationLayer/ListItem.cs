using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class ListItem : UserControl
    {
        public ListItem()
        {
            InitializeComponent();
        }

        private string _NomeSirus;
        private string _AwakenerLevel;
        private DateTime _DataFeito;
        private string _Drop1;
        private string _Drop2;

        #region Propriedades

        [Category("Custom Props")]
        public string NomeSirus
        {
            get { return _NomeSirus; }
            set { _NomeSirus = value; lbNomeSirus.Text = value; }
        }
        [Category("Custom Props")]
        public string AwakenerLevel
        {
            get { return _AwakenerLevel; }
            set { _AwakenerLevel = value; lbAwakenerLevel.Text = value; }
        }
        [Category("Custom Props")]
        public DateTime DataFeito
        {
            get { return _DataFeito; }
            set { _DataFeito = value; lbDataDone.Text = value.ToString(); }
        }
        [Category("Custom Props")]
        public string Drop2
        {
            get { return _Drop2; }
            set { _Drop2 = value; lbDrop2.Text = value; }
        }
        [Category("Custom Props")]
        public string Drop1
        {
            get { return _Drop1; }
            set { _Drop1 = value; lbDrop1.Text = value; }
        }
        #endregion
    }
}
