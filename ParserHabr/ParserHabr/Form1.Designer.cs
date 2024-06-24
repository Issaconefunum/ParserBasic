namespace ParserHabr
{
    partial class Form1
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
            ListTitles = new ListBox();
            StartPoint = new Label();
            NumericStart = new NumericUpDown();
            EndPoint = new Label();
            NumericEnd = new NumericUpDown();
            ButtonStart = new Button();
            ButtonAbort = new Button();
            ((System.ComponentModel.ISupportInitialize)NumericStart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumericEnd).BeginInit();
            SuspendLayout();
            // 
            // ListTitles
            // 
            ListTitles.FormattingEnabled = true;
            ListTitles.Location = new Point(2, 3);
            ListTitles.Name = "ListTitles";
            ListTitles.Size = new Size(542, 444);
            ListTitles.TabIndex = 0;
            // 
            // StartPoint
            // 
            StartPoint.AutoSize = true;
            StartPoint.Location = new Point(550, 19);
            StartPoint.Name = "StartPoint";
            StartPoint.Size = new Size(77, 20);
            StartPoint.TabIndex = 1;
            StartPoint.Text = "Start Point";
            // 
            // NumericStart
            // 
            NumericStart.Location = new Point(550, 53);
            NumericStart.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NumericStart.Name = "NumericStart";
            NumericStart.Size = new Size(150, 27);
            NumericStart.TabIndex = 2;
            NumericStart.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // EndPoint
            // 
            EndPoint.AutoSize = true;
            EndPoint.Location = new Point(550, 111);
            EndPoint.Name = "EndPoint";
            EndPoint.Size = new Size(71, 20);
            EndPoint.TabIndex = 3;
            EndPoint.Text = "End Point";
            // 
            // NumericEnd
            // 
            NumericEnd.Location = new Point(550, 152);
            NumericEnd.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NumericEnd.Name = "NumericEnd";
            NumericEnd.Size = new Size(150, 27);
            NumericEnd.TabIndex = 4;
            NumericEnd.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // ButtonStart
            // 
            ButtonStart.Location = new Point(550, 207);
            ButtonStart.Name = "ButtonStart";
            ButtonStart.Size = new Size(150, 29);
            ButtonStart.TabIndex = 5;
            ButtonStart.Text = "Start";
            ButtonStart.UseVisualStyleBackColor = true;
            ButtonStart.Click += ButtonStart_Click;
            // 
            // ButtonAbort
            // 
            ButtonAbort.Location = new Point(550, 257);
            ButtonAbort.Name = "ButtonAbort";
            ButtonAbort.Size = new Size(150, 29);
            ButtonAbort.TabIndex = 6;
            ButtonAbort.Text = "Abort";
            ButtonAbort.UseVisualStyleBackColor = true;
            ButtonAbort.Click += ButtonAbort_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ButtonAbort);
            Controls.Add(ButtonStart);
            Controls.Add(NumericEnd);
            Controls.Add(EndPoint);
            Controls.Add(NumericStart);
            Controls.Add(StartPoint);
            Controls.Add(ListTitles);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)NumericStart).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumericEnd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ListTitles;
        private Label StartPoint;
        private NumericUpDown NumericStart;
        private Label EndPoint;
        private NumericUpDown NumericEnd;
        private Button ButtonStart;
        private Button ButtonAbort;
    }
}
