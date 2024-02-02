
namespace ControlPanel
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.keyBoardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gamepadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.grpBoxEchoIP = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelEchoIP = new System.Windows.Forms.TableLayoutPanel();
            this.txtEchoIP4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEchoIP3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEchoIP2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEchoIP1 = new System.Windows.Forms.TextBox();
            this.checkBoxEchoIP = new System.Windows.Forms.CheckBox();
            this.contextMenu.SuspendLayout();
            this.grpBoxEchoIP.SuspendLayout();
            this.tableLayoutPanelEchoIP.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(123, 67);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(137, 49);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start Server";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.StartServer);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(123, 173);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(137, 49);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop Server";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.StopServer);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(381, 74);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(143, 29);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Server Ideal";
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.stopServerToolStripMenuItem,
            this.exitToolStripMenuItem1,
            this.exitToolStripMenuItem2});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(134, 114);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.OnShowFromContextMenu);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.exitToolStripMenuItem.Text = "Start Server";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.OnStartFromContextMenu);
            // 
            // stopServerToolStripMenuItem
            // 
            this.stopServerToolStripMenuItem.Name = "stopServerToolStripMenuItem";
            this.stopServerToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.stopServerToolStripMenuItem.Text = "Stop Server";
            this.stopServerToolStripMenuItem.Click += new System.EventHandler(this.OnStopFromContextMenu);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.keyBoardToolStripMenuItem,
            this.gamepadeToolStripMenuItem});
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.exitToolStripMenuItem1.Text = "Expand";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.OnExpandFromContextMenu);
            // 
            // keyBoardToolStripMenuItem
            // 
            this.keyBoardToolStripMenuItem.Name = "keyBoardToolStripMenuItem";
            this.keyBoardToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.keyBoardToolStripMenuItem.Text = "Keyboard";
            this.keyBoardToolStripMenuItem.Click += new System.EventHandler(this.OnKeyboardFromContextMenu);
            // 
            // gamepadeToolStripMenuItem
            // 
            this.gamepadeToolStripMenuItem.Name = "gamepadeToolStripMenuItem";
            this.gamepadeToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.gamepadeToolStripMenuItem.Text = "Gamepad";
            this.gamepadeToolStripMenuItem.Click += new System.EventHandler(this.OnGamePadFromConextMenu);
            // 
            // exitToolStripMenuItem2
            // 
            this.exitToolStripMenuItem2.Name = "exitToolStripMenuItem2";
            this.exitToolStripMenuItem2.Size = new System.Drawing.Size(133, 22);
            this.exitToolStripMenuItem2.Text = "Exit";
            this.exitToolStripMenuItem2.Click += new System.EventHandler(this.OnExitFromContextMenu);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "MouseRemote";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notufyIconOnClick);
            // 
            // grpBoxEchoIP
            // 
            this.grpBoxEchoIP.Controls.Add(this.checkBoxEchoIP);
            this.grpBoxEchoIP.Controls.Add(this.tableLayoutPanelEchoIP);
            this.grpBoxEchoIP.Location = new System.Drawing.Point(123, 291);
            this.grpBoxEchoIP.Name = "grpBoxEchoIP";
            this.grpBoxEchoIP.Size = new System.Drawing.Size(171, 70);
            this.grpBoxEchoIP.TabIndex = 3;
            this.grpBoxEchoIP.TabStop = false;
            this.grpBoxEchoIP.Text = "Echo IP";
            // 
            // tableLayoutPanelEchoIP
            // 
            this.tableLayoutPanelEchoIP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelEchoIP.AutoSize = true;
            this.tableLayoutPanelEchoIP.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelEchoIP.ColumnCount = 7;
            this.tableLayoutPanelEchoIP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelEchoIP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelEchoIP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelEchoIP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelEchoIP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelEchoIP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelEchoIP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelEchoIP.Controls.Add(this.txtEchoIP1, 0, 0);
            this.tableLayoutPanelEchoIP.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanelEchoIP.Controls.Add(this.txtEchoIP2, 2, 0);
            this.tableLayoutPanelEchoIP.Controls.Add(this.label2, 3, 0);
            this.tableLayoutPanelEchoIP.Controls.Add(this.txtEchoIP3, 4, 0);
            this.tableLayoutPanelEchoIP.Controls.Add(this.label3, 5, 0);
            this.tableLayoutPanelEchoIP.Controls.Add(this.txtEchoIP4, 6, 0);
            this.tableLayoutPanelEchoIP.Enabled = false;
            this.tableLayoutPanelEchoIP.Location = new System.Drawing.Point(2, 17);
            this.tableLayoutPanelEchoIP.Name = "tableLayoutPanelEchoIP";
            this.tableLayoutPanelEchoIP.RowCount = 2;
            this.tableLayoutPanelEchoIP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelEchoIP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelEchoIP.Size = new System.Drawing.Size(162, 26);
            this.tableLayoutPanelEchoIP.TabIndex = 7;
            // 
            // txtEchoIP4
            // 
            this.txtEchoIP4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEchoIP4.Location = new System.Drawing.Point(132, 3);
            this.txtEchoIP4.Name = "txtEchoIP4";
            this.txtEchoIP4.Size = new System.Drawing.Size(27, 20);
            this.txtEchoIP4.TabIndex = 4;
            this.txtEchoIP4.Text = "1";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = ".";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txtEchoIP3
            // 
            this.txtEchoIP3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEchoIP3.Location = new System.Drawing.Point(89, 3);
            this.txtEchoIP3.Name = "txtEchoIP3";
            this.txtEchoIP3.Size = new System.Drawing.Size(27, 20);
            this.txtEchoIP3.TabIndex = 3;
            this.txtEchoIP3.Text = "0";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = ".";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txtEchoIP2
            // 
            this.txtEchoIP2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEchoIP2.Location = new System.Drawing.Point(46, 3);
            this.txtEchoIP2.Name = "txtEchoIP2";
            this.txtEchoIP2.Size = new System.Drawing.Size(27, 20);
            this.txtEchoIP2.TabIndex = 2;
            this.txtEchoIP2.Text = "168";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = ".";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txtEchoIP1
            // 
            this.txtEchoIP1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEchoIP1.Location = new System.Drawing.Point(3, 3);
            this.txtEchoIP1.Name = "txtEchoIP1";
            this.txtEchoIP1.Size = new System.Drawing.Size(27, 20);
            this.txtEchoIP1.TabIndex = 0;
            this.txtEchoIP1.Text = "192";
            // 
            // checkBoxEchoIP
            // 
            this.checkBoxEchoIP.AutoSize = true;
            this.checkBoxEchoIP.Checked = true;
            this.checkBoxEchoIP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEchoIP.Location = new System.Drawing.Point(5, 47);
            this.checkBoxEchoIP.Name = "checkBoxEchoIP";
            this.checkBoxEchoIP.Size = new System.Drawing.Size(73, 17);
            this.checkBoxEchoIP.TabIndex = 4;
            this.checkBoxEchoIP.Text = "Automatic";
            this.checkBoxEchoIP.UseVisualStyleBackColor = true;
            this.checkBoxEchoIP.CheckedChanged += new System.EventHandler(this.checkBoxEchoIP_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 403);
            this.Controls.Add(this.grpBoxEchoIP);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Mouse Remote Server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnExit);
            this.Move += new System.EventHandler(this.MainForm_Move);
            this.contextMenu.ResumeLayout(false);
            this.grpBoxEchoIP.ResumeLayout(false);
            this.grpBoxEchoIP.PerformLayout();
            this.tableLayoutPanelEchoIP.ResumeLayout(false);
            this.tableLayoutPanelEchoIP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem keyBoardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gamepadeToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.GroupBox grpBoxEchoIP;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelEchoIP;
        private System.Windows.Forms.TextBox txtEchoIP4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEchoIP3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEchoIP2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEchoIP1;
        private System.Windows.Forms.CheckBox checkBoxEchoIP;
    }
}

