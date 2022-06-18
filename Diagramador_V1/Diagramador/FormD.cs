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
        private void FormD_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true; //Permite que la forma reciba las teclas antes que los componentes
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

        private void Conectar_Nodos(LinkType LT)
        {
            Liberar();
            Pizarra.Document.Action = DesignerAction.Connect; //Modo Conectar de la Pizarra

            switch (LT) //Pinta el boton presionado de verde o anula la operacion en caso de inconsistencia
            {
                case LinkType.RightAngle:
                    {
                        bttFlecha.BackColor = Color.Green;
                        break;
                    }
                case LinkType.RightAngleArrow:
                    {
                        bttFlechaCruz.BackColor = Color.Green;
                        break;
                    }
                case LinkType.RightAngleDoubleArrow:
                    {
                        bttFlechaDosCruz.BackColor = Color.Green;
                        break;
                    }
                default:
                    {
                        Liberar();
                        return;
                    }
            }

            Pizarra.Document.LinkType = LT; //Indica el tipo de flecha a utilizar

        }
        #endregion

        #region Handlers
        private void bttCuadrado_Click(object sender, EventArgs e)
        {
            Añadir_Nodo(ElementType.RectangleNode);
        }
        private void bttCirculo_Click(object sender, EventArgs e)
        {
            Añadir_Nodo(ElementType.ElipseNode);
        }
        private void bttFlecha_Click(object sender, EventArgs e)
        {
            Conectar_Nodos(LinkType.RightAngle);
        }
        private void bttFlechaCruz_Click(object sender, EventArgs e)
        {
            Conectar_Nodos(LinkType.RightAngleArrow);
        }
        private void bttFlechaDosCruz_Click(object sender, EventArgs e)
        {
            Conectar_Nodos(LinkType.RightAngleDoubleArrow);
        }
        private void Pizarra_Click(object sender, EventArgs e)
        {
            Liberar();
        }
        private void Menu_Click(object sender, EventArgs e)
        {
            Liberar();
        }
        private void FormD_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    {
                        Liberar();
                        e.Handled = true;
                        break;
                    }
                default:
                    {
                        e.Handled = false;
                        break;
                    }
            }

        }
        #endregion

    }
}
