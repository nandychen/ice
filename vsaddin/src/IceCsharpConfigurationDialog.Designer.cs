// **********************************************************************
//
// Copyright (c) 2003-2011 ZeroC, Inc. All rights reserved.
//
// This copy of Ice is licensed to you under the terms described in the
// ICE_LICENSE file included in this distribution.
//
// **********************************************************************

namespace Ice.VisualStudio
{
    partial class IceCsharpConfigurationDialog
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
            this.chkEnableBuilder = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkIceStorm = new System.Windows.Forms.CheckBox();
            this.chkIceSSL = new System.Windows.Forms.CheckBox();
            this.chkIcePatch2 = new System.Windows.Forms.CheckBox();
            this.chkIceGrid = new System.Windows.Forms.CheckBox();
            this.chkIceBox = new System.Windows.Forms.CheckBox();
            this.chkGlacier2 = new System.Windows.Forms.CheckBox();
            this.chkIce = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxVerboseLevel = new System.Windows.Forms.ComboBox();
            this.chkChecksum = new System.Windows.Forms.CheckBox();
            this.chkIcePrefix = new System.Windows.Forms.CheckBox();
            this.chkStreaming = new System.Windows.Forms.CheckBox();
            this.chkTie = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnApply = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.extraCompilerOptions = new Ice.VisualStudio.ExtraCompilerOptionsView();
            this.includePathView = new Ice.VisualStudio.IncludePathView();
            this.outputDirView = new Ice.VisualStudio.OutputDirView();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkEnableBuilder
            // 
            this.chkEnableBuilder.AutoSize = true;
            this.chkEnableBuilder.Location = new System.Drawing.Point(12, 13);
            this.chkEnableBuilder.Name = "chkEnableBuilder";
            this.chkEnableBuilder.Size = new System.Drawing.Size(112, 17);
            this.chkEnableBuilder.TabIndex = 0;
            this.chkEnableBuilder.Text = "Enable Ice Builder";
            this.chkEnableBuilder.UseVisualStyleBackColor = true;
            this.chkEnableBuilder.CheckedChanged += new System.EventHandler(this.chkEnableBuilder_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkIceStorm);
            this.groupBox3.Controls.Add(this.chkIceSSL);
            this.groupBox3.Controls.Add(this.chkIcePatch2);
            this.groupBox3.Controls.Add(this.chkIceGrid);
            this.groupBox3.Controls.Add(this.chkIceBox);
            this.groupBox3.Controls.Add(this.chkGlacier2);
            this.groupBox3.Controls.Add(this.chkIce);
            this.groupBox3.Location = new System.Drawing.Point(12, 392);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(487, 47);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ice Components";
            // 
            // chkIceStorm
            // 
            this.chkIceStorm.AutoSize = true;
            this.chkIceStorm.Location = new System.Drawing.Point(404, 19);
            this.chkIceStorm.Name = "chkIceStorm";
            this.chkIceStorm.Size = new System.Drawing.Size(68, 17);
            this.chkIceStorm.TabIndex = 6;
            this.chkIceStorm.TabStop = false;
            this.chkIceStorm.Text = "IceStorm";
            this.chkIceStorm.UseVisualStyleBackColor = true;
            this.chkIceStorm.CheckedChanged += new System.EventHandler(this.component_Changed);
            // 
            // chkIceSSL
            // 
            this.chkIceSSL.AutoSize = true;
            this.chkIceSSL.Location = new System.Drawing.Point(337, 19);
            this.chkIceSSL.Name = "chkIceSSL";
            this.chkIceSSL.Size = new System.Drawing.Size(61, 17);
            this.chkIceSSL.TabIndex = 5;
            this.chkIceSSL.TabStop = false;
            this.chkIceSSL.Text = "IceSSL";
            this.chkIceSSL.UseVisualStyleBackColor = true;
            this.chkIceSSL.CheckedChanged += new System.EventHandler(this.component_Changed);
            // 
            // chkIcePatch2
            // 
            this.chkIcePatch2.AutoSize = true;
            this.chkIcePatch2.Location = new System.Drawing.Point(256, 19);
            this.chkIcePatch2.Name = "chkIcePatch2";
            this.chkIcePatch2.Size = new System.Drawing.Size(75, 17);
            this.chkIcePatch2.TabIndex = 4;
            this.chkIcePatch2.TabStop = false;
            this.chkIcePatch2.Text = "IcePatch2";
            this.chkIcePatch2.UseVisualStyleBackColor = true;
            this.chkIcePatch2.CheckedChanged += new System.EventHandler(this.component_Changed);
            // 
            // chkIceGrid
            // 
            this.chkIceGrid.AutoSize = true;
            this.chkIceGrid.Location = new System.Drawing.Point(190, 19);
            this.chkIceGrid.Name = "chkIceGrid";
            this.chkIceGrid.Size = new System.Drawing.Size(60, 17);
            this.chkIceGrid.TabIndex = 3;
            this.chkIceGrid.TabStop = false;
            this.chkIceGrid.Text = "IceGrid";
            this.chkIceGrid.UseVisualStyleBackColor = true;
            this.chkIceGrid.CheckedChanged += new System.EventHandler(this.component_Changed);
            // 
            // chkIceBox
            // 
            this.chkIceBox.AutoSize = true;
            this.chkIceBox.Location = new System.Drawing.Point(125, 19);
            this.chkIceBox.Name = "chkIceBox";
            this.chkIceBox.Size = new System.Drawing.Size(59, 17);
            this.chkIceBox.TabIndex = 2;
            this.chkIceBox.TabStop = false;
            this.chkIceBox.Text = "IceBox";
            this.chkIceBox.UseVisualStyleBackColor = true;
            this.chkIceBox.CheckedChanged += new System.EventHandler(this.component_Changed);
            // 
            // chkGlacier2
            // 
            this.chkGlacier2.AutoSize = true;
            this.chkGlacier2.Location = new System.Drawing.Point(7, 19);
            this.chkGlacier2.Name = "chkGlacier2";
            this.chkGlacier2.Size = new System.Drawing.Size(65, 17);
            this.chkGlacier2.TabIndex = 0;
            this.chkGlacier2.TabStop = false;
            this.chkGlacier2.Text = "Glacier2";
            this.chkGlacier2.UseVisualStyleBackColor = true;
            this.chkGlacier2.CheckedChanged += new System.EventHandler(this.component_Changed);
            // 
            // chkIce
            // 
            this.chkIce.AutoSize = true;
            this.chkIce.Location = new System.Drawing.Point(78, 19);
            this.chkIce.Name = "chkIce";
            this.chkIce.Size = new System.Drawing.Size(41, 17);
            this.chkIce.TabIndex = 1;
            this.chkIce.TabStop = false;
            this.chkIce.Text = "Ice";
            this.chkIce.UseVisualStyleBackColor = true;
            this.chkIce.CheckedChanged += new System.EventHandler(this.component_Changed);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.comboBoxVerboseLevel);
            this.groupBox4.Controls.Add(this.chkChecksum);
            this.groupBox4.Controls.Add(this.chkIcePrefix);
            this.groupBox4.Controls.Add(this.chkStreaming);
            this.groupBox4.Controls.Add(this.chkTie);
            this.groupBox4.Location = new System.Drawing.Point(12, 95);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(487, 44);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Slice Compiler Options";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tracing Level:";
            // 
            // comboBoxVerboseLevel
            // 
            this.comboBoxVerboseLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVerboseLevel.FormattingEnabled = true;
            this.comboBoxVerboseLevel.Items.AddRange(new object[] {
            "Errors",
            "Info",
            "Debug"});
            this.comboBoxVerboseLevel.Location = new System.Drawing.Point(359, 15);
            this.comboBoxVerboseLevel.Name = "comboBoxVerboseLevel";
            this.comboBoxVerboseLevel.Size = new System.Drawing.Size(121, 21);
            this.comboBoxVerboseLevel.TabIndex = 6;
            this.comboBoxVerboseLevel.SelectedIndexChanged += new System.EventHandler(this.component_Changed);
            // 
            // chkChecksum
            // 
            this.chkChecksum.AutoSize = true;
            this.chkChecksum.Location = new System.Drawing.Point(179, 19);
            this.chkChecksum.Name = "chkChecksum";
            this.chkChecksum.Size = new System.Drawing.Size(76, 17);
            this.chkChecksum.TabIndex = 5;
            this.chkChecksum.Text = "Checksum";
            this.chkChecksum.UseVisualStyleBackColor = true;
            this.chkChecksum.CheckedChanged += new System.EventHandler(this.component_Changed);
            // 
            // chkIcePrefix
            // 
            this.chkIcePrefix.AutoSize = true;
            this.chkIcePrefix.Location = new System.Drawing.Point(6, 19);
            this.chkIcePrefix.Name = "chkIcePrefix";
            this.chkIcePrefix.Size = new System.Drawing.Size(41, 17);
            this.chkIcePrefix.TabIndex = 2;
            this.chkIcePrefix.Text = "Ice";
            this.chkIcePrefix.UseVisualStyleBackColor = true;
            this.chkIcePrefix.CheckedChanged += new System.EventHandler(this.component_Changed);
            // 
            // chkStreaming
            // 
            this.chkStreaming.AutoSize = true;
            this.chkStreaming.Location = new System.Drawing.Point(100, 19);
            this.chkStreaming.Name = "chkStreaming";
            this.chkStreaming.Size = new System.Drawing.Size(73, 17);
            this.chkStreaming.TabIndex = 1;
            this.chkStreaming.Text = "Streaming";
            this.chkStreaming.UseVisualStyleBackColor = true;
            this.chkStreaming.CheckedChanged += new System.EventHandler(this.component_Changed);
            // 
            // chkTie
            // 
            this.chkTie.AutoSize = true;
            this.chkTie.Location = new System.Drawing.Point(53, 19);
            this.chkTie.Name = "chkTie";
            this.chkTie.Size = new System.Drawing.Size(41, 17);
            this.chkTie.TabIndex = 0;
            this.chkTie.Text = "Tie";
            this.chkTie.UseVisualStyleBackColor = true;
            this.chkTie.CheckedChanged += new System.EventHandler(this.component_Changed);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(424, 447);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(343, 447);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 7;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(262, 447);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // extraCompilerOptions
            // 
            this.extraCompilerOptions.Location = new System.Drawing.Point(7, 145);
            this.extraCompilerOptions.Name = "extraCompilerOptions";
            this.extraCompilerOptions.Size = new System.Drawing.Size(494, 73);
            this.extraCompilerOptions.TabIndex = 9;
            // 
            // includePathView
            // 
            this.includePathView.Location = new System.Drawing.Point(9, 217);
            this.includePathView.Name = "includePathView";
            this.includePathView.Size = new System.Drawing.Size(495, 174);
            this.includePathView.TabIndex = 11;
            // 
            // outputDirView
            // 
            this.outputDirView.Location = new System.Drawing.Point(5, 33);
            this.outputDirView.Name = "outputDirView";
            this.outputDirView.Size = new System.Drawing.Size(498, 54);
            this.outputDirView.TabIndex = 12;
            // 
            // IceCsharpConfigurationDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(512, 479);
            this.Controls.Add(this.outputDirView);
            this.Controls.Add(this.includePathView);
            this.Controls.Add(this.extraCompilerOptions);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.chkEnableBuilder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "IceCsharpConfigurationDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ice Configuration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formClosing);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkEnableBuilder;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkIceStorm;
        private System.Windows.Forms.CheckBox chkIceSSL;
        private System.Windows.Forms.CheckBox chkIcePatch2;
        private System.Windows.Forms.CheckBox chkIceGrid;
        private System.Windows.Forms.CheckBox chkIceBox;
        private System.Windows.Forms.CheckBox chkGlacier2;
        private System.Windows.Forms.CheckBox chkIce;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chkTie;
        private System.Windows.Forms.CheckBox chkIcePrefix;
        private System.Windows.Forms.CheckBox chkStreaming;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.CheckBox chkChecksum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxVerboseLevel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnApply;
        private ExtraCompilerOptionsView extraCompilerOptions;
        private IncludePathView includePathView;
        private OutputDirView outputDirView;
    }
}
