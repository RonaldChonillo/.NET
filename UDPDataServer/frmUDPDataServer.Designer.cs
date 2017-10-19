namespace UDPDataServer
{
    partial class frmUDPDataServer
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
            this.components = new System.ComponentModel.Container();
            this.sttMain = new System.Windows.Forms.StatusStrip();
            this.tssMain = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ttDateLast = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssMails = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgvDataActivity = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnClear = new System.Windows.Forms.ToolStripButton();
            this.dgvMessages = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDeleteAll = new System.Windows.Forms.ToolStripButton();
            this.btnSendMessage = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.lblTotalEstaciones = new System.Windows.Forms.ToolStripLabel();
            this.dgvStations = new System.Windows.Forms.DataGridView();
            this.pnlComm = new System.Windows.Forms.Panel();
            this.picComm = new System.Windows.Forms.PictureBox();
            this.btnChangeMode = new System.Windows.Forms.Button();
            this.txtSocket = new System.Windows.Forms.TextBox();
            this.lblServerSwitch = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtComm = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniStations = new System.Windows.Forms.ToolStripMenuItem();
            this.mniReceiver = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.btnClearDone = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.lblTotalActividades = new System.Windows.Forms.ToolStripLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmdIntro = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.btnClearAll = new System.Windows.Forms.ToolStripButton();
            this.sttMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataActivity)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessages)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStations)).BeginInit();
            this.pnlComm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picComm)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sttMain
            // 
            this.sttMain.BackColor = System.Drawing.SystemColors.Control;
            this.sttMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssMain,
            this.toolStripStatusLabel1,
            this.ttDateLast,
            this.toolStripStatusLabel2,
            this.tssMails,
            this.toolStripStatusLabel6,
            this.lblDate});
            this.sttMain.Location = new System.Drawing.Point(0, 289);
            this.sttMain.Name = "sttMain";
            this.sttMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.sttMain.Size = new System.Drawing.Size(819, 25);
            this.sttMain.TabIndex = 7;
            // 
            // tssMain
            // 
            this.tssMain.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.tssMain.ForeColor = System.Drawing.Color.ForestGreen;
            this.tssMain.Name = "tssMain";
            this.tssMain.Size = new System.Drawing.Size(59, 20);
            this.tssMain.Text = "Conexión";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(200, 20);
            // 
            // ttDateLast
            // 
            this.ttDateLast.BackColor = System.Drawing.Color.White;
            this.ttDateLast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ttDateLast.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.ttDateLast.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttDateLast.ForeColor = System.Drawing.Color.Black;
            this.ttDateLast.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ttDateLast.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ttDateLast.Name = "ttDateLast";
            this.ttDateLast.Size = new System.Drawing.Size(20, 20);
            this.ttDateLast.Text = "...";
            this.ttDateLast.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(16, 20);
            this.toolStripStatusLabel2.Text = "   ";
            // 
            // tssMails
            // 
            this.tssMails.AutoSize = false;
            this.tssMails.BorderStyle = System.Windows.Forms.Border3DStyle.Raised;
            this.tssMails.Name = "tssMails";
            this.tssMails.Size = new System.Drawing.Size(25, 20);
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(37, 20);
            this.toolStripStatusLabel6.Text = "          ";
            // 
            // lblDate
            // 
            this.lblDate.ForeColor = System.Drawing.Color.DimGray;
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(95, 20);
            this.lblDate.Text = "05/08/2011 12:00";
            // 
            // dgvDataActivity
            // 
            this.dgvDataActivity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDataActivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataActivity.Location = new System.Drawing.Point(3, 28);
            this.dgvDataActivity.Name = "dgvDataActivity";
            this.dgvDataActivity.Size = new System.Drawing.Size(688, 227);
            this.dgvDataActivity.TabIndex = 8;
            this.dgvDataActivity.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvDataActivity_RowsAdded);
            this.dgvDataActivity.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvDataActivity_RowsRemoved);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(819, 284);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Controls.Add(this.pnlComm);
            this.tabPage1.Controls.Add(this.menuStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(811, 258);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Operacion";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(3, 95);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip2);
            this.splitContainer1.Panel1.Controls.Add(this.dgvMessages);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip1);
            this.splitContainer1.Panel2.Controls.Add(this.dgvStations);
            this.splitContainer1.Size = new System.Drawing.Size(807, 156);
            this.splitContainer1.SplitterDistance = 417;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 29;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnClear});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(417, 25);
            this.toolStrip2.TabIndex = 29;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnClear
            // 
            this.btnClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnClear.Image = global::UDPDataServer.Properties.Resources.gif_cerrar_peq3;
            this.btnClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(23, 22);
            this.btnClear.Text = "Limpiar log";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvMessages
            // 
            this.dgvMessages.AllowUserToAddRows = false;
            this.dgvMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMessages.Location = new System.Drawing.Point(3, 28);
            this.dgvMessages.Name = "dgvMessages";
            this.dgvMessages.ReadOnly = true;
            this.dgvMessages.Size = new System.Drawing.Size(412, 125);
            this.dgvMessages.TabIndex = 28;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.btnDeleteAll,
            this.btnSendMessage,
            this.toolStripLabel2,
            this.lblTotalEstaciones});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(388, 25);
            this.toolStrip1.TabIndex = 33;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel1.ForeColor = System.Drawing.Color.DarkGreen;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(64, 22);
            this.toolStripLabel1.Text = "Estaciones";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeleteAll.Image = global::UDPDataServer.Properties.Resources.png_refresh_on;
            this.btnDeleteAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(23, 22);
            this.btnDeleteAll.Text = "...";
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSendMessage.Image = global::UDPDataServer.Properties.Resources.icon_sendmail_01;
            this.btnSendMessage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(23, 22);
            this.btnSendMessage.Text = "Enviar mensaje";
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.AutoSize = false;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(100, 22);
            this.toolStripLabel2.Text = "  ";
            // 
            // lblTotalEstaciones
            // 
            this.lblTotalEstaciones.Name = "lblTotalEstaciones";
            this.lblTotalEstaciones.Size = new System.Drawing.Size(71, 22);
            this.lblTotalEstaciones.Text = "0 Estaciones";
            // 
            // dgvStations
            // 
            this.dgvStations.AllowUserToAddRows = false;
            this.dgvStations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStations.Location = new System.Drawing.Point(3, 28);
            this.dgvStations.Name = "dgvStations";
            this.dgvStations.ReadOnly = true;
            this.dgvStations.Size = new System.Drawing.Size(396, 125);
            this.dgvStations.TabIndex = 34;
            this.dgvStations.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvStations_RowsAdded);
            this.dgvStations.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvStations_RowsRemoved);
            // 
            // pnlComm
            // 
            this.pnlComm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlComm.BackColor = System.Drawing.SystemColors.Control;
            this.pnlComm.Controls.Add(this.picComm);
            this.pnlComm.Controls.Add(this.btnChangeMode);
            this.pnlComm.Controls.Add(this.txtSocket);
            this.pnlComm.Controls.Add(this.lblServerSwitch);
            this.pnlComm.Controls.Add(this.Label1);
            this.pnlComm.Controls.Add(this.txtComm);
            this.pnlComm.Location = new System.Drawing.Point(3, 30);
            this.pnlComm.Name = "pnlComm";
            this.pnlComm.Size = new System.Drawing.Size(805, 61);
            this.pnlComm.TabIndex = 16;
            // 
            // picComm
            // 
            this.picComm.Image = global::UDPDataServer.Properties.Resources.gif_comunication_off;
            this.picComm.Location = new System.Drawing.Point(9, 7);
            this.picComm.Name = "picComm";
            this.picComm.Size = new System.Drawing.Size(22, 22);
            this.picComm.TabIndex = 0;
            this.picComm.TabStop = false;
            // 
            // btnChangeMode
            // 
            this.btnChangeMode.Location = new System.Drawing.Point(9, 32);
            this.btnChangeMode.Name = "btnChangeMode";
            this.btnChangeMode.Size = new System.Drawing.Size(66, 25);
            this.btnChangeMode.TabIndex = 17;
            this.btnChangeMode.Text = "Iniciar";
            this.btnChangeMode.UseVisualStyleBackColor = true;
            this.btnChangeMode.Click += new System.EventHandler(this.btnChangeMode_Click);
            // 
            // txtSocket
            // 
            this.txtSocket.BackColor = System.Drawing.Color.Snow;
            this.txtSocket.Location = new System.Drawing.Point(90, 4);
            this.txtSocket.Name = "txtSocket";
            this.txtSocket.ReadOnly = true;
            this.txtSocket.Size = new System.Drawing.Size(68, 20);
            this.txtSocket.TabIndex = 15;
            this.txtSocket.Text = "11000";
            // 
            // lblServerSwitch
            // 
            this.lblServerSwitch.AutoSize = true;
            this.lblServerSwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerSwitch.ForeColor = System.Drawing.Color.Red;
            this.lblServerSwitch.Location = new System.Drawing.Point(81, 38);
            this.lblServerSwitch.Name = "lblServerSwitch";
            this.lblServerSwitch.Size = new System.Drawing.Size(71, 13);
            this.lblServerSwitch.TabIndex = 16;
            this.lblServerSwitch.Text = "Server OFF";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(37, 7);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(51, 13);
            this.Label1.TabIndex = 16;
            this.Label1.Text = "Socket:";
            // 
            // txtComm
            // 
            this.txtComm.BackColor = System.Drawing.Color.Black;
            this.txtComm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtComm.Font = new System.Drawing.Font("Consolas", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComm.ForeColor = System.Drawing.Color.White;
            this.txtComm.Location = new System.Drawing.Point(164, 3);
            this.txtComm.Multiline = true;
            this.txtComm.Name = "txtComm";
            this.txtComm.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComm.Size = new System.Drawing.Size(401, 54);
            this.txtComm.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(805, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniStations,
            this.mniReceiver});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // mniStations
            // 
            this.mniStations.Name = "mniStations";
            this.mniStations.Size = new System.Drawing.Size(129, 22);
            this.mniStations.Text = "Estaciones";
            this.mniStations.Click += new System.EventHandler(this.mniStations_Click);
            // 
            // mniReceiver
            // 
            this.mniReceiver.Name = "mniReceiver";
            this.mniReceiver.Size = new System.Drawing.Size(129, 22);
            this.mniReceiver.Text = "Receiver";
            this.mniReceiver.Click += new System.EventHandler(this.mniReceiver_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.toolStrip3);
            this.tabPage3.Controls.Add(this.dgvDataActivity);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(811, 258);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "DataActivity";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // toolStrip3
            // 
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnClearDone,
            this.btnClearAll,
            this.toolStripLabel3,
            this.lblTotalActividades});
            this.toolStrip3.Location = new System.Drawing.Point(0, 0);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(811, 25);
            this.toolStrip3.TabIndex = 9;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // btnClearDone
            // 
            this.btnClearDone.Image = global::UDPDataServer.Properties.Resources.png_refresh_on;
            this.btnClearDone.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClearDone.Name = "btnClearDone";
            this.btnClearDone.Size = new System.Drawing.Size(130, 22);
            this.btnClearDone.Text = "Limpiar terminados";
            this.btnClearDone.Click += new System.EventHandler(this.btnClearDone_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.AutoSize = false;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(100, 22);
            // 
            // lblTotalActividades
            // 
            this.lblTotalActividades.Name = "lblTotalActividades";
            this.lblTotalActividades.Size = new System.Drawing.Size(77, 22);
            this.lblTotalActividades.Text = "0 Actividades";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cmdIntro);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(811, 258);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SqlServer";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cmdIntro
            // 
            this.cmdIntro.BackColor = System.Drawing.SystemColors.Control;
            this.cmdIntro.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdIntro.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmdIntro.Location = new System.Drawing.Point(269, 59);
            this.cmdIntro.Name = "cmdIntro";
            this.cmdIntro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdIntro.Size = new System.Drawing.Size(76, 38);
            this.cmdIntro.TabIndex = 16;
            this.cmdIntro.Text = "&Conectar";
            this.cmdIntro.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(84, 24);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(146, 20);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "192.168.14.55";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(25, 27);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Servidor:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.Label2);
            this.panel2.Controls.Add(this.Label3);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.panel2.Location = new System.Drawing.Point(17, 46);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel2.Size = new System.Drawing.Size(246, 55);
            this.panel2.TabIndex = 15;
            this.panel2.TabStop = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(66, 31);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(145, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "rootwallescopusa";
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(66, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "sa";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.DimGray;
            this.Label2.Location = new System.Drawing.Point(24, 6);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(42, 13);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Login:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.DimGray;
            this.Label3.Location = new System.Drawing.Point(1, 34);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label3.Size = new System.Drawing.Size(65, 13);
            this.Label3.TabIndex = 3;
            this.Label3.Text = "Password:";
            // 
            // tmrMain
            // 
            this.tmrMain.Interval = 1000;
            this.tmrMain.Tick += new System.EventHandler(this.tmrMain_Tick);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Image = global::UDPDataServer.Properties.Resources.png_refresh_on;
            this.btnClearAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(95, 22);
            this.btnClearAll.Text = "Limpiar todo";
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // frmUDPDataServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 314);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.sttMain);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmUDPDataServer";
            this.Text = "UDPDataServer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUDPDataServer_FormClosing);
            this.Load += new System.EventHandler(this.frmUDPDataServer_Load);
            this.sttMain.ResumeLayout(false);
            this.sttMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataActivity)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessages)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStations)).EndInit();
            this.pnlComm.ResumeLayout(false);
            this.pnlComm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picComm)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.StatusStrip sttMain;
        public System.Windows.Forms.ToolStripStatusLabel tssMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel ttDateLast;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tssMails;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        public System.Windows.Forms.ToolStripStatusLabel lblDate;
        private System.Windows.Forms.DataGridView dgvDataActivity;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.Button cmdIntro;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label Label2;
        public System.Windows.Forms.Label Label3;
        private System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mniStations;
        private System.Windows.Forms.ToolStripMenuItem mniReceiver;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtComm;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtSocket;
        private System.Windows.Forms.Button btnChangeMode;
        private System.Windows.Forms.PictureBox picComm;
        private System.Windows.Forms.Panel pnlComm;
        private System.Windows.Forms.DataGridView dgvMessages;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnClear;
        internal System.Windows.Forms.Label lblServerSwitch;
        private System.Windows.Forms.DataGridView dgvStations;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton btnClearDone;
        private System.Windows.Forms.Timer tmrMain;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnDeleteAll;
        private System.Windows.Forms.ToolStripButton btnSendMessage;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel lblTotalEstaciones;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel lblTotalActividades;
        private System.Windows.Forms.ToolStripButton btnClearAll;
    }
}

