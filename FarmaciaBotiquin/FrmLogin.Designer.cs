namespace FarmaciaBotiquin
{
    partial class FrmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.txtContra = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbContra = new System.Windows.Forms.Label();
            this.gbContenido = new System.Windows.Forms.GroupBox();
            this.pbLotgin = new System.Windows.Forms.PictureBox();
            this.gbcontenidoinput = new System.Windows.Forms.GroupBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.llbRecuperar = new System.Windows.Forms.LinkLabel();
            this.pbCerrar = new System.Windows.Forms.PictureBox();
            this.pbMinimizar = new System.Windows.Forms.PictureBox();
            this.gbContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLotgin)).BeginInit();
            this.gbcontenidoinput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtContra
            // 
            this.txtContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContra.Location = new System.Drawing.Point(53, 132);
            this.txtContra.Name = "txtContra";
            this.txtContra.PasswordChar = '⬤';
            this.txtContra.Size = new System.Drawing.Size(306, 30);
            this.txtContra.TabIndex = 2;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(53, 66);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(306, 30);
            this.txtUsuario.TabIndex = 1;
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.ForeColor = System.Drawing.Color.Black;
            this.lbUsuario.Location = new System.Drawing.Point(48, 38);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(86, 25);
            this.lbUsuario.TabIndex = 2;
            this.lbUsuario.Text = "Usuario";
            // 
            // lbContra
            // 
            this.lbContra.AutoSize = true;
            this.lbContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContra.ForeColor = System.Drawing.Color.Black;
            this.lbContra.Location = new System.Drawing.Point(48, 104);
            this.lbContra.Name = "lbContra";
            this.lbContra.Size = new System.Drawing.Size(124, 25);
            this.lbContra.TabIndex = 3;
            this.lbContra.Text = "Contraseña";
            // 
            // gbContenido
            // 
            this.gbContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.gbContenido.Controls.Add(this.pbLotgin);
            this.gbContenido.Controls.Add(this.gbcontenidoinput);
            this.gbContenido.Location = new System.Drawing.Point(38, 48);
            this.gbContenido.Name = "gbContenido";
            this.gbContenido.Size = new System.Drawing.Size(487, 510);
            this.gbContenido.TabIndex = 4;
            this.gbContenido.TabStop = false;
            // 
            // pbLotgin
            // 
            this.pbLotgin.Image = ((System.Drawing.Image)(resources.GetObject("pbLotgin.Image")));
            this.pbLotgin.Location = new System.Drawing.Point(172, 21);
            this.pbLotgin.Name = "pbLotgin";
            this.pbLotgin.Size = new System.Drawing.Size(170, 163);
            this.pbLotgin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLotgin.TabIndex = 5;
            this.pbLotgin.TabStop = false;
            // 
            // gbcontenidoinput
            // 
            this.gbcontenidoinput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(224)))), ((int)(((byte)(198)))));
            this.gbcontenidoinput.Controls.Add(this.btnLogin);
            this.gbcontenidoinput.Controls.Add(this.llbRecuperar);
            this.gbcontenidoinput.Controls.Add(this.txtContra);
            this.gbcontenidoinput.Controls.Add(this.txtUsuario);
            this.gbcontenidoinput.Controls.Add(this.lbContra);
            this.gbcontenidoinput.Controls.Add(this.lbUsuario);
            this.gbcontenidoinput.Location = new System.Drawing.Point(50, 213);
            this.gbcontenidoinput.Name = "gbcontenidoinput";
            this.gbcontenidoinput.Size = new System.Drawing.Size(389, 272);
            this.gbcontenidoinput.TabIndex = 4;
            this.gbcontenidoinput.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(159, 178);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(84, 36);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // llbRecuperar
            // 
            this.llbRecuperar.AutoSize = true;
            this.llbRecuperar.Location = new System.Drawing.Point(119, 239);
            this.llbRecuperar.Name = "llbRecuperar";
            this.llbRecuperar.Size = new System.Drawing.Size(182, 16);
            this.llbRecuperar.TabIndex = 4;
            this.llbRecuperar.TabStop = true;
            this.llbRecuperar.Text = "¿has olvidado tu contraseña?";
            // 
            // pbCerrar
            // 
            this.pbCerrar.BackColor = System.Drawing.Color.Transparent;
            this.pbCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pbCerrar.Image")));
            this.pbCerrar.Location = new System.Drawing.Point(545, 5);
            this.pbCerrar.Name = "pbCerrar";
            this.pbCerrar.Size = new System.Drawing.Size(29, 30);
            this.pbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCerrar.TabIndex = 5;
            this.pbCerrar.TabStop = false;
            this.pbCerrar.Click += new System.EventHandler(this.pbCerrar_Click);
            // 
            // pbMinimizar
            // 
            this.pbMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.pbMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("pbMinimizar.Image")));
            this.pbMinimizar.Location = new System.Drawing.Point(500, 4);
            this.pbMinimizar.Name = "pbMinimizar";
            this.pbMinimizar.Size = new System.Drawing.Size(36, 37);
            this.pbMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMinimizar.TabIndex = 6;
            this.pbMinimizar.TabStop = false;
            this.pbMinimizar.Click += new System.EventHandler(this.pbMinimizar_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(97)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(580, 600);
            this.Controls.Add(this.pbMinimizar);
            this.Controls.Add(this.pbCerrar);
            this.Controls.Add(this.gbContenido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmLogin_MouseDown);
            this.gbContenido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLotgin)).EndInit();
            this.gbcontenidoinput.ResumeLayout(false);
            this.gbcontenidoinput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbContra;
        private System.Windows.Forms.GroupBox gbContenido;
        private System.Windows.Forms.PictureBox pbLotgin;
        private System.Windows.Forms.GroupBox gbcontenidoinput;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel llbRecuperar;
        private System.Windows.Forms.PictureBox pbCerrar;
        private System.Windows.Forms.PictureBox pbMinimizar;
    }
}

