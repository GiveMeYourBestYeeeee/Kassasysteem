namespace kassa
{
    partial class RegisterForm
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
            this.LogoutButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.display = new System.Windows.Forms.Panel();
            this.customerNavButton = new System.Windows.Forms.Button();
            this.orderNavButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(752, 12);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(75, 23);
            this.LogoutButton.TabIndex = 1;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(608, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Logged in as user: Admin";
            // 
            // display
            // 
            this.display.Location = new System.Drawing.Point(12, 54);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(816, 489);
            this.display.TabIndex = 3;
            // 
            // customerNavButton
            // 
            this.customerNavButton.Location = new System.Drawing.Point(12, 12);
            this.customerNavButton.Name = "customerNavButton";
            this.customerNavButton.Size = new System.Drawing.Size(117, 36);
            this.customerNavButton.TabIndex = 4;
            this.customerNavButton.Text = "Customer";
            this.customerNavButton.UseVisualStyleBackColor = true;
            this.customerNavButton.Click += new System.EventHandler(this.customerNavButton_Click);
            // 
            // orderNavButton
            // 
            this.orderNavButton.Location = new System.Drawing.Point(135, 12);
            this.orderNavButton.Name = "orderNavButton";
            this.orderNavButton.Size = new System.Drawing.Size(117, 36);
            this.orderNavButton.TabIndex = 5;
            this.orderNavButton.Text = "Order";
            this.orderNavButton.UseVisualStyleBackColor = true;
            this.orderNavButton.Click += new System.EventHandler(this.orderNavButton_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 554);
            this.Controls.Add(this.orderNavButton);
            this.Controls.Add(this.customerNavButton);
            this.Controls.Add(this.display);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LogoutButton);
            this.MaximumSize = new System.Drawing.Size(855, 593);
            this.MinimumSize = new System.Drawing.Size(855, 593);
            this.Name = "RegisterForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel display;
        private System.Windows.Forms.Button customerNavButton;
        private System.Windows.Forms.Button orderNavButton;
    }
}