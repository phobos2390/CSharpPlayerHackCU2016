namespace SmartHeadphonePlayer
{
    partial class PlayerComponent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerComponent));
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.videoFileSelector = new System.Windows.Forms.OpenFileDialog();
            this.openFileButton = new System.Windows.Forms.Button();
            this.detectHeadphone = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(12, 12);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(260, 237);
            this.player.TabIndex = 0;
            // 
            // videoFileSelector
            // 
            this.videoFileSelector.InitialDirectory = "C:\\Users\\James\\Videos";
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(12, 255);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(92, 21);
            this.openFileButton.TabIndex = 1;
            this.openFileButton.Text = "Open File";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // detectHeadphone
            // 
            this.detectHeadphone.AutoSize = true;
            this.detectHeadphone.Location = new System.Drawing.Point(150, 258);
            this.detectHeadphone.Name = "detectHeadphone";
            this.detectHeadphone.Size = new System.Drawing.Size(122, 17);
            this.detectHeadphone.TabIndex = 2;
            this.detectHeadphone.Text = "Detect Headphones";
            this.detectHeadphone.UseVisualStyleBackColor = true;
            // 
            // PlayerComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 284);
            this.Controls.Add(this.detectHeadphone);
            this.Controls.Add(this.openFileButton);
            this.Controls.Add(this.player);
            this.Name = "PlayerComponent";
            this.Text = "Smart Headphones Player";
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.OpenFileDialog videoFileSelector;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.CheckBox detectHeadphone;
    }
}

