namespace LikeBoss
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
            this.buttonLike = new System.Windows.Forms.Button();
            this.buttonUnlike = new System.Windows.Forms.Button();
            this.loginsBox = new System.Windows.Forms.TextBox();
            this.linkBox = new System.Windows.Forms.TextBox();
            this.appidBox = new System.Windows.Forms.TextBox();
            this.labelLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonLike
            // 
            this.buttonLike.Location = new System.Drawing.Point(31, 33);
            this.buttonLike.Name = "buttonLike";
            this.buttonLike.Size = new System.Drawing.Size(75, 23);
            this.buttonLike.TabIndex = 1;
            this.buttonLike.Text = "Like";
            this.buttonLike.UseVisualStyleBackColor = true;
            this.buttonLike.Click += new System.EventHandler(this.buttonLike_Click);
            // 
            // buttonUnlike
            // 
            this.buttonUnlike.Location = new System.Drawing.Point(138, 33);
            this.buttonUnlike.Name = "buttonUnlike";
            this.buttonUnlike.Size = new System.Drawing.Size(75, 23);
            this.buttonUnlike.TabIndex = 2;
            this.buttonUnlike.Text = "Unlike";
            this.buttonUnlike.UseVisualStyleBackColor = true;
            this.buttonUnlike.Click += new System.EventHandler(this.buttonUnlike_Click);
            // 
            // loginsBox
            // 
            this.loginsBox.Location = new System.Drawing.Point(31, 199);
            this.loginsBox.Name = "loginsBox";
            this.loginsBox.Size = new System.Drawing.Size(180, 20);
            this.loginsBox.TabIndex = 14;
            this.loginsBox.Text = "C:\\Users\\Panda\\Desktop\\login.txt";
            // 
            // linkBox
            // 
            this.linkBox.Location = new System.Drawing.Point(31, 231);
            this.linkBox.Name = "linkBox";
            this.linkBox.Size = new System.Drawing.Size(180, 20);
            this.linkBox.TabIndex = 17;
            this.linkBox.Text = "C:\\Users\\Panda\\Desktop\\link.txt";
            // 
            // appidBox
            // 
            this.appidBox.Location = new System.Drawing.Point(71, 155);
            this.appidBox.Name = "appidBox";
            this.appidBox.Size = new System.Drawing.Size(100, 20);
            this.appidBox.TabIndex = 18;
            this.appidBox.Text = "6151019";
            // 
            // labelLabel
            // 
            this.labelLabel.AutoSize = true;
            this.labelLabel.Location = new System.Drawing.Point(90, 139);
            this.labelLabel.Name = "labelLabel";
            this.labelLabel.Size = new System.Drawing.Size(65, 13);
            this.labelLabel.TabIndex = 19;
            this.labelLabel.Text = "VK_app_ID:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 278);
            this.Controls.Add(this.labelLabel);
            this.Controls.Add(this.appidBox);
            this.Controls.Add(this.linkBox);
            this.Controls.Add(this.loginsBox);
            this.Controls.Add(this.buttonUnlike);
            this.Controls.Add(this.buttonLike);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonLike;
        private System.Windows.Forms.Button buttonUnlike;
        private System.Windows.Forms.TextBox loginsBox;
        private System.Windows.Forms.TextBox linkBox;
        private System.Windows.Forms.TextBox appidBox;
        private System.Windows.Forms.Label labelLabel;
    }
}

