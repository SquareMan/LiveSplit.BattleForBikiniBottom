﻿using System.ComponentModel;

namespace LiveSplit.BattleForBikiniBottom.UI
{
    partial class SplitSettingsControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.splitLabel = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.cboSubType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // splitLabel
            // 
            this.splitLabel.AutoEllipsis = true;
            this.splitLabel.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.splitLabel.Location = new System.Drawing.Point(3, 3);
            this.splitLabel.Margin = new System.Windows.Forms.Padding(3);
            this.splitLabel.Name = "splitLabel";
            this.splitLabel.Size = new System.Drawing.Size(160, 21);
            this.splitLabel.TabIndex = 0;
            this.splitLabel.Text = "The cool split thing that happens here. Gaming Time ye";
            this.splitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.splitLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.splitLabel_MouseDown);
            // 
            // cboType
            // 
            this.cboType.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(169, 3);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(136, 21);
            this.cboType.TabIndex = 1;
            this.cboType.SelectionChangeCommitted += new System.EventHandler(this.cboType_SelectionChangeCommitted);
            this.cboType.Validating += new System.ComponentModel.CancelEventHandler(this.cboType_Validating);
            // 
            // txtValue
            // 
            this.txtValue.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValue.Location = new System.Drawing.Point(311, 3);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(27, 20);
            this.txtValue.TabIndex = 2;
            this.txtValue.Text = "0";
            this.txtValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValue.Visible = false;
            this.txtValue.Validating += new System.ComponentModel.CancelEventHandler(this.txtValue_Validating);
            // 
            // cboSubType
            // 
            this.cboSubType.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSubType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboSubType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSubType.FormattingEnabled = true;
            this.cboSubType.Location = new System.Drawing.Point(311, 3);
            this.cboSubType.Name = "cboSubType";
            this.cboSubType.Size = new System.Drawing.Size(136, 21);
            this.cboSubType.TabIndex = 3;
            this.cboSubType.Visible = false;
            this.cboSubType.SelectionChangeCommitted += new System.EventHandler(this.cboSubType_SelectionChangeCommitted);
            this.cboSubType.Validating += new System.ComponentModel.CancelEventHandler(this.cboSubType_Validating);
            // 
            // SplitSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitLabel);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.cboSubType);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "SplitSettings";
            this.Size = new System.Drawing.Size(450, 27);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ComboBox cboSubType;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label splitLabel;
        private System.Windows.Forms.TextBox txtValue;

        #endregion
    }
}