namespace Lab062
{
    partial class fMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbX1 = new TextBox();
            tbX2 = new TextBox();
            tbY = new TextBox();
            btnCalculate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            label4 = new Label();
            tbSeredne = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Змінна X1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 44);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 1;
            label2.Text = "Змінна X2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 73);
            label3.Name = "label3";
            label3.Size = new Size(136, 15);
            label3.TabIndex = 2;
            label3.Text = "Результат розрахунку Y";
            // 
            // tbX1
            // 
            tbX1.Location = new Point(194, 12);
            tbX1.Name = "tbX1";
            tbX1.Size = new Size(100, 23);
            tbX1.TabIndex = 3;
            // 
            // tbX2
            // 
            tbX2.Location = new Point(194, 41);
            tbX2.Name = "tbX2";
            tbX2.Size = new Size(100, 23);
            tbX2.TabIndex = 4;
            // 
            // tbY
            // 
            tbY.Location = new Point(194, 70);
            tbY.Name = "tbY";
            tbY.ReadOnly = true;
            tbY.Size = new Size(100, 23);
            tbY.TabIndex = 5;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(12, 142);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(108, 23);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "Обчислити";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(126, 142);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(81, 23);
            btnClear.TabIndex = 7;
            btnClear.Text = "Очистити";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(213, 142);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(81, 23);
            btnExit.TabIndex = 8;
            btnExit.Text = "Вихід";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 102);
            label4.Name = "label4";
            label4.Size = new Size(135, 15);
            label4.TabIndex = 9;
            label4.Text = "Середнє арифметичне:";
            // 
            // tbSeredne
            // 
            tbSeredne.Location = new Point(194, 99);
            tbSeredne.Name = "tbSeredne";
            tbSeredne.ReadOnly = true;
            tbSeredne.Size = new Size(100, 23);
            tbSeredne.TabIndex = 10;
            // 
            // fMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(316, 184);
            Controls.Add(tbSeredne);
            Controls.Add(label4);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(tbY);
            Controls.Add(tbX2);
            Controls.Add(tbX1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "fMain";
            Text = "Л.Р.6 Завдання для самостійного опрацювання";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbX1;
        private TextBox tbX2;
        private TextBox tbY;
        private Button btnCalculate;
        private Button btnClear;
        private Button btnExit;
        private Label label4;
        private TextBox tbSeredne;
    }
}
