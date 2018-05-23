namespace MyDataStructure.Chapter6
{
    partial class FormChapter6
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
            this.textBoxInt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMove = new System.Windows.Forms.TextBox();
            this.labelInt = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxInt
            // 
            this.textBoxInt.Location = new System.Drawing.Point(192, 116);
            this.textBoxInt.Name = "textBoxInt";
            this.textBoxInt.Size = new System.Drawing.Size(148, 21);
            this.textBoxInt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "输入整数";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(437, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "输入移位";
            // 
            // textBoxMove
            // 
            this.textBoxMove.Location = new System.Drawing.Point(523, 116);
            this.textBoxMove.Name = "textBoxMove";
            this.textBoxMove.Size = new System.Drawing.Size(148, 21);
            this.textBoxMove.TabIndex = 2;
            // 
            // labelInt
            // 
            this.labelInt.AutoSize = true;
            this.labelInt.Location = new System.Drawing.Point(253, 192);
            this.labelInt.Name = "labelInt";
            this.labelInt.Size = new System.Drawing.Size(0, 12);
            this.labelInt.TabIndex = 4;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(253, 255);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 12);
            this.labelResult.TabIndex = 5;
            // 
            // buttonLeft
            // 
            this.buttonLeft.Location = new System.Drawing.Point(247, 356);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(93, 45);
            this.buttonLeft.TabIndex = 6;
            this.buttonLeft.Text = "<<";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Location = new System.Drawing.Point(523, 356);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(93, 45);
            this.buttonRight.TabIndex = 7;
            this.buttonRight.Text = ">>";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(247, 449);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(93, 45);
            this.buttonClear.TabIndex = 8;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(523, 449);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(93, 45);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // FormChapter6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 534);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelInt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxMove);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxInt);
            this.Name = "FormChapter6";
            this.Text = "FormChapter6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMove;
        private System.Windows.Forms.Label labelInt;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExit;
    }
}