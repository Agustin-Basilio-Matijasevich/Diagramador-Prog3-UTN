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
        private void Liberar() //Libera la forma de cualquier accion pendiente
        {
            bttCirculo.BackColor = Color.Empty;
            bttCuadrado.BackColor = Color.Empty;
            bttFlecha.BackColor = Color.Empty;
            bttFlechaCruz.BackColor = Color.Empty;
            bttFlechaDosCruz.BackColor = Color.Empty;
            Pizarra.Document.Action = DesignerAction.Select; //Modo de seleccion de la pizarra
        }
        private void Añadir_Nodo(ElementType NT) //Configura la forma para añadir un nodo
        {
            Liberar();
            Pizarra.Document.Action = DesignerAction.Add; //Modo de añadr de la pizarra

            switch (NT) //Pinta el boton presionado de verde o anula la operacion en caso de inconsistencia
            {
                case ElementType.RectangleNode:
                    {
                        bttCuadrado.BackColor = Color.Green;
                        break;
                    }
                case ElementType.ElipseNode:
                    {
                        bttCirculo.BackColor = Color.Green;
                        break;
                    }
                default:
                    {
                        Liberar();
                        return;
                    }
            }

            Pizarra.Document.ElementType = NT; //Indica el tipo de nodo a añadir

        }
        #endregion

        #region Handlers

        #endregion

    }
}
