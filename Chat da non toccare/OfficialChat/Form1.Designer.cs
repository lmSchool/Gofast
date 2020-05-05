﻿namespace OfficialChat
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.mainPanelUp = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelMinimize = new System.Windows.Forms.Label();
            this.labelClose = new System.Windows.Forms.Label();
            this.panelMove = new System.Windows.Forms.Panel();
            this.labelLogo = new System.Windows.Forms.Label();
            this.mainPanelDown = new System.Windows.Forms.Panel();
            this.mainPanelUp.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelMove.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanelUp
            // 
            this.mainPanelUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(179)))), ((int)(((byte)(16)))));
            this.mainPanelUp.Controls.Add(this.panel1);
            this.mainPanelUp.Controls.Add(this.panelMove);
            this.mainPanelUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainPanelUp.Location = new System.Drawing.Point(0, 0);
            this.mainPanelUp.Name = "mainPanelUp";
            this.mainPanelUp.Size = new System.Drawing.Size(1000, 36);
            this.mainPanelUp.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(179)))), ((int)(((byte)(16)))));
            this.panel1.Controls.Add(this.labelMinimize);
            this.panel1.Controls.Add(this.labelClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(938, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(62, 36);
            this.panel1.TabIndex = 4;
            // 
            // labelMinimize
            // 
            this.labelMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMinimize.AutoSize = true;
            this.labelMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinimize.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelMinimize.Location = new System.Drawing.Point(7, 9);
            this.labelMinimize.Name = "labelMinimize";
            this.labelMinimize.Size = new System.Drawing.Size(16, 18);
            this.labelMinimize.TabIndex = 3;
            this.labelMinimize.Text = "_";
            this.labelMinimize.Click += new System.EventHandler(this.labelMinimize_Click);
            this.labelMinimize.MouseEnter += new System.EventHandler(this.labelMinimize_MouseEnter);
            this.labelMinimize.MouseLeave += new System.EventHandler(this.labelMinimize_MouseLeave);
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelClose.Location = new System.Drawing.Point(31, 10);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(18, 18);
            this.labelClose.TabIndex = 1;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            this.labelClose.MouseEnter += new System.EventHandler(this.labelClose_MouseEnter);
            this.labelClose.MouseLeave += new System.EventHandler(this.labelClose_MouseLeave);
            // 
            // panelMove
            // 
            this.panelMove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(179)))), ((int)(((byte)(16)))));
            this.panelMove.Controls.Add(this.labelLogo);
            this.panelMove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMove.Location = new System.Drawing.Point(0, 0);
            this.panelMove.Name = "panelMove";
            this.panelMove.Size = new System.Drawing.Size(1000, 36);
            this.panelMove.TabIndex = 4;
            this.panelMove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDownMoveForm);
            // 
            // labelLogo
            // 
            this.labelLogo.AutoSize = true;
            this.labelLogo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelLogo.Location = new System.Drawing.Point(12, 7);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(64, 23);
            this.labelLogo.TabIndex = 2;
            this.labelLogo.Text = "GoFast";
            // 
            // mainPanelDown
            // 
            this.mainPanelDown.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainPanelDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.mainPanelDown.Location = new System.Drawing.Point(0, 36);
            this.mainPanelDown.Name = "mainPanelDown";
            this.mainPanelDown.Size = new System.Drawing.Size(1000, 665);
            this.mainPanelDown.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(60)))), ((int)(((byte)(93)))));
            this.ClientSize = new System.Drawing.Size(1000, 701);
            this.Controls.Add(this.mainPanelDown);
            this.Controls.Add(this.mainPanelUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainPanelUp.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelMove.ResumeLayout(false);
            this.panelMove.PerformLayout();
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.Panel mainPanelUp;
        private System.Windows.Forms.Panel mainPanelDown;
        private System.Windows.Forms.Label labelMinimize;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Panel panelMove;
        private System.Windows.Forms.Panel panel1;
    }
}