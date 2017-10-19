namespace UDPDataServer
{
    partial class frmUDPReceive
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStopListening = new System.Windows.Forms.Button();
            this.btnBeginListening = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtSocket = new System.Windows.Forms.TextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.dgvMessages = new System.Windows.Forms.DataGridView();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmdSend = new System.Windows.Forms.Button();
            this.trvPC = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessages)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStopListening
            // 
            this.btnStopListening.Enabled = false;
            this.btnStopListening.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopListening.Location = new System.Drawing.Point(290, 5);
            this.btnStopListening.Name = "btnStopListening";
            this.btnStopListening.Size = new System.Drawing.Size(48, 24);
            this.btnStopListening.TabIndex = 20;
            this.btnStopListening.Text = "Stop";
            this.btnStopListening.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnBeginListening
            // 
            this.btnBeginListening.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeginListening.Location = new System.Drawing.Point(236, 5);
            this.btnBeginListening.Name = "btnBeginListening";
            this.btnBeginListening.Size = new System.Drawing.Size(48, 24);
            this.btnBeginListening.TabIndex = 17;
            this.btnBeginListening.Text = "Start";
            this.btnBeginListening.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(12, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(128, 16);
            this.Label1.TabIndex = 14;
            this.Label1.Text = "Receiving Socket No";
            // 
            // txtSocket
            // 
            this.txtSocket.Location = new System.Drawing.Point(148, 7);
            this.txtSocket.Name = "txtSocket";
            this.txtSocket.Size = new System.Drawing.Size(68, 20);
            this.txtSocket.TabIndex = 13;
            this.txtSocket.Text = "11000";
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(12, 391);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(62, 29);
            this.Clear.TabIndex = 12;
            this.Clear.Text = "Borrar";
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // TextBox1
            // 
            this.TextBox1.AcceptsReturn = true;
            this.TextBox1.AcceptsTab = true;
            this.TextBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.TextBox1.Location = new System.Drawing.Point(15, 267);
            this.TextBox1.Multiline = true;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextBox1.Size = new System.Drawing.Size(609, 118);
            this.TextBox1.TabIndex = 11;
            this.TextBox1.Text = "INFORMATION";
            // 
            // dgvMessages
            // 
            this.dgvMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMessages.Location = new System.Drawing.Point(12, 33);
            this.dgvMessages.Name = "dgvMessages";
            this.dgvMessages.Size = new System.Drawing.Size(326, 219);
            this.dgvMessages.TabIndex = 21;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(549, 4);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(88, 20);
            this.txtPort.TabIndex = 29;
            this.txtPort.Text = "11000";
            // 
            // Label3
            // 
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(513, 4);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(38, 18);
            this.Label3.TabIndex = 28;
            this.Label3.Text = "Port";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(356, 25);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(281, 197);
            this.txtMessage.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(353, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Mensaje:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdSend
            // 
            this.cmdSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSend.Location = new System.Drawing.Point(368, 228);
            this.cmdSend.Name = "cmdSend";
            this.cmdSend.Size = new System.Drawing.Size(96, 24);
            this.cmdSend.TabIndex = 22;
            this.cmdSend.Text = "Send";
            this.cmdSend.Click += new System.EventHandler(this.cmdSend_Click);
            // 
            // trvPC
            // 
            this.trvPC.CheckBoxes = true;
            this.trvPC.Location = new System.Drawing.Point(643, 4);
            this.trvPC.Name = "trvPC";
            this.trvPC.ShowNodeToolTips = true;
            this.trvPC.Size = new System.Drawing.Size(124, 331);
            this.trvPC.TabIndex = 30;
            this.trvPC.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView1_AfterSelect);
            this.trvPC.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeView1_NodeMouseClick);
            // 
            // frmUDPReceive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 424);
            this.Controls.Add(this.trvPC);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmdSend);
            this.Controls.Add(this.dgvMessages);
            this.Controls.Add(this.btnStopListening);
            this.Controls.Add(this.btnBeginListening);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtSocket);
            this.Controls.Add(this.Clear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmUDPReceive";
            this.Text = "Mensajes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUDPReceive_FormClosing);
            this.Load += new System.EventHandler(this.frmUDPReceive_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnStopListening;
        internal System.Windows.Forms.Button btnBeginListening;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtSocket;
        internal System.Windows.Forms.Button Clear;
        internal System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.DataGridView dgvMessages;
        internal System.Windows.Forms.TextBox txtPort;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtMessage;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Button cmdSend;
        internal System.Windows.Forms.TreeView trvPC;

    }
}