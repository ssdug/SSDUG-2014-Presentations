﻿namespace Microsoft.WindowsAzure.CAT.ServiceBusExplorer
{
    partial class TestTopicControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.mainTabMessagePage = new System.Windows.Forms.TabPage();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.messageTabControl = new System.Windows.Forms.TabControl();
            this.tabMessagePage = new System.Windows.Forms.TabPage();
            this.grouperMessageText = new Microsoft.WindowsAzure.CAT.ServiceBusExplorer.Grouper();
            this.txtMessageText = new System.Windows.Forms.TextBox();
            this.tabFilesPage = new System.Windows.Forms.TabPage();
            this.grouperMessageFiles = new Microsoft.WindowsAzure.CAT.ServiceBusExplorer.Grouper();
            this.checkBoxFileName = new System.Windows.Forms.CheckBox();
            this.messageFileListView = new System.Windows.Forms.ListView();
            this.nameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sizeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grouperMessageProperties = new Microsoft.WindowsAzure.CAT.ServiceBusExplorer.Grouper();
            this.propertiesDataGridView = new System.Windows.Forms.DataGridView();
            this.mainTabSenderPage = new System.Windows.Forms.TabPage();
            this.senderEnabledCheckBox = new System.Windows.Forms.CheckBox();
            this.grouperSender = new Microsoft.WindowsAzure.CAT.ServiceBusExplorer.Grouper();
            this.txtSenderThinkTime = new System.Windows.Forms.TextBox();
            this.lblSenderThinkTime = new System.Windows.Forms.Label();
            this.checkBoxSenderThinkTime = new System.Windows.Forms.CheckBox();
            this.txtSendTaskCount = new System.Windows.Forms.TextBox();
            this.checkBoxSendBatch = new System.Windows.Forms.CheckBox();
            this.checkBoxAddMessageNumber = new System.Windows.Forms.CheckBox();
            this.checkBoxSenderEnableGraph = new System.Windows.Forms.CheckBox();
            this.checkBoxSenderEnableStatistics = new System.Windows.Forms.CheckBox();
            this.checkBoxOneSessionPerTask = new System.Windows.Forms.CheckBox();
            this.checkBoxUpdateMessageId = new System.Windows.Forms.CheckBox();
            this.checkBoxEnableSenderLogging = new System.Windows.Forms.CheckBox();
            this.checkBoxSenderVerboseLogging = new System.Windows.Forms.CheckBox();
            this.checkBoxSenderCommitTransaction = new System.Windows.Forms.CheckBox();
            this.checkBoxSenderUseTransaction = new System.Windows.Forms.CheckBox();
            this.lblSendBatchSize = new System.Windows.Forms.Label();
            this.txtSendBatchSize = new System.Windows.Forms.TextBox();
            this.lblBody = new System.Windows.Forms.Label();
            this.cboBodyType = new System.Windows.Forms.ComboBox();
            this.lblSendTaskCount = new System.Windows.Forms.Label();
            this.txtMessageCount = new System.Windows.Forms.TextBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.grouperMessage = new Microsoft.WindowsAzure.CAT.ServiceBusExplorer.Grouper();
            this.lblContentType = new System.Windows.Forms.Label();
            this.txtContentType = new System.Windows.Forms.TextBox();
            this.txtScheduledEnqueueTimeUtc = new System.Windows.Forms.TextBox();
            this.lblScheduledEnqueueTimeUtc = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.txtTimeToLive = new System.Windows.Forms.TextBox();
            this.lblTimeToLive = new System.Windows.Forms.Label();
            this.lblReplyToSessionId = new System.Windows.Forms.Label();
            this.txtReplyToSessionId = new System.Windows.Forms.TextBox();
            this.lblReplyTo = new System.Windows.Forms.Label();
            this.txtReplyTo = new System.Windows.Forms.TextBox();
            this.txtCorrelationId = new System.Windows.Forms.TextBox();
            this.lblCorrelationId = new System.Windows.Forms.Label();
            this.lblSessionId = new System.Windows.Forms.Label();
            this.txtSessionId = new System.Windows.Forms.TextBox();
            this.lblLabel = new System.Windows.Forms.Label();
            this.txtLabel = new System.Windows.Forms.TextBox();
            this.lblMessageId = new System.Windows.Forms.Label();
            this.txtMessageId = new System.Windows.Forms.TextBox();
            this.mainTabReceiverPage = new System.Windows.Forms.TabPage();
            this.receiverEnabledCheckBox = new System.Windows.Forms.CheckBox();
            this.grouperReceiver = new Microsoft.WindowsAzure.CAT.ServiceBusExplorer.Grouper();
            this.txtReceiverThinkTime = new System.Windows.Forms.TextBox();
            this.lblReceiverThinkTime = new System.Windows.Forms.Label();
            this.checkBoxReceiverThinkTime = new System.Windows.Forms.CheckBox();
            this.txtReceiveTaskCount = new System.Windows.Forms.TextBox();
            this.lblReceiveBatchSize = new System.Windows.Forms.Label();
            this.txtReceiveBatchSize = new System.Windows.Forms.TextBox();
            this.txtPrefetchCount = new System.Windows.Forms.TextBox();
            this.lblPrefetchCount = new System.Windows.Forms.Label();
            this.txtReceiveTimeout = new System.Windows.Forms.TextBox();
            this.txtServerTimeout = new System.Windows.Forms.TextBox();
            this.lblServerTimeout = new System.Windows.Forms.Label();
            this.txtFilterExpression = new System.Windows.Forms.TextBox();
            this.lblFilterExpr = new System.Windows.Forms.Label();
            this.cboReceivedMode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblReceiveTaskCount = new System.Windows.Forms.Label();
            this.lblServerWaitTime = new System.Windows.Forms.Label();
            this.cboSubscriptions = new System.Windows.Forms.ComboBox();
            this.lblSubscription = new System.Windows.Forms.Label();
            this.checkBoxReceiveBatch = new System.Windows.Forms.CheckBox();
            this.checkBoxReceiverUseTransaction = new System.Windows.Forms.CheckBox();
            this.checkBoxDeferMessage = new System.Windows.Forms.CheckBox();
            this.checkBoxReceiverEnableGraph = new System.Windows.Forms.CheckBox();
            this.checkBoxCompleteReceive = new System.Windows.Forms.CheckBox();
            this.checkBoxReceiverEnableStatistics = new System.Windows.Forms.CheckBox();
            this.checkBoxReadFromDeadLetter = new System.Windows.Forms.CheckBox();
            this.checkBoxMoveToDeadLetter = new System.Windows.Forms.CheckBox();
            this.checkBoxReceiverVerboseLogging = new System.Windows.Forms.CheckBox();
            this.checkBoxReceiverCommitTransaction = new System.Windows.Forms.CheckBox();
            this.checkBoxEnableReceiverLogging = new System.Windows.Forms.CheckBox();
            this.tabPageGraph = new System.Windows.Forms.TabPage();
            this.grouperReceiverStatistics = new Microsoft.WindowsAzure.CAT.ServiceBusExplorer.Grouper();
            this.receiverLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel17 = new System.Windows.Forms.TableLayoutPanel();
            this.lblReceiverLastTime = new System.Windows.Forms.Label();
            this.lblReceiverLastCaption = new System.Windows.Forms.Label();
            this.tableLayoutPanel16 = new System.Windows.Forms.TableLayoutPanel();
            this.lblReceiverAverageTime = new System.Windows.Forms.Label();
            this.lblReceiverAverageCaption = new System.Windows.Forms.Label();
            this.tableLayoutPanel15 = new System.Windows.Forms.TableLayoutPanel();
            this.lblReceiverMinimumTime = new System.Windows.Forms.Label();
            this.lblReceiverMinimumCaption = new System.Windows.Forms.Label();
            this.tableLayoutPanel14 = new System.Windows.Forms.TableLayoutPanel();
            this.lblReceiverMaximumTime = new System.Windows.Forms.Label();
            this.lblReceiverMaximumCaption = new System.Windows.Forms.Label();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.lblReceiverMessagesPerSecond = new System.Windows.Forms.Label();
            this.lblReceiverMessagesPerSecondCaption = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.lblReceiverMessageNumber = new System.Windows.Forms.Label();
            this.lblReceiverCallsSuccessedCaption = new System.Windows.Forms.Label();
            this.grouperSenderStatistics = new Microsoft.WindowsAzure.CAT.ServiceBusExplorer.Grouper();
            this.senderLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSenderAverageTime = new System.Windows.Forms.Label();
            this.lblSenderAverageCaption = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSenderLastTime = new System.Windows.Forms.Label();
            this.lblSenderLastCaption = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSenderMinimumTime = new System.Windows.Forms.Label();
            this.lblSenderMinimumCaption = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSenderMaximumTime = new System.Windows.Forms.Label();
            this.lblSenderMaximumCaption = new System.Windows.Forms.Label();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSenderMessagesPerSecond = new System.Windows.Forms.Label();
            this.lblSenderMessagesPerSecondCaption = new System.Windows.Forms.Label();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSenderMessageNumber = new System.Windows.Forms.Label();
            this.lblSenderCallsSuccessedCaption = new System.Windows.Forms.Label();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnClearFiles = new System.Windows.Forms.Button();
            this.btnSelectFiles = new System.Windows.Forms.Button();
            this.mainTabControl.SuspendLayout();
            this.mainTabMessagePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.messageTabControl.SuspendLayout();
            this.tabMessagePage.SuspendLayout();
            this.grouperMessageText.SuspendLayout();
            this.tabFilesPage.SuspendLayout();
            this.grouperMessageFiles.SuspendLayout();
            this.grouperMessageProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesDataGridView)).BeginInit();
            this.mainTabSenderPage.SuspendLayout();
            this.grouperSender.SuspendLayout();
            this.grouperMessage.SuspendLayout();
            this.mainTabReceiverPage.SuspendLayout();
            this.grouperReceiver.SuspendLayout();
            this.tabPageGraph.SuspendLayout();
            this.grouperReceiverStatistics.SuspendLayout();
            this.receiverLayoutPanel.SuspendLayout();
            this.tableLayoutPanel17.SuspendLayout();
            this.tableLayoutPanel16.SuspendLayout();
            this.tableLayoutPanel15.SuspendLayout();
            this.tableLayoutPanel14.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.grouperSenderStatistics.SuspendLayout();
            this.senderLayoutPanel.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStart.Location = new System.Drawing.Point(1120, 482);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(96, 30);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            this.btnStart.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.btnStart.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancel.Location = new System.Drawing.Point(1227, 482);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 30);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.btnCancel.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // mainTabControl
            // 
            this.mainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTabControl.Controls.Add(this.mainTabMessagePage);
            this.mainTabControl.Controls.Add(this.mainTabSenderPage);
            this.mainTabControl.Controls.Add(this.mainTabReceiverPage);
            this.mainTabControl.Controls.Add(this.tabPageGraph);
            this.mainTabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.mainTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTabControl.Location = new System.Drawing.Point(21, 20);
            this.mainTabControl.Margin = new System.Windows.Forms.Padding(4);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1301, 453);
            this.mainTabControl.TabIndex = 11;
            this.mainTabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.mainTabControl_DrawItem);
            // 
            // mainTabMessagePage
            // 
            this.mainTabMessagePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.mainTabMessagePage.Controls.Add(this.splitContainer);
            this.mainTabMessagePage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mainTabMessagePage.Location = new System.Drawing.Point(4, 27);
            this.mainTabMessagePage.Margin = new System.Windows.Forms.Padding(4);
            this.mainTabMessagePage.Name = "mainTabMessagePage";
            this.mainTabMessagePage.Padding = new System.Windows.Forms.Padding(4);
            this.mainTabMessagePage.Size = new System.Drawing.Size(1293, 422);
            this.mainTabMessagePage.TabIndex = 0;
            this.mainTabMessagePage.Text = "Message";
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.Location = new System.Drawing.Point(21, 10);
            this.splitContainer.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.messageTabControl);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.grouperMessageProperties);
            this.splitContainer.Size = new System.Drawing.Size(1248, 394);
            this.splitContainer.SplitterDistance = 612;
            this.splitContainer.SplitterWidth = 21;
            this.splitContainer.TabIndex = 2;
            // 
            // messageTabControl
            // 
            this.messageTabControl.Controls.Add(this.tabMessagePage);
            this.messageTabControl.Controls.Add(this.tabFilesPage);
            this.messageTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageTabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.messageTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageTabControl.Location = new System.Drawing.Point(0, 0);
            this.messageTabControl.Margin = new System.Windows.Forms.Padding(4);
            this.messageTabControl.Name = "messageTabControl";
            this.messageTabControl.SelectedIndex = 0;
            this.messageTabControl.Size = new System.Drawing.Size(612, 394);
            this.messageTabControl.TabIndex = 11;
            this.messageTabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.messageTabControl_DrawItem);
            // 
            // tabMessagePage
            // 
            this.tabMessagePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.tabMessagePage.Controls.Add(this.grouperMessageText);
            this.tabMessagePage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabMessagePage.Location = new System.Drawing.Point(4, 27);
            this.tabMessagePage.Margin = new System.Windows.Forms.Padding(4);
            this.tabMessagePage.Name = "tabMessagePage";
            this.tabMessagePage.Size = new System.Drawing.Size(604, 363);
            this.tabMessagePage.TabIndex = 2;
            this.tabMessagePage.Text = "Message";
            // 
            // grouperMessageText
            // 
            this.grouperMessageText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grouperMessageText.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.grouperMessageText.BackgroundGradientColor = System.Drawing.Color.White;
            this.grouperMessageText.BackgroundGradientMode = Microsoft.WindowsAzure.CAT.ServiceBusExplorer.Grouper.GroupBoxGradientMode.None;
            this.grouperMessageText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.grouperMessageText.BorderThickness = 1F;
            this.grouperMessageText.Controls.Add(this.txtMessageText);
            this.grouperMessageText.CustomGroupBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.grouperMessageText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.grouperMessageText.ForeColor = System.Drawing.Color.White;
            this.grouperMessageText.GroupImage = null;
            this.grouperMessageText.GroupTitle = "Message Text";
            this.grouperMessageText.Location = new System.Drawing.Point(21, 10);
            this.grouperMessageText.Margin = new System.Windows.Forms.Padding(4);
            this.grouperMessageText.Name = "grouperMessageText";
            this.grouperMessageText.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.grouperMessageText.PaintGroupBox = true;
            this.grouperMessageText.RoundCorners = 4;
            this.grouperMessageText.ShadowColor = System.Drawing.Color.DarkGray;
            this.grouperMessageText.ShadowControl = false;
            this.grouperMessageText.ShadowThickness = 1;
            this.grouperMessageText.Size = new System.Drawing.Size(555, 331);
            this.grouperMessageText.TabIndex = 14;
            // 
            // txtMessageText
            // 
            this.txtMessageText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessageText.BackColor = System.Drawing.SystemColors.Window;
            this.txtMessageText.Location = new System.Drawing.Point(21, 39);
            this.txtMessageText.Margin = new System.Windows.Forms.Padding(4);
            this.txtMessageText.Multiline = true;
            this.txtMessageText.Name = "txtMessageText";
            this.txtMessageText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMessageText.Size = new System.Drawing.Size(511, 271);
            this.txtMessageText.TabIndex = 0;
            this.txtMessageText.TextChanged += new System.EventHandler(this.txtMessageText_TextChanged);
            // 
            // tabFilesPage
            // 
            this.tabFilesPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.tabFilesPage.Controls.Add(this.grouperMessageFiles);
            this.tabFilesPage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabFilesPage.Location = new System.Drawing.Point(4, 27);
            this.tabFilesPage.Margin = new System.Windows.Forms.Padding(4);
            this.tabFilesPage.Name = "tabFilesPage";
            this.tabFilesPage.Padding = new System.Windows.Forms.Padding(4);
            this.tabFilesPage.Size = new System.Drawing.Size(604, 363);
            this.tabFilesPage.TabIndex = 5;
            this.tabFilesPage.Text = "Files";
            // 
            // grouperMessageFiles
            // 
            this.grouperMessageFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grouperMessageFiles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.grouperMessageFiles.BackgroundGradientColor = System.Drawing.Color.White;
            this.grouperMessageFiles.BackgroundGradientMode = Microsoft.WindowsAzure.CAT.ServiceBusExplorer.Grouper.GroupBoxGradientMode.None;
            this.grouperMessageFiles.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.grouperMessageFiles.BorderThickness = 1F;
            this.grouperMessageFiles.Controls.Add(this.checkBoxFileName);
            this.grouperMessageFiles.Controls.Add(this.messageFileListView);
            this.grouperMessageFiles.CustomGroupBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.grouperMessageFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.grouperMessageFiles.ForeColor = System.Drawing.Color.White;
            this.grouperMessageFiles.GroupImage = null;
            this.grouperMessageFiles.GroupTitle = "Message Files";
            this.grouperMessageFiles.Location = new System.Drawing.Point(21, 10);
            this.grouperMessageFiles.Margin = new System.Windows.Forms.Padding(4);
            this.grouperMessageFiles.Name = "grouperMessageFiles";
            this.grouperMessageFiles.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.grouperMessageFiles.PaintGroupBox = true;
            this.grouperMessageFiles.RoundCorners = 4;
            this.grouperMessageFiles.ShadowColor = System.Drawing.Color.DarkGray;
            this.grouperMessageFiles.ShadowControl = false;
            this.grouperMessageFiles.ShadowThickness = 1;
            this.grouperMessageFiles.Size = new System.Drawing.Size(555, 331);
            this.grouperMessageFiles.TabIndex = 17;
            this.grouperMessageFiles.CustomPaint += new System.Action<System.Windows.Forms.PaintEventArgs>(this.grouperMessageFiles_CustomPaint);
            // 
            // checkBoxFileName
            // 
            this.checkBoxFileName.AutoSize = true;
            this.checkBoxFileName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxFileName.Location = new System.Drawing.Point(29, 43);
            this.checkBoxFileName.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxFileName.Name = "checkBoxFileName";
            this.checkBoxFileName.Size = new System.Drawing.Size(67, 21);
            this.checkBoxFileName.TabIndex = 4;
            this.checkBoxFileName.Text = "Name";
            this.checkBoxFileName.UseVisualStyleBackColor = true;
            this.checkBoxFileName.CheckedChanged += new System.EventHandler(this.checkBoxFileName_CheckedChanged);
            // 
            // messageFileListView
            // 
            this.messageFileListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messageFileListView.CheckBoxes = true;
            this.messageFileListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumnHeader,
            this.sizeColumnHeader});
            this.messageFileListView.FullRowSelect = true;
            this.messageFileListView.Location = new System.Drawing.Point(21, 39);
            this.messageFileListView.Margin = new System.Windows.Forms.Padding(4);
            this.messageFileListView.Name = "messageFileListView";
            this.messageFileListView.OwnerDraw = true;
            this.messageFileListView.Size = new System.Drawing.Size(511, 271);
            this.messageFileListView.TabIndex = 2;
            this.messageFileListView.UseCompatibleStateImageBehavior = false;
            this.messageFileListView.View = System.Windows.Forms.View.Details;
            this.messageFileListView.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.messageFileListView_DrawColumnHeader);
            this.messageFileListView.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.messageFileListView_DrawItem);
            this.messageFileListView.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.messageFileListView_DrawSubItem);
            this.messageFileListView.Resize += new System.EventHandler(this.messageFileListView_Resize);
            // 
            // nameColumnHeader
            // 
            this.nameColumnHeader.Text = "Name";
            this.nameColumnHeader.Width = 200;
            // 
            // sizeColumnHeader
            // 
            this.sizeColumnHeader.Text = "Size";
            this.sizeColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.sizeColumnHeader.Width = 70;
            // 
            // grouperMessageProperties
            // 
            this.grouperMessageProperties.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.grouperMessageProperties.BackgroundGradientColor = System.Drawing.Color.White;
            this.grouperMessageProperties.BackgroundGradientMode = Microsoft.WindowsAzure.CAT.ServiceBusExplorer.Grouper.GroupBoxGradientMode.None;
            this.grouperMessageProperties.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.grouperMessageProperties.BorderThickness = 1F;
            this.grouperMessageProperties.Controls.Add(this.propertiesDataGridView);
            this.grouperMessageProperties.CustomGroupBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.grouperMessageProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grouperMessageProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.grouperMessageProperties.ForeColor = System.Drawing.Color.White;
            this.grouperMessageProperties.GroupImage = null;
            this.grouperMessageProperties.GroupTitle = "Message Properties";
            this.grouperMessageProperties.Location = new System.Drawing.Point(0, 0);
            this.grouperMessageProperties.Margin = new System.Windows.Forms.Padding(4);
            this.grouperMessageProperties.Name = "grouperMessageProperties";
            this.grouperMessageProperties.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.grouperMessageProperties.PaintGroupBox = true;
            this.grouperMessageProperties.RoundCorners = 4;
            this.grouperMessageProperties.ShadowColor = System.Drawing.Color.DarkGray;
            this.grouperMessageProperties.ShadowControl = false;
            this.grouperMessageProperties.ShadowThickness = 1;
            this.grouperMessageProperties.Size = new System.Drawing.Size(615, 394);
            this.grouperMessageProperties.TabIndex = 15;
            this.grouperMessageProperties.CustomPaint += new System.Action<System.Windows.Forms.PaintEventArgs>(this.grouperMessageProperties_CustomPaint);
            // 
            // propertiesDataGridView
            // 
            this.propertiesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertiesDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.propertiesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.propertiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.propertiesDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.propertiesDataGridView.Location = new System.Drawing.Point(21, 39);
            this.propertiesDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.propertiesDataGridView.Name = "propertiesDataGridView";
            this.propertiesDataGridView.RowHeadersWidth = 20;
            this.propertiesDataGridView.Size = new System.Drawing.Size(572, 335);
            this.propertiesDataGridView.TabIndex = 0;
            this.propertiesDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.propertiesDataGridView_RowsAdded);
            this.propertiesDataGridView.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.propertiesDataGridView_RowsRemoved);
            this.propertiesDataGridView.Resize += new System.EventHandler(this.propertiesDataGridView_Resize);
            // 
            // mainTabSenderPage
            // 
            this.mainTabSenderPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.mainTabSenderPage.Controls.Add(this.senderEnabledCheckBox);
            this.mainTabSenderPage.Controls.Add(this.grouperSender);
            this.mainTabSenderPage.Controls.Add(this.grouperMessage);
            this.mainTabSenderPage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mainTabSenderPage.Location = new System.Drawing.Point(4, 27);
            this.mainTabSenderPage.Margin = new System.Windows.Forms.Padding(4);
            this.mainTabSenderPage.Name = "mainTabSenderPage";
            this.mainTabSenderPage.Padding = new System.Windows.Forms.Padding(4);
            this.mainTabSenderPage.Size = new System.Drawing.Size(1293, 422);
            this.mainTabSenderPage.TabIndex = 1;
            this.mainTabSenderPage.Text = "Sender";
            // 
            // senderEnabledCheckBox
            // 
            this.senderEnabledCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.senderEnabledCheckBox.AutoSize = true;
            this.senderEnabledCheckBox.Checked = true;
            this.senderEnabledCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.senderEnabledCheckBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.senderEnabledCheckBox.Location = new System.Drawing.Point(1134, 15);
            this.senderEnabledCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.senderEnabledCheckBox.Name = "senderEnabledCheckBox";
            this.senderEnabledCheckBox.Size = new System.Drawing.Size(87, 22);
            this.senderEnabledCheckBox.TabIndex = 14;
            this.senderEnabledCheckBox.Text = "Enabled:";
            this.senderEnabledCheckBox.UseVisualStyleBackColor = true;
            this.senderEnabledCheckBox.CheckedChanged += new System.EventHandler(this.senderEnabledCheckBox_CheckedChanged);
            // 
            // grouperSender
            // 
            this.grouperSender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grouperSender.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.grouperSender.BackgroundGradientColor = System.Drawing.Color.White;
            this.grouperSender.BackgroundGradientMode = Microsoft.WindowsAzure.CAT.ServiceBusExplorer.Grouper.GroupBoxGradientMode.None;
            this.grouperSender.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.grouperSender.BorderThickness = 1F;
            this.grouperSender.Controls.Add(this.txtSenderThinkTime);
            this.grouperSender.Controls.Add(this.lblSenderThinkTime);
            this.grouperSender.Controls.Add(this.checkBoxSenderThinkTime);
            this.grouperSender.Controls.Add(this.txtSendTaskCount);
            this.grouperSender.Controls.Add(this.checkBoxSendBatch);
            this.grouperSender.Controls.Add(this.checkBoxAddMessageNumber);
            this.grouperSender.Controls.Add(this.checkBoxSenderEnableGraph);
            this.grouperSender.Controls.Add(this.checkBoxSenderEnableStatistics);
            this.grouperSender.Controls.Add(this.checkBoxOneSessionPerTask);
            this.grouperSender.Controls.Add(this.checkBoxUpdateMessageId);
            this.grouperSender.Controls.Add(this.checkBoxEnableSenderLogging);
            this.grouperSender.Controls.Add(this.checkBoxSenderVerboseLogging);
            this.grouperSender.Controls.Add(this.checkBoxSenderCommitTransaction);
            this.grouperSender.Controls.Add(this.checkBoxSenderUseTransaction);
            this.grouperSender.Controls.Add(this.lblSendBatchSize);
            this.grouperSender.Controls.Add(this.txtSendBatchSize);
            this.grouperSender.Controls.Add(this.lblBody);
            this.grouperSender.Controls.Add(this.cboBodyType);
            this.grouperSender.Controls.Add(this.lblSendTaskCount);
            this.grouperSender.Controls.Add(this.txtMessageCount);
            this.grouperSender.Controls.Add(this.lblCount);
            this.grouperSender.CustomGroupBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.grouperSender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.grouperSender.ForeColor = System.Drawing.Color.White;
            this.grouperSender.GroupImage = null;
            this.grouperSender.GroupTitle = "Configuration";
            this.grouperSender.Location = new System.Drawing.Point(832, 30);
            this.grouperSender.Margin = new System.Windows.Forms.Padding(4);
            this.grouperSender.Name = "grouperSender";
            this.grouperSender.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.grouperSender.PaintGroupBox = true;
            this.grouperSender.RoundCorners = 4;
            this.grouperSender.ShadowColor = System.Drawing.Color.DarkGray;
            this.grouperSender.ShadowControl = false;
            this.grouperSender.ShadowThickness = 1;
            this.grouperSender.Size = new System.Drawing.Size(437, 374);
            this.grouperSender.TabIndex = 17;
            this.grouperSender.CustomPaint += new System.Action<System.Windows.Forms.PaintEventArgs>(this.grouperSender_CustomPaint);
            // 
            // txtSenderThinkTime
            // 
            this.txtSenderThinkTime.Enabled = false;
            this.txtSenderThinkTime.Location = new System.Drawing.Point(320, 246);
            this.txtSenderThinkTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenderThinkTime.Name = "txtSenderThinkTime";
            this.txtSenderThinkTime.Size = new System.Drawing.Size(95, 23);
            this.txtSenderThinkTime.TabIndex = 85;
            this.txtSenderThinkTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // lblSenderThinkTime
            // 
            this.lblSenderThinkTime.AutoSize = true;
            this.lblSenderThinkTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSenderThinkTime.Location = new System.Drawing.Point(235, 251);
            this.lblSenderThinkTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSenderThinkTime.Name = "lblSenderThinkTime";
            this.lblSenderThinkTime.Size = new System.Drawing.Size(90, 17);
            this.lblSenderThinkTime.TabIndex = 86;
            this.lblSenderThinkTime.Text = "Interval (ms):";
            // 
            // checkBoxSenderThinkTime
            // 
            this.checkBoxSenderThinkTime.AutoSize = true;
            this.checkBoxSenderThinkTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxSenderThinkTime.Location = new System.Drawing.Point(21, 251);
            this.checkBoxSenderThinkTime.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxSenderThinkTime.Name = "checkBoxSenderThinkTime";
            this.checkBoxSenderThinkTime.Size = new System.Drawing.Size(129, 21);
            this.checkBoxSenderThinkTime.TabIndex = 84;
            this.checkBoxSenderThinkTime.Text = "Use Think Time";
            this.checkBoxSenderThinkTime.UseVisualStyleBackColor = true;
            this.checkBoxSenderThinkTime.CheckedChanged += new System.EventHandler(this.checkBoxSenderThinkTime_CheckedChanged);
            // 
            // txtSendTaskCount
            // 
            this.txtSendTaskCount.Location = new System.Drawing.Point(320, 286);
            this.txtSendTaskCount.Margin = new System.Windows.Forms.Padding(4);
            this.txtSendTaskCount.Name = "txtSendTaskCount";
            this.txtSendTaskCount.Size = new System.Drawing.Size(95, 23);
            this.txtSendTaskCount.TabIndex = 11;
            this.txtSendTaskCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // checkBoxSendBatch
            // 
            this.checkBoxSendBatch.AutoSize = true;
            this.checkBoxSendBatch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxSendBatch.Location = new System.Drawing.Point(235, 212);
            this.checkBoxSendBatch.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxSendBatch.Name = "checkBoxSendBatch";
            this.checkBoxSendBatch.Size = new System.Drawing.Size(103, 21);
            this.checkBoxSendBatch.TabIndex = 9;
            this.checkBoxSendBatch.Text = "Send Batch";
            this.checkBoxSendBatch.UseVisualStyleBackColor = true;
            this.checkBoxSendBatch.CheckedChanged += new System.EventHandler(this.checkBoxSendBatch_CheckedChanged);
            // 
            // checkBoxAddMessageNumber
            // 
            this.checkBoxAddMessageNumber.AutoSize = true;
            this.checkBoxAddMessageNumber.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxAddMessageNumber.Location = new System.Drawing.Point(21, 212);
            this.checkBoxAddMessageNumber.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxAddMessageNumber.Name = "checkBoxAddMessageNumber";
            this.checkBoxAddMessageNumber.Size = new System.Drawing.Size(109, 21);
            this.checkBoxAddMessageNumber.TabIndex = 8;
            this.checkBoxAddMessageNumber.Text = "Add Number";
            this.checkBoxAddMessageNumber.UseVisualStyleBackColor = true;
            // 
            // checkBoxSenderEnableGraph
            // 
            this.checkBoxSenderEnableGraph.AutoSize = true;
            this.checkBoxSenderEnableGraph.Enabled = false;
            this.checkBoxSenderEnableGraph.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxSenderEnableGraph.Location = new System.Drawing.Point(235, 133);
            this.checkBoxSenderEnableGraph.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxSenderEnableGraph.Name = "checkBoxSenderEnableGraph";
            this.checkBoxSenderEnableGraph.Size = new System.Drawing.Size(118, 21);
            this.checkBoxSenderEnableGraph.TabIndex = 5;
            this.checkBoxSenderEnableGraph.Text = "Enable Graph";
            this.checkBoxSenderEnableGraph.UseVisualStyleBackColor = true;
            // 
            // checkBoxSenderEnableStatistics
            // 
            this.checkBoxSenderEnableStatistics.AutoSize = true;
            this.checkBoxSenderEnableStatistics.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxSenderEnableStatistics.Location = new System.Drawing.Point(21, 133);
            this.checkBoxSenderEnableStatistics.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxSenderEnableStatistics.Name = "checkBoxSenderEnableStatistics";
            this.checkBoxSenderEnableStatistics.Size = new System.Drawing.Size(134, 21);
            this.checkBoxSenderEnableStatistics.TabIndex = 4;
            this.checkBoxSenderEnableStatistics.Text = "Enable Statistics";
            this.checkBoxSenderEnableStatistics.UseVisualStyleBackColor = true;
            this.checkBoxSenderEnableStatistics.CheckedChanged += new System.EventHandler(this.checkBoxSenderEnableStatistics_CheckedChanged);
            // 
            // checkBoxOneSessionPerTask
            // 
            this.checkBoxOneSessionPerTask.AutoSize = true;
            this.checkBoxOneSessionPerTask.Checked = true;
            this.checkBoxOneSessionPerTask.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxOneSessionPerTask.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxOneSessionPerTask.Location = new System.Drawing.Point(21, 172);
            this.checkBoxOneSessionPerTask.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxOneSessionPerTask.Name = "checkBoxOneSessionPerTask";
            this.checkBoxOneSessionPerTask.Size = new System.Drawing.Size(146, 21);
            this.checkBoxOneSessionPerTask.TabIndex = 6;
            this.checkBoxOneSessionPerTask.Text = "One Session/Task";
            this.checkBoxOneSessionPerTask.UseVisualStyleBackColor = true;
            // 
            // checkBoxUpdateMessageId
            // 
            this.checkBoxUpdateMessageId.AutoSize = true;
            this.checkBoxUpdateMessageId.Checked = true;
            this.checkBoxUpdateMessageId.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxUpdateMessageId.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxUpdateMessageId.Location = new System.Drawing.Point(235, 172);
            this.checkBoxUpdateMessageId.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxUpdateMessageId.Name = "checkBoxUpdateMessageId";
            this.checkBoxUpdateMessageId.Size = new System.Drawing.Size(148, 21);
            this.checkBoxUpdateMessageId.TabIndex = 7;
            this.checkBoxUpdateMessageId.Text = "Update MessageId";
            this.checkBoxUpdateMessageId.UseVisualStyleBackColor = true;
            // 
            // checkBoxEnableSenderLogging
            // 
            this.checkBoxEnableSenderLogging.AutoSize = true;
            this.checkBoxEnableSenderLogging.Checked = true;
            this.checkBoxEnableSenderLogging.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEnableSenderLogging.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxEnableSenderLogging.Location = new System.Drawing.Point(21, 94);
            this.checkBoxEnableSenderLogging.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxEnableSenderLogging.Name = "checkBoxEnableSenderLogging";
            this.checkBoxEnableSenderLogging.Size = new System.Drawing.Size(129, 21);
            this.checkBoxEnableSenderLogging.TabIndex = 2;
            this.checkBoxEnableSenderLogging.Text = "Enable Logging";
            this.checkBoxEnableSenderLogging.UseVisualStyleBackColor = true;
            this.checkBoxEnableSenderLogging.CheckedChanged += new System.EventHandler(this.checkBoxEnableSenderLogging_CheckedChanged);
            // 
            // checkBoxSenderVerboseLogging
            // 
            this.checkBoxSenderVerboseLogging.AutoSize = true;
            this.checkBoxSenderVerboseLogging.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxSenderVerboseLogging.Location = new System.Drawing.Point(236, 94);
            this.checkBoxSenderVerboseLogging.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxSenderVerboseLogging.Name = "checkBoxSenderVerboseLogging";
            this.checkBoxSenderVerboseLogging.Size = new System.Drawing.Size(131, 21);
            this.checkBoxSenderVerboseLogging.TabIndex = 3;
            this.checkBoxSenderVerboseLogging.Text = "Enable Verbose";
            this.checkBoxSenderVerboseLogging.UseVisualStyleBackColor = true;
            // 
            // checkBoxSenderCommitTransaction
            // 
            this.checkBoxSenderCommitTransaction.AutoSize = true;
            this.checkBoxSenderCommitTransaction.Checked = true;
            this.checkBoxSenderCommitTransaction.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSenderCommitTransaction.Enabled = false;
            this.checkBoxSenderCommitTransaction.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxSenderCommitTransaction.Location = new System.Drawing.Point(235, 54);
            this.checkBoxSenderCommitTransaction.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxSenderCommitTransaction.Name = "checkBoxSenderCommitTransaction";
            this.checkBoxSenderCommitTransaction.Size = new System.Drawing.Size(155, 21);
            this.checkBoxSenderCommitTransaction.TabIndex = 1;
            this.checkBoxSenderCommitTransaction.Text = "Commit Transaction";
            this.checkBoxSenderCommitTransaction.UseVisualStyleBackColor = true;
            // 
            // checkBoxSenderUseTransaction
            // 
            this.checkBoxSenderUseTransaction.AutoSize = true;
            this.checkBoxSenderUseTransaction.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxSenderUseTransaction.Location = new System.Drawing.Point(21, 54);
            this.checkBoxSenderUseTransaction.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxSenderUseTransaction.Name = "checkBoxSenderUseTransaction";
            this.checkBoxSenderUseTransaction.Size = new System.Drawing.Size(134, 21);
            this.checkBoxSenderUseTransaction.TabIndex = 0;
            this.checkBoxSenderUseTransaction.Text = "Use Transaction";
            this.checkBoxSenderUseTransaction.UseVisualStyleBackColor = true;
            this.checkBoxSenderUseTransaction.CheckedChanged += new System.EventHandler(this.checkBoxSenderUseTransaction_CheckedChanged);
            // 
            // lblSendBatchSize
            // 
            this.lblSendBatchSize.AutoSize = true;
            this.lblSendBatchSize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSendBatchSize.Location = new System.Drawing.Point(235, 330);
            this.lblSendBatchSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSendBatchSize.Name = "lblSendBatchSize";
            this.lblSendBatchSize.Size = new System.Drawing.Size(79, 17);
            this.lblSendBatchSize.TabIndex = 80;
            this.lblSendBatchSize.Text = "Batch Size:";
            // 
            // txtSendBatchSize
            // 
            this.txtSendBatchSize.Location = new System.Drawing.Point(320, 325);
            this.txtSendBatchSize.Margin = new System.Windows.Forms.Padding(4);
            this.txtSendBatchSize.Name = "txtSendBatchSize";
            this.txtSendBatchSize.Size = new System.Drawing.Size(95, 23);
            this.txtSendBatchSize.TabIndex = 13;
            this.txtSendBatchSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // lblBody
            // 
            this.lblBody.AutoSize = true;
            this.lblBody.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBody.Location = new System.Drawing.Point(21, 330);
            this.lblBody.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBody.Name = "lblBody";
            this.lblBody.Size = new System.Drawing.Size(80, 17);
            this.lblBody.TabIndex = 75;
            this.lblBody.Text = "Body Type:";
            // 
            // cboBodyType
            // 
            this.cboBodyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBodyType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboBodyType.FormattingEnabled = true;
            this.cboBodyType.Items.AddRange(new object[] {
            "Stream",
            "String",
            "WCF"});
            this.cboBodyType.Location = new System.Drawing.Point(128, 325);
            this.cboBodyType.Margin = new System.Windows.Forms.Padding(4);
            this.cboBodyType.Name = "cboBodyType";
            this.cboBodyType.Size = new System.Drawing.Size(95, 25);
            this.cboBodyType.TabIndex = 12;
            // 
            // lblSendTaskCount
            // 
            this.lblSendTaskCount.AutoSize = true;
            this.lblSendTaskCount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSendTaskCount.Location = new System.Drawing.Point(235, 290);
            this.lblSendTaskCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSendTaskCount.Name = "lblSendTaskCount";
            this.lblSendTaskCount.Size = new System.Drawing.Size(84, 17);
            this.lblSendTaskCount.TabIndex = 76;
            this.lblSendTaskCount.Text = "Task Count:";
            // 
            // txtMessageCount
            // 
            this.txtMessageCount.Location = new System.Drawing.Point(128, 286);
            this.txtMessageCount.Margin = new System.Windows.Forms.Padding(4);
            this.txtMessageCount.Name = "txtMessageCount";
            this.txtMessageCount.Size = new System.Drawing.Size(95, 23);
            this.txtMessageCount.TabIndex = 10;
            this.txtMessageCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCount.Location = new System.Drawing.Point(21, 290);
            this.lblCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(110, 17);
            this.lblCount.TabIndex = 73;
            this.lblCount.Text = "Message Count:";
            // 
            // grouperMessage
            // 
            this.grouperMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grouperMessage.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.grouperMessage.BackgroundGradientColor = System.Drawing.Color.White;
            this.grouperMessage.BackgroundGradientMode = Microsoft.WindowsAzure.CAT.ServiceBusExplorer.Grouper.GroupBoxGradientMode.None;
            this.grouperMessage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.grouperMessage.BorderThickness = 1F;
            this.grouperMessage.Controls.Add(this.lblContentType);
            this.grouperMessage.Controls.Add(this.txtContentType);
            this.grouperMessage.Controls.Add(this.txtScheduledEnqueueTimeUtc);
            this.grouperMessage.Controls.Add(this.lblScheduledEnqueueTimeUtc);
            this.grouperMessage.Controls.Add(this.txtTo);
            this.grouperMessage.Controls.Add(this.lblTo);
            this.grouperMessage.Controls.Add(this.txtTimeToLive);
            this.grouperMessage.Controls.Add(this.lblTimeToLive);
            this.grouperMessage.Controls.Add(this.lblReplyToSessionId);
            this.grouperMessage.Controls.Add(this.txtReplyToSessionId);
            this.grouperMessage.Controls.Add(this.lblReplyTo);
            this.grouperMessage.Controls.Add(this.txtReplyTo);
            this.grouperMessage.Controls.Add(this.txtCorrelationId);
            this.grouperMessage.Controls.Add(this.lblCorrelationId);
            this.grouperMessage.Controls.Add(this.lblSessionId);
            this.grouperMessage.Controls.Add(this.txtSessionId);
            this.grouperMessage.Controls.Add(this.lblLabel);
            this.grouperMessage.Controls.Add(this.txtLabel);
            this.grouperMessage.Controls.Add(this.lblMessageId);
            this.grouperMessage.Controls.Add(this.txtMessageId);
            this.grouperMessage.CustomGroupBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.grouperMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.grouperMessage.ForeColor = System.Drawing.Color.White;
            this.grouperMessage.GroupImage = null;
            this.grouperMessage.GroupTitle = "Message";
            this.grouperMessage.Location = new System.Drawing.Point(21, 30);
            this.grouperMessage.Margin = new System.Windows.Forms.Padding(4);
            this.grouperMessage.Name = "grouperMessage";
            this.grouperMessage.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.grouperMessage.PaintGroupBox = true;
            this.grouperMessage.RoundCorners = 4;
            this.grouperMessage.ShadowColor = System.Drawing.Color.DarkGray;
            this.grouperMessage.ShadowControl = false;
            this.grouperMessage.ShadowThickness = 1;
            this.grouperMessage.Size = new System.Drawing.Size(789, 374);
            this.grouperMessage.TabIndex = 0;
            // 
            // lblContentType
            // 
            this.lblContentType.AutoSize = true;
            this.lblContentType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblContentType.Location = new System.Drawing.Point(395, 133);
            this.lblContentType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContentType.Name = "lblContentType";
            this.lblContentType.Size = new System.Drawing.Size(93, 17);
            this.lblContentType.TabIndex = 70;
            this.lblContentType.Text = "ContentType:";
            // 
            // txtContentType
            // 
            this.txtContentType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContentType.Location = new System.Drawing.Point(523, 128);
            this.txtContentType.Margin = new System.Windows.Forms.Padding(4);
            this.txtContentType.Name = "txtContentType";
            this.txtContentType.Size = new System.Drawing.Size(244, 23);
            this.txtContentType.TabIndex = 5;
            // 
            // txtScheduledEnqueueTimeUtc
            // 
            this.txtScheduledEnqueueTimeUtc.Location = new System.Drawing.Point(128, 207);
            this.txtScheduledEnqueueTimeUtc.Margin = new System.Windows.Forms.Padding(4);
            this.txtScheduledEnqueueTimeUtc.Name = "txtScheduledEnqueueTimeUtc";
            this.txtScheduledEnqueueTimeUtc.Size = new System.Drawing.Size(244, 23);
            this.txtScheduledEnqueueTimeUtc.TabIndex = 8;
            this.txtScheduledEnqueueTimeUtc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // lblScheduledEnqueueTimeUtc
            // 
            this.lblScheduledEnqueueTimeUtc.AutoSize = true;
            this.lblScheduledEnqueueTimeUtc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblScheduledEnqueueTimeUtc.Location = new System.Drawing.Point(21, 212);
            this.lblScheduledEnqueueTimeUtc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScheduledEnqueueTimeUtc.Name = "lblScheduledEnqueueTimeUtc";
            this.lblScheduledEnqueueTimeUtc.Size = new System.Drawing.Size(107, 17);
            this.lblScheduledEnqueueTimeUtc.TabIndex = 58;
            this.lblScheduledEnqueueTimeUtc.Text = "Schedule (sec):";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(128, 89);
            this.txtTo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(244, 23);
            this.txtTo.TabIndex = 2;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTo.Location = new System.Drawing.Point(21, 94);
            this.lblTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(29, 17);
            this.lblTo.TabIndex = 69;
            this.lblTo.Text = "To:";
            // 
            // txtTimeToLive
            // 
            this.txtTimeToLive.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimeToLive.Location = new System.Drawing.Point(523, 207);
            this.txtTimeToLive.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimeToLive.Name = "txtTimeToLive";
            this.txtTimeToLive.Size = new System.Drawing.Size(244, 23);
            this.txtTimeToLive.TabIndex = 9;
            this.txtTimeToLive.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // lblTimeToLive
            // 
            this.lblTimeToLive.AutoSize = true;
            this.lblTimeToLive.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTimeToLive.Location = new System.Drawing.Point(395, 212);
            this.lblTimeToLive.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimeToLive.Name = "lblTimeToLive";
            this.lblTimeToLive.Size = new System.Drawing.Size(107, 17);
            this.lblTimeToLive.TabIndex = 68;
            this.lblTimeToLive.Text = "TimeToLive (s):";
            // 
            // lblReplyToSessionId
            // 
            this.lblReplyToSessionId.AutoSize = true;
            this.lblReplyToSessionId.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblReplyToSessionId.Location = new System.Drawing.Point(395, 172);
            this.lblReplyToSessionId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReplyToSessionId.Name = "lblReplyToSessionId";
            this.lblReplyToSessionId.Size = new System.Drawing.Size(126, 17);
            this.lblReplyToSessionId.TabIndex = 67;
            this.lblReplyToSessionId.Text = "ReplyToSessionId:";
            // 
            // txtReplyToSessionId
            // 
            this.txtReplyToSessionId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReplyToSessionId.Location = new System.Drawing.Point(523, 167);
            this.txtReplyToSessionId.Margin = new System.Windows.Forms.Padding(4);
            this.txtReplyToSessionId.Name = "txtReplyToSessionId";
            this.txtReplyToSessionId.Size = new System.Drawing.Size(244, 23);
            this.txtReplyToSessionId.TabIndex = 7;
            // 
            // lblReplyTo
            // 
            this.lblReplyTo.AutoSize = true;
            this.lblReplyTo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblReplyTo.Location = new System.Drawing.Point(21, 133);
            this.lblReplyTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReplyTo.Name = "lblReplyTo";
            this.lblReplyTo.Size = new System.Drawing.Size(65, 17);
            this.lblReplyTo.TabIndex = 66;
            this.lblReplyTo.Text = "ReplyTo:";
            // 
            // txtReplyTo
            // 
            this.txtReplyTo.Location = new System.Drawing.Point(128, 128);
            this.txtReplyTo.Margin = new System.Windows.Forms.Padding(4);
            this.txtReplyTo.Name = "txtReplyTo";
            this.txtReplyTo.Size = new System.Drawing.Size(244, 23);
            this.txtReplyTo.TabIndex = 4;
            // 
            // txtCorrelationId
            // 
            this.txtCorrelationId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCorrelationId.Location = new System.Drawing.Point(523, 89);
            this.txtCorrelationId.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorrelationId.Name = "txtCorrelationId";
            this.txtCorrelationId.Size = new System.Drawing.Size(244, 23);
            this.txtCorrelationId.TabIndex = 3;
            // 
            // lblCorrelationId
            // 
            this.lblCorrelationId.AutoSize = true;
            this.lblCorrelationId.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCorrelationId.Location = new System.Drawing.Point(395, 94);
            this.lblCorrelationId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorrelationId.Name = "lblCorrelationId";
            this.lblCorrelationId.Size = new System.Drawing.Size(92, 17);
            this.lblCorrelationId.TabIndex = 65;
            this.lblCorrelationId.Text = "CorrelationId:";
            // 
            // lblSessionId
            // 
            this.lblSessionId.AutoSize = true;
            this.lblSessionId.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSessionId.Location = new System.Drawing.Point(395, 54);
            this.lblSessionId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSessionId.Name = "lblSessionId";
            this.lblSessionId.Size = new System.Drawing.Size(73, 17);
            this.lblSessionId.TabIndex = 64;
            this.lblSessionId.Text = "SessionId:";
            // 
            // txtSessionId
            // 
            this.txtSessionId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSessionId.Location = new System.Drawing.Point(523, 49);
            this.txtSessionId.Margin = new System.Windows.Forms.Padding(4);
            this.txtSessionId.Name = "txtSessionId";
            this.txtSessionId.Size = new System.Drawing.Size(244, 23);
            this.txtSessionId.TabIndex = 1;
            // 
            // lblLabel
            // 
            this.lblLabel.AutoSize = true;
            this.lblLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLabel.Location = new System.Drawing.Point(21, 172);
            this.lblLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(47, 17);
            this.lblLabel.TabIndex = 57;
            this.lblLabel.Text = "Label:";
            // 
            // txtLabel
            // 
            this.txtLabel.Location = new System.Drawing.Point(128, 167);
            this.txtLabel.Margin = new System.Windows.Forms.Padding(4);
            this.txtLabel.Name = "txtLabel";
            this.txtLabel.Size = new System.Drawing.Size(244, 23);
            this.txtLabel.TabIndex = 6;
            this.txtLabel.TextChanged += new System.EventHandler(this.txtLabel_TextChanged);
            // 
            // lblMessageId
            // 
            this.lblMessageId.AutoSize = true;
            this.lblMessageId.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMessageId.Location = new System.Drawing.Point(21, 54);
            this.lblMessageId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessageId.Name = "lblMessageId";
            this.lblMessageId.Size = new System.Drawing.Size(80, 17);
            this.lblMessageId.TabIndex = 41;
            this.lblMessageId.Text = "MessageId:";
            // 
            // txtMessageId
            // 
            this.txtMessageId.Location = new System.Drawing.Point(128, 49);
            this.txtMessageId.Margin = new System.Windows.Forms.Padding(4);
            this.txtMessageId.Name = "txtMessageId";
            this.txtMessageId.Size = new System.Drawing.Size(244, 23);
            this.txtMessageId.TabIndex = 0;
            // 
            // mainTabReceiverPage
            // 
            this.mainTabReceiverPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.mainTabReceiverPage.Controls.Add(this.receiverEnabledCheckBox);
            this.mainTabReceiverPage.Controls.Add(this.grouperReceiver);
            this.mainTabReceiverPage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mainTabReceiverPage.Location = new System.Drawing.Point(4, 27);
            this.mainTabReceiverPage.Margin = new System.Windows.Forms.Padding(4);
            this.mainTabReceiverPage.Name = "mainTabReceiverPage";
            this.mainTabReceiverPage.Size = new System.Drawing.Size(1293, 422);
            this.mainTabReceiverPage.TabIndex = 2;
            this.mainTabReceiverPage.Text = "Receiver";
            // 
            // receiverEnabledCheckBox
            // 
            this.receiverEnabledCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.receiverEnabledCheckBox.AutoSize = true;
            this.receiverEnabledCheckBox.Checked = true;
            this.receiverEnabledCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.receiverEnabledCheckBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.receiverEnabledCheckBox.Location = new System.Drawing.Point(1188, 15);
            this.receiverEnabledCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.receiverEnabledCheckBox.Name = "receiverEnabledCheckBox";
            this.receiverEnabledCheckBox.Size = new System.Drawing.Size(87, 22);
            this.receiverEnabledCheckBox.TabIndex = 14;
            this.receiverEnabledCheckBox.Text = "Enabled:";
            this.receiverEnabledCheckBox.UseVisualStyleBackColor = true;
            this.receiverEnabledCheckBox.CheckedChanged += new System.EventHandler(this.receiverEnabledCheckBox_CheckedChanged);
            // 
            // grouperReceiver
            // 
            this.grouperReceiver.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grouperReceiver.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.grouperReceiver.BackgroundGradientColor = System.Drawing.Color.White;
            this.grouperReceiver.BackgroundGradientMode = Microsoft.WindowsAzure.CAT.ServiceBusExplorer.Grouper.GroupBoxGradientMode.None;
            this.grouperReceiver.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.grouperReceiver.BorderThickness = 1F;
            this.grouperReceiver.Controls.Add(this.txtReceiverThinkTime);
            this.grouperReceiver.Controls.Add(this.lblReceiverThinkTime);
            this.grouperReceiver.Controls.Add(this.checkBoxReceiverThinkTime);
            this.grouperReceiver.Controls.Add(this.txtReceiveTaskCount);
            this.grouperReceiver.Controls.Add(this.lblReceiveBatchSize);
            this.grouperReceiver.Controls.Add(this.txtReceiveBatchSize);
            this.grouperReceiver.Controls.Add(this.txtPrefetchCount);
            this.grouperReceiver.Controls.Add(this.lblPrefetchCount);
            this.grouperReceiver.Controls.Add(this.txtReceiveTimeout);
            this.grouperReceiver.Controls.Add(this.txtServerTimeout);
            this.grouperReceiver.Controls.Add(this.lblServerTimeout);
            this.grouperReceiver.Controls.Add(this.txtFilterExpression);
            this.grouperReceiver.Controls.Add(this.lblFilterExpr);
            this.grouperReceiver.Controls.Add(this.cboReceivedMode);
            this.grouperReceiver.Controls.Add(this.label1);
            this.grouperReceiver.Controls.Add(this.lblReceiveTaskCount);
            this.grouperReceiver.Controls.Add(this.lblServerWaitTime);
            this.grouperReceiver.Controls.Add(this.cboSubscriptions);
            this.grouperReceiver.Controls.Add(this.lblSubscription);
            this.grouperReceiver.Controls.Add(this.checkBoxReceiveBatch);
            this.grouperReceiver.Controls.Add(this.checkBoxReceiverUseTransaction);
            this.grouperReceiver.Controls.Add(this.checkBoxDeferMessage);
            this.grouperReceiver.Controls.Add(this.checkBoxReceiverEnableGraph);
            this.grouperReceiver.Controls.Add(this.checkBoxCompleteReceive);
            this.grouperReceiver.Controls.Add(this.checkBoxReceiverEnableStatistics);
            this.grouperReceiver.Controls.Add(this.checkBoxReadFromDeadLetter);
            this.grouperReceiver.Controls.Add(this.checkBoxMoveToDeadLetter);
            this.grouperReceiver.Controls.Add(this.checkBoxReceiverVerboseLogging);
            this.grouperReceiver.Controls.Add(this.checkBoxReceiverCommitTransaction);
            this.grouperReceiver.Controls.Add(this.checkBoxEnableReceiverLogging);
            this.grouperReceiver.CustomGroupBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.grouperReceiver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.grouperReceiver.ForeColor = System.Drawing.Color.White;
            this.grouperReceiver.GroupImage = null;
            this.grouperReceiver.GroupTitle = "Configuration";
            this.grouperReceiver.Location = new System.Drawing.Point(21, 30);
            this.grouperReceiver.Margin = new System.Windows.Forms.Padding(4);
            this.grouperReceiver.Name = "grouperReceiver";
            this.grouperReceiver.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.grouperReceiver.PaintGroupBox = true;
            this.grouperReceiver.RoundCorners = 4;
            this.grouperReceiver.ShadowColor = System.Drawing.Color.DarkGray;
            this.grouperReceiver.ShadowControl = false;
            this.grouperReceiver.ShadowThickness = 1;
            this.grouperReceiver.Size = new System.Drawing.Size(1248, 374);
            this.grouperReceiver.TabIndex = 15;
            this.grouperReceiver.CustomPaint += new System.Action<System.Windows.Forms.PaintEventArgs>(this.grouperReceiver_CustomPaint);
            // 
            // txtReceiverThinkTime
            // 
            this.txtReceiverThinkTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReceiverThinkTime.Enabled = false;
            this.txtReceiverThinkTime.Location = new System.Drawing.Point(1131, 286);
            this.txtReceiverThinkTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtReceiverThinkTime.Name = "txtReceiverThinkTime";
            this.txtReceiverThinkTime.Size = new System.Drawing.Size(95, 23);
            this.txtReceiverThinkTime.TabIndex = 145;
            this.txtReceiverThinkTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // lblReceiverThinkTime
            // 
            this.lblReceiverThinkTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReceiverThinkTime.AutoSize = true;
            this.lblReceiverThinkTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblReceiverThinkTime.Location = new System.Drawing.Point(1045, 290);
            this.lblReceiverThinkTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReceiverThinkTime.Name = "lblReceiverThinkTime";
            this.lblReceiverThinkTime.Size = new System.Drawing.Size(90, 17);
            this.lblReceiverThinkTime.TabIndex = 146;
            this.lblReceiverThinkTime.Text = "Interval (ms):";
            // 
            // checkBoxReceiverThinkTime
            // 
            this.checkBoxReceiverThinkTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxReceiverThinkTime.AutoSize = true;
            this.checkBoxReceiverThinkTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxReceiverThinkTime.Location = new System.Drawing.Point(838, 290);
            this.checkBoxReceiverThinkTime.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxReceiverThinkTime.Name = "checkBoxReceiverThinkTime";
            this.checkBoxReceiverThinkTime.Size = new System.Drawing.Size(129, 21);
            this.checkBoxReceiverThinkTime.TabIndex = 144;
            this.checkBoxReceiverThinkTime.Text = "Use Think Time";
            this.checkBoxReceiverThinkTime.UseVisualStyleBackColor = true;
            this.checkBoxReceiverThinkTime.CheckedChanged += new System.EventHandler(this.checkBoxReceiverThinkTime_CheckedChanged);
            // 
            // txtReceiveTaskCount
            // 
            this.txtReceiveTaskCount.Location = new System.Drawing.Point(117, 49);
            this.txtReceiveTaskCount.Margin = new System.Windows.Forms.Padding(4);
            this.txtReceiveTaskCount.Name = "txtReceiveTaskCount";
            this.txtReceiveTaskCount.Size = new System.Drawing.Size(137, 23);
            this.txtReceiveTaskCount.TabIndex = 125;
            this.txtReceiveTaskCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // lblReceiveBatchSize
            // 
            this.lblReceiveBatchSize.AutoSize = true;
            this.lblReceiveBatchSize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblReceiveBatchSize.Location = new System.Drawing.Point(21, 94);
            this.lblReceiveBatchSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReceiveBatchSize.Name = "lblReceiveBatchSize";
            this.lblReceiveBatchSize.Size = new System.Drawing.Size(79, 17);
            this.lblReceiveBatchSize.TabIndex = 140;
            this.lblReceiveBatchSize.Text = "Batch Size:";
            // 
            // txtReceiveBatchSize
            // 
            this.txtReceiveBatchSize.Location = new System.Drawing.Point(117, 89);
            this.txtReceiveBatchSize.Margin = new System.Windows.Forms.Padding(4);
            this.txtReceiveBatchSize.Name = "txtReceiveBatchSize";
            this.txtReceiveBatchSize.Size = new System.Drawing.Size(137, 23);
            this.txtReceiveBatchSize.TabIndex = 128;
            this.txtReceiveBatchSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // txtPrefetchCount
            // 
            this.txtPrefetchCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrefetchCount.Location = new System.Drawing.Point(672, 49);
            this.txtPrefetchCount.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrefetchCount.Name = "txtPrefetchCount";
            this.txtPrefetchCount.Size = new System.Drawing.Size(137, 23);
            this.txtPrefetchCount.TabIndex = 127;
            this.txtPrefetchCount.Text = "0";
            this.txtPrefetchCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // lblPrefetchCount
            // 
            this.lblPrefetchCount.AutoSize = true;
            this.lblPrefetchCount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPrefetchCount.Location = new System.Drawing.Point(555, 54);
            this.lblPrefetchCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrefetchCount.Name = "lblPrefetchCount";
            this.lblPrefetchCount.Size = new System.Drawing.Size(106, 17);
            this.lblPrefetchCount.TabIndex = 139;
            this.lblPrefetchCount.Text = "Prefetch Count:";
            // 
            // txtReceiveTimeout
            // 
            this.txtReceiveTimeout.Location = new System.Drawing.Point(405, 49);
            this.txtReceiveTimeout.Margin = new System.Windows.Forms.Padding(4);
            this.txtReceiveTimeout.Name = "txtReceiveTimeout";
            this.txtReceiveTimeout.Size = new System.Drawing.Size(137, 23);
            this.txtReceiveTimeout.TabIndex = 126;
            this.txtReceiveTimeout.Text = "1";
            this.txtReceiveTimeout.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // txtServerTimeout
            // 
            this.txtServerTimeout.Location = new System.Drawing.Point(405, 89);
            this.txtServerTimeout.Margin = new System.Windows.Forms.Padding(4);
            this.txtServerTimeout.Name = "txtServerTimeout";
            this.txtServerTimeout.Size = new System.Drawing.Size(137, 23);
            this.txtServerTimeout.TabIndex = 129;
            this.txtServerTimeout.Text = "5";
            this.txtServerTimeout.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // lblServerTimeout
            // 
            this.lblServerTimeout.AutoSize = true;
            this.lblServerTimeout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblServerTimeout.Location = new System.Drawing.Point(279, 94);
            this.lblServerTimeout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServerTimeout.Name = "lblServerTimeout";
            this.lblServerTimeout.Size = new System.Drawing.Size(130, 17);
            this.lblServerTimeout.TabIndex = 138;
            this.lblServerTimeout.Text = "Server Timeout (s):";
            // 
            // txtFilterExpression
            // 
            this.txtFilterExpression.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilterExpression.Location = new System.Drawing.Point(117, 128);
            this.txtFilterExpression.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilterExpression.Multiline = true;
            this.txtFilterExpression.Name = "txtFilterExpression";
            this.txtFilterExpression.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFilterExpression.Size = new System.Drawing.Size(692, 176);
            this.txtFilterExpression.TabIndex = 131;
            this.txtFilterExpression.Text = "1=1";
            // 
            // lblFilterExpr
            // 
            this.lblFilterExpr.AutoSize = true;
            this.lblFilterExpr.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFilterExpr.Location = new System.Drawing.Point(21, 133);
            this.lblFilterExpr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilterExpr.Name = "lblFilterExpr";
            this.lblFilterExpr.Size = new System.Drawing.Size(43, 17);
            this.lblFilterExpr.TabIndex = 137;
            this.lblFilterExpr.Text = "Filter:";
            // 
            // cboReceivedMode
            // 
            this.cboReceivedMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboReceivedMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReceivedMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboReceivedMode.FormattingEnabled = true;
            this.cboReceivedMode.Items.AddRange(new object[] {
            "PeekLock",
            "ReceiveDelete"});
            this.cboReceivedMode.Location = new System.Drawing.Point(672, 89);
            this.cboReceivedMode.Margin = new System.Windows.Forms.Padding(4);
            this.cboReceivedMode.Name = "cboReceivedMode";
            this.cboReceivedMode.Size = new System.Drawing.Size(137, 25);
            this.cboReceivedMode.TabIndex = 130;
            this.cboReceivedMode.SelectedIndexChanged += new System.EventHandler(this.cboReceivedMode_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(555, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 136;
            this.label1.Text = "Receive Mode:";
            // 
            // lblReceiveTaskCount
            // 
            this.lblReceiveTaskCount.AutoSize = true;
            this.lblReceiveTaskCount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblReceiveTaskCount.Location = new System.Drawing.Point(21, 54);
            this.lblReceiveTaskCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReceiveTaskCount.Name = "lblReceiveTaskCount";
            this.lblReceiveTaskCount.Size = new System.Drawing.Size(84, 17);
            this.lblReceiveTaskCount.TabIndex = 135;
            this.lblReceiveTaskCount.Text = "Task Count:";
            // 
            // lblServerWaitTime
            // 
            this.lblServerWaitTime.AutoSize = true;
            this.lblServerWaitTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblServerWaitTime.Location = new System.Drawing.Point(267, 54);
            this.lblServerWaitTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServerWaitTime.Name = "lblServerWaitTime";
            this.lblServerWaitTime.Size = new System.Drawing.Size(139, 17);
            this.lblServerWaitTime.TabIndex = 134;
            this.lblServerWaitTime.Text = "Receive Timeout (s):";
            // 
            // cboSubscriptions
            // 
            this.cboSubscriptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSubscriptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSubscriptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboSubscriptions.FormattingEnabled = true;
            this.cboSubscriptions.Location = new System.Drawing.Point(117, 325);
            this.cboSubscriptions.Margin = new System.Windows.Forms.Padding(4);
            this.cboSubscriptions.Name = "cboSubscriptions";
            this.cboSubscriptions.Size = new System.Drawing.Size(692, 25);
            this.cboSubscriptions.TabIndex = 132;
            // 
            // lblSubscription
            // 
            this.lblSubscription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSubscription.AutoSize = true;
            this.lblSubscription.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSubscription.Location = new System.Drawing.Point(21, 330);
            this.lblSubscription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubscription.Name = "lblSubscription";
            this.lblSubscription.Size = new System.Drawing.Size(90, 17);
            this.lblSubscription.TabIndex = 133;
            this.lblSubscription.Text = "Subscription:";
            // 
            // checkBoxReceiveBatch
            // 
            this.checkBoxReceiveBatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxReceiveBatch.AutoSize = true;
            this.checkBoxReceiveBatch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxReceiveBatch.Location = new System.Drawing.Point(840, 172);
            this.checkBoxReceiveBatch.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxReceiveBatch.Name = "checkBoxReceiveBatch";
            this.checkBoxReceiveBatch.Size = new System.Drawing.Size(121, 21);
            this.checkBoxReceiveBatch.TabIndex = 14;
            this.checkBoxReceiveBatch.Text = "Receive Batch";
            this.checkBoxReceiveBatch.UseVisualStyleBackColor = true;
            this.checkBoxReceiveBatch.CheckedChanged += new System.EventHandler(this.checkBoxReceiveBatch_CheckedChanged);
            // 
            // checkBoxReceiverUseTransaction
            // 
            this.checkBoxReceiverUseTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxReceiverUseTransaction.AutoSize = true;
            this.checkBoxReceiverUseTransaction.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxReceiverUseTransaction.Location = new System.Drawing.Point(837, 54);
            this.checkBoxReceiverUseTransaction.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxReceiverUseTransaction.Name = "checkBoxReceiverUseTransaction";
            this.checkBoxReceiverUseTransaction.Size = new System.Drawing.Size(134, 21);
            this.checkBoxReceiverUseTransaction.TabIndex = 8;
            this.checkBoxReceiverUseTransaction.Text = "Use Transaction";
            this.checkBoxReceiverUseTransaction.UseVisualStyleBackColor = true;
            this.checkBoxReceiverUseTransaction.CheckedChanged += new System.EventHandler(this.checkBoxReceiverUseTransaction_CheckedChanged);
            // 
            // checkBoxDeferMessage
            // 
            this.checkBoxDeferMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxDeferMessage.AutoSize = true;
            this.checkBoxDeferMessage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxDeferMessage.Location = new System.Drawing.Point(1050, 212);
            this.checkBoxDeferMessage.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxDeferMessage.Name = "checkBoxDeferMessage";
            this.checkBoxDeferMessage.Size = new System.Drawing.Size(126, 21);
            this.checkBoxDeferMessage.TabIndex = 17;
            this.checkBoxDeferMessage.Text = "Defer Message";
            this.checkBoxDeferMessage.UseVisualStyleBackColor = true;
            this.checkBoxDeferMessage.CheckedChanged += new System.EventHandler(this.checkBoxDeferMessage_CheckedChanged);
            // 
            // checkBoxReceiverEnableGraph
            // 
            this.checkBoxReceiverEnableGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxReceiverEnableGraph.AutoSize = true;
            this.checkBoxReceiverEnableGraph.Enabled = false;
            this.checkBoxReceiverEnableGraph.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxReceiverEnableGraph.Location = new System.Drawing.Point(1048, 133);
            this.checkBoxReceiverEnableGraph.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxReceiverEnableGraph.Name = "checkBoxReceiverEnableGraph";
            this.checkBoxReceiverEnableGraph.Size = new System.Drawing.Size(118, 21);
            this.checkBoxReceiverEnableGraph.TabIndex = 13;
            this.checkBoxReceiverEnableGraph.Text = "Enable Graph";
            this.checkBoxReceiverEnableGraph.UseVisualStyleBackColor = true;
            // 
            // checkBoxCompleteReceive
            // 
            this.checkBoxCompleteReceive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxCompleteReceive.AutoSize = true;
            this.checkBoxCompleteReceive.Checked = true;
            this.checkBoxCompleteReceive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCompleteReceive.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxCompleteReceive.Location = new System.Drawing.Point(1052, 172);
            this.checkBoxCompleteReceive.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxCompleteReceive.Name = "checkBoxCompleteReceive";
            this.checkBoxCompleteReceive.Size = new System.Drawing.Size(144, 21);
            this.checkBoxCompleteReceive.TabIndex = 15;
            this.checkBoxCompleteReceive.Text = "Complete Receive";
            this.checkBoxCompleteReceive.UseVisualStyleBackColor = true;
            // 
            // checkBoxReceiverEnableStatistics
            // 
            this.checkBoxReceiverEnableStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxReceiverEnableStatistics.AutoSize = true;
            this.checkBoxReceiverEnableStatistics.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxReceiverEnableStatistics.Location = new System.Drawing.Point(837, 133);
            this.checkBoxReceiverEnableStatistics.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxReceiverEnableStatistics.Name = "checkBoxReceiverEnableStatistics";
            this.checkBoxReceiverEnableStatistics.Size = new System.Drawing.Size(134, 21);
            this.checkBoxReceiverEnableStatistics.TabIndex = 12;
            this.checkBoxReceiverEnableStatistics.Text = "Enable Statistics";
            this.checkBoxReceiverEnableStatistics.UseVisualStyleBackColor = true;
            this.checkBoxReceiverEnableStatistics.CheckedChanged += new System.EventHandler(this.checkBoxReceiverEnableStatistics_CheckedChanged);
            // 
            // checkBoxReadFromDeadLetter
            // 
            this.checkBoxReadFromDeadLetter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxReadFromDeadLetter.AutoSize = true;
            this.checkBoxReadFromDeadLetter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxReadFromDeadLetter.Location = new System.Drawing.Point(835, 251);
            this.checkBoxReadFromDeadLetter.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxReadFromDeadLetter.Name = "checkBoxReadFromDeadLetter";
            this.checkBoxReadFromDeadLetter.Size = new System.Drawing.Size(222, 21);
            this.checkBoxReadFromDeadLetter.TabIndex = 18;
            this.checkBoxReadFromDeadLetter.Text = "Read From DeadLetter Queue";
            this.checkBoxReadFromDeadLetter.UseVisualStyleBackColor = true;
            this.checkBoxReadFromDeadLetter.CheckedChanged += new System.EventHandler(this.checkBoxReadFromDeadLetter_CheckedChanged);
            // 
            // checkBoxMoveToDeadLetter
            // 
            this.checkBoxMoveToDeadLetter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxMoveToDeadLetter.AutoSize = true;
            this.checkBoxMoveToDeadLetter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxMoveToDeadLetter.Location = new System.Drawing.Point(838, 212);
            this.checkBoxMoveToDeadLetter.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxMoveToDeadLetter.Name = "checkBoxMoveToDeadLetter";
            this.checkBoxMoveToDeadLetter.Size = new System.Drawing.Size(207, 21);
            this.checkBoxMoveToDeadLetter.TabIndex = 16;
            this.checkBoxMoveToDeadLetter.Text = "Move To DeadLetter Queue";
            this.checkBoxMoveToDeadLetter.UseVisualStyleBackColor = true;
            this.checkBoxMoveToDeadLetter.CheckedChanged += new System.EventHandler(this.checkBoxMoveToDeadLetter_CheckedChanged);
            // 
            // checkBoxReceiverVerboseLogging
            // 
            this.checkBoxReceiverVerboseLogging.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxReceiverVerboseLogging.AutoSize = true;
            this.checkBoxReceiverVerboseLogging.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxReceiverVerboseLogging.Location = new System.Drawing.Point(1049, 94);
            this.checkBoxReceiverVerboseLogging.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxReceiverVerboseLogging.Name = "checkBoxReceiverVerboseLogging";
            this.checkBoxReceiverVerboseLogging.Size = new System.Drawing.Size(131, 21);
            this.checkBoxReceiverVerboseLogging.TabIndex = 11;
            this.checkBoxReceiverVerboseLogging.Text = "Enable Verbose";
            this.checkBoxReceiverVerboseLogging.UseVisualStyleBackColor = true;
            // 
            // checkBoxReceiverCommitTransaction
            // 
            this.checkBoxReceiverCommitTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxReceiverCommitTransaction.AutoSize = true;
            this.checkBoxReceiverCommitTransaction.Checked = true;
            this.checkBoxReceiverCommitTransaction.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxReceiverCommitTransaction.Enabled = false;
            this.checkBoxReceiverCommitTransaction.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxReceiverCommitTransaction.Location = new System.Drawing.Point(1049, 54);
            this.checkBoxReceiverCommitTransaction.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxReceiverCommitTransaction.Name = "checkBoxReceiverCommitTransaction";
            this.checkBoxReceiverCommitTransaction.Size = new System.Drawing.Size(155, 21);
            this.checkBoxReceiverCommitTransaction.TabIndex = 9;
            this.checkBoxReceiverCommitTransaction.Text = "Commit Transaction";
            this.checkBoxReceiverCommitTransaction.UseVisualStyleBackColor = true;
            // 
            // checkBoxEnableReceiverLogging
            // 
            this.checkBoxEnableReceiverLogging.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxEnableReceiverLogging.AutoSize = true;
            this.checkBoxEnableReceiverLogging.Checked = true;
            this.checkBoxEnableReceiverLogging.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEnableReceiverLogging.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxEnableReceiverLogging.Location = new System.Drawing.Point(836, 94);
            this.checkBoxEnableReceiverLogging.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxEnableReceiverLogging.Name = "checkBoxEnableReceiverLogging";
            this.checkBoxEnableReceiverLogging.Size = new System.Drawing.Size(129, 21);
            this.checkBoxEnableReceiverLogging.TabIndex = 10;
            this.checkBoxEnableReceiverLogging.Text = "Enable Logging";
            this.checkBoxEnableReceiverLogging.UseVisualStyleBackColor = true;
            this.checkBoxEnableReceiverLogging.CheckedChanged += new System.EventHandler(this.checkBoxEnableReceiverLogging_CheckedChanged);
            // 
            // tabPageGraph
            // 
            this.tabPageGraph.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.tabPageGraph.Controls.Add(this.grouperReceiverStatistics);
            this.tabPageGraph.Controls.Add(this.grouperSenderStatistics);
            this.tabPageGraph.Controls.Add(this.chart);
            this.tabPageGraph.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPageGraph.Location = new System.Drawing.Point(4, 27);
            this.tabPageGraph.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageGraph.Name = "tabPageGraph";
            this.tabPageGraph.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageGraph.Size = new System.Drawing.Size(1293, 422);
            this.tabPageGraph.TabIndex = 3;
            this.tabPageGraph.Text = "Graph";
            // 
            // grouperReceiverStatistics
            // 
            this.grouperReceiverStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grouperReceiverStatistics.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.grouperReceiverStatistics.BackgroundGradientColor = System.Drawing.Color.White;
            this.grouperReceiverStatistics.BackgroundGradientMode = Microsoft.WindowsAzure.CAT.ServiceBusExplorer.Grouper.GroupBoxGradientMode.None;
            this.grouperReceiverStatistics.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.grouperReceiverStatistics.BorderThickness = 1F;
            this.grouperReceiverStatistics.Controls.Add(this.receiverLayoutPanel);
            this.grouperReceiverStatistics.CustomGroupBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.grouperReceiverStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.grouperReceiverStatistics.ForeColor = System.Drawing.Color.White;
            this.grouperReceiverStatistics.GroupImage = null;
            this.grouperReceiverStatistics.GroupTitle = "Receiver";
            this.grouperReceiverStatistics.Location = new System.Drawing.Point(1099, 10);
            this.grouperReceiverStatistics.Margin = new System.Windows.Forms.Padding(4);
            this.grouperReceiverStatistics.Name = "grouperReceiverStatistics";
            this.grouperReceiverStatistics.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.grouperReceiverStatistics.PaintGroupBox = true;
            this.grouperReceiverStatistics.RoundCorners = 4;
            this.grouperReceiverStatistics.ShadowColor = System.Drawing.Color.DarkGray;
            this.grouperReceiverStatistics.ShadowControl = false;
            this.grouperReceiverStatistics.ShadowThickness = 1;
            this.grouperReceiverStatistics.Size = new System.Drawing.Size(171, 394);
            this.grouperReceiverStatistics.TabIndex = 131;
            // 
            // receiverLayoutPanel
            // 
            this.receiverLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.receiverLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.receiverLayoutPanel.ColumnCount = 1;
            this.receiverLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.receiverLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.receiverLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.receiverLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.receiverLayoutPanel.Controls.Add(this.tableLayoutPanel17, 0, 0);
            this.receiverLayoutPanel.Controls.Add(this.tableLayoutPanel16, 0, 1);
            this.receiverLayoutPanel.Controls.Add(this.tableLayoutPanel15, 0, 2);
            this.receiverLayoutPanel.Controls.Add(this.tableLayoutPanel14, 0, 3);
            this.receiverLayoutPanel.Controls.Add(this.tableLayoutPanel12, 0, 4);
            this.receiverLayoutPanel.Controls.Add(this.tableLayoutPanel6, 0, 5);
            this.receiverLayoutPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.receiverLayoutPanel.Location = new System.Drawing.Point(21, 39);
            this.receiverLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.receiverLayoutPanel.Name = "receiverLayoutPanel";
            this.receiverLayoutPanel.RowCount = 6;
            this.receiverLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.receiverLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.receiverLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.receiverLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.receiverLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.receiverLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.receiverLayoutPanel.Size = new System.Drawing.Size(128, 335);
            this.receiverLayoutPanel.TabIndex = 122;
            // 
            // tableLayoutPanel17
            // 
            this.tableLayoutPanel17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel17.ColumnCount = 1;
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel17.Controls.Add(this.lblReceiverLastTime, 0, 1);
            this.tableLayoutPanel17.Controls.Add(this.lblReceiverLastCaption, 0, 0);
            this.tableLayoutPanel17.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel17.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel17.Name = "tableLayoutPanel17";
            this.tableLayoutPanel17.RowCount = 2;
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel17.Size = new System.Drawing.Size(120, 47);
            this.tableLayoutPanel17.TabIndex = 0;
            // 
            // lblReceiverLastTime
            // 
            this.lblReceiverLastTime.BackColor = System.Drawing.Color.White;
            this.lblReceiverLastTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblReceiverLastTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblReceiverLastTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiverLastTime.Location = new System.Drawing.Point(4, 23);
            this.lblReceiverLastTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReceiverLastTime.Name = "lblReceiverLastTime";
            this.lblReceiverLastTime.Size = new System.Drawing.Size(112, 16);
            this.lblReceiverLastTime.TabIndex = 113;
            this.lblReceiverLastTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblReceiverLastCaption
            // 
            this.lblReceiverLastCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReceiverLastCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiverLastCaption.Location = new System.Drawing.Point(4, 0);
            this.lblReceiverLastCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReceiverLastCaption.Name = "lblReceiverLastCaption";
            this.lblReceiverLastCaption.Size = new System.Drawing.Size(112, 23);
            this.lblReceiverLastCaption.TabIndex = 112;
            this.lblReceiverLastCaption.Text = "Last Time";
            // 
            // tableLayoutPanel16
            // 
            this.tableLayoutPanel16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel16.ColumnCount = 1;
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel16.Controls.Add(this.lblReceiverAverageTime, 0, 1);
            this.tableLayoutPanel16.Controls.Add(this.lblReceiverAverageCaption, 0, 0);
            this.tableLayoutPanel16.Location = new System.Drawing.Point(4, 59);
            this.tableLayoutPanel16.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel16.Name = "tableLayoutPanel16";
            this.tableLayoutPanel16.RowCount = 2;
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel16.Size = new System.Drawing.Size(120, 47);
            this.tableLayoutPanel16.TabIndex = 1;
            // 
            // lblReceiverAverageTime
            // 
            this.lblReceiverAverageTime.BackColor = System.Drawing.Color.White;
            this.lblReceiverAverageTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblReceiverAverageTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblReceiverAverageTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiverAverageTime.Location = new System.Drawing.Point(4, 23);
            this.lblReceiverAverageTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReceiverAverageTime.Name = "lblReceiverAverageTime";
            this.lblReceiverAverageTime.Size = new System.Drawing.Size(112, 16);
            this.lblReceiverAverageTime.TabIndex = 116;
            this.lblReceiverAverageTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblReceiverAverageCaption
            // 
            this.lblReceiverAverageCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReceiverAverageCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiverAverageCaption.Location = new System.Drawing.Point(4, 0);
            this.lblReceiverAverageCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReceiverAverageCaption.Name = "lblReceiverAverageCaption";
            this.lblReceiverAverageCaption.Size = new System.Drawing.Size(112, 23);
            this.lblReceiverAverageCaption.TabIndex = 115;
            this.lblReceiverAverageCaption.Text = "Average Time";
            // 
            // tableLayoutPanel15
            // 
            this.tableLayoutPanel15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel15.ColumnCount = 1;
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel15.Controls.Add(this.lblReceiverMinimumTime, 0, 1);
            this.tableLayoutPanel15.Controls.Add(this.lblReceiverMinimumCaption, 0, 0);
            this.tableLayoutPanel15.Location = new System.Drawing.Point(4, 114);
            this.tableLayoutPanel15.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel15.Name = "tableLayoutPanel15";
            this.tableLayoutPanel15.RowCount = 2;
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel15.Size = new System.Drawing.Size(120, 47);
            this.tableLayoutPanel15.TabIndex = 2;
            // 
            // lblReceiverMinimumTime
            // 
            this.lblReceiverMinimumTime.BackColor = System.Drawing.Color.White;
            this.lblReceiverMinimumTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblReceiverMinimumTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblReceiverMinimumTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiverMinimumTime.Location = new System.Drawing.Point(4, 23);
            this.lblReceiverMinimumTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReceiverMinimumTime.Name = "lblReceiverMinimumTime";
            this.lblReceiverMinimumTime.Size = new System.Drawing.Size(112, 16);
            this.lblReceiverMinimumTime.TabIndex = 118;
            this.lblReceiverMinimumTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblReceiverMinimumCaption
            // 
            this.lblReceiverMinimumCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReceiverMinimumCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiverMinimumCaption.Location = new System.Drawing.Point(4, 0);
            this.lblReceiverMinimumCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReceiverMinimumCaption.Name = "lblReceiverMinimumCaption";
            this.lblReceiverMinimumCaption.Size = new System.Drawing.Size(112, 23);
            this.lblReceiverMinimumCaption.TabIndex = 117;
            this.lblReceiverMinimumCaption.Text = "Minimum Time";
            // 
            // tableLayoutPanel14
            // 
            this.tableLayoutPanel14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel14.ColumnCount = 1;
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel14.Controls.Add(this.lblReceiverMaximumTime, 0, 1);
            this.tableLayoutPanel14.Controls.Add(this.lblReceiverMaximumCaption, 0, 0);
            this.tableLayoutPanel14.Location = new System.Drawing.Point(4, 169);
            this.tableLayoutPanel14.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel14.Name = "tableLayoutPanel14";
            this.tableLayoutPanel14.RowCount = 2;
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel14.Size = new System.Drawing.Size(120, 47);
            this.tableLayoutPanel14.TabIndex = 3;
            // 
            // lblReceiverMaximumTime
            // 
            this.lblReceiverMaximumTime.BackColor = System.Drawing.Color.White;
            this.lblReceiverMaximumTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblReceiverMaximumTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblReceiverMaximumTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiverMaximumTime.Location = new System.Drawing.Point(4, 23);
            this.lblReceiverMaximumTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReceiverMaximumTime.Name = "lblReceiverMaximumTime";
            this.lblReceiverMaximumTime.Size = new System.Drawing.Size(112, 16);
            this.lblReceiverMaximumTime.TabIndex = 126;
            this.lblReceiverMaximumTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblReceiverMaximumCaption
            // 
            this.lblReceiverMaximumCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReceiverMaximumCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiverMaximumCaption.Location = new System.Drawing.Point(4, 0);
            this.lblReceiverMaximumCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReceiverMaximumCaption.Name = "lblReceiverMaximumCaption";
            this.lblReceiverMaximumCaption.Size = new System.Drawing.Size(112, 23);
            this.lblReceiverMaximumCaption.TabIndex = 125;
            this.lblReceiverMaximumCaption.Text = "Maximum Time";
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel12.ColumnCount = 1;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel12.Controls.Add(this.lblReceiverMessagesPerSecond, 0, 1);
            this.tableLayoutPanel12.Controls.Add(this.lblReceiverMessagesPerSecondCaption, 0, 0);
            this.tableLayoutPanel12.Location = new System.Drawing.Point(4, 224);
            this.tableLayoutPanel12.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 2;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(120, 47);
            this.tableLayoutPanel12.TabIndex = 6;
            // 
            // lblReceiverMessagesPerSecond
            // 
            this.lblReceiverMessagesPerSecond.BackColor = System.Drawing.Color.White;
            this.lblReceiverMessagesPerSecond.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblReceiverMessagesPerSecond.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblReceiverMessagesPerSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiverMessagesPerSecond.Location = new System.Drawing.Point(4, 23);
            this.lblReceiverMessagesPerSecond.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReceiverMessagesPerSecond.Name = "lblReceiverMessagesPerSecond";
            this.lblReceiverMessagesPerSecond.Size = new System.Drawing.Size(112, 16);
            this.lblReceiverMessagesPerSecond.TabIndex = 141;
            this.lblReceiverMessagesPerSecond.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblReceiverMessagesPerSecondCaption
            // 
            this.lblReceiverMessagesPerSecondCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReceiverMessagesPerSecondCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiverMessagesPerSecondCaption.Location = new System.Drawing.Point(4, 0);
            this.lblReceiverMessagesPerSecondCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReceiverMessagesPerSecondCaption.Name = "lblReceiverMessagesPerSecondCaption";
            this.lblReceiverMessagesPerSecondCaption.Size = new System.Drawing.Size(112, 23);
            this.lblReceiverMessagesPerSecondCaption.TabIndex = 140;
            this.lblReceiverMessagesPerSecondCaption.Text = "Messages/Sec";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel6.Controls.Add(this.lblReceiverMessageNumber, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.lblReceiverCallsSuccessedCaption, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(4, 279);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(120, 52);
            this.tableLayoutPanel6.TabIndex = 8;
            // 
            // lblReceiverMessageNumber
            // 
            this.lblReceiverMessageNumber.BackColor = System.Drawing.Color.White;
            this.lblReceiverMessageNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblReceiverMessageNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblReceiverMessageNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiverMessageNumber.Location = new System.Drawing.Point(4, 26);
            this.lblReceiverMessageNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReceiverMessageNumber.Name = "lblReceiverMessageNumber";
            this.lblReceiverMessageNumber.Size = new System.Drawing.Size(112, 16);
            this.lblReceiverMessageNumber.TabIndex = 125;
            this.lblReceiverMessageNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblReceiverCallsSuccessedCaption
            // 
            this.lblReceiverCallsSuccessedCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReceiverCallsSuccessedCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiverCallsSuccessedCaption.Location = new System.Drawing.Point(4, 0);
            this.lblReceiverCallsSuccessedCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReceiverCallsSuccessedCaption.Name = "lblReceiverCallsSuccessedCaption";
            this.lblReceiverCallsSuccessedCaption.Size = new System.Drawing.Size(112, 26);
            this.lblReceiverCallsSuccessedCaption.TabIndex = 124;
            this.lblReceiverCallsSuccessedCaption.Text = "Messages Total";
            // 
            // grouperSenderStatistics
            // 
            this.grouperSenderStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grouperSenderStatistics.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.grouperSenderStatistics.BackgroundGradientColor = System.Drawing.Color.White;
            this.grouperSenderStatistics.BackgroundGradientMode = Microsoft.WindowsAzure.CAT.ServiceBusExplorer.Grouper.GroupBoxGradientMode.None;
            this.grouperSenderStatistics.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.grouperSenderStatistics.BorderThickness = 1F;
            this.grouperSenderStatistics.Controls.Add(this.senderLayoutPanel);
            this.grouperSenderStatistics.CustomGroupBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.grouperSenderStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.grouperSenderStatistics.ForeColor = System.Drawing.Color.White;
            this.grouperSenderStatistics.GroupImage = null;
            this.grouperSenderStatistics.GroupTitle = "Sender";
            this.grouperSenderStatistics.Location = new System.Drawing.Point(21, 10);
            this.grouperSenderStatistics.Margin = new System.Windows.Forms.Padding(4);
            this.grouperSenderStatistics.Name = "grouperSenderStatistics";
            this.grouperSenderStatistics.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.grouperSenderStatistics.PaintGroupBox = true;
            this.grouperSenderStatistics.RoundCorners = 4;
            this.grouperSenderStatistics.ShadowColor = System.Drawing.Color.DarkGray;
            this.grouperSenderStatistics.ShadowControl = false;
            this.grouperSenderStatistics.ShadowThickness = 1;
            this.grouperSenderStatistics.Size = new System.Drawing.Size(171, 394);
            this.grouperSenderStatistics.TabIndex = 130;
            // 
            // senderLayoutPanel
            // 
            this.senderLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.senderLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.senderLayoutPanel.ColumnCount = 1;
            this.senderLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.senderLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.senderLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.senderLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.senderLayoutPanel.Controls.Add(this.tableLayoutPanel7, 0, 1);
            this.senderLayoutPanel.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.senderLayoutPanel.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.senderLayoutPanel.Controls.Add(this.tableLayoutPanel5, 0, 3);
            this.senderLayoutPanel.Controls.Add(this.tableLayoutPanel8, 0, 4);
            this.senderLayoutPanel.Controls.Add(this.tableLayoutPanel10, 0, 5);
            this.senderLayoutPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.senderLayoutPanel.Location = new System.Drawing.Point(21, 39);
            this.senderLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.senderLayoutPanel.Name = "senderLayoutPanel";
            this.senderLayoutPanel.RowCount = 6;
            this.senderLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.senderLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.senderLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.senderLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.senderLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.senderLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.senderLayoutPanel.Size = new System.Drawing.Size(128, 335);
            this.senderLayoutPanel.TabIndex = 121;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel7.Controls.Add(this.lblSenderAverageTime, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.lblSenderAverageCaption, 0, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(4, 59);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(120, 47);
            this.tableLayoutPanel7.TabIndex = 5;
            // 
            // lblSenderAverageTime
            // 
            this.lblSenderAverageTime.BackColor = System.Drawing.Color.White;
            this.lblSenderAverageTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSenderAverageTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSenderAverageTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenderAverageTime.Location = new System.Drawing.Point(4, 23);
            this.lblSenderAverageTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSenderAverageTime.Name = "lblSenderAverageTime";
            this.lblSenderAverageTime.Size = new System.Drawing.Size(112, 16);
            this.lblSenderAverageTime.TabIndex = 117;
            this.lblSenderAverageTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSenderAverageCaption
            // 
            this.lblSenderAverageCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSenderAverageCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenderAverageCaption.Location = new System.Drawing.Point(4, 0);
            this.lblSenderAverageCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSenderAverageCaption.Name = "lblSenderAverageCaption";
            this.lblSenderAverageCaption.Size = new System.Drawing.Size(112, 23);
            this.lblSenderAverageCaption.TabIndex = 116;
            this.lblSenderAverageCaption.Text = "Average Time";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.Controls.Add(this.lblSenderLastTime, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblSenderLastCaption, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(120, 47);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblSenderLastTime
            // 
            this.lblSenderLastTime.BackColor = System.Drawing.Color.White;
            this.lblSenderLastTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSenderLastTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSenderLastTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenderLastTime.Location = new System.Drawing.Point(4, 23);
            this.lblSenderLastTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSenderLastTime.Name = "lblSenderLastTime";
            this.lblSenderLastTime.Size = new System.Drawing.Size(112, 16);
            this.lblSenderLastTime.TabIndex = 113;
            this.lblSenderLastTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSenderLastCaption
            // 
            this.lblSenderLastCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSenderLastCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenderLastCaption.Location = new System.Drawing.Point(4, 0);
            this.lblSenderLastCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSenderLastCaption.Name = "lblSenderLastCaption";
            this.lblSenderLastCaption.Size = new System.Drawing.Size(112, 23);
            this.lblSenderLastCaption.TabIndex = 112;
            this.lblSenderLastCaption.Text = "Last Time";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel4.Controls.Add(this.lblSenderMinimumTime, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblSenderMinimumCaption, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(4, 114);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(120, 47);
            this.tableLayoutPanel4.TabIndex = 9;
            // 
            // lblSenderMinimumTime
            // 
            this.lblSenderMinimumTime.BackColor = System.Drawing.Color.White;
            this.lblSenderMinimumTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSenderMinimumTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSenderMinimumTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenderMinimumTime.Location = new System.Drawing.Point(4, 23);
            this.lblSenderMinimumTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSenderMinimumTime.Name = "lblSenderMinimumTime";
            this.lblSenderMinimumTime.Size = new System.Drawing.Size(112, 16);
            this.lblSenderMinimumTime.TabIndex = 118;
            this.lblSenderMinimumTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSenderMinimumCaption
            // 
            this.lblSenderMinimumCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSenderMinimumCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenderMinimumCaption.Location = new System.Drawing.Point(4, 0);
            this.lblSenderMinimumCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSenderMinimumCaption.Name = "lblSenderMinimumCaption";
            this.lblSenderMinimumCaption.Size = new System.Drawing.Size(112, 23);
            this.lblSenderMinimumCaption.TabIndex = 117;
            this.lblSenderMinimumCaption.Text = "Minimum Time";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel5.Controls.Add(this.lblSenderMaximumTime, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.lblSenderMaximumCaption, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(4, 169);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(120, 47);
            this.tableLayoutPanel5.TabIndex = 10;
            // 
            // lblSenderMaximumTime
            // 
            this.lblSenderMaximumTime.BackColor = System.Drawing.Color.White;
            this.lblSenderMaximumTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSenderMaximumTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSenderMaximumTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenderMaximumTime.Location = new System.Drawing.Point(4, 23);
            this.lblSenderMaximumTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSenderMaximumTime.Name = "lblSenderMaximumTime";
            this.lblSenderMaximumTime.Size = new System.Drawing.Size(112, 16);
            this.lblSenderMaximumTime.TabIndex = 126;
            this.lblSenderMaximumTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSenderMaximumCaption
            // 
            this.lblSenderMaximumCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSenderMaximumCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenderMaximumCaption.Location = new System.Drawing.Point(4, 0);
            this.lblSenderMaximumCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSenderMaximumCaption.Name = "lblSenderMaximumCaption";
            this.lblSenderMaximumCaption.Size = new System.Drawing.Size(112, 23);
            this.lblSenderMaximumCaption.TabIndex = 125;
            this.lblSenderMaximumCaption.Text = "Maximum Time";
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel8.Controls.Add(this.lblSenderMessagesPerSecond, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.lblSenderMessagesPerSecondCaption, 0, 0);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(4, 224);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(120, 47);
            this.tableLayoutPanel8.TabIndex = 11;
            // 
            // lblSenderMessagesPerSecond
            // 
            this.lblSenderMessagesPerSecond.BackColor = System.Drawing.Color.White;
            this.lblSenderMessagesPerSecond.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSenderMessagesPerSecond.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSenderMessagesPerSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenderMessagesPerSecond.Location = new System.Drawing.Point(4, 23);
            this.lblSenderMessagesPerSecond.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSenderMessagesPerSecond.Name = "lblSenderMessagesPerSecond";
            this.lblSenderMessagesPerSecond.Size = new System.Drawing.Size(112, 16);
            this.lblSenderMessagesPerSecond.TabIndex = 141;
            this.lblSenderMessagesPerSecond.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSenderMessagesPerSecondCaption
            // 
            this.lblSenderMessagesPerSecondCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSenderMessagesPerSecondCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenderMessagesPerSecondCaption.Location = new System.Drawing.Point(4, 0);
            this.lblSenderMessagesPerSecondCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSenderMessagesPerSecondCaption.Name = "lblSenderMessagesPerSecondCaption";
            this.lblSenderMessagesPerSecondCaption.Size = new System.Drawing.Size(112, 23);
            this.lblSenderMessagesPerSecondCaption.TabIndex = 140;
            this.lblSenderMessagesPerSecondCaption.Text = "Messages/Sec";
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel10.ColumnCount = 1;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel10.Controls.Add(this.lblSenderMessageNumber, 0, 1);
            this.tableLayoutPanel10.Controls.Add(this.lblSenderCallsSuccessedCaption, 0, 0);
            this.tableLayoutPanel10.Location = new System.Drawing.Point(4, 279);
            this.tableLayoutPanel10.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 2;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(120, 52);
            this.tableLayoutPanel10.TabIndex = 8;
            // 
            // lblSenderMessageNumber
            // 
            this.lblSenderMessageNumber.BackColor = System.Drawing.Color.White;
            this.lblSenderMessageNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSenderMessageNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSenderMessageNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenderMessageNumber.Location = new System.Drawing.Point(4, 26);
            this.lblSenderMessageNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSenderMessageNumber.Name = "lblSenderMessageNumber";
            this.lblSenderMessageNumber.Size = new System.Drawing.Size(112, 16);
            this.lblSenderMessageNumber.TabIndex = 125;
            this.lblSenderMessageNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSenderCallsSuccessedCaption
            // 
            this.lblSenderCallsSuccessedCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSenderCallsSuccessedCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenderCallsSuccessedCaption.Location = new System.Drawing.Point(4, 0);
            this.lblSenderCallsSuccessedCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSenderCallsSuccessedCaption.Name = "lblSenderCallsSuccessedCaption";
            this.lblSenderCallsSuccessedCaption.Size = new System.Drawing.Size(112, 26);
            this.lblSenderCallsSuccessedCaption.TabIndex = 124;
            this.lblSenderCallsSuccessedCaption.Text = "Messages Total";
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart.BackImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.chart.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.chart.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.chart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chart.BorderSkin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.chart.BorderSkin.BorderWidth = 0;
            this.chart.BorderSkin.PageColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.chart.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.FrameTitle1;
            chartArea1.Area3DStyle.Inclination = 15;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.Perspective = 10;
            chartArea1.Area3DStyle.Rotation = 10;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.AxisX.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)(((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.IncreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.ScrollBar.LineColor = System.Drawing.Color.Black;
            chartArea1.AxisX.ScrollBar.Size = 10D;
            chartArea1.AxisX.Title = "Messages";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.ScrollBar.LineColor = System.Drawing.Color.Black;
            chartArea1.AxisY.ScrollBar.Size = 10D;
            chartArea1.AxisY.Title = "Time - Msg/Sec";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY2.Title = "Messages/Sec";
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.CursorY.IsUserEnabled = true;
            chartArea1.CursorY.IsUserSelectionEnabled = true;
            chartArea1.Name = "Default";
            chartArea1.ShadowColor = System.Drawing.Color.White;
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Far;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F);
            legend1.IsTextAutoFit = false;
            legend1.MaximumAutoSize = 5F;
            legend1.Name = "Default";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(203, 20);
            this.chart.Margin = new System.Windows.Forms.Padding(4);
            this.chart.Name = "chart";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.BorderWidth = 2;
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Legend = "Default";
            series1.LegendText = "Sender Latency";
            series1.Name = "SenderLatency";
            series2.BorderColor = System.Drawing.Color.Red;
            series2.BorderWidth = 2;
            series2.ChartArea = "Default";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Legend = "Default";
            series2.LegendText = "Receiver Latency";
            series2.Name = "ReceiverLatency";
            series3.BorderWidth = 2;
            series3.ChartArea = "Default";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.Legend = "Default";
            series3.LegendText = "Sender Throughput";
            series3.Name = "SenderThroughput";
            series4.BorderWidth = 2;
            series4.ChartArea = "Default";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series4.Legend = "Default";
            series4.LegendText = "Receiver Throughput";
            series4.Name = "ReceiverThroughput";
            this.chart.Series.Add(series1);
            this.chart.Series.Add(series2);
            this.chart.Series.Add(series3);
            this.chart.Series.Add(series4);
            this.chart.Size = new System.Drawing.Size(891, 384);
            this.chart.TabIndex = 129;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title";
            title1.ShadowColor = System.Drawing.Color.Transparent;
            title1.ShadowOffset = 1;
            title1.Text = "Sender & Receiver Performance Counters";
            this.chart.Titles.Add(title1);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.btnOpenFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnOpenFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnOpenFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOpenFile.Location = new System.Drawing.Point(1013, 482);
            this.btnOpenFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(96, 30);
            this.btnOpenFile.TabIndex = 2;
            this.btnOpenFile.Text = "Open";
            this.btnOpenFile.UseVisualStyleBackColor = false;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            this.btnOpenFile.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.btnOpenFile.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // btnClearFiles
            // 
            this.btnClearFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.btnClearFiles.Enabled = false;
            this.btnClearFiles.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnClearFiles.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnClearFiles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnClearFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearFiles.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClearFiles.Location = new System.Drawing.Point(907, 482);
            this.btnClearFiles.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearFiles.Name = "btnClearFiles";
            this.btnClearFiles.Size = new System.Drawing.Size(96, 30);
            this.btnClearFiles.TabIndex = 1;
            this.btnClearFiles.Text = "Clear Files";
            this.btnClearFiles.UseVisualStyleBackColor = false;
            this.btnClearFiles.Click += new System.EventHandler(this.btnClearFiles_Click);
            // 
            // btnSelectFiles
            // 
            this.btnSelectFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.btnSelectFiles.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnSelectFiles.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnSelectFiles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnSelectFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectFiles.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSelectFiles.Location = new System.Drawing.Point(801, 482);
            this.btnSelectFiles.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectFiles.Name = "btnSelectFiles";
            this.btnSelectFiles.Size = new System.Drawing.Size(96, 30);
            this.btnSelectFiles.TabIndex = 0;
            this.btnSelectFiles.Text = "Select Files";
            this.btnSelectFiles.UseVisualStyleBackColor = false;
            this.btnSelectFiles.Click += new System.EventHandler(this.btnSelectFiles_Click);
            // 
            // TestTopicControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.btnClearFiles);
            this.Controls.Add(this.btnSelectFiles);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnStart);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TestTopicControl";
            this.Size = new System.Drawing.Size(1344, 532);
            this.Resize += new System.EventHandler(this.TestTopicControl_Resize);
            this.mainTabControl.ResumeLayout(false);
            this.mainTabMessagePage.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.messageTabControl.ResumeLayout(false);
            this.tabMessagePage.ResumeLayout(false);
            this.grouperMessageText.ResumeLayout(false);
            this.grouperMessageText.PerformLayout();
            this.tabFilesPage.ResumeLayout(false);
            this.grouperMessageFiles.ResumeLayout(false);
            this.grouperMessageFiles.PerformLayout();
            this.grouperMessageProperties.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.propertiesDataGridView)).EndInit();
            this.mainTabSenderPage.ResumeLayout(false);
            this.mainTabSenderPage.PerformLayout();
            this.grouperSender.ResumeLayout(false);
            this.grouperSender.PerformLayout();
            this.grouperMessage.ResumeLayout(false);
            this.grouperMessage.PerformLayout();
            this.mainTabReceiverPage.ResumeLayout(false);
            this.mainTabReceiverPage.PerformLayout();
            this.grouperReceiver.ResumeLayout(false);
            this.grouperReceiver.PerformLayout();
            this.tabPageGraph.ResumeLayout(false);
            this.grouperReceiverStatistics.ResumeLayout(false);
            this.receiverLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel17.ResumeLayout(false);
            this.tableLayoutPanel16.ResumeLayout(false);
            this.tableLayoutPanel15.ResumeLayout(false);
            this.tableLayoutPanel14.ResumeLayout(false);
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.grouperSenderStatistics.ResumeLayout(false);
            this.senderLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TabPage mainTabMessagePage;
        private System.Windows.Forms.TabPage mainTabSenderPage;
        private System.Windows.Forms.TabPage mainTabReceiverPage;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.TabControl mainTabControl;
        internal System.Windows.Forms.DataVisualization.Charting.Chart chart;
        internal System.Windows.Forms.TabPage tabPageGraph;
        private System.Windows.Forms.SplitContainer splitContainer;
        private Grouper grouperMessageProperties;
        private System.Windows.Forms.CheckBox senderEnabledCheckBox;
        internal System.Windows.Forms.CheckBox receiverEnabledCheckBox;
        private Grouper grouperReceiverStatistics;
        private System.Windows.Forms.TableLayoutPanel receiverLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel17;
        private System.Windows.Forms.Label lblReceiverLastTime;
        private System.Windows.Forms.Label lblReceiverLastCaption;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel16;
        private System.Windows.Forms.Label lblReceiverAverageTime;
        private System.Windows.Forms.Label lblReceiverAverageCaption;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel15;
        private System.Windows.Forms.Label lblReceiverMinimumTime;
        private System.Windows.Forms.Label lblReceiverMinimumCaption;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel14;
        private System.Windows.Forms.Label lblReceiverMaximumTime;
        private System.Windows.Forms.Label lblReceiverMaximumCaption;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private System.Windows.Forms.Label lblReceiverMessagesPerSecond;
        private System.Windows.Forms.Label lblReceiverMessagesPerSecondCaption;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label lblReceiverMessageNumber;
        private System.Windows.Forms.Label lblReceiverCallsSuccessedCaption;
        private Grouper grouperSenderStatistics;
        private System.Windows.Forms.TableLayoutPanel senderLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label lblSenderAverageTime;
        private System.Windows.Forms.Label lblSenderAverageCaption;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblSenderLastTime;
        private System.Windows.Forms.Label lblSenderLastCaption;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lblSenderMinimumTime;
        private System.Windows.Forms.Label lblSenderMinimumCaption;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label lblSenderMaximumTime;
        private System.Windows.Forms.Label lblSenderMaximumCaption;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Label lblSenderMessagesPerSecond;
        private System.Windows.Forms.Label lblSenderMessagesPerSecondCaption;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Label lblSenderMessageNumber;
        private System.Windows.Forms.Label lblSenderCallsSuccessedCaption;
        private System.Windows.Forms.DataGridView propertiesDataGridView;
        private Grouper grouperSender;
        private System.Windows.Forms.TextBox txtSendTaskCount;
        private System.Windows.Forms.CheckBox checkBoxSendBatch;
        private System.Windows.Forms.CheckBox checkBoxAddMessageNumber;
        private System.Windows.Forms.CheckBox checkBoxSenderEnableGraph;
        private System.Windows.Forms.CheckBox checkBoxSenderEnableStatistics;
        private System.Windows.Forms.CheckBox checkBoxOneSessionPerTask;
        private System.Windows.Forms.CheckBox checkBoxUpdateMessageId;
        private System.Windows.Forms.CheckBox checkBoxEnableSenderLogging;
        private System.Windows.Forms.CheckBox checkBoxSenderVerboseLogging;
        private System.Windows.Forms.CheckBox checkBoxSenderCommitTransaction;
        private System.Windows.Forms.CheckBox checkBoxSenderUseTransaction;
        private System.Windows.Forms.Label lblSendBatchSize;
        private System.Windows.Forms.TextBox txtSendBatchSize;
        private System.Windows.Forms.Label lblBody;
        private System.Windows.Forms.ComboBox cboBodyType;
        private System.Windows.Forms.Label lblSendTaskCount;
        private System.Windows.Forms.TextBox txtMessageCount;
        private System.Windows.Forms.Label lblCount;
        private Grouper grouperMessage;
        private System.Windows.Forms.Label lblContentType;
        private System.Windows.Forms.TextBox txtContentType;
        private System.Windows.Forms.TextBox txtScheduledEnqueueTimeUtc;
        private System.Windows.Forms.Label lblScheduledEnqueueTimeUtc;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.TextBox txtTimeToLive;
        private System.Windows.Forms.Label lblTimeToLive;
        private System.Windows.Forms.Label lblReplyToSessionId;
        private System.Windows.Forms.TextBox txtReplyToSessionId;
        private System.Windows.Forms.Label lblReplyTo;
        private System.Windows.Forms.TextBox txtReplyTo;
        private System.Windows.Forms.TextBox txtCorrelationId;
        private System.Windows.Forms.Label lblCorrelationId;
        private System.Windows.Forms.Label lblSessionId;
        private System.Windows.Forms.TextBox txtSessionId;
        private System.Windows.Forms.Label lblLabel;
        private System.Windows.Forms.TextBox txtLabel;
        private System.Windows.Forms.Label lblMessageId;
        private System.Windows.Forms.TextBox txtMessageId;
        private Grouper grouperReceiver;
        private System.Windows.Forms.CheckBox checkBoxReceiveBatch;
        private System.Windows.Forms.CheckBox checkBoxReceiverUseTransaction;
        private System.Windows.Forms.CheckBox checkBoxDeferMessage;
        private System.Windows.Forms.CheckBox checkBoxReceiverEnableGraph;
        private System.Windows.Forms.CheckBox checkBoxCompleteReceive;
        private System.Windows.Forms.CheckBox checkBoxReceiverEnableStatistics;
        private System.Windows.Forms.CheckBox checkBoxReadFromDeadLetter;
        private System.Windows.Forms.CheckBox checkBoxMoveToDeadLetter;
        private System.Windows.Forms.CheckBox checkBoxReceiverVerboseLogging;
        private System.Windows.Forms.CheckBox checkBoxReceiverCommitTransaction;
        private System.Windows.Forms.CheckBox checkBoxEnableReceiverLogging;
        private System.Windows.Forms.TextBox txtReceiveTaskCount;
        private System.Windows.Forms.Label lblReceiveBatchSize;
        private System.Windows.Forms.TextBox txtReceiveBatchSize;
        private System.Windows.Forms.TextBox txtPrefetchCount;
        private System.Windows.Forms.Label lblPrefetchCount;
        private System.Windows.Forms.TextBox txtReceiveTimeout;
        private System.Windows.Forms.TextBox txtServerTimeout;
        private System.Windows.Forms.Label lblServerTimeout;
        private System.Windows.Forms.TextBox txtFilterExpression;
        private System.Windows.Forms.Label lblFilterExpr;
        private System.Windows.Forms.ComboBox cboReceivedMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblReceiveTaskCount;
        private System.Windows.Forms.Label lblServerWaitTime;
        private System.Windows.Forms.ComboBox cboSubscriptions;
        private System.Windows.Forms.Label lblSubscription;
        private System.Windows.Forms.TextBox txtSenderThinkTime;
        private System.Windows.Forms.Label lblSenderThinkTime;
        private System.Windows.Forms.CheckBox checkBoxSenderThinkTime;
        private System.Windows.Forms.TextBox txtReceiverThinkTime;
        private System.Windows.Forms.Label lblReceiverThinkTime;
        private System.Windows.Forms.CheckBox checkBoxReceiverThinkTime;
        internal System.Windows.Forms.TabControl messageTabControl;
        private System.Windows.Forms.TabPage tabMessagePage;
        private Grouper grouperMessageText;
        private System.Windows.Forms.TextBox txtMessageText;
        private System.Windows.Forms.TabPage tabFilesPage;
        private Grouper grouperMessageFiles;
        private System.Windows.Forms.ListView messageFileListView;
        private System.Windows.Forms.ColumnHeader nameColumnHeader;
        private System.Windows.Forms.ColumnHeader sizeColumnHeader;
        private System.Windows.Forms.Button btnClearFiles;
        private System.Windows.Forms.Button btnSelectFiles;
        private System.Windows.Forms.CheckBox checkBoxFileName;
    }
}
