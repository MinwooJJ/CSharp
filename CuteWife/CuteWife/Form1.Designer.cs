
namespace CuteWife
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.Hug = new System.Windows.Forms.Button();
			this.Feeling = new System.Windows.Forms.Label();
			this.Kiss = new System.Windows.Forms.Button();
			this.Feed = new System.Windows.Forms.Button();
			this.Board = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// Hug
			// 
			this.Hug.Location = new System.Drawing.Point(58, 86);
			this.Hug.Name = "Hug";
			this.Hug.Size = new System.Drawing.Size(57, 54);
			this.Hug.TabIndex = 0;
			this.Hug.Text = "Hug";
			this.Hug.UseVisualStyleBackColor = true;
			this.Hug.Click += new System.EventHandler(this.Control_Click);
			// 
			// Feeling
			// 
			this.Feeling.BackColor = System.Drawing.Color.White;
			this.Feeling.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Feeling.Location = new System.Drawing.Point(12, 9);
			this.Feeling.Name = "Feeling";
			this.Feeling.Size = new System.Drawing.Size(307, 62);
			this.Feeling.TabIndex = 2;
			this.Feeling.Text = "label1";
			this.Feeling.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Kiss
			// 
			this.Kiss.Location = new System.Drawing.Point(135, 86);
			this.Kiss.Name = "Kiss";
			this.Kiss.Size = new System.Drawing.Size(57, 54);
			this.Kiss.TabIndex = 3;
			this.Kiss.Text = "Kiss";
			this.Kiss.UseVisualStyleBackColor = true;
			this.Kiss.Click += new System.EventHandler(this.Control_Click);
			// 
			// Feed
			// 
			this.Feed.Location = new System.Drawing.Point(212, 86);
			this.Feed.Name = "Feed";
			this.Feed.Size = new System.Drawing.Size(57, 54);
			this.Feed.TabIndex = 4;
			this.Feed.Text = "Feed";
			this.Feed.UseVisualStyleBackColor = true;
			this.Feed.Click += new System.EventHandler(this.Control_Click);
			// 
			// Board
			// 
			this.Board.Enabled = true;
			this.Board.Interval = 5000;
			this.Board.Tick += new System.EventHandler(this.Board_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(335, 371);
			this.Controls.Add(this.Feed);
			this.Controls.Add(this.Kiss);
			this.Controls.Add(this.Feeling);
			this.Controls.Add(this.Hug);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button Hug;
		private System.Windows.Forms.Label Feeling;
		private System.Windows.Forms.Button Kiss;
		private System.Windows.Forms.Button Feed;
		private System.Windows.Forms.Timer Board;
	}
}

