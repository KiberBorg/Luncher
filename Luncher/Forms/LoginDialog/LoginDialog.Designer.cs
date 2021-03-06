﻿namespace Luncher.Forms.LoginDialog
{
    partial class LoginDialog
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
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            this.acceptButton = new Telerik.WinControls.UI.RadButton();
            this.username = new Telerik.WinControls.UI.RadTextBox();
            this.password = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.acceptButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.username)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // acceptButton
            // 
            this.acceptButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.acceptButton.Location = new System.Drawing.Point(119, 99);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(127, 26);
            this.acceptButton.TabIndex = 0;
            this.acceptButton.Text = "Accept";
            this.acceptButton.ThemeName = "VisualStudio2012Dark";
            this.acceptButton.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(96, 2);
            this.username.Name = "username";
            this.username.NullText = "Mojang e-mail or Nickname";
            this.username.Size = new System.Drawing.Size(172, 21);
            this.username.TabIndex = 1;
            this.username.ThemeName = "VisualStudio2012Dark";
            this.username.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyPressed);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(96, 28);
            this.password.Name = "password";
            this.password.NullText = "Password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(172, 21);
            this.password.TabIndex = 2;
            this.password.ThemeName = "VisualStudio2012Dark";
            this.password.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyPressed);
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(7, 55);
            this.radLabel1.MaximumSize = new System.Drawing.Size(350, 38);
            this.radLabel1.MinimumSize = new System.Drawing.Size(350, 38);
            this.radLabel1.Name = "radLabel1";
            // 
            // 
            // 
            this.radLabel1.RootElement.MaxSize = new System.Drawing.Size(350, 38);
            this.radLabel1.RootElement.MinSize = new System.Drawing.Size(350, 38);
            this.radLabel1.Size = new System.Drawing.Size(350, 38);
            this.radLabel1.TabIndex = 3;
            this.radLabel1.Text = "wub wub wub";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radLabel1.ThemeName = "VisualStudio2012Dark";
            ((Telerik.WinControls.UI.RadLabelElement)(this.radLabel1.GetChildAt(0))).TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadLabelElement)(this.radLabel1.GetChildAt(0))).Text = "wub wub wub";
            ((Telerik.WinControls.Layouts.ImageAndTextLayoutPanel)(this.radLabel1.GetChildAt(0).GetChildAt(2))).TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radLabel1.GetChildAt(0).GetChildAt(2).GetChildAt(1))).TextWrap = true;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radLabel1.GetChildAt(0).GetChildAt(2).GetChildAt(1))).TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radButton2
            // 
            this.radButton2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.radButton2.Location = new System.Drawing.Point(119, 131);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(127, 24);
            this.radButton2.TabIndex = 4;
            this.radButton2.Text = "Cancel";
            this.radButton2.ThemeName = "VisualStudio2012Dark";
            this.radButton2.Click += new System.EventHandler(this.radButton2_Click);
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(-2, 159);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(207, 18);
            this.radLabel2.TabIndex = 5;
            this.radLabel2.Text = "Powered by YaDra4il (Yggdrasil for .Net)";
            this.radLabel2.ThemeName = "VisualStudio2012Dark";
            ((Telerik.WinControls.UI.RadLabelElement)(this.radLabel2.GetChildAt(0))).Text = "Powered by YaDra4il (Yggdrasil for .Net)";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radLabel2.GetChildAt(0).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.radLabel2.GetChildAt(0).GetChildAt(2).GetChildAt(0))).Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.radLabel2.GetChildAt(0).GetChildAt(2).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Visible;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radLabel2.GetChildAt(0).GetChildAt(2).GetChildAt(1))).TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radLabel2.GetChildAt(0).GetChildAt(2).GetChildAt(1))).Opacity = 0.3D;
            // 
            // LoginDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 175);
            this.ControlBox = false;
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radButton2);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "LoginDialog";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.Text = "Adding premium account";
            this.ThemeName = "VisualStudio2012Dark";
            ((System.ComponentModel.ISupportInitialize)(this.acceptButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.username)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
        private Telerik.WinControls.UI.RadButton acceptButton;
        private Telerik.WinControls.UI.RadTextBox username;
        private Telerik.WinControls.UI.RadTextBox password;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadButton radButton2;
        private Telerik.WinControls.UI.RadLabel radLabel2;
    }
}
