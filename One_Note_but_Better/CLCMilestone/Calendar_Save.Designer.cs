namespace CLCMilestone
{
    partial class Calendar_Save
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
            this.cal_Calendar = new System.Windows.Forms.MonthCalendar();
            this.lbl_SaveSelection = new System.Windows.Forms.Label();
            this.cmbo_SaveOptions = new System.Windows.Forms.ComboBox();
            this.btn_SaveNote = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cal_Calendar
            // 
            this.cal_Calendar.Location = new System.Drawing.Point(53, 51);
            this.cal_Calendar.Name = "cal_Calendar";
            this.cal_Calendar.TabIndex = 0;
            this.cal_Calendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // lbl_SaveSelection
            // 
            this.lbl_SaveSelection.AutoSize = true;
            this.lbl_SaveSelection.Location = new System.Drawing.Point(367, 39);
            this.lbl_SaveSelection.Name = "lbl_SaveSelection";
            this.lbl_SaveSelection.Size = new System.Drawing.Size(79, 13);
            this.lbl_SaveSelection.TabIndex = 1;
            this.lbl_SaveSelection.Text = "Save Selection";
            this.lbl_SaveSelection.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbo_SaveOptions
            // 
            this.cmbo_SaveOptions.FormattingEnabled = true;
            this.cmbo_SaveOptions.Location = new System.Drawing.Point(353, 73);
            this.cmbo_SaveOptions.Name = "cmbo_SaveOptions";
            this.cmbo_SaveOptions.Size = new System.Drawing.Size(121, 21);
            this.cmbo_SaveOptions.TabIndex = 2;
            // 
            // btn_SaveNote
            // 
            this.btn_SaveNote.Location = new System.Drawing.Point(353, 143);
            this.btn_SaveNote.Name = "btn_SaveNote";
            this.btn_SaveNote.Size = new System.Drawing.Size(121, 42);
            this.btn_SaveNote.TabIndex = 3;
            this.btn_SaveNote.Text = "Save Note";
            this.btn_SaveNote.UseVisualStyleBackColor = true;
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(12, 12);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 23);
            this.btn_Back.TabIndex = 4;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // Calendar_Save
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 231);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_SaveNote);
            this.Controls.Add(this.cmbo_SaveOptions);
            this.Controls.Add(this.lbl_SaveSelection);
            this.Controls.Add(this.cal_Calendar);
            this.Name = "Calendar_Save";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Calendar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar cal_Calendar;
        private System.Windows.Forms.Label lbl_SaveSelection;
        private System.Windows.Forms.ComboBox cmbo_SaveOptions;
        private System.Windows.Forms.Button btn_SaveNote;
        private System.Windows.Forms.Button btn_Back;
    }
}