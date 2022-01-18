
namespace WinFormMenu
{
    partial class ForForm3
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
            this.labelN = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.buttonSolve = new System.Windows.Forms.Button();
            this.labelPow = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.BackColor = System.Drawing.Color.Ivory;
            this.labelA.Location = new System.Drawing.Point(55, 52);
            this.labelA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(40, 23);
            this.labelA.TabIndex = 0;
            this.labelA.Text = "A =";
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.BackColor = System.Drawing.Color.Ivory;
            this.labelN.Location = new System.Drawing.Point(55, 98);
            this.labelN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(41, 23);
            this.labelN.TabIndex = 1;
            this.labelN.Text = "N =";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(120, 45);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(100, 30);
            this.textBoxA.TabIndex = 2;
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(120, 91);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(100, 30);
            this.textBoxN.TabIndex = 3;
            // 
            // buttonSolve
            // 
            this.buttonSolve.BackColor = System.Drawing.Color.Azure;
            this.buttonSolve.Location = new System.Drawing.Point(28, 155);
            this.buttonSolve.Name = "buttonSolve";
            this.buttonSolve.Size = new System.Drawing.Size(233, 40);
            this.buttonSolve.TabIndex = 4;
            this.buttonSolve.Text = "Порахувати";
            this.buttonSolve.UseVisualStyleBackColor = false;
            this.buttonSolve.Click += new System.EventHandler(this.buttonSolve_Click);
            // 
            // labelPow
            // 
            this.labelPow.AutoSize = true;
            this.labelPow.BackColor = System.Drawing.Color.Ivory;
            this.labelPow.Font = new System.Drawing.Font("Californian FB", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPow.Location = new System.Drawing.Point(40, 239);
            this.labelPow.Name = "labelPow";
            this.labelPow.Size = new System.Drawing.Size(178, 25);
            this.labelPow.TabIndex = 5;
            this.labelPow.Text = "А в степені N  = ";
            this.labelPow.Visible = false;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(234, 239);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(51, 23);
            this.labelResult.TabIndex = 6;
            this.labelResult.Text = "label";
            this.labelResult.Visible = false;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackColor = System.Drawing.Color.LightCyan;
            this.buttonClose.Location = new System.Drawing.Point(339, 426);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(154, 37);
            this.buttonClose.TabIndex = 7;
            this.buttonClose.Text = "Закрити";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // ForForm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 491);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelPow);
            this.Controls.Add(this.buttonSolve);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.labelA);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ForForm3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForForm3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.Button buttonSolve;
        private System.Windows.Forms.Label labelPow;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonClose;
    }
}