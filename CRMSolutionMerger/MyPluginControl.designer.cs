﻿namespace CRMSolutionMerger
{
    partial class MyPluginControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyPluginControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.tssSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSLoadSolution = new System.Windows.Forms.ToolStripButton();
            this.tsbSClonePatch = new System.Windows.Forms.ToolStripButton();
            this.tsbSDeletePatch = new System.Windows.Forms.ToolStripButton();
            this.tsbSMergePatch = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbConnectTarget = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbCopySource2Target = new System.Windows.Forms.ToolStripButton();
            this.gbSource = new System.Windows.Forms.GroupBox();
            this.dgvSource = new System.Windows.Forms.DataGridView();
            this.lblSEnvironment = new System.Windows.Forms.Label();
            this.lblSEnvironmentTitle = new System.Windows.Forms.Label();
            this.gbTarget = new System.Windows.Forms.GroupBox();
            this.dgvTarget = new System.Windows.Forms.DataGridView();
            this.lblTEnvironment = new System.Windows.Forms.Label();
            this.lblTEnvironmentTitle = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.rbManaged = new System.Windows.Forms.RadioButton();
            this.rbUnmanaged = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.rbBoth = new System.Windows.Forms.RadioButton();
            this.tsbPublishAll = new System.Windows.Forms.ToolStripButton();
            this.tsbAboutMe = new System.Windows.Forms.ToolStripButton();
            this.toolStripMenu.SuspendLayout();
            this.gbSource.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSource)).BeginInit();
            this.gbTarget.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarget)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbClose,
            this.toolStripSeparator1,
            this.tsbConnectTarget,
            this.tssSeparator1,
            this.tsbSLoadSolution,
            this.tsbSClonePatch,
            this.tsbSMergePatch,
            this.tsbSDeletePatch,
            this.toolStripSeparator2,
            this.tsbCopySource2Target,
            this.tsbPublishAll,
            this.tsbAboutMe});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(1429, 31);
            this.toolStripMenu.TabIndex = 4;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // tsbClose
            // 
            this.tsbClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbClose.Image = ((System.Drawing.Image)(resources.GetObject("tsbClose.Image")));
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(28, 28);
            this.tsbClose.Text = "Close this tool";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // tssSeparator1
            // 
            this.tssSeparator1.Name = "tssSeparator1";
            this.tssSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbSLoadSolution
            // 
            this.tsbSLoadSolution.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSLoadSolution.Image = ((System.Drawing.Image)(resources.GetObject("tsbSLoadSolution.Image")));
            this.tsbSLoadSolution.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSLoadSolution.Name = "tsbSLoadSolution";
            this.tsbSLoadSolution.Size = new System.Drawing.Size(28, 28);
            this.tsbSLoadSolution.Text = "Load Solution(s)";
            this.tsbSLoadSolution.Click += new System.EventHandler(this.tsbSLoadSolution_Click);
            // 
            // tsbSClonePatch
            // 
            this.tsbSClonePatch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSClonePatch.Enabled = false;
            this.tsbSClonePatch.Image = ((System.Drawing.Image)(resources.GetObject("tsbSClonePatch.Image")));
            this.tsbSClonePatch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSClonePatch.Name = "tsbSClonePatch";
            this.tsbSClonePatch.Size = new System.Drawing.Size(28, 28);
            this.tsbSClonePatch.Text = "Clone Patch";
            this.tsbSClonePatch.Click += new System.EventHandler(this.tsbSClonePath_Click);
            // 
            // tsbSDeletePatch
            // 
            this.tsbSDeletePatch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSDeletePatch.Enabled = false;
            this.tsbSDeletePatch.Image = ((System.Drawing.Image)(resources.GetObject("tsbSDeletePatch.Image")));
            this.tsbSDeletePatch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSDeletePatch.Name = "tsbSDeletePatch";
            this.tsbSDeletePatch.Size = new System.Drawing.Size(28, 28);
            this.tsbSDeletePatch.Text = "Delete Patch";
            this.tsbSDeletePatch.Click += new System.EventHandler(this.tsbSDeletePatch_Click);
            // 
            // tsbSMergePatch
            // 
            this.tsbSMergePatch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSMergePatch.Enabled = false;
            this.tsbSMergePatch.Image = ((System.Drawing.Image)(resources.GetObject("tsbSMergePatch.Image")));
            this.tsbSMergePatch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSMergePatch.Name = "tsbSMergePatch";
            this.tsbSMergePatch.Size = new System.Drawing.Size(28, 28);
            this.tsbSMergePatch.Text = "Merge Patch";
            this.tsbSMergePatch.Click += new System.EventHandler(this.tsbSMergePatch_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbConnectTarget
            // 
            this.tsbConnectTarget.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbConnectTarget.Image = ((System.Drawing.Image)(resources.GetObject("tsbConnectTarget.Image")));
            this.tsbConnectTarget.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbConnectTarget.Name = "tsbConnectTarget";
            this.tsbConnectTarget.Size = new System.Drawing.Size(28, 28);
            this.tsbConnectTarget.Text = "Connect Target";
            this.tsbConnectTarget.Click += new System.EventHandler(this.tsbConnectTarget_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbCopySource2Target
            // 
            this.tsbCopySource2Target.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCopySource2Target.Enabled = false;
            this.tsbCopySource2Target.Image = ((System.Drawing.Image)(resources.GetObject("tsbCopySource2Target.Image")));
            this.tsbCopySource2Target.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCopySource2Target.Name = "tsbCopySource2Target";
            this.tsbCopySource2Target.Size = new System.Drawing.Size(28, 28);
            this.tsbCopySource2Target.Text = "Copy Solution";
            this.tsbCopySource2Target.Click += new System.EventHandler(this.tsbCopySource2Target_Click);
            // 
            // gbSource
            // 
            this.gbSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSource.Controls.Add(this.dgvSource);
            this.gbSource.Controls.Add(this.lblSEnvironment);
            this.gbSource.Controls.Add(this.lblSEnvironmentTitle);
            this.gbSource.Location = new System.Drawing.Point(3, 85);
            this.gbSource.Name = "gbSource";
            this.gbSource.Size = new System.Drawing.Size(1423, 416);
            this.gbSource.TabIndex = 5;
            this.gbSource.TabStop = false;
            this.gbSource.Text = "Source Solution Info";
            // 
            // dgvSource
            // 
            this.dgvSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSource.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvSource.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSource.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvSource.Location = new System.Drawing.Point(6, 42);
            this.dgvSource.Name = "dgvSource";
            this.dgvSource.Size = new System.Drawing.Size(1411, 364);
            this.dgvSource.TabIndex = 2;
            this.dgvSource.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSource_CellClick);
            this.dgvSource.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSource_CellDoubleClick);
            // 
            // lblSEnvironment
            // 
            this.lblSEnvironment.AutoSize = true;
            this.lblSEnvironment.ForeColor = System.Drawing.Color.Red;
            this.lblSEnvironment.Location = new System.Drawing.Point(122, 16);
            this.lblSEnvironment.Name = "lblSEnvironment";
            this.lblSEnvironment.Size = new System.Drawing.Size(79, 13);
            this.lblSEnvironment.TabIndex = 1;
            this.lblSEnvironment.Text = "Not Conencted";
            // 
            // lblSEnvironmentTitle
            // 
            this.lblSEnvironmentTitle.AutoSize = true;
            this.lblSEnvironmentTitle.Location = new System.Drawing.Point(7, 16);
            this.lblSEnvironmentTitle.Name = "lblSEnvironmentTitle";
            this.lblSEnvironmentTitle.Size = new System.Drawing.Size(109, 13);
            this.lblSEnvironmentTitle.TabIndex = 0;
            this.lblSEnvironmentTitle.Text = "Source Environment: ";
            // 
            // gbTarget
            // 
            this.gbTarget.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTarget.Controls.Add(this.dgvTarget);
            this.gbTarget.Controls.Add(this.lblTEnvironment);
            this.gbTarget.Controls.Add(this.lblTEnvironmentTitle);
            this.gbTarget.Location = new System.Drawing.Point(6, 507);
            this.gbTarget.Name = "gbTarget";
            this.gbTarget.Size = new System.Drawing.Size(1423, 416);
            this.gbTarget.TabIndex = 6;
            this.gbTarget.TabStop = false;
            this.gbTarget.Text = "Target Solution Info";
            // 
            // dgvTarget
            // 
            this.dgvTarget.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTarget.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvTarget.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTarget.DefaultCellStyle = dataGridViewCellStyle16;
            this.dgvTarget.Location = new System.Drawing.Point(6, 40);
            this.dgvTarget.Name = "dgvTarget";
            this.dgvTarget.Size = new System.Drawing.Size(1411, 364);
            this.dgvTarget.TabIndex = 3;
            this.dgvTarget.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTarget_CellClick);
            this.dgvTarget.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTarget_CellDoubleClick);
            // 
            // lblTEnvironment
            // 
            this.lblTEnvironment.AutoSize = true;
            this.lblTEnvironment.ForeColor = System.Drawing.Color.Red;
            this.lblTEnvironment.Location = new System.Drawing.Point(119, 16);
            this.lblTEnvironment.Name = "lblTEnvironment";
            this.lblTEnvironment.Size = new System.Drawing.Size(79, 13);
            this.lblTEnvironment.TabIndex = 2;
            this.lblTEnvironment.Text = "Not Connected";
            // 
            // lblTEnvironmentTitle
            // 
            this.lblTEnvironmentTitle.AutoSize = true;
            this.lblTEnvironmentTitle.Location = new System.Drawing.Point(6, 16);
            this.lblTEnvironmentTitle.Name = "lblTEnvironmentTitle";
            this.lblTEnvironmentTitle.Size = new System.Drawing.Size(106, 13);
            this.lblTEnvironmentTitle.TabIndex = 1;
            this.lblTEnvironmentTitle.Text = "Target Environment: ";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(10, 50);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(120, 13);
            this.lblSearch.TabIndex = 7;
            this.lblSearch.Text = "Solution Search Criteria:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(142, 46);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(283, 20);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.Tag = "";
            this.txtSearch.Text = "*";
            this.txtSearch.MouseHover += new System.EventHandler(this.txtSearch_MouseHover);
            // 
            // rbManaged
            // 
            this.rbManaged.AutoSize = true;
            this.rbManaged.Location = new System.Drawing.Point(524, 49);
            this.rbManaged.Name = "rbManaged";
            this.rbManaged.Size = new System.Drawing.Size(70, 17);
            this.rbManaged.TabIndex = 9;
            this.rbManaged.Text = "Managed";
            this.rbManaged.UseVisualStyleBackColor = true;
            // 
            // rbUnmanaged
            // 
            this.rbUnmanaged.AutoSize = true;
            this.rbUnmanaged.Checked = true;
            this.rbUnmanaged.Location = new System.Drawing.Point(595, 49);
            this.rbUnmanaged.Name = "rbUnmanaged";
            this.rbUnmanaged.Size = new System.Drawing.Size(83, 17);
            this.rbUnmanaged.TabIndex = 10;
            this.rbUnmanaged.TabStop = true;
            this.rbUnmanaged.Text = "Unmanaged";
            this.rbUnmanaged.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(440, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Solution Type:";
            // 
            // rbBoth
            // 
            this.rbBoth.AutoSize = true;
            this.rbBoth.Location = new System.Drawing.Point(681, 50);
            this.rbBoth.Name = "rbBoth";
            this.rbBoth.Size = new System.Drawing.Size(47, 17);
            this.rbBoth.TabIndex = 12;
            this.rbBoth.Text = "Both";
            this.rbBoth.UseVisualStyleBackColor = true;
            // 
            // tsbPublishAll
            // 
            this.tsbPublishAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPublishAll.Image = ((System.Drawing.Image)(resources.GetObject("tsbPublishAll.Image")));
            this.tsbPublishAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPublishAll.Name = "tsbPublishAll";
            this.tsbPublishAll.Size = new System.Drawing.Size(28, 28);
            this.tsbPublishAll.Text = "Publish All";
            this.tsbPublishAll.Click += new System.EventHandler(this.tsbPublishAll_Click);
            // 
            // tsbAboutMe
            // 
            this.tsbAboutMe.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAboutMe.Image = ((System.Drawing.Image)(resources.GetObject("tsbAboutMe.Image")));
            this.tsbAboutMe.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAboutMe.Name = "tsbAboutMe";
            this.tsbAboutMe.Size = new System.Drawing.Size(28, 28);
            this.tsbAboutMe.Text = "About Me";
            this.tsbAboutMe.Click += new System.EventHandler(this.tsbAboutMe_Click);
            // 
            // MyPluginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rbBoth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbUnmanaged);
            this.Controls.Add(this.rbManaged);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.gbTarget);
            this.Controls.Add(this.gbSource);
            this.Controls.Add(this.toolStripMenu);
            this.Name = "MyPluginControl";
            this.Size = new System.Drawing.Size(1429, 952);
            this.Load += new System.EventHandler(this.MyPluginControl_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.gbSource.ResumeLayout(false);
            this.gbSource.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSource)).EndInit();
            this.gbTarget.ResumeLayout(false);
            this.gbTarget.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarget)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStripSeparator tssSeparator1;
        private System.Windows.Forms.GroupBox gbSource;
        private System.Windows.Forms.GroupBox gbTarget;
        private System.Windows.Forms.ToolStripButton tsbConnectTarget;
        private System.Windows.Forms.Label lblSEnvironmentTitle;
        private System.Windows.Forms.Label lblTEnvironmentTitle;
        private System.Windows.Forms.Label lblSEnvironment;
        private System.Windows.Forms.Label lblTEnvironment;
        private System.Windows.Forms.ToolStripButton tsbSLoadSolution;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridView dgvSource;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RadioButton rbManaged;
        private System.Windows.Forms.RadioButton rbUnmanaged;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.RadioButton rbBoth;
        private System.Windows.Forms.ToolStripButton tsbSClonePatch;
        private System.Windows.Forms.ToolStripButton tsbSMergePatch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbCopySource2Target;
        private System.Windows.Forms.DataGridView dgvTarget;
        private System.Windows.Forms.ToolStripButton tsbSDeletePatch;
        private System.Windows.Forms.ToolStripButton tsbPublishAll;
        private System.Windows.Forms.ToolStripButton tsbAboutMe;
    }
}
