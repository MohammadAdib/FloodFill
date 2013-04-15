namespace Flood_Fill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Panel = new System.Windows.Forms.Panel();
            this.SmCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.White;
            this.Panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel.BackgroundImage")));
            this.Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Panel.Location = new System.Drawing.Point(8, 8);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(232, 232);
            this.Panel.TabIndex = 3;
            this.Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MousePressed);
            // 
            // SmCheckBox
            // 
            this.SmCheckBox.AutoSize = true;
            this.SmCheckBox.Checked = true;
            this.SmCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SmCheckBox.Location = new System.Drawing.Point(80, 248);
            this.SmCheckBox.Name = "SmCheckBox";
            this.SmCheckBox.Size = new System.Drawing.Size(84, 17);
            this.SmCheckBox.TabIndex = 4;
            this.SmCheckBox.Text = "Slow-Motion";
            this.SmCheckBox.UseVisualStyleBackColor = true;
            this.SmCheckBox.CheckedChanged += new System.EventHandler(this.SmCheckBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(250, 270);
            this.Controls.Add(this.SmCheckBox);
            this.Controls.Add(this.Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flood Fill";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.CheckBox SmCheckBox;
    }
}

