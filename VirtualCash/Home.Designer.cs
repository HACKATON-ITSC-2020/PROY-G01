﻿namespace VirtualCash
{
    partial class Home
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
            this.PnlMenu = new System.Windows.Forms.Panel();
            this.BtnCuenta = new System.Windows.Forms.Button();
            this.BtnTarjetas = new System.Windows.Forms.Button();
            this.BtnTienda = new System.Windows.Forms.Button();
            this.BtnDesloguear = new System.Windows.Forms.Button();
            this.PnlForms = new System.Windows.Forms.Panel();
            this.PnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlMenu
            // 
            this.PnlMenu.BackColor = System.Drawing.Color.White;
            this.PnlMenu.Controls.Add(this.BtnDesloguear);
            this.PnlMenu.Controls.Add(this.BtnTienda);
            this.PnlMenu.Controls.Add(this.BtnTarjetas);
            this.PnlMenu.Controls.Add(this.BtnCuenta);
            this.PnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlMenu.Location = new System.Drawing.Point(0, 0);
            this.PnlMenu.Name = "PnlMenu";
            this.PnlMenu.Size = new System.Drawing.Size(250, 461);
            this.PnlMenu.TabIndex = 0;
            // 
            // BtnCuenta
            // 
            this.BtnCuenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnCuenta.FlatAppearance.BorderSize = 0;
            this.BtnCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCuenta.Location = new System.Drawing.Point(0, 93);
            this.BtnCuenta.Name = "BtnCuenta";
            this.BtnCuenta.Size = new System.Drawing.Size(250, 50);
            this.BtnCuenta.TabIndex = 0;
            this.BtnCuenta.Text = "Cuenta";
            this.BtnCuenta.UseVisualStyleBackColor = true;
            this.BtnCuenta.Click += new System.EventHandler(this.BtnCuenta_Click);
            // 
            // BtnTarjetas
            // 
            this.BtnTarjetas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnTarjetas.FlatAppearance.BorderSize = 0;
            this.BtnTarjetas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTarjetas.Location = new System.Drawing.Point(0, 153);
            this.BtnTarjetas.Name = "BtnTarjetas";
            this.BtnTarjetas.Size = new System.Drawing.Size(250, 50);
            this.BtnTarjetas.TabIndex = 1;
            this.BtnTarjetas.Text = "Tarjetas";
            this.BtnTarjetas.UseVisualStyleBackColor = true;
            this.BtnTarjetas.Click += new System.EventHandler(this.BtnTarjetas_Click);
            // 
            // BtnTienda
            // 
            this.BtnTienda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnTienda.FlatAppearance.BorderSize = 0;
            this.BtnTienda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTienda.Location = new System.Drawing.Point(0, 213);
            this.BtnTienda.Name = "BtnTienda";
            this.BtnTienda.Size = new System.Drawing.Size(250, 50);
            this.BtnTienda.TabIndex = 2;
            this.BtnTienda.Text = "Tienda";
            this.BtnTienda.UseVisualStyleBackColor = true;
            this.BtnTienda.Click += new System.EventHandler(this.BtnTienda_Click);
            // 
            // BtnDesloguear
            // 
            this.BtnDesloguear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnDesloguear.FlatAppearance.BorderSize = 0;
            this.BtnDesloguear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDesloguear.Location = new System.Drawing.Point(0, 409);
            this.BtnDesloguear.Name = "BtnDesloguear";
            this.BtnDesloguear.Size = new System.Drawing.Size(250, 50);
            this.BtnDesloguear.TabIndex = 3;
            this.BtnDesloguear.Text = "Cerrar Sesión";
            this.BtnDesloguear.UseVisualStyleBackColor = true;
            this.BtnDesloguear.Click += new System.EventHandler(this.BtnDesloguear_Click);
            // 
            // PnlForms
            // 
            this.PnlForms.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PnlForms.Location = new System.Drawing.Point(250, 0);
            this.PnlForms.Name = "PnlForms";
            this.PnlForms.Size = new System.Drawing.Size(584, 461);
            this.PnlForms.TabIndex = 1;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.PnlForms);
            this.Controls.Add(this.PnlMenu);
            this.MaximumSize = new System.Drawing.Size(850, 500);
            this.MinimumSize = new System.Drawing.Size(850, 500);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.PnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlMenu;
        private System.Windows.Forms.Button BtnCuenta;
        private System.Windows.Forms.Button BtnDesloguear;
        private System.Windows.Forms.Button BtnTienda;
        private System.Windows.Forms.Button BtnTarjetas;
        private System.Windows.Forms.Panel PnlForms;
    }
}