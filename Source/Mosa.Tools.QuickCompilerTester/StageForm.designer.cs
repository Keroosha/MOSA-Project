﻿namespace Mosa.Tools.TypeExplorer
{
	partial class StageForm
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
			System.Windows.Forms.Label labelLabel;
			System.Windows.Forms.Label methodLabel;
			System.Windows.Forms.Label stageLabel;
			this.menuStrip2 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.spaceAfterBlockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.removeNextprevInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.lbStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.Result = new System.Windows.Forms.TabPage();
			this.panel2 = new System.Windows.Forms.Panel();
			this.cbLabel = new System.Windows.Forms.CheckBox();
			this.cbMethods = new System.Windows.Forms.ComboBox();
			this.cbLabels = new System.Windows.Forms.ComboBox();
			this.cbStage = new System.Windows.Forms.CheckBox();
			this.cbStages = new System.Windows.Forms.ComboBox();
			this.tbResult = new System.Windows.Forms.RichTextBox();
			this.Source = new System.Windows.Forms.TabPage();
			this.tbSource = new System.Windows.Forms.RichTextBox();
			labelLabel = new System.Windows.Forms.Label();
			methodLabel = new System.Windows.Forms.Label();
			stageLabel = new System.Windows.Forms.Label();
			this.menuStrip2.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.Result.SuspendLayout();
			this.panel2.SuspendLayout();
			this.Source.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelLabel
			// 
			labelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			labelLabel.Location = new System.Drawing.Point(643, 3);
			labelLabel.Margin = new System.Windows.Forms.Padding(4);
			labelLabel.Name = "labelLabel";
			labelLabel.Size = new System.Drawing.Size(76, 22);
			labelLabel.TabIndex = 17;
			labelLabel.Text = "Label:";
			// 
			// methodLabel
			// 
			methodLabel.AutoSize = true;
			methodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			methodLabel.Location = new System.Drawing.Point(10, 7);
			methodLabel.Margin = new System.Windows.Forms.Padding(4);
			methodLabel.Name = "methodLabel";
			methodLabel.Size = new System.Drawing.Size(59, 17);
			methodLabel.TabIndex = 4;
			methodLabel.Text = "Method:";
			// 
			// stageLabel
			// 
			stageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			stageLabel.Location = new System.Drawing.Point(387, 3);
			stageLabel.Margin = new System.Windows.Forms.Padding(4);
			stageLabel.Name = "stageLabel";
			stageLabel.Size = new System.Drawing.Size(158, 22);
			stageLabel.TabIndex = 18;
			stageLabel.Text = "Stage:";
			// 
			// menuStrip2
			// 
			this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
			this.menuStrip2.Location = new System.Drawing.Point(0, 0);
			this.menuStrip2.Name = "menuStrip2";
			this.menuStrip2.Size = new System.Drawing.Size(895, 24);
			this.menuStrip2.TabIndex = 29;
			this.menuStrip2.Text = "menuStrip2";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripMenuItem1,
            this.refreshToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.quitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// loadToolStripMenuItem
			// 
			this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
			this.loadToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
			this.loadToolStripMenuItem.Text = "Load";
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
			this.saveToolStripMenuItem.Text = "Save";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(110, 6);
			// 
			// refreshToolStripMenuItem
			// 
			this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
			this.refreshToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
			this.refreshToolStripMenuItem.Text = "Refresh";
			// 
			// resetToolStripMenuItem
			// 
			this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
			this.resetToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
			this.resetToolStripMenuItem.Text = "Reset";
			// 
			// quitToolStripMenuItem
			// 
			this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
			this.quitToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
			this.quitToolStripMenuItem.Text = "Quit";
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spaceAfterBlockToolStripMenuItem,
            this.removeNextprevInformationToolStripMenuItem});
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.optionsToolStripMenuItem.Text = "Options";
			// 
			// spaceAfterBlockToolStripMenuItem
			// 
			this.spaceAfterBlockToolStripMenuItem.Checked = true;
			this.spaceAfterBlockToolStripMenuItem.CheckOnClick = true;
			this.spaceAfterBlockToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.spaceAfterBlockToolStripMenuItem.Name = "spaceAfterBlockToolStripMenuItem";
			this.spaceAfterBlockToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
			this.spaceAfterBlockToolStripMenuItem.Text = "Space after block";
			// 
			// removeNextprevInformationToolStripMenuItem
			// 
			this.removeNextprevInformationToolStripMenuItem.Checked = true;
			this.removeNextprevInformationToolStripMenuItem.CheckOnClick = true;
			this.removeNextprevInformationToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.removeNextprevInformationToolStripMenuItem.Name = "removeNextprevInformationToolStripMenuItem";
			this.removeNextprevInformationToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
			this.removeNextprevInformationToolStripMenuItem.Text = "Remove next/prev information";
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbStatus});
			this.statusStrip1.Location = new System.Drawing.Point(0, 573);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Padding = new System.Windows.Forms.Padding(3, 0, 24, 0);
			this.statusStrip1.Size = new System.Drawing.Size(895, 22);
			this.statusStrip1.TabIndex = 28;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// lbStatus
			// 
			this.lbStatus.Name = "lbStatus";
			this.lbStatus.Size = new System.Drawing.Size(145, 17);
			this.lbStatus.Text = "MOSA Compiler Visualizer";
			// 
			// tabControl1
			// 
			this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.Result);
			this.tabControl1.Controls.Add(this.Source);
			this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabControl1.Location = new System.Drawing.Point(0, 31);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(5);
			this.tabControl1.Multiline = true;
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(857, 534);
			this.tabControl1.TabIndex = 2;
			// 
			// Result
			// 
			this.Result.BackColor = System.Drawing.Color.Silver;
			this.Result.Controls.Add(this.panel2);
			this.Result.Controls.Add(this.tbResult);
			this.Result.Location = new System.Drawing.Point(4, 4);
			this.Result.Margin = new System.Windows.Forms.Padding(5);
			this.Result.Name = "Result";
			this.Result.Padding = new System.Windows.Forms.Padding(5);
			this.Result.Size = new System.Drawing.Size(849, 505);
			this.Result.TabIndex = 0;
			this.Result.Text = "Result";
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.BackColor = System.Drawing.Color.LightGray;
			this.panel2.Controls.Add(labelLabel);
			this.panel2.Controls.Add(this.cbLabel);
			this.panel2.Controls.Add(this.cbMethods);
			this.panel2.Controls.Add(this.cbLabels);
			this.panel2.Controls.Add(methodLabel);
			this.panel2.Controls.Add(this.cbStage);
			this.panel2.Controls.Add(this.cbStages);
			this.panel2.Controls.Add(stageLabel);
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(849, 59);
			this.panel2.TabIndex = 5;
			// 
			// cbLabel
			// 
			this.cbLabel.AutoSize = true;
			this.cbLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbLabel.Location = new System.Drawing.Point(759, 2);
			this.cbLabel.Margin = new System.Windows.Forms.Padding(4);
			this.cbLabel.Name = "cbLabel";
			this.cbLabel.Size = new System.Drawing.Size(73, 21);
			this.cbLabel.TabIndex = 8;
			this.cbLabel.Text = "Display";
			this.cbLabel.UseVisualStyleBackColor = true;
			this.cbLabel.CheckedChanged += new System.EventHandler(this.refreshButton_Click);
			// 
			// cbMethods
			// 
			this.cbMethods.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbMethods.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbMethods.FormattingEnabled = true;
			this.cbMethods.Location = new System.Drawing.Point(10, 28);
			this.cbMethods.Margin = new System.Windows.Forms.Padding(4);
			this.cbMethods.MaxDropDownItems = 20;
			this.cbMethods.Name = "cbMethods";
			this.cbMethods.Size = new System.Drawing.Size(372, 21);
			this.cbMethods.TabIndex = 3;
			this.cbMethods.SelectionChangeCommitted += new System.EventHandler(this.cbMethods_SelectionChangeCommitted);
			// 
			// cbLabels
			// 
			this.cbLabels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbLabels.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbLabels.FormattingEnabled = true;
			this.cbLabels.Location = new System.Drawing.Point(646, 28);
			this.cbLabels.Margin = new System.Windows.Forms.Padding(4);
			this.cbLabels.MaxDropDownItems = 20;
			this.cbLabels.Name = "cbLabels";
			this.cbLabels.Size = new System.Drawing.Size(186, 21);
			this.cbLabels.TabIndex = 6;
			this.cbLabels.SelectionChangeCommitted += new System.EventHandler(this.cbLabels_SelectionChangeCommitted);
			// 
			// cbStage
			// 
			this.cbStage.AutoSize = true;
			this.cbStage.Checked = true;
			this.cbStage.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbStage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbStage.Location = new System.Drawing.Point(565, 2);
			this.cbStage.Margin = new System.Windows.Forms.Padding(4);
			this.cbStage.Name = "cbStage";
			this.cbStage.Size = new System.Drawing.Size(73, 21);
			this.cbStage.TabIndex = 11;
			this.cbStage.Text = "Display";
			this.cbStage.UseVisualStyleBackColor = true;
			this.cbStage.CheckedChanged += new System.EventHandler(this.refreshButton_Click);
			// 
			// cbStages
			// 
			this.cbStages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbStages.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbStages.FormattingEnabled = true;
			this.cbStages.Location = new System.Drawing.Point(390, 28);
			this.cbStages.Margin = new System.Windows.Forms.Padding(4);
			this.cbStages.MaxDropDownItems = 20;
			this.cbStages.Name = "cbStages";
			this.cbStages.Size = new System.Drawing.Size(248, 21);
			this.cbStages.TabIndex = 0;
			this.cbStages.SelectionChangeCommitted += new System.EventHandler(this.cbStages_SelectionChangeCommitted);
			// 
			// tbResult
			// 
			this.tbResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbResult.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbResult.Location = new System.Drawing.Point(0, 61);
			this.tbResult.Margin = new System.Windows.Forms.Padding(0);
			this.tbResult.Name = "tbResult";
			this.tbResult.Size = new System.Drawing.Size(849, 442);
			this.tbResult.TabIndex = 2;
			this.tbResult.Text = "";
			this.tbResult.WordWrap = false;
			// 
			// Source
			// 
			this.Source.Controls.Add(this.tbSource);
			this.Source.Location = new System.Drawing.Point(4, 4);
			this.Source.Margin = new System.Windows.Forms.Padding(0);
			this.Source.Name = "Source";
			this.Source.Size = new System.Drawing.Size(849, 505);
			this.Source.TabIndex = 1;
			this.Source.Text = "Source";
			this.Source.UseVisualStyleBackColor = true;
			// 
			// tbSource
			// 
			this.tbSource.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbSource.Font = new System.Drawing.Font("Lucida Console", 10F);
			this.tbSource.Location = new System.Drawing.Point(0, 0);
			this.tbSource.Margin = new System.Windows.Forms.Padding(0);
			this.tbSource.Name = "tbSource";
			this.tbSource.Size = new System.Drawing.Size(849, 502);
			this.tbSource.TabIndex = 1;
			this.tbSource.Text = "";
			this.tbSource.WordWrap = false;
			this.tbSource.TextChanged += new System.EventHandler(this.tbSource_TextChanged);
			// 
			// StageForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(895, 595);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.menuStrip2);
			this.Controls.Add(this.statusStrip1);
			this.Name = "StageForm";
			this.Text = "StageForm";
			this.menuStrip2.ResumeLayout(false);
			this.menuStrip2.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.Result.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.Source.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip2;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem spaceAfterBlockToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem removeNextprevInformationToolStripMenuItem;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel lbStatus;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage Result;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.CheckBox cbLabel;
		private System.Windows.Forms.ComboBox cbMethods;
		private System.Windows.Forms.ComboBox cbLabels;
		private System.Windows.Forms.CheckBox cbStage;
		private System.Windows.Forms.ComboBox cbStages;
		private System.Windows.Forms.RichTextBox tbResult;
		private System.Windows.Forms.TabPage Source;
		private System.Windows.Forms.RichTextBox tbSource;
	}
}