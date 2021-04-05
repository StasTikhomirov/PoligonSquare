namespace PoligonSquare
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAddPoint = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbResultText = new System.Windows.Forms.Label();
            this.tbxPoints = new System.Windows.Forms.TextBox();
            this.tbxInput = new System.Windows.Forms.TextBox();
            this.lbResultValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(349, 136);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Рассчитать";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(424, 87);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAddPoint
            // 
            this.btnAddPoint.Location = new System.Drawing.Point(278, 87);
            this.btnAddPoint.Name = "btnAddPoint";
            this.btnAddPoint.Size = new System.Drawing.Size(109, 23);
            this.btnAddPoint.TabIndex = 1;
            this.btnAddPoint.Text = "Добавить точку";
            this.btnAddPoint.UseVisualStyleBackColor = true;
            this.btnAddPoint.Click += new System.EventHandler(this.btnAddPoint_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите координату";
            // 
            // lbResultText
            // 
            this.lbResultText.AutoSize = true;
            this.lbResultText.Location = new System.Drawing.Point(257, 203);
            this.lbResultText.Name = "lbResultText";
            this.lbResultText.Size = new System.Drawing.Size(149, 13);
            this.lbResultText.TabIndex = 4;
            this.lbResultText.Text = "Площадь многоугольника =";
            // 
            // tbxPoints
            // 
            this.tbxPoints.Location = new System.Drawing.Point(41, 34);
            this.tbxPoints.Multiline = true;
            this.tbxPoints.Name = "tbxPoints";
            this.tbxPoints.ReadOnly = true;
            this.tbxPoints.Size = new System.Drawing.Size(179, 215);
            this.tbxPoints.TabIndex = 5;
            // 
            // tbxInput
            // 
            this.tbxInput.Location = new System.Drawing.Point(399, 34);
            this.tbxInput.Name = "tbxInput";
            this.tbxInput.Size = new System.Drawing.Size(100, 20);
            this.tbxInput.TabIndex = 0;
            this.tbxInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxInput_KeyPress);
            // 
            // lbResultValue
            // 
            this.lbResultValue.AutoSize = true;
            this.lbResultValue.Location = new System.Drawing.Point(440, 203);
            this.lbResultValue.Name = "lbResultValue";
            this.lbResultValue.Size = new System.Drawing.Size(59, 13);
            this.lbResultValue.TabIndex = 7;
            this.lbResultValue.Text = "Результат";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 305);
            this.Controls.Add(this.lbResultValue);
            this.Controls.Add(this.tbxInput);
            this.Controls.Add(this.tbxPoints);
            this.Controls.Add(this.lbResultText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddPoint);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.Text = "Площадь Многоугольника";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAddPoint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbResultText;
        private System.Windows.Forms.TextBox tbxPoints;
        private System.Windows.Forms.TextBox tbxInput;
        private System.Windows.Forms.Label lbResultValue;
    }
}

