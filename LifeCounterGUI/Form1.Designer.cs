namespace LifeCounterGUI
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
            this.buttonGO = new System.Windows.Forms.Button();
            this.CalendarPicker = new System.Windows.Forms.MonthCalendar();
            this.BornLabel = new System.Windows.Forms.Label();
            this.BornDate = new System.Windows.Forms.TextBox();
            this.ExpectedEnding = new System.Windows.Forms.Label();
            this.TextpectedAge = new System.Windows.Forms.TextBox();
            this.textBoxTimeLeft = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonGO
            // 
            this.buttonGO.Location = new System.Drawing.Point(10, 258);
            this.buttonGO.Name = "buttonGO";
            this.buttonGO.Size = new System.Drawing.Size(227, 23);
            this.buttonGO.TabIndex = 0;
            this.buttonGO.Text = "How long till you make it?";
            this.buttonGO.UseVisualStyleBackColor = true;
            this.buttonGO.Click += new System.EventHandler(this.ButtonGO_Click);
            // 
            // CalendarPicker
            // 
            this.CalendarPicker.Location = new System.Drawing.Point(10, 33);
            this.CalendarPicker.Name = "CalendarPicker";
            this.CalendarPicker.TabIndex = 1;
            this.CalendarPicker.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.CalendarPicker_DateChanged);
            // 
            // BornLabel
            // 
            this.BornLabel.AutoSize = true;
            this.BornLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BornLabel.Location = new System.Drawing.Point(23, 6);
            this.BornLabel.Name = "BornLabel";
            this.BornLabel.Size = new System.Drawing.Size(198, 24);
            this.BornLabel.TabIndex = 2;
            this.BornLabel.Text = "When were you born?";
            this.BornLabel.Click += new System.EventHandler(this.BornLabel_Click);
            // 
            // BornDate
            // 
            this.BornDate.Location = new System.Drawing.Point(10, 206);
            this.BornDate.Name = "BornDate";
            this.BornDate.ReadOnly = true;
            this.BornDate.Size = new System.Drawing.Size(227, 20);
            this.BornDate.TabIndex = 3;
            this.BornDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ExpectedEnding
            // 
            this.ExpectedEnding.AutoSize = true;
            this.ExpectedEnding.Location = new System.Drawing.Point(7, 235);
            this.ExpectedEnding.Name = "ExpectedEnding";
            this.ExpectedEnding.Size = new System.Drawing.Size(148, 13);
            this.ExpectedEnding.TabIndex = 4;
            this.ExpectedEnding.Text = "What age do you want to be?";
            this.ExpectedEnding.Click += new System.EventHandler(this.ExpectedEnding_Click);
            // 
            // TextpectedAge
            // 
            this.TextpectedAge.Location = new System.Drawing.Point(154, 232);
            this.TextpectedAge.Name = "TextpectedAge";
            this.TextpectedAge.Size = new System.Drawing.Size(83, 20);
            this.TextpectedAge.TabIndex = 5;
            this.TextpectedAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextpectedAge.TextChanged += new System.EventHandler(this.TextBoxExpectedAge_TextChanged);
            // 
            // textBoxTimeLeft
            // 
            this.textBoxTimeLeft.Location = new System.Drawing.Point(105, 286);
            this.textBoxTimeLeft.Name = "textBoxTimeLeft";
            this.textBoxTimeLeft.Size = new System.Drawing.Size(132, 20);
            this.textBoxTimeLeft.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "How long to wait?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 319);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxTimeLeft);
            this.Controls.Add(this.TextpectedAge);
            this.Controls.Add(this.ExpectedEnding);
            this.Controls.Add(this.BornDate);
            this.Controls.Add(this.BornLabel);
            this.Controls.Add(this.CalendarPicker);
            this.Controls.Add(this.buttonGO);
            this.Name = "Form1";
            this.Text = "Seconds Until...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGO;
        private System.Windows.Forms.MonthCalendar CalendarPicker;
        private System.Windows.Forms.Label BornLabel;
        private System.Windows.Forms.TextBox BornDate;
        private System.Windows.Forms.Label ExpectedEnding;
        private System.Windows.Forms.TextBox TextpectedAge;

        private System.Windows.Forms.TextBox textBoxTimeLeft;
        private System.Windows.Forms.Label label3;
    }
}

