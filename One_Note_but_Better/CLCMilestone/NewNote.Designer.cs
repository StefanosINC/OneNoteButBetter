namespace CLCMilestone
{
    partial class NewNote
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
            this.txtbox_NotePad = new System.Windows.Forms.RichTextBox();
            this.note_title = new System.Windows.Forms.TextBox();
            this.Btn_BackIcon = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.lbl_Welcome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.date_picker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtbox_NotePad
            // 
            this.txtbox_NotePad.Location = new System.Drawing.Point(25, 99);
            this.txtbox_NotePad.Name = "txtbox_NotePad";
            this.txtbox_NotePad.Size = new System.Drawing.Size(495, 451);
            this.txtbox_NotePad.TabIndex = 4;
            this.txtbox_NotePad.Text = "";
            this.txtbox_NotePad.TextChanged += new System.EventHandler(this.txtbox_NotePad_TextChanged);
            // 
            // note_title
            // 
            this.note_title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.note_title.Location = new System.Drawing.Point(182, 80);
            this.note_title.Name = "note_title";
            this.note_title.Size = new System.Drawing.Size(148, 13);
            this.note_title.TabIndex = 5;
            this.note_title.Text = "Note Title";
            this.note_title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Btn_BackIcon
            // 
            this.Btn_BackIcon.FlatAppearance.BorderSize = 0;
            this.Btn_BackIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_BackIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_BackIcon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_BackIcon.IconChar = FontAwesome.Sharp.IconChar.ChevronCircleLeft;
            this.Btn_BackIcon.IconColor = System.Drawing.Color.White;
            this.Btn_BackIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_BackIcon.IconSize = 50;
            this.Btn_BackIcon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_BackIcon.Location = new System.Drawing.Point(1, 1);
            this.Btn_BackIcon.Name = "Btn_BackIcon";
            this.Btn_BackIcon.Size = new System.Drawing.Size(138, 66);
            this.Btn_BackIcon.TabIndex = 9;
            this.Btn_BackIcon.Text = "Return to Home";
            this.Btn_BackIcon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_BackIcon.UseVisualStyleBackColor = true;
            this.Btn_BackIcon.Click += new System.EventHandler(this.Btn_BackIcon_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 50;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(12, 556);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(138, 56);
            this.iconButton1.TabIndex = 10;
            this.iconButton1.Text = "Trash";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 50;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(372, 27);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(138, 56);
            this.iconButton2.TabIndex = 11;
            this.iconButton2.Text = "Save Note";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // lbl_Welcome
            // 
            this.lbl_Welcome.AutoSize = true;
            this.lbl_Welcome.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Welcome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Welcome.Location = new System.Drawing.Point(176, 9);
            this.lbl_Welcome.Name = "lbl_Welcome";
            this.lbl_Welcome.Size = new System.Drawing.Size(179, 34);
            this.lbl_Welcome.TabIndex = 12;
            this.lbl_Welcome.Text = "Create a Note";
            this.lbl_Welcome.Click += new System.EventHandler(this.lbl_Welcome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(60, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Enter A Note Title -->";
            // 
            // date_picker
            // 
            this.date_picker.Location = new System.Drawing.Point(166, 47);
            this.date_picker.Name = "date_picker";
            this.date_picker.Size = new System.Drawing.Size(200, 20);
            this.date_picker.TabIndex = 14;
            // 
            // NewNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(547, 628);
            this.Controls.Add(this.date_picker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Welcome);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.Btn_BackIcon);
            this.Controls.Add(this.note_title);
            this.Controls.Add(this.txtbox_NotePad);
            this.Name = "NewNote";
            this.Text = "NewNote";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewNote_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox txtbox_NotePad;
        private System.Windows.Forms.TextBox note_title;
        private FontAwesome.Sharp.IconButton Btn_BackIcon;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Label lbl_Welcome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker date_picker;
    }
}