namespace Diagramador
{
    partial class FormD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormD));
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainerP = new System.Windows.Forms.SplitContainer();
            this.Pizarra = new Dalssoft.DiagramNet.Designer();
            this.bttFlechaDosCruz = new System.Windows.Forms.Button();
            this.bttFlechaCruz = new System.Windows.Forms.Button();
            this.bttFlecha = new System.Windows.Forms.Button();
            this.bttCuadrado = new System.Windows.Forms.Button();
            this.bttCirculo = new System.Windows.Forms.Button();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerP)).BeginInit();
            this.splitContainerP.Panel1.SuspendLayout();
            this.splitContainerP.Panel2.SuspendLayout();
            this.splitContainerP.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(800, 24);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "Menu";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo...";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            // 
            // splitContainerP
            // 
            this.splitContainerP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerP.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerP.IsSplitterFixed = true;
            this.splitContainerP.Location = new System.Drawing.Point(0, 24);
            this.splitContainerP.Name = "splitContainerP";
            // 
            // splitContainerP.Panel1
            // 
            this.splitContainerP.Panel1.AutoScroll = true;
            this.splitContainerP.Panel1.Controls.Add(this.bttFlechaDosCruz);
            this.splitContainerP.Panel1.Controls.Add(this.bttFlechaCruz);
            this.splitContainerP.Panel1.Controls.Add(this.bttFlecha);
            this.splitContainerP.Panel1.Controls.Add(this.bttCuadrado);
            this.splitContainerP.Panel1.Controls.Add(this.bttCirculo);
            // 
            // splitContainerP.Panel2
            // 
            this.splitContainerP.Panel2.Controls.Add(this.Pizarra);
            this.splitContainerP.Size = new System.Drawing.Size(800, 686);
            this.splitContainerP.SplitterDistance = 266;
            this.splitContainerP.TabIndex = 1;
            // 
            // Pizarra
            // 
            this.Pizarra.AutoScroll = true;
            this.Pizarra.BackColor = System.Drawing.SystemColors.Window;
            this.Pizarra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pizarra.Location = new System.Drawing.Point(0, 0);
            this.Pizarra.Name = "Pizarra";
            this.Pizarra.Size = new System.Drawing.Size(530, 686);
            this.Pizarra.TabIndex = 0;
            // 
            // bttFlechaDosCruz
            // 
            this.bttFlechaDosCruz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttFlechaDosCruz.FlatAppearance.BorderSize = 0;
            this.bttFlechaDosCruz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttFlechaDosCruz.Image = global::Diagramador.Properties.Resources.FlechaDosCruz;
            this.bttFlechaDosCruz.Location = new System.Drawing.Point(32, 535);
            this.bttFlechaDosCruz.Name = "bttFlechaDosCruz";
            this.bttFlechaDosCruz.Size = new System.Drawing.Size(199, 110);
            this.bttFlechaDosCruz.TabIndex = 5;
            this.bttFlechaDosCruz.UseVisualStyleBackColor = true;
            // 
            // bttFlechaCruz
            // 
            this.bttFlechaCruz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttFlechaCruz.FlatAppearance.BorderSize = 0;
            this.bttFlechaCruz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttFlechaCruz.Image = global::Diagramador.Properties.Resources.FlechaCruz;
            this.bttFlechaCruz.Location = new System.Drawing.Point(32, 405);
            this.bttFlechaCruz.Name = "bttFlechaCruz";
            this.bttFlechaCruz.Size = new System.Drawing.Size(199, 110);
            this.bttFlechaCruz.TabIndex = 4;
            this.bttFlechaCruz.UseVisualStyleBackColor = true;
            // 
            // bttFlecha
            // 
            this.bttFlecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttFlecha.FlatAppearance.BorderSize = 0;
            this.bttFlecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttFlecha.Image = global::Diagramador.Properties.Resources.Flecha;
            this.bttFlecha.Location = new System.Drawing.Point(32, 274);
            this.bttFlecha.Name = "bttFlecha";
            this.bttFlecha.Size = new System.Drawing.Size(199, 110);
            this.bttFlecha.TabIndex = 3;
            this.bttFlecha.UseVisualStyleBackColor = true;
            // 
            // bttCuadrado
            // 
            this.bttCuadrado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttCuadrado.FlatAppearance.BorderSize = 0;
            this.bttCuadrado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttCuadrado.Image = global::Diagramador.Properties.Resources.Cuadrado;
            this.bttCuadrado.Location = new System.Drawing.Point(32, 17);
            this.bttCuadrado.Name = "bttCuadrado";
            this.bttCuadrado.Size = new System.Drawing.Size(199, 116);
            this.bttCuadrado.TabIndex = 2;
            this.bttCuadrado.UseVisualStyleBackColor = true;
            // 
            // bttCirculo
            // 
            this.bttCirculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttCirculo.FlatAppearance.BorderSize = 0;
            this.bttCirculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttCirculo.Image = global::Diagramador.Properties.Resources.Circulo;
            this.bttCirculo.Location = new System.Drawing.Point(32, 149);
            this.bttCirculo.Name = "bttCirculo";
            this.bttCirculo.Size = new System.Drawing.Size(199, 108);
            this.bttCirculo.TabIndex = 1;
            this.bttCirculo.UseVisualStyleBackColor = true;
            // 
            // FormD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 710);
            this.Controls.Add(this.splitContainerP);
            this.Controls.Add(this.Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu;
            this.Name = "FormD";
            this.Text = "Diagramador G10";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.splitContainerP.Panel1.ResumeLayout(false);
            this.splitContainerP.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerP)).EndInit();
            this.splitContainerP.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainerP;
        private Dalssoft.DiagramNet.Designer Pizarra;
        private System.Windows.Forms.Button bttCirculo;
        private System.Windows.Forms.Button bttCuadrado;
        private System.Windows.Forms.Button bttFlecha;
        private System.Windows.Forms.Button bttFlechaDosCruz;
        private System.Windows.Forms.Button bttFlechaCruz;
    }
}

