namespace WindowsFormsApp1
{
    partial class frmMenu
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnCINCO = new System.Windows.Forms.Button();
            this.btnCUATRO = new System.Windows.Forms.Button();
            this.btnTRES = new System.Windows.Forms.Button();
            this.btnDOS = new System.Windows.Forms.Button();
            this.btnUNO = new System.Windows.Forms.Button();
            this.panelSubMenu = new System.Windows.Forms.Panel();
            this.btnOPTRES = new System.Windows.Forms.Button();
            this.btnOPDOS = new System.Windows.Forms.Button();
            this.btnOPUNO = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.picAPP = new System.Windows.Forms.PictureBox();
            this.panelHeader.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelSubMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAPP)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Teal;
            this.panelHeader.Controls.Add(this.lblTitulo);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 44);
            this.panelHeader.TabIndex = 0;
            this.panelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHeader_Paint);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblTitulo.Location = new System.Drawing.Point(3, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(146, 27);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Menu general";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btnCINCO);
            this.panelMenu.Controls.Add(this.btnCUATRO);
            this.panelMenu.Controls.Add(this.btnTRES);
            this.panelMenu.Controls.Add(this.btnDOS);
            this.panelMenu.Controls.Add(this.btnUNO);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 44);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(188, 406);
            this.panelMenu.TabIndex = 1;
            // 
            // btnCINCO
            // 
            this.btnCINCO.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCINCO.Location = new System.Drawing.Point(0, 200);
            this.btnCINCO.Name = "btnCINCO";
            this.btnCINCO.Size = new System.Drawing.Size(188, 50);
            this.btnCINCO.TabIndex = 7;
            this.btnCINCO.Text = "Menu Cinco";
            this.btnCINCO.UseVisualStyleBackColor = true;
            this.btnCINCO.Click += new System.EventHandler(this.btnCINCO_Click);
            // 
            // btnCUATRO
            // 
            this.btnCUATRO.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCUATRO.Location = new System.Drawing.Point(0, 150);
            this.btnCUATRO.Name = "btnCUATRO";
            this.btnCUATRO.Size = new System.Drawing.Size(188, 50);
            this.btnCUATRO.TabIndex = 6;
            this.btnCUATRO.Text = "Menu Cuatro";
            this.btnCUATRO.UseVisualStyleBackColor = true;
            this.btnCUATRO.Click += new System.EventHandler(this.btnCUATRO_Click);
            // 
            // btnTRES
            // 
            this.btnTRES.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTRES.Location = new System.Drawing.Point(0, 100);
            this.btnTRES.Name = "btnTRES";
            this.btnTRES.Size = new System.Drawing.Size(188, 50);
            this.btnTRES.TabIndex = 2;
            this.btnTRES.Text = "Menu Tres";
            this.btnTRES.UseVisualStyleBackColor = true;
            this.btnTRES.Click += new System.EventHandler(this.btnTRES_Click);
            // 
            // btnDOS
            // 
            this.btnDOS.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDOS.Location = new System.Drawing.Point(0, 50);
            this.btnDOS.Name = "btnDOS";
            this.btnDOS.Size = new System.Drawing.Size(188, 50);
            this.btnDOS.TabIndex = 1;
            this.btnDOS.Text = "Menu Dos";
            this.btnDOS.UseVisualStyleBackColor = true;
            this.btnDOS.Click += new System.EventHandler(this.btnDOS_Click);
            // 
            // btnUNO
            // 
            this.btnUNO.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUNO.Location = new System.Drawing.Point(0, 0);
            this.btnUNO.Name = "btnUNO";
            this.btnUNO.Size = new System.Drawing.Size(188, 50);
            this.btnUNO.TabIndex = 0;
            this.btnUNO.Text = "Menu Uno";
            this.btnUNO.UseVisualStyleBackColor = true;
            this.btnUNO.Click += new System.EventHandler(this.btnUNO_Click_1);
            // 
            // panelSubMenu
            // 
            this.panelSubMenu.Controls.Add(this.btnOPTRES);
            this.panelSubMenu.Controls.Add(this.btnOPDOS);
            this.panelSubMenu.Controls.Add(this.btnOPUNO);
            this.panelSubMenu.Location = new System.Drawing.Point(185, 44);
            this.panelSubMenu.Name = "panelSubMenu";
            this.panelSubMenu.Size = new System.Drawing.Size(243, 186);
            this.panelSubMenu.TabIndex = 2;
            // 
            // btnOPTRES
            // 
            this.btnOPTRES.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOPTRES.Location = new System.Drawing.Point(0, 100);
            this.btnOPTRES.Name = "btnOPTRES";
            this.btnOPTRES.Size = new System.Drawing.Size(243, 50);
            this.btnOPTRES.TabIndex = 5;
            this.btnOPTRES.Text = "Tres";
            this.btnOPTRES.UseVisualStyleBackColor = true;
            this.btnOPTRES.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnOPDOS
            // 
            this.btnOPDOS.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOPDOS.Location = new System.Drawing.Point(0, 50);
            this.btnOPDOS.Name = "btnOPDOS";
            this.btnOPDOS.Size = new System.Drawing.Size(243, 50);
            this.btnOPDOS.TabIndex = 4;
            this.btnOPDOS.Text = "Dos";
            this.btnOPDOS.UseVisualStyleBackColor = true;
            // 
            // btnOPUNO
            // 
            this.btnOPUNO.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOPUNO.Location = new System.Drawing.Point(0, 0);
            this.btnOPUNO.Name = "btnOPUNO";
            this.btnOPUNO.Size = new System.Drawing.Size(243, 50);
            this.btnOPUNO.TabIndex = 3;
            this.btnOPUNO.Text = "Uno";
            this.btnOPUNO.UseVisualStyleBackColor = true;
            this.btnOPUNO.Click += new System.EventHandler(this.btnOPUNO_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUsuario.Location = new System.Drawing.Point(625, 215);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(128, 39);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "label1";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNombre.Location = new System.Drawing.Point(491, 215);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(128, 39);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "label1";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picAPP
            // 
            this.picAPP.InitialImage = null;
            this.picAPP.Location = new System.Drawing.Point(483, 56);
            this.picAPP.Name = "picAPP";
            this.picAPP.Size = new System.Drawing.Size(280, 138);
            this.picAPP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAPP.TabIndex = 6;
            this.picAPP.TabStop = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picAPP);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.panelSubMenu);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelHeader);
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMenu_KeyDown);
            this.panelHeader.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelSubMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAPP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnCINCO;
        private System.Windows.Forms.Button btnCUATRO;
        private System.Windows.Forms.Button btnTRES;
        private System.Windows.Forms.Button btnDOS;
        private System.Windows.Forms.Button btnUNO;
        private System.Windows.Forms.Panel panelSubMenu;
        private System.Windows.Forms.Button btnOPTRES;
        private System.Windows.Forms.Button btnOPDOS;
        private System.Windows.Forms.Button btnOPUNO;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox picAPP;
    }
}