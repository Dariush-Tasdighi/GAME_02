namespace MY_APPLICATION
{
	partial class MainForm
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.topPanel = new System.Windows.Forms.Panel();
			this.exitButton = new System.Windows.Forms.Button();
			this.bulletCountLabel = new System.Windows.Forms.Label();
			this.bottomPanel = new System.Windows.Forms.Panel();
			this.scenePictureBox = new System.Windows.Forms.PictureBox();
			this.topPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.scenePictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// topPanel
			// 
			this.topPanel.BackColor = System.Drawing.Color.White;
			this.topPanel.Controls.Add(this.exitButton);
			this.topPanel.Controls.Add(this.bulletCountLabel);
			this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.topPanel.Location = new System.Drawing.Point(0, 0);
			this.topPanel.Name = "topPanel";
			this.topPanel.Size = new System.Drawing.Size(496, 60);
			this.topPanel.TabIndex = 0;
			this.topPanel.DoubleClick += new System.EventHandler(this.TopPanel_DoubleClick);
			// 
			// exitButton
			// 
			this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.exitButton.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.exitButton.Location = new System.Drawing.Point(384, 11);
			this.exitButton.Margin = new System.Windows.Forms.Padding(2);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(101, 47);
			this.exitButton.TabIndex = 1;
			this.exitButton.Text = "E&xit";
			this.exitButton.UseVisualStyleBackColor = true;
			this.exitButton.Visible = false;
			this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// bulletCountLabel
			// 
			this.bulletCountLabel.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bulletCountLabel.Location = new System.Drawing.Point(8, 6);
			this.bulletCountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.bulletCountLabel.Name = "bulletCountLabel";
			this.bulletCountLabel.Size = new System.Drawing.Size(89, 54);
			this.bulletCountLabel.TabIndex = 0;
			this.bulletCountLabel.Text = "-----";
			this.bulletCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.bulletCountLabel.Visible = false;
			// 
			// bottomPanel
			// 
			this.bottomPanel.BackColor = System.Drawing.Color.White;
			this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.bottomPanel.Location = new System.Drawing.Point(0, 367);
			this.bottomPanel.Name = "bottomPanel";
			this.bottomPanel.Size = new System.Drawing.Size(496, 60);
			this.bottomPanel.TabIndex = 1;
			// 
			// scenePictureBox
			// 
			this.scenePictureBox.BackColor = System.Drawing.Color.White;
			this.scenePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
			this.scenePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.scenePictureBox.Location = new System.Drawing.Point(0, 60);
			this.scenePictureBox.Name = "scenePictureBox";
			this.scenePictureBox.Size = new System.Drawing.Size(496, 307);
			this.scenePictureBox.TabIndex = 2;
			this.scenePictureBox.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(496, 427);
			this.ControlBox = false;
			this.Controls.Add(this.scenePictureBox);
			this.Controls.Add(this.bottomPanel);
			this.Controls.Add(this.topPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.topPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.scenePictureBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel topPanel;
		private System.Windows.Forms.Panel bottomPanel;
		private System.Windows.Forms.PictureBox scenePictureBox;
		private System.Windows.Forms.Label bulletCountLabel;
		private System.Windows.Forms.Button exitButton;
	}
}
