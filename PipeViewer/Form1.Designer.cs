﻿using System.Windows.Forms;

namespace PipeViewer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIntegrityLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPermissions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSddl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnClientPID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPipeType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnConfiguration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnReadMode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNumberOfLinks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDirectoryGrantedAccess = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGrantedAccess = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGrantedAccessGeneric = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCreationTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOwnerSid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOwnerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGroupSid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEndPointType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHandle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFileCreationTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLastAccessTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLastWriteTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnChangeTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelTotalNamedPipes = new System.Windows.Forms.ToolStripStatusLabel();
            this.Separator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripStatusLabelTotalSelectedRows = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClear = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonFilter = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonFind = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonHighLight = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonGrid = new System.Windows.Forms.ToolStripButton();
            this.colorPermissionsButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonStatus = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStripRightClickGridView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyCellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStripRightClickGridView.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnIntegrityLevel,
            this.ColumnPermissions,
            this.ColumnSddl,
            this.ColumnClientPID,
            this.ColumnPipeType,
            this.ColumnConfiguration,
            this.ColumnReadMode,
            this.ColumnNumberOfLinks,
            this.ColumnDirectoryGrantedAccess,
            this.ColumnGrantedAccess,
            this.ColumnGrantedAccessGeneric,
            this.ColumnCreationTime,
            this.ColumnOwnerSid,
            this.ColumnOwnerName,
            this.ColumnGroupSid,
            this.ColumnGroupName,
            this.ColumnEndPointType,
            this.ColumnHandle,
            this.ColumnFileCreationTime,
            this.ColumnLastAccessTime,
            this.ColumnLastWriteTime,
            this.ColumnChangeTime});
            this.dataGridView1.Location = new System.Drawing.Point(4, 67);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1268, 460);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.MinimumWidth = 6;
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            // 
            // ColumnIntegrityLevel
            // 
            this.ColumnIntegrityLevel.HeaderText = "Integrity Level";
            this.ColumnIntegrityLevel.MinimumWidth = 6;
            this.ColumnIntegrityLevel.Name = "ColumnIntegrityLevel";
            this.ColumnIntegrityLevel.ReadOnly = true;
            // 
            // ColumnPermissions
            // 
            this.ColumnPermissions.HeaderText = "Permissions";
            this.ColumnPermissions.MinimumWidth = 6;
            this.ColumnPermissions.Name = "ColumnPermissions";
            this.ColumnPermissions.ReadOnly = true;
            // 
            // ColumnSddl
            // 
            this.ColumnSddl.HeaderText = "Sddl";
            this.ColumnSddl.MinimumWidth = 6;
            this.ColumnSddl.Name = "ColumnSddl";
            this.ColumnSddl.ReadOnly = true;
            this.ColumnSddl.Visible = false;
            // 
            // ColumnClientPID
            // 
            this.ColumnClientPID.HeaderText = "Client PIDs";
            this.ColumnClientPID.MinimumWidth = 6;
            this.ColumnClientPID.Name = "ColumnClientPID";
            this.ColumnClientPID.ReadOnly = true;
            // 
            // ColumnPipeType
            // 
            this.ColumnPipeType.HeaderText = "Pipe Type";
            this.ColumnPipeType.MinimumWidth = 6;
            this.ColumnPipeType.Name = "ColumnPipeType";
            this.ColumnPipeType.ReadOnly = true;
            // 
            // ColumnConfiguration
            // 
            this.ColumnConfiguration.HeaderText = "Configuration";
            this.ColumnConfiguration.MinimumWidth = 6;
            this.ColumnConfiguration.Name = "ColumnConfiguration";
            this.ColumnConfiguration.ReadOnly = true;
            // 
            // ColumnReadMode
            // 
            this.ColumnReadMode.HeaderText = "Read Mode";
            this.ColumnReadMode.MinimumWidth = 6;
            this.ColumnReadMode.Name = "ColumnReadMode";
            this.ColumnReadMode.ReadOnly = true;
            // 
            // ColumnNumberOfLinks
            // 
            this.ColumnNumberOfLinks.HeaderText = "Number of Links";
            this.ColumnNumberOfLinks.MinimumWidth = 6;
            this.ColumnNumberOfLinks.Name = "ColumnNumberOfLinks";
            this.ColumnNumberOfLinks.ReadOnly = true;
            // 
            // ColumnDirectoryGrantedAccess
            // 
            this.ColumnDirectoryGrantedAccess.HeaderText = "Directory Granted Access";
            this.ColumnDirectoryGrantedAccess.MinimumWidth = 6;
            this.ColumnDirectoryGrantedAccess.Name = "ColumnDirectoryGrantedAccess";
            this.ColumnDirectoryGrantedAccess.ReadOnly = true;
            // 
            // ColumnGrantedAccess
            // 
            this.ColumnGrantedAccess.HeaderText = "Granted Access";
            this.ColumnGrantedAccess.MinimumWidth = 6;
            this.ColumnGrantedAccess.Name = "ColumnGrantedAccess";
            this.ColumnGrantedAccess.ReadOnly = true;
            // 
            // ColumnGrantedAccessGeneric
            // 
            this.ColumnGrantedAccessGeneric.HeaderText = "Granted Access Generic";
            this.ColumnGrantedAccessGeneric.MinimumWidth = 6;
            this.ColumnGrantedAccessGeneric.Name = "ColumnGrantedAccessGeneric";
            this.ColumnGrantedAccessGeneric.ReadOnly = true;
            // 
            // ColumnCreationTime
            // 
            this.ColumnCreationTime.HeaderText = "Creation Time";
            this.ColumnCreationTime.MinimumWidth = 6;
            this.ColumnCreationTime.Name = "ColumnCreationTime";
            this.ColumnCreationTime.ReadOnly = true;
            // 
            // ColumnOwnerSid
            // 
            this.ColumnOwnerSid.HeaderText = "Owner Sid";
            this.ColumnOwnerSid.MinimumWidth = 6;
            this.ColumnOwnerSid.Name = "ColumnOwnerSid";
            this.ColumnOwnerSid.ReadOnly = true;
            this.ColumnOwnerSid.Visible = false;
            // 
            // ColumnOwnerName
            // 
            this.ColumnOwnerName.HeaderText = "Owner Name";
            this.ColumnOwnerName.MinimumWidth = 6;
            this.ColumnOwnerName.Name = "ColumnOwnerName";
            this.ColumnOwnerName.ReadOnly = true;
            // 
            // ColumnGroupSid
            // 
            this.ColumnGroupSid.HeaderText = "Group Sid";
            this.ColumnGroupSid.MinimumWidth = 6;
            this.ColumnGroupSid.Name = "ColumnGroupSid";
            this.ColumnGroupSid.ReadOnly = true;
            this.ColumnGroupSid.Visible = false;
            // 
            // ColumnGroupName
            // 
            this.ColumnGroupName.HeaderText = "Group Name";
            this.ColumnGroupName.MinimumWidth = 6;
            this.ColumnGroupName.Name = "ColumnGroupName";
            this.ColumnGroupName.ReadOnly = true;
            this.ColumnGroupName.Visible = false;
            // 
            // ColumnEndPointType
            // 
            this.ColumnEndPointType.HeaderText = "Endpoint Type";
            this.ColumnEndPointType.MinimumWidth = 6;
            this.ColumnEndPointType.Name = "ColumnEndPointType";
            this.ColumnEndPointType.ReadOnly = true;
            // 
            // ColumnHandle
            // 
            this.ColumnHandle.HeaderText = "Handle";
            this.ColumnHandle.MinimumWidth = 6;
            this.ColumnHandle.Name = "ColumnHandle";
            this.ColumnHandle.ReadOnly = true;
            // 
            // ColumnFileCreationTime
            // 
            this.ColumnFileCreationTime.HeaderText = "File Creation Time";
            this.ColumnFileCreationTime.MinimumWidth = 6;
            this.ColumnFileCreationTime.Name = "ColumnFileCreationTime";
            this.ColumnFileCreationTime.ReadOnly = true;
            this.ColumnFileCreationTime.Visible = false;
            // 
            // ColumnLastAccessTime
            // 
            this.ColumnLastAccessTime.HeaderText = "Last Access Time";
            this.ColumnLastAccessTime.MinimumWidth = 6;
            this.ColumnLastAccessTime.Name = "ColumnLastAccessTime";
            this.ColumnLastAccessTime.ReadOnly = true;
            this.ColumnLastAccessTime.Visible = false;
            // 
            // ColumnLastWriteTime
            // 
            this.ColumnLastWriteTime.HeaderText = "Last Write Time";
            this.ColumnLastWriteTime.MinimumWidth = 6;
            this.ColumnLastWriteTime.Name = "ColumnLastWriteTime";
            this.ColumnLastWriteTime.ReadOnly = true;
            this.ColumnLastWriteTime.Visible = false;
            // 
            // ColumnChangeTime
            // 
            this.ColumnChangeTime.HeaderText = "Change Time";
            this.ColumnChangeTime.MinimumWidth = 6;
            this.ColumnChangeTime.Name = "ColumnChangeTime";
            this.ColumnChangeTime.ReadOnly = true;
            this.ColumnChangeTime.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1273, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.importToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.saveToolStripMenuItem.Text = "Export...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.importToolStripMenuItem.Text = "Import...";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelTotalNamedPipes,
            this.Separator,
            this.toolStripStatusLabelTotalSelectedRows});
            this.statusStrip1.Location = new System.Drawing.Point(0, 533);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1273, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelTotalNamedPipes
            // 
            this.toolStripStatusLabelTotalNamedPipes.Name = "toolStripStatusLabelTotalNamedPipes";
            this.toolStripStatusLabelTotalNamedPipes.Size = new System.Drawing.Size(149, 20);
            this.toolStripStatusLabelTotalNamedPipes.Text = "Total Named Pipes: 0";
            // 
            // Separator
            // 
            this.Separator.Name = "Separator";
            this.Separator.Size = new System.Drawing.Size(6, 26);
            // 
            // toolStripStatusLabelTotalSelectedRows
            // 
            this.toolStripStatusLabelTotalSelectedRows.Name = "toolStripStatusLabelTotalSelectedRows";
            this.toolStripStatusLabelTotalSelectedRows.Size = new System.Drawing.Size(120, 20);
            this.toolStripStatusLabelTotalSelectedRows.Text = "Selected Rows: 0";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonRefresh,
            this.toolStripButtonClear,
            this.toolStripButtonFilter,
            this.toolStripButtonFind,
            this.toolStripButtonHighLight,
            this.toolStripButtonGrid,
            this.colorPermissionsButton,
            this.toolStripButtonStatus});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1273, 27);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonRefresh
            // 
            this.toolStripButtonRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRefresh.Image = global::PipeViewer.Properties.Resources.startIcon;
            this.toolStripButtonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRefresh.Name = "toolStripButtonRefresh";
            this.toolStripButtonRefresh.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonRefresh.Text = "Start";
            this.toolStripButtonRefresh.Click += new System.EventHandler(this.toolStripButtonRefresh_Click);
            // 
            // toolStripButtonClear
            // 
            this.toolStripButtonClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonClear.Image = global::PipeViewer.Properties.Resources.eraser;
            this.toolStripButtonClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonClear.Name = "toolStripButtonClear";
            this.toolStripButtonClear.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonClear.Text = "Clear (Ctrl+X)";
            this.toolStripButtonClear.Click += new System.EventHandler(this.toolStripButtonClear_Click);
            // 
            // toolStripButtonFilter
            // 
            this.toolStripButtonFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFilter.Image = global::PipeViewer.Properties.Resources.filter;
            this.toolStripButtonFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFilter.Name = "toolStripButtonFilter";
            this.toolStripButtonFilter.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonFilter.Text = "Filter (Ctrl+L)";
            this.toolStripButtonFilter.Click += new System.EventHandler(this.toolStripButtonFilter_Click);
            // 
            // toolStripButtonFind
            // 
            this.toolStripButtonFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFind.Image = global::PipeViewer.Properties.Resources.find;
            this.toolStripButtonFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFind.Name = "toolStripButtonFind";
            this.toolStripButtonFind.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonFind.Text = "Find (Ctrl+F)";
            this.toolStripButtonFind.Click += new System.EventHandler(this.toolStripButtonFind_Click);
            // 
            // toolStripButtonHighLight
            // 
            this.toolStripButtonHighLight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonHighLight.Image = global::PipeViewer.Properties.Resources.highlighter;
            this.toolStripButtonHighLight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonHighLight.Name = "toolStripButtonHighLight";
            this.toolStripButtonHighLight.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonHighLight.Text = "HighLight (Ctrk+H)";
            this.toolStripButtonHighLight.Click += new System.EventHandler(this.toolStripButtonHighLight_Click);
            // 
            // toolStripButtonGrid
            // 
            this.toolStripButtonGrid.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonGrid.Image = global::PipeViewer.Properties.Resources.grid_disable;
            this.toolStripButtonGrid.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGrid.Name = "toolStripButtonGrid";
            this.toolStripButtonGrid.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonGrid.Text = "Show Grid";
            this.toolStripButtonGrid.Click += new System.EventHandler(this.toolStripButtonGrid_Click);
            // 
            // colorPermissionsButton
            // 
            this.colorPermissionsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.colorPermissionsButton.Image = global::PipeViewer.Properties.Resources.permission;
            this.colorPermissionsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.colorPermissionsButton.Name = "colorPermissionsButton";
            this.colorPermissionsButton.Size = new System.Drawing.Size(29, 24);
            this.colorPermissionsButton.Text = "Hide permissions color";
            this.colorPermissionsButton.Click += new System.EventHandler(this.showPermissionsByColorButton);
            // 
            // toolStripButtonStatus
            // 
            this.toolStripButtonStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonStatus.Image = global::PipeViewer.Properties.Resources.search__2_;
            this.toolStripButtonStatus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStatus.Name = "toolStripButtonStatus";
            this.toolStripButtonStatus.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonStatus.Text = "Show connected pipes";
            this.toolStripButtonStatus.Click += new System.EventHandler(this.toolStripButtonConnectionStatus_Click);
            // 
            // contextMenuStripRightClickGridView
            // 
            this.contextMenuStripRightClickGridView.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripRightClickGridView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyRowToolStripMenuItem,
            this.copyCellToolStripMenuItem});
            this.contextMenuStripRightClickGridView.Name = "contextMenuStripRightClickGridView";
            this.contextMenuStripRightClickGridView.Size = new System.Drawing.Size(146, 52);
            this.contextMenuStripRightClickGridView.Closing += new System.Windows.Forms.ToolStripDropDownClosingEventHandler(this.contextMenuStripRightClickGridView_Closing);
            // 
            // copyRowToolStripMenuItem
            // 
            this.copyRowToolStripMenuItem.Name = "copyRowToolStripMenuItem";
            this.copyRowToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.copyRowToolStripMenuItem.Text = "Copy Row";
            this.copyRowToolStripMenuItem.Click += new System.EventHandler(this.copyRowToolStripMenuItem_Click);
            // 
            // copyCellToolStripMenuItem
            // 
            this.copyCellToolStripMenuItem.Name = "copyCellToolStripMenuItem";
            this.copyCellToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.copyCellToolStripMenuItem.Text = "Copy Cell";
            this.copyCellToolStripMenuItem.Click += new System.EventHandler(this.copyCellToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1273, 559);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "PipeViewer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStripRightClickGridView.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTotalNamedPipes;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTotalSelectedRows;
        private System.Windows.Forms.ToolStripButton toolStripButtonClear;
        private System.Windows.Forms.ToolStripButton toolStripButtonFilter;
        private System.Windows.Forms.ToolStripButton toolStripButtonFind;
        private System.Windows.Forms.ToolStripButton toolStripButtonHighLight;
        private System.Windows.Forms.ToolStripButton toolStripButtonGrid;
        private System.Windows.Forms.ToolStripButton toolStripButtonRefresh;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripRightClickGridView;
        private System.Windows.Forms.ToolStripMenuItem copyRowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyCellToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIntegrityLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPermissions;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSddl;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnClientPID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPipeType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnConfiguration;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnReadMode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumberOfLinks;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDirectoryGrantedAccess;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGrantedAccess;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGrantedAccessGeneric;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCreationTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOwnerSid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOwnerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGroupSid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEndPointType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHandle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFileCreationTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLastAccessTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLastWriteTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnChangeTime;
        private System.Windows.Forms.ToolStripButton colorPermissionsButton;
        private ToolStripSeparator Separator;
        private ToolStripButton toolStripButtonStatus;
    }
}

