namespace MathQuiz
{
    partial class AdditionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdditionForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxNumToSolve = new System.Windows.Forms.TextBox();
            this.btnGO = new System.Windows.Forms.Button();
            this.txtBoxOp1 = new System.Windows.Forms.TextBox();
            this.txtBoxOp2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxAnswer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(90, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "How many math questions do you want to solve?";
            // 
            // txtBoxNumToSolve
            // 
            this.txtBoxNumToSolve.Location = new System.Drawing.Point(424, 100);
            this.txtBoxNumToSolve.Name = "txtBoxNumToSolve";
            this.txtBoxNumToSolve.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNumToSolve.TabIndex = 0;
            this.txtBoxNumToSolve.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGO
            // 
            this.btnGO.Location = new System.Drawing.Point(424, 126);
            this.btnGO.Name = "btnGO";
            this.btnGO.Size = new System.Drawing.Size(100, 39);
            this.btnGO.TabIndex = 1;
            this.btnGO.Text = "GO";
            this.btnGO.UseVisualStyleBackColor = true;
            // 
            // txtBoxOp1
            // 
            this.txtBoxOp1.Location = new System.Drawing.Point(93, 175);
            this.txtBoxOp1.Name = "txtBoxOp1";
            this.txtBoxOp1.Size = new System.Drawing.Size(100, 20);
            this.txtBoxOp1.TabIndex = 3;
            this.txtBoxOp1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxOp2
            // 
            this.txtBoxOp2.Location = new System.Drawing.Point(256, 175);
            this.txtBoxOp2.Name = "txtBoxOp2";
            this.txtBoxOp2.Size = new System.Drawing.Size(100, 20);
            this.txtBoxOp2.TabIndex = 4;
            this.txtBoxOp2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(215, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "+";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(373, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "=";
            // 
            // txtBoxAnswer
            // 
            this.txtBoxAnswer.Location = new System.Drawing.Point(424, 175);
            this.txtBoxAnswer.Name = "txtBoxAnswer";
            this.txtBoxAnswer.Size = new System.Drawing.Size(100, 20);
            this.txtBoxAnswer.TabIndex = 2;
            this.txtBoxAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AdditionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(737, 420);
            this.Controls.Add(this.txtBoxAnswer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxOp2);
            this.Controls.Add(this.txtBoxOp1);
            this.Controls.Add(this.btnGO);
            this.Controls.Add(this.txtBoxNumToSolve);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdditionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Math Additon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxNumToSolve;
        private System.Windows.Forms.Button btnGO;
        private System.Windows.Forms.TextBox txtBoxOp1;
        private System.Windows.Forms.TextBox txtBoxOp2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxAnswer;
    }
}