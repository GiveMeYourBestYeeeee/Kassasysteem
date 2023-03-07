namespace kassa.Forms
{
    partial class OrderForm
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
            this.fruitButton = new System.Windows.Forms.Button();
            this.meatButton = new System.Windows.Forms.Button();
            this.sodaButton = new System.Windows.Forms.Button();
            this.vegetablesButton = new System.Windows.Forms.Button();
            this.dairyButton = new System.Windows.Forms.Button();
            this.buttonGroupBox = new System.Windows.Forms.GroupBox();
            this.informationLabel = new System.Windows.Forms.Label();
            this.itemCodeLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.producerLabel = new System.Windows.Forms.Label();
            this.itemCodeInformation = new System.Windows.Forms.Label();
            this.nameInformation = new System.Windows.Forms.Label();
            this.producerInformation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fruitButton
            // 
            this.fruitButton.Location = new System.Drawing.Point(24, 12);
            this.fruitButton.Name = "fruitButton";
            this.fruitButton.Size = new System.Drawing.Size(145, 65);
            this.fruitButton.TabIndex = 1;
            this.fruitButton.Text = "Fruit";
            this.fruitButton.UseVisualStyleBackColor = true;
            this.fruitButton.Click += new System.EventHandler(this.fruitButton_Click);
            // 
            // meatButton
            // 
            this.meatButton.Location = new System.Drawing.Point(175, 12);
            this.meatButton.Name = "meatButton";
            this.meatButton.Size = new System.Drawing.Size(145, 65);
            this.meatButton.TabIndex = 2;
            this.meatButton.Text = "Meat";
            this.meatButton.UseVisualStyleBackColor = true;
            this.meatButton.Click += new System.EventHandler(this.meatButton_Click);
            // 
            // sodaButton
            // 
            this.sodaButton.Location = new System.Drawing.Point(326, 12);
            this.sodaButton.Name = "sodaButton";
            this.sodaButton.Size = new System.Drawing.Size(145, 65);
            this.sodaButton.TabIndex = 3;
            this.sodaButton.Text = "Soda";
            this.sodaButton.UseVisualStyleBackColor = true;
            this.sodaButton.Click += new System.EventHandler(this.sodaButton_Click);
            // 
            // vegetablesButton
            // 
            this.vegetablesButton.Location = new System.Drawing.Point(477, 12);
            this.vegetablesButton.Name = "vegetablesButton";
            this.vegetablesButton.Size = new System.Drawing.Size(145, 65);
            this.vegetablesButton.TabIndex = 4;
            this.vegetablesButton.Text = "Vegetables";
            this.vegetablesButton.UseVisualStyleBackColor = true;
            this.vegetablesButton.Click += new System.EventHandler(this.vegetablesButton_Click);
            // 
            // dairyButton
            // 
            this.dairyButton.Location = new System.Drawing.Point(628, 12);
            this.dairyButton.Name = "dairyButton";
            this.dairyButton.Size = new System.Drawing.Size(145, 65);
            this.dairyButton.TabIndex = 5;
            this.dairyButton.Text = "Dairy";
            this.dairyButton.UseVisualStyleBackColor = true;
            this.dairyButton.Click += new System.EventHandler(this.dairyButton_Click);
            // 
            // buttonGroupBox
            // 
            this.buttonGroupBox.Location = new System.Drawing.Point(24, 97);
            this.buttonGroupBox.Name = "buttonGroupBox";
            this.buttonGroupBox.Size = new System.Drawing.Size(300, 300);
            this.buttonGroupBox.TabIndex = 6;
            this.buttonGroupBox.TabStop = false;
            this.buttonGroupBox.Text = "buttonGroupBox";
            // 
            // informationLabel
            // 
            this.informationLabel.AutoSize = true;
            this.informationLabel.Location = new System.Drawing.Point(340, 97);
            this.informationLabel.Name = "informationLabel";
            this.informationLabel.Size = new System.Drawing.Size(59, 13);
            this.informationLabel.TabIndex = 7;
            this.informationLabel.Text = "Information";
            // 
            // itemCodeLabel
            // 
            this.itemCodeLabel.AutoSize = true;
            this.itemCodeLabel.Location = new System.Drawing.Point(340, 125);
            this.itemCodeLabel.Name = "itemCodeLabel";
            this.itemCodeLabel.Size = new System.Drawing.Size(55, 13);
            this.itemCodeLabel.TabIndex = 8;
            this.itemCodeLabel.Text = "Item Code";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(340, 151);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 9;
            this.nameLabel.Text = "Name";
            // 
            // producerLabel
            // 
            this.producerLabel.AutoSize = true;
            this.producerLabel.Location = new System.Drawing.Point(340, 178);
            this.producerLabel.Name = "producerLabel";
            this.producerLabel.Size = new System.Drawing.Size(50, 13);
            this.producerLabel.TabIndex = 10;
            this.producerLabel.Text = "Producer";
            // 
            // itemCodeInformation
            // 
            this.itemCodeInformation.AutoSize = true;
            this.itemCodeInformation.Location = new System.Drawing.Point(424, 125);
            this.itemCodeInformation.Name = "itemCodeInformation";
            this.itemCodeInformation.Size = new System.Drawing.Size(0, 13);
            this.itemCodeInformation.TabIndex = 11;
            // 
            // nameInformation
            // 
            this.nameInformation.AutoSize = true;
            this.nameInformation.Location = new System.Drawing.Point(424, 151);
            this.nameInformation.Name = "nameInformation";
            this.nameInformation.Size = new System.Drawing.Size(0, 13);
            this.nameInformation.TabIndex = 12;
            // 
            // producerInformation
            // 
            this.producerInformation.AutoSize = true;
            this.producerInformation.Location = new System.Drawing.Point(424, 178);
            this.producerInformation.Name = "producerInformation";
            this.producerInformation.Size = new System.Drawing.Size(0, 13);
            this.producerInformation.TabIndex = 13;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.producerInformation);
            this.Controls.Add(this.nameInformation);
            this.Controls.Add(this.itemCodeInformation);
            this.Controls.Add(this.producerLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.itemCodeLabel);
            this.Controls.Add(this.informationLabel);
            this.Controls.Add(this.buttonGroupBox);
            this.Controls.Add(this.dairyButton);
            this.Controls.Add(this.vegetablesButton);
            this.Controls.Add(this.sodaButton);
            this.Controls.Add(this.meatButton);
            this.Controls.Add(this.fruitButton);
            this.Name = "OrderForm";
            this.Text = "Order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fruitButton;
        private System.Windows.Forms.Button meatButton;
        private System.Windows.Forms.Button sodaButton;
        private System.Windows.Forms.Button vegetablesButton;
        private System.Windows.Forms.Button dairyButton;
        private System.Windows.Forms.GroupBox buttonGroupBox;
        private System.Windows.Forms.Label informationLabel;
        private System.Windows.Forms.Label itemCodeLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label producerLabel;
        private System.Windows.Forms.Label itemCodeInformation;
        private System.Windows.Forms.Label nameInformation;
        private System.Windows.Forms.Label producerInformation;
    }
}