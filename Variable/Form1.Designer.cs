namespace Variable
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
            this.Wayne = new System.Windows.Forms.Button();
            this.Circle = new System.Windows.Forms.Button();
            this.Carpet = new System.Windows.Forms.Button();
            this.Sale = new System.Windows.Forms.Button();
            this.OutPutLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Wayne
            // 
            this.Wayne.Location = new System.Drawing.Point(79, 59);
            this.Wayne.Name = "Wayne";
            this.Wayne.Size = new System.Drawing.Size(137, 35);
            this.Wayne.TabIndex = 0;
            this.Wayne.Text = "Wayne Gretzky";
            this.Wayne.UseVisualStyleBackColor = true;
            this.Wayne.Click += new System.EventHandler(this.Wayne_Click);
            // 
            // Circle
            // 
            this.Circle.Location = new System.Drawing.Point(79, 115);
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(137, 30);
            this.Circle.TabIndex = 1;
            this.Circle.Text = "Area of a Circle ";
            this.Circle.UseVisualStyleBackColor = true;
            this.Circle.Click += new System.EventHandler(this.Circle_Click);
            // 
            // Carpet
            // 
            this.Carpet.Location = new System.Drawing.Point(79, 167);
            this.Carpet.Name = "Carpet";
            this.Carpet.Size = new System.Drawing.Size(137, 34);
            this.Carpet.TabIndex = 2;
            this.Carpet.Text = "Carpet";
            this.Carpet.UseVisualStyleBackColor = true;
            this.Carpet.Click += new System.EventHandler(this.Carpet_Click);
            // 
            // Sale
            // 
            this.Sale.Location = new System.Drawing.Point(79, 226);
            this.Sale.Name = "Sale";
            this.Sale.Size = new System.Drawing.Size(137, 37);
            this.Sale.TabIndex = 3;
            this.Sale.Text = "Bill of Sale";
            this.Sale.UseVisualStyleBackColor = true;
            this.Sale.Click += new System.EventHandler(this.Sale_Click);
            // 
            // OutPutLabel
            // 
            this.OutPutLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OutPutLabel.ForeColor = System.Drawing.Color.Lime;
            this.OutPutLabel.Location = new System.Drawing.Point(264, 59);
            this.OutPutLabel.Name = "OutPutLabel";
            this.OutPutLabel.Size = new System.Drawing.Size(434, 204);
            this.OutPutLabel.TabIndex = 4;
            this.OutPutLabel.Text = "Pick one to begin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OutPutLabel);
            this.Controls.Add(this.Sale);
            this.Controls.Add(this.Carpet);
            this.Controls.Add(this.Circle);
            this.Controls.Add(this.Wayne);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Wayne;
        private System.Windows.Forms.Button Circle;
        private System.Windows.Forms.Button Carpet;
        private System.Windows.Forms.Button Sale;
        private System.Windows.Forms.Label OutPutLabel;
    }
}

