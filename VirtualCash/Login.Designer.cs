namespace VirtualCash
{
    partial class Login
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
            this.LinkNuevoRegistro = new System.Windows.Forms.LinkLabel();
            this.LinkReestablecerClave = new System.Windows.Forms.LinkLabel();
            this.BtnIniciarSesion = new System.Windows.Forms.Button();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.TxtClave = new System.Windows.Forms.TextBox();
            this.LblCorreo = new System.Windows.Forms.Label();
            this.LblClave = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LinkNuevoRegistro
            // 
            this.LinkNuevoRegistro.AutoSize = true;
            this.LinkNuevoRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkNuevoRegistro.Location = new System.Drawing.Point(98, 165);
            this.LinkNuevoRegistro.Name = "LinkNuevoRegistro";
            this.LinkNuevoRegistro.Size = new System.Drawing.Size(70, 16);
            this.LinkNuevoRegistro.TabIndex = 24;
            this.LinkNuevoRegistro.TabStop = true;
            this.LinkNuevoRegistro.Text = "Registrate";
            this.LinkNuevoRegistro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkNuevoRegistro_LinkClicked);
            // 
            // LinkReestablecerClave
            // 
            this.LinkReestablecerClave.AutoSize = true;
            this.LinkReestablecerClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkReestablecerClave.Location = new System.Drawing.Point(142, 133);
            this.LinkReestablecerClave.Name = "LinkReestablecerClave";
            this.LinkReestablecerClave.Size = new System.Drawing.Size(100, 16);
            this.LinkReestablecerClave.TabIndex = 23;
            this.LinkReestablecerClave.TabStop = true;
            this.LinkReestablecerClave.Text = "Olvidé mi clave";
            this.LinkReestablecerClave.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkReestablecerClave_LinkClicked);
            // 
            // BtnIniciarSesion
            // 
            this.BtnIniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIniciarSesion.Location = new System.Drawing.Point(26, 191);
            this.BtnIniciarSesion.Name = "BtnIniciarSesion";
            this.BtnIniciarSesion.Size = new System.Drawing.Size(216, 48);
            this.BtnIniciarSesion.TabIndex = 25;
            this.BtnIniciarSesion.Text = "Iniciar Sesión";
            this.BtnIniciarSesion.UseVisualStyleBackColor = true;
            this.BtnIniciarSesion.Click += new System.EventHandler(this.BtnIniciarSesion_Click);
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCorreo.Location = new System.Drawing.Point(26, 48);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(216, 21);
            this.TxtCorreo.TabIndex = 26;
            // 
            // TxtClave
            // 
            this.TxtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtClave.Location = new System.Drawing.Point(26, 106);
            this.TxtClave.Name = "TxtClave";
            this.TxtClave.PasswordChar = '*';
            this.TxtClave.Size = new System.Drawing.Size(216, 21);
            this.TxtClave.TabIndex = 27;
            // 
            // LblCorreo
            // 
            this.LblCorreo.AutoSize = true;
            this.LblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCorreo.Location = new System.Drawing.Point(26, 29);
            this.LblCorreo.Name = "LblCorreo";
            this.LblCorreo.Size = new System.Drawing.Size(107, 15);
            this.LblCorreo.TabIndex = 28;
            this.LblCorreo.Text = "Correo electrónico";
            // 
            // LblClave
            // 
            this.LblClave.AutoSize = true;
            this.LblClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClave.Location = new System.Drawing.Point(26, 88);
            this.LblClave.Name = "LblClave";
            this.LblClave.Size = new System.Drawing.Size(37, 15);
            this.LblClave.TabIndex = 29;
            this.LblClave.Text = "Clave";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(270, 256);
            this.Controls.Add(this.LblClave);
            this.Controls.Add(this.LblCorreo);
            this.Controls.Add(this.TxtClave);
            this.Controls.Add(this.TxtCorreo);
            this.Controls.Add(this.BtnIniciarSesion);
            this.Controls.Add(this.LinkNuevoRegistro);
            this.Controls.Add(this.LinkReestablecerClave);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(286, 295);
            this.MinimumSize = new System.Drawing.Size(286, 295);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel LinkNuevoRegistro;
        private System.Windows.Forms.LinkLabel LinkReestablecerClave;
        private System.Windows.Forms.Button BtnIniciarSesion;
        private System.Windows.Forms.TextBox TxtCorreo;
        private System.Windows.Forms.TextBox TxtClave;
        private System.Windows.Forms.Label LblCorreo;
        private System.Windows.Forms.Label LblClave;
    }
}