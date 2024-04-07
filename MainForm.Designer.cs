namespace BusylightForm
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
            this.RedLightButton = new System.Windows.Forms.Button();
            this.BlueLightButton = new System.Windows.Forms.Button();
            this.NoLightButton = new System.Windows.Forms.Button();
            this.reducedIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // RedLightButton
            // 
            this.RedLightButton.Location = new System.Drawing.Point(12, 12);
            this.RedLightButton.Name = "RedLightButton";
            this.RedLightButton.Size = new System.Drawing.Size(253, 58);
            this.RedLightButton.TabIndex = 0;
            this.RedLightButton.Text = "RED";
            this.RedLightButton.UseVisualStyleBackColor = true;
            this.RedLightButton.Click += new System.EventHandler(this.RedLightButton_Click);
            // 
            // BlueLightButton
            // 
            this.BlueLightButton.Location = new System.Drawing.Point(12, 76);
            this.BlueLightButton.Name = "BlueLightButton";
            this.BlueLightButton.Size = new System.Drawing.Size(253, 58);
            this.BlueLightButton.TabIndex = 2;
            this.BlueLightButton.Text = "BLUE";
            this.BlueLightButton.UseVisualStyleBackColor = true;
            this.BlueLightButton.Click += new System.EventHandler(this.BlueLightButton_Click);
            // 
            // NoLightButton
            // 
            this.NoLightButton.Location = new System.Drawing.Point(12, 141);
            this.NoLightButton.Name = "NoLightButton";
            this.NoLightButton.Size = new System.Drawing.Size(253, 58);
            this.NoLightButton.TabIndex = 4;
            this.NoLightButton.Text = "OFF";
            this.NoLightButton.UseVisualStyleBackColor = true;
            this.NoLightButton.Click += new System.EventHandler(this.NoLightButton_Click);
            // 
            // reducedIcon
            // 
            this.reducedIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("reducedIcon.Icon")));
            this.reducedIcon.Text = "Busylight Controls";
            this.reducedIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.reducedIcon_MouseDoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 211);
            this.Controls.Add(this.NoLightButton);
            this.Controls.Add(this.BlueLightButton);
            this.Controls.Add(this.RedLightButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.Text = "Busylight Omega controls";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RedLightButton;
        private System.Windows.Forms.Button BlueLightButton;
        private System.Windows.Forms.Button NoLightButton;
        private System.Windows.Forms.NotifyIcon reducedIcon;
    }
}

