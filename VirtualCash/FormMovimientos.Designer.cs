namespace VirtualCash
{
    partial class FormMovimientos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DtgMovimientos = new System.Windows.Forms.DataGridView();
            this.Id_Mov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transaccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblCtaCte = new System.Windows.Forms.Label();
            this.LblCH = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DtgMovimientos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DtgMovimientos
            // 
            this.DtgMovimientos.AllowUserToAddRows = false;
            this.DtgMovimientos.AllowUserToDeleteRows = false;
            this.DtgMovimientos.AllowUserToResizeRows = false;
            this.DtgMovimientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DtgMovimientos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DtgMovimientos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgMovimientos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DtgMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DtgMovimientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Mov,
            this.Importe,
            this.Transaccion,
            this.Fecha});
            this.DtgMovimientos.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtgMovimientos.DefaultCellStyle = dataGridViewCellStyle12;
            this.DtgMovimientos.EnableHeadersVisualStyles = false;
            this.DtgMovimientos.GridColor = System.Drawing.Color.White;
            this.DtgMovimientos.Location = new System.Drawing.Point(12, 167);
            this.DtgMovimientos.Name = "DtgMovimientos";
            this.DtgMovimientos.ReadOnly = true;
            this.DtgMovimientos.RowHeadersVisible = false;
            this.DtgMovimientos.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DtgMovimientos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DtgMovimientos.RowTemplate.ReadOnly = true;
            this.DtgMovimientos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DtgMovimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtgMovimientos.Size = new System.Drawing.Size(560, 282);
            this.DtgMovimientos.TabIndex = 34;
            this.DtgMovimientos.TabStop = false;
            this.DtgMovimientos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgMovimientos_CellContentClick);
            // 
            // Id_Mov
            // 
            this.Id_Mov.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Id_Mov.DefaultCellStyle = dataGridViewCellStyle8;
            this.Id_Mov.Frozen = true;
            this.Id_Mov.HeaderText = " Referencia";
            this.Id_Mov.Name = "Id_Mov";
            this.Id_Mov.ReadOnly = true;
            this.Id_Mov.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Id_Mov.Width = 140;
            // 
            // Importe
            // 
            this.Importe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Format = "N2";
            dataGridViewCellStyle9.NullValue = null;
            this.Importe.DefaultCellStyle = dataGridViewCellStyle9;
            this.Importe.Frozen = true;
            this.Importe.HeaderText = " Importe";
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            this.Importe.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Importe.Width = 140;
            // 
            // Transaccion
            // 
            this.Transaccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.NullValue = null;
            this.Transaccion.DefaultCellStyle = dataGridViewCellStyle10;
            this.Transaccion.HeaderText = "Transacción";
            this.Transaccion.Name = "Transaccion";
            this.Transaccion.ReadOnly = true;
            this.Transaccion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Transaccion.Width = 140;
            // 
            // Fecha
            // 
            this.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.Format = "d";
            dataGridViewCellStyle11.NullValue = null;
            this.Fecha.DefaultCellStyle = dataGridViewCellStyle11;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Fecha.Width = 140;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.LblCtaCte);
            this.panel1.Controls.Add(this.LblCH);
            this.panel1.Location = new System.Drawing.Point(56, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 97);
            this.panel1.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(286, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 18);
            this.label4.TabIndex = 41;
            this.label4.Text = "Cuenta corriente";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 18);
            this.label3.TabIndex = 40;
            this.label3.Text = "Caja de Ahorro";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // LblCtaCte
            // 
            this.LblCtaCte.AutoSize = true;
            this.LblCtaCte.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCtaCte.Location = new System.Drawing.Point(327, 28);
            this.LblCtaCte.Name = "LblCtaCte";
            this.LblCtaCte.Size = new System.Drawing.Size(57, 61);
            this.LblCtaCte.TabIndex = 39;
            this.LblCtaCte.Text = "0";
            this.LblCtaCte.Click += new System.EventHandler(this.LblCtaCte_Click);
            // 
            // LblCH
            // 
            this.LblCH.AutoSize = true;
            this.LblCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCH.Location = new System.Drawing.Point(65, 28);
            this.LblCH.Name = "LblCH";
            this.LblCH.Size = new System.Drawing.Size(57, 61);
            this.LblCH.TabIndex = 38;
            this.LblCH.Text = "0";
            // 
            // FormMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VirtualCash.Properties.Resources.FOONDO;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DtgMovimientos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMovimientos";
            this.Text = "FormMovimientos";
            this.Load += new System.EventHandler(this.FormMovimientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgMovimientos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DtgMovimientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Mov;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transaccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblCtaCte;
        private System.Windows.Forms.Label LblCH;
    }
}