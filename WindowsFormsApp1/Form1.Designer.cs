namespace WindowsFormsApp1
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.guessButton = new System.Windows.Forms.Button();
			this.newGameButton = new System.Windows.Forms.Button();
			this.guessTextBox = new System.Windows.Forms.TextBox();
			this.resultLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// guessButton
			// 
			this.guessButton.Location = new System.Drawing.Point(311, 87);
			this.guessButton.Name = "guessButton";
			this.guessButton.Size = new System.Drawing.Size(75, 23);
			this.guessButton.TabIndex = 0;
			this.guessButton.Text = "猜猜看";
			this.guessButton.UseVisualStyleBackColor = true;
			this.guessButton.Click += new System.EventHandler(this.guessButton_Click);
			// 
			// newGameButton
			// 
			this.newGameButton.Location = new System.Drawing.Point(311, 149);
			this.newGameButton.Name = "newGameButton";
			this.newGameButton.Size = new System.Drawing.Size(75, 23);
			this.newGameButton.TabIndex = 1;
			this.newGameButton.Text = "新遊戲";
			this.newGameButton.UseVisualStyleBackColor = true;
			this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
			// 
			// guessTextBox
			// 
			this.guessTextBox.Location = new System.Drawing.Point(107, 89);
			this.guessTextBox.Name = "guessTextBox";
			this.guessTextBox.Size = new System.Drawing.Size(100, 22);
			this.guessTextBox.TabIndex = 2;
			// 
			// resultLabel
			// 
			this.resultLabel.AutoSize = true;
			this.resultLabel.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.resultLabel.Location = new System.Drawing.Point(101, 217);
			this.resultLabel.Name = "resultLabel";
			this.resultLabel.Size = new System.Drawing.Size(92, 35);
			this.resultLabel.TabIndex = 3;
			this.resultLabel.Text = "label1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(478, 346);
			this.Controls.Add(this.resultLabel);
			this.Controls.Add(this.guessTextBox);
			this.Controls.Add(this.newGameButton);
			this.Controls.Add(this.guessButton);
			this.Name = "Form1";
			this.Text = "猜數字";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button guessButton;
		private System.Windows.Forms.Button newGameButton;
		private System.Windows.Forms.TextBox guessTextBox;
		private System.Windows.Forms.Label resultLabel;
	}
}

