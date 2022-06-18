using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dalssoft.DiagramNet;

namespace Diagramador
{
    public partial class FormD : Form
    {
        #region Variables y Constantes

        #endregion

        #region Load
        public FormD()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        #endregion

        #region Metodos
        private void Liberar()
        {
            bttCirculo.BackColor = Color.Empty;
            bttCuadrado.BackColor = Color.Empty;
            bttFlecha.BackColor = Color.Empty;
            bttFlechaCruz.BackColor = Color.Empty;
            bttFlechaDosCruz.BackColor = Color.Empty;
            Pizarra.Document.Action = DesignerAction.Select;
        }
        #endregion

        #region Handlers

        #endregion

    }
}
