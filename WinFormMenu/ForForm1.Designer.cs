
namespace WinFormMenu
{
    partial class ForForm1
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
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.buttonSolve = new System.Windows.Forms.Button();
            this.labelDob = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(96, 70);
            this.labelA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(46, 23);
            this.labelA.TabIndex = 0;
            this.labelA.Text = "A = ";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(96, 116);
            this.labelB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(41, 23);
            this.labelB.TabIndex = 1;
            this.labelB.Text = "B =";
            // 
            // textBoxA
            // 
            this.textBoxA.BackColor = System.Drawing.Color.Snow;
            this.textBoxA.Location = new System.Drawing.Point(162, 70);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(100, 30);
            this.textBoxA.TabIndex = 2;
            // 
            // textBoxB
            // 
            this.textBoxB.BackColor = System.Drawing.Color.Snow;
            this.textBoxB.Location = new System.Drawing.Point(162, 109);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(100, 30);
            this.textBoxB.TabIndex = 3;
            // 
            // buttonSolve
            // 
            this.buttonSolve.BackColor = System.Drawing.Color.Thistle;
            this.buttonSolve.Location = new System.Drawing.Point(45, 175);
            this.buttonSolve.Name = "buttonSolve";
            this.buttonSolve.Size = new System.Drawing.Size(261, 42);
            this.buttonSolve.TabIndex = 4;
            this.buttonSolve.Text = "Порахувати";
            this.buttonSolve.UseVisualStyleBackColor = false;
            this.buttonSolve.Click += new System.EventHandler(this.buttonSolve_Click);
            // 
            // labelDob
            // 
            this.labelDob.AutoSize = true;
            this.labelDob.Location = new System.Drawing.Point(28, 261);
            this.labelDob.Name = "labelDob";
            this.labelDob.Size = new System.Drawing.Size(272, 23);
            this.labelDob.TabIndex = 5;
            this.labelDob.Text = "Добуток чисел від А до B  = ";
            this.labelDob.Visible = false;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(306, 261);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 23);
            this.labelResult.TabIndex = 6;
            this.labelResult.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Ivory;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(363, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "Закрити";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ForForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(475, 470);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelDob);
            this.Controls.Add(this.buttonSolve);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ForForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForForm1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Button buttonSolve;
        private System.Windows.Forms.Label labelDob;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button button1;
    }
}