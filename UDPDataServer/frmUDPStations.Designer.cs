namespace UDPDataServer
{
    partial class frmUDPStations
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.dgvMessages = new System.Windows.Forms.DataGridView();
            this.btnStopListening = new System.Windows.Forms.Button();
            this.btnBeginListening = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtSocket = new System.Windows.Forms.TextBox();
            this.Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessages)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBox1
            // 
            this.TextBox1.AcceptsReturn = true;
            this.TextBox1.AcceptsTab = true;
            this.TextBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.TextBox1.Location = new System.Drawing.Point(12, 388);
            this.TextBox1.Multiline = true;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextBox1.Size = new System.Drawing.Size(609, 118);
            this.TextBox1.TabIndex = 22;
            this.TextBox1.Text = "INFORMATION";
            // 
            // dgvMessages
            // 
            this.dgvMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMessages.Location = new System.Drawing.Point(12, 31);
            this.dgvMessages.Name = "dgvMessages";
            this.dgvMessages.Size = new System.Drawing.Size(612, 351);
            this.dgvMessages.StandardTab = true;
            this.dgvMessages.TabIndex = 27;
            // 
            // btnStopListening
            // 
            this.btnStopListening.Enabled = false;
            this.btnStopListening.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopListening.Location = new System.Drawing.Point(290, 3);
            this.btnStopListening.Name = "btnStopListening";
            this.btnStopListening.Size = new System.Drawing.Size(53, 24);
            this.btnStopListening.TabIndex = 26;
            this.btnStopListening.Text = "Stop";
            this.btnStopListening.Click += new System.EventHandler(this.btnStopListening_Click);
            // 
            // btnBeginListening
            // 
            this.btnBeginListening.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeginListening.Location = new System.Drawing.Point(236, 3);
            this.btnBeginListening.Name = "btnBeginListening";
            this.btnBeginListening.Size = new System.Drawing.Size(53, 24);
            this.btnBeginListening.TabIndex = 25;
            this.btnBeginListening.Text = "Start";
            this.btnBeginListening.Click += new System.EventHandler(this.btnBeginListening_Click);
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(66, 7);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(74, 18);
            this.Label1.TabIndex = 24;
            this.Label1.Text = "Socket No";
            // 
            // txtSocket
            // 
            this.txtSocket.Location = new System.Drawing.Point(148, 5);
            this.txtSocket.Name = "txtSocket";
            this.txtSocket.Size = new System.Drawing.Size(68, 20);
            this.txtSocket.TabIndex = 23;
            this.txtSocket.Text = "11000";
            this.txtSocket.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(344, 3);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(53, 24);
            this.Clear.TabIndex = 28;
            this.Clear.Text = "Borrar";
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // frmUDPStations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 511);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.dgvMessages);
            this.Controls.Add(this.btnStopListening);
            this.Controls.Add(this.btnBeginListening);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtSocket);
            this.MaximizeBox = false;
            this.Name = "frmUDPStations";
            this.Text = "Monitoreo de Estaciones Conectadas";
            this.Load += new System.EventHandler(this.frmUDPStations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.DataGridView dgvMessages;
        internal System.Windows.Forms.Button btnStopListening;
        internal System.Windows.Forms.Button btnBeginListening;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtSocket;
        internal System.Windows.Forms.Button Clear;
    }
}