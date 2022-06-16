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
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.splitContainerP.Panel1.Controls.Add(this.button5);
            this.splitContainerP.Panel1.Controls.Add(this.button4);
            this.splitContainerP.Panel1.Controls.Add(this.button3);
            this.splitContainerP.Panel1.Controls.Add(this.button1);
            this.splitContainerP.Panel1.Controls.Add(this.button2);
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
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = global::Diagramador.Properties.Resources.FlechaDosCruz;
            this.button5.Location = new System.Drawing.Point(32, 535);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(199, 110);
            this.button5.TabIndex = 5;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = global::Diagramador.Properties.Resources.FlechaCruz;
            this.button4.Location = new System.Drawing.Point(32, 405);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(199, 110);
            this.button4.TabIndex = 4;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::Diagramador.Properties.Resources.Flecha;
            this.button3.Location = new System.Drawing.Point(32, 274);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(199, 110);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Diagramador.Properties.Resources.Cuadrado;
            this.button1.Location = new System.Drawing.Point(32, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 116);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::Diagramador.Properties.Resources.Circulo;
            this.button2.Location = new System.Drawing.Point(32, 149);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 108);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
    }
}

