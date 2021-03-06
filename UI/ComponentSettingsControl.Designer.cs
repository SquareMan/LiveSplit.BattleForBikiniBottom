﻿using System.ComponentModel;

namespace LiveSplit.BattleForBikiniBottom.UI
{
    partial class ComponentSettingsControl
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
            this.flowLayoutSplits = new System.Windows.Forms.FlowLayoutPanel();
            this.rdoNever = new System.Windows.Forms.RadioButton();
            this.rdoMainMenu = new System.Windows.Forms.RadioButton();
            this.rdoNewGame = new System.Windows.Forms.RadioButton();
            this.grpReset = new System.Windows.Forms.GroupBox();
            this.lblRevision = new System.Windows.Forms.Label();
            this.grpReset.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutSplits
            // 
            this.flowLayoutSplits.AllowDrop = true;
            this.flowLayoutSplits.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutSplits.AutoScroll = true;
            this.flowLayoutSplits.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutSplits.Location = new System.Drawing.Point(0, 65);
            this.flowLayoutSplits.Name = "flowLayoutSplits";
            this.flowLayoutSplits.Size = new System.Drawing.Size(450, 161);
            this.flowLayoutSplits.TabIndex = 0;
            this.flowLayoutSplits.WrapContents = false;
            this.flowLayoutSplits.DragOver += new System.Windows.Forms.DragEventHandler(this.flowLayoutSplits_DragOver);
            // 
            // rdoNever
            // 
            this.rdoNever.Location = new System.Drawing.Point(183, 19);
            this.rdoNever.Name = "rdoNever";
            this.rdoNever.Size = new System.Drawing.Size(57, 17);
            this.rdoNever.TabIndex = 3;
            this.rdoNever.Text = "Never";
            this.rdoNever.UseVisualStyleBackColor = true;
            this.rdoNever.CheckedChanged += new System.EventHandler(this.rdoNever_CheckedChanged);
            // 
            // rdoMainMenu
            // 
            this.rdoMainMenu.Location = new System.Drawing.Point(92, 19);
            this.rdoMainMenu.Name = "rdoMainMenu";
            this.rdoMainMenu.Size = new System.Drawing.Size(85, 17);
            this.rdoMainMenu.TabIndex = 2;
            this.rdoMainMenu.Text = "Main Menu";
            this.rdoMainMenu.UseVisualStyleBackColor = true;
            this.rdoMainMenu.CheckedChanged += new System.EventHandler(this.rdoMainMenu_CheckedChanged);
            // 
            // rdoNewGame
            // 
            this.rdoNewGame.Location = new System.Drawing.Point(6, 19);
            this.rdoNewGame.Name = "rdoNewGame";
            this.rdoNewGame.Size = new System.Drawing.Size(80, 17);
            this.rdoNewGame.TabIndex = 1;
            this.rdoNewGame.Text = "New Game";
            this.rdoNewGame.UseVisualStyleBackColor = true;
            this.rdoNewGame.CheckedChanged += new System.EventHandler(this.rdoNewGame_CheckedChanged);
            // 
            // grpReset
            // 
            this.grpReset.Controls.Add(this.rdoNewGame);
            this.grpReset.Controls.Add(this.rdoMainMenu);
            this.grpReset.Controls.Add(this.rdoNever);
            this.grpReset.Location = new System.Drawing.Point(10, 10);
            this.grpReset.Margin = new System.Windows.Forms.Padding(10);
            this.grpReset.Name = "grpReset";
            this.grpReset.Size = new System.Drawing.Size(246, 42);
            this.grpReset.TabIndex = 5;
            this.grpReset.TabStop = false;
            this.grpReset.Text = "Auto Reset Preference";
            // 
            // lblRevision
            // 
            this.lblRevision.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblRevision.Location = new System.Drawing.Point(269, 26);
            this.lblRevision.Name = "lblRevision";
            this.lblRevision.Size = new System.Drawing.Size(178, 23);
            this.lblRevision.TabIndex = 6;
            this.lblRevision.Text = "Game Revision: 000000";
            this.lblRevision.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RehydratedSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblRevision);
            this.Controls.Add(this.grpReset);
            this.Controls.Add(this.flowLayoutSplits);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "RehydratedSettings";
            this.Size = new System.Drawing.Size(450, 226);
            this.Load += new System.EventHandler(this.RehydratedSettings_Load);
            this.grpReset.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.FlowLayoutPanel flowLayoutSplits;
        private System.Windows.Forms.GroupBox grpReset;
        private System.Windows.Forms.Label lblRevision;
        private System.Windows.Forms.RadioButton rdoMainMenu;
        private System.Windows.Forms.RadioButton rdoNever;
        private System.Windows.Forms.RadioButton rdoNewGame;

        #endregion
    }
}