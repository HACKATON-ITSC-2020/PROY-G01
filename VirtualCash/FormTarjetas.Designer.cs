namespace VirtualCash
{
    partial class FormTarjetas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnTarjetaVisa = new System.Windows.Forms.Button();
            this.BtnTarjetaAmex = new System.Windows.Forms.Button();
            this.DtgMovimientos = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transaccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DtgMovimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnTarjetaVisa
            // 
            this.BtnTarjetaVisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTarjetaVisa.Location = new System.Drawing.Point(101, 31);
            this.BtnTarjetaVisa.Name = "BtnTarjetaVisa";
            this.BtnTarjetaVisa.Size = new System.Drawing.Size(150, 100);
            this.BtnTarjetaVisa.TabIndex = 0;
            this.BtnTarjetaVisa.Text = "Visa";
            this.BtnTarjetaVisa.UseVisualStyleBackColor = true;
            // 
            // BtnTarjetaAmex
            // 
            this.BtnTarjetaAmex.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTarjetaAmex.Location = new System.Drawing.Point(315, 31);
            this.BtnTarjetaAmex.Name = "BtnTarjetaAmex";
            this.BtnTarjetaAmex.Size = new System.Drawing.Size(150, 100);
            this.BtnTarjetaAmex.TabIndex = 1;
            this.BtnTarjetaAmex.Text = "American Express";
            this.BtnTarjetaAmex.UseVisualStyleBackColor = true;
            // 
            // DtgMovimientos
            // 
            this.DtgMovimientos.AllowUserToAddRows = false;
            this.DtgMovimientos.AllowUserToDeleteRows = false;
            this.DtgMovimientos.AllowUserToResizeRows = false;
            this.DtgMovimientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DtgMovimientos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DtgMovimientos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgMovimientos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DtgMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DtgMovimientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Transaccion,
            this.Importe});
            this.DtgMovimientos.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtgMovimientos.DefaultCellStyle = dataGridViewCellStyle5;
            this.DtgMovimientos.EnableHeadersVisualStyles = false;
            this.DtgMovimientos.GridColor = System.Drawing.SystemColors.Control;
            this.DtgMovimientos.Location = new System.Drawing.Point(12, 167);
            this.DtgMovimientos.Name = "DtgMovimientos";
            this.DtgMovimientos.ReadOnly = true;
            this.DtgMovimientos.RowHeadersVisible = false;
            this.DtgMovimientos.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DtgMovimientos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DtgMovimientos.RowTemplate.ReadOnly = true;
            this.DtgMovimientos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DtgMovimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtgMovimientos.Size = new System.Drawing.Size(364, 282);
            this.DtgMovimientos.TabIndex = 35;
            this.DtgMovimientos.TabStop = false;
            // 
            // Fecha
            // 
            this.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.Fecha.DefaultCellStyle = dataGridViewCellStyle2;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Fecha.Width = 120;
            // 
            // Transaccion
            // 
            this.Transaccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = null;
            this.Transaccion.DefaultCellStyle = dataGridViewCellStyle3;
            this.Transaccion.HeaderText = "Descripción";
            this.Transaccion.Name = "Transaccion";
            this.Transaccion.ReadOnly = true;
            this.Transaccion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Transaccion.Width = 140;
            // 
            // Importe
            // 
            this.Importe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.Importe.DefaultCellStyle = dataGridViewCellStyle4;
            this.Importe.HeaderText = " Importe";
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            this.Importe.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // FormTarjetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VirtualCash.Properties.Resources.FOONDO;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.DtgMovimientos);
            this.Controls.Add(this.BtnTarjetaAmex);
            this.Controls.Add(this.BtnTarjetaVisa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTarjetas";
            this.Text = "FormTarjetas";
            ((System.ComponentModel.ISupportInitialize)(this.DtgMovimientos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnTarjetaVisa;
        private System.Windows.Forms.Button BtnTarjetaAmex;
        private System.Windows.Forms.DataGridView DtgMovimientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transaccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
    }
}