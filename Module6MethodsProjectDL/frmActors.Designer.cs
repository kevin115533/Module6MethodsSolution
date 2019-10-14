namespace Module6MethodsProjectDL
{
    partial class frmActors
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
            this.txtRightOp = new System.Windows.Forms.TextBox();
            this.txtLeftOp = new System.Windows.Forms.TextBox();
            this.lblLeftOp = new System.Windows.Forms.Label();
            this.lblRightOp = new System.Windows.Forms.Label();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnModul = new System.Windows.Forms.Button();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRightOp
            // 
            this.txtRightOp.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRightOp.Location = new System.Drawing.Point(157, 42);
            this.txtRightOp.Margin = new System.Windows.Forms.Padding(2);
            this.txtRightOp.Name = "txtRightOp";
            this.txtRightOp.Size = new System.Drawing.Size(122, 32);
            this.txtRightOp.TabIndex = 1;
            // 
            // txtLeftOp
            // 
            this.txtLeftOp.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLeftOp.Location = new System.Drawing.Point(157, 3);
            this.txtLeftOp.Margin = new System.Windows.Forms.Padding(2);
            this.txtLeftOp.Name = "txtLeftOp";
            this.txtLeftOp.Size = new System.Drawing.Size(122, 32);
            this.txtLeftOp.TabIndex = 0;
            // 
            // lblLeftOp
            // 
            this.lblLeftOp.AutoSize = true;
            this.lblLeftOp.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeftOp.Location = new System.Drawing.Point(31, 5);
            this.lblLeftOp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLeftOp.Name = "lblLeftOp";
            this.lblLeftOp.Size = new System.Drawing.Size(128, 25);
            this.lblLeftOp.TabIndex = 0;
            this.lblLeftOp.Text = "Left Operand";
            // 
            // lblRightOp
            // 
            this.lblRightOp.AutoSize = true;
            this.lblRightOp.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRightOp.Location = new System.Drawing.Point(25, 44);
            this.lblRightOp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRightOp.Name = "lblRightOp";
            this.lblRightOp.Size = new System.Drawing.Size(133, 25);
            this.lblRightOp.TabIndex = 1;
            this.lblRightOp.Text = "RightOperand";
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.Location = new System.Drawing.Point(8, 86);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(32, 37);
            this.btnPlus.TabIndex = 4;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.AddButton);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtract.Location = new System.Drawing.Point(67, 86);
            this.btnSubtract.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(32, 37);
            this.btnSubtract.TabIndex = 5;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.SubtractionButton);
            // 
            // btnMult
            // 
            this.btnMult.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMult.Location = new System.Drawing.Point(127, 86);
            this.btnMult.Margin = new System.Windows.Forms.Padding(2);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(32, 37);
            this.btnMult.TabIndex = 6;
            this.btnMult.Text = "*";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.MultButton);
            // 
            // btnDivide
            // 
            this.btnDivide.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.Location = new System.Drawing.Point(186, 86);
            this.btnDivide.Margin = new System.Windows.Forms.Padding(2);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(32, 37);
            this.btnDivide.TabIndex = 7;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.DivisionButton);
            // 
            // btnModul
            // 
            this.btnModul.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModul.Location = new System.Drawing.Point(245, 86);
            this.btnModul.Margin = new System.Windows.Forms.Padding(2);
            this.btnModul.Name = "btnModul";
            this.btnModul.Size = new System.Drawing.Size(32, 37);
            this.btnModul.TabIndex = 8;
            this.btnModul.Text = "%";
            this.btnModul.UseVisualStyleBackColor = true;
            this.btnModul.Click += new System.EventHandler(this.ModulusButton);
            // 
            // lblAnswer
            // 
            this.lblAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblAnswer.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(8, 134);
            this.lblAnswer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(269, 84);
            this.lblAnswer.TabIndex = 9;
            this.lblAnswer.Text = "Answer Shows Here";
            this.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(8, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(0, 0);
            this.btnExit.TabIndex = 10;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "button1";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmActors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(286, 224);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.btnModul);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.lblRightOp);
            this.Controls.Add(this.lblLeftOp);
            this.Controls.Add(this.txtLeftOp);
            this.Controls.Add(this.txtRightOp);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmActors";
            this.Text = "A Madness to my Methods";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRightOp;
        private System.Windows.Forms.TextBox txtLeftOp;
        private System.Windows.Forms.Label lblLeftOp;
        private System.Windows.Forms.Label lblRightOp;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnModul;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Button btnExit;
    }
}

