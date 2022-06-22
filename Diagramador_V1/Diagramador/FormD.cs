using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using Dalssoft.DiagramNet;

namespace Diagramador
{
    public partial class FormD : Form
    {
        #region Variables y Constantes
        private SaveFileDialog SaveDialog; //Para guardar el estado de guardado en ejecucion y plantilla
        private OpenFileDialog OpenDialog; //Para plantilla de apertura
        #endregion

        #region Load
        public FormD()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        private void FormD_Load(object sender, EventArgs e)
        {
            #region Config Forma
            this.KeyPreview = true; //Permite que la forma reciba las teclas antes que los componentes
            #endregion
            #region Plantillas SaveDialogs
            SaveDialog = new SaveFileDialog();
            OpenDialog = new OpenFileDialog();
            // Save
            SaveDialog.FileName = "Diagrama";
            SaveDialog.Filter = "Archivo JSON (*.JSON)|*.JSON|Archivo XML (*.XML)|*.XML";
            // Open
            OpenDialog.Filter = "Extensiones Compatibles (*.JSON,*.XML)|*.JSON;*.XML";
            #endregion
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
        private void Liberar_Todo() //Libera Todos los recursos de la forma
        {
            bttCirculo.BackColor = Color.Empty;
            bttCuadrado.BackColor = Color.Empty;
            bttFlecha.BackColor = Color.Empty;
            bttFlechaCruz.BackColor = Color.Empty;
            bttFlechaDosCruz.BackColor = Color.Empty;
            Pizarra.Document.Action = DesignerAction.Select; //Modo de seleccion de la pizarra
            Pizarra.Liberar_Seleccion(); //Libera la seleccion de la Pizarra
        }
        private void Añadir_Nodo(ElementType NT) //Configura la forma para añadir un nodo
        {
            Liberar_Todo();
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
            Liberar_Todo();
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
        private void Abrir()
        {
            if (OpenDialog.ShowDialog() == DialogResult.OK)
            {
                if (Pizarra.Open(OpenDialog.FileName)) //Carga el archivo en la pizarra
                {
                    SaveDialog.FileName = OpenDialog.FileName; //Pasa al save el nombre del archivo abierto
                    OpenDialog.FileName = null; //El Open olvida el archivo
                    OpenDialog.Dispose(); //Libera recursos del Dialog
                    Liberar_Todo(); //Libera recursos de pizarra para refrescarla
                    MessageBox.Show("Diagrama Abierto Correctamente", "Abrir");
                }
                else //Error cargando archivo
                {
                    OpenDialog.Dispose(); //Libera recursos del Dialog
                    Liberar_Todo(); //Libera recursos de pizarra para refrescarla
                    MessageBox.Show("Error Abriendo Diagrama:\nArchivo Corrupto", "Abrir");
                }
            }
        }
        private void Guardar()
        {
            if (File.Exists(SaveDialog.FileName))
            {
                if ((MessageBox.Show("¿Desea sobreescribir el ultimo diagrama que guardo?", "Guardar", MessageBoxButtons.YesNo)) == (System.Windows.Forms.DialogResult.Yes))
                {
                    Pizarra.Save(SaveDialog.FileName);
                    MessageBox.Show("Diagrama Guardado Correctamente", "Guardar");
                }
                else //Si no quiere sobreescribir
                {
                    if (SaveDialog.ShowDialog(this) == DialogResult.OK)
                    {
                        Pizarra.Save(SaveDialog.FileName);
                    }
                    SaveDialog.Dispose();
                    MessageBox.Show("Diagrama Guardado Correctamente", "Guardar");
                }
            }
            else
            {
                if (SaveDialog.ShowDialog(this) == DialogResult.OK)
                {
                    Pizarra.Save(SaveDialog.FileName);
                }
                SaveDialog.Dispose();
                MessageBox.Show("Diagrama Guardado Correctamente", "Guardar");
            }
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
            Liberar_Todo();
        }
        private void FormD_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    {
                        Liberar_Todo();
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
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrir();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void pngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void jpegToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion


    }
}
