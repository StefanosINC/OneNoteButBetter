namespace CLCMilestone
{
    partial class MainNotePage
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
            this.notes_list = new System.Windows.Forms.ListBox();
            this.lbl_Welcome = new System.Windows.Forms.Label();
            this.NewNoteIconbtn = new FontAwesome.Sharp.IconButton();
            this.Btn_BackIcon = new FontAwesome.Sharp.IconButton();
            this.btn_Sort = new FontAwesome.Sharp.IconButton();
            this.sort_type = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // notes_list
            // 
            this.notes_list.BackColor = System.Drawing.Color.WhiteSmoke;
            this.notes_list.FormattingEnabled = true;
            this.notes_list.Location = new System.Drawing.Point(24, 72);
            this.notes_list.Name = "notes_list";
            this.notes_list.Size = new System.Drawing.Size(269, 290);
            this.notes_list.TabIndex = 5;
            this.notes_list.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notes_list_MouseDoubleClick_1);
            // 
            // lbl_Welcome
            // 
            this.lbl_Welcome.AutoSize = true;
            this.lbl_Welcome.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Welcome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Welcome.Location = new System.Drawing.Point(173, 18);
            this.lbl_Welcome.Name = "lbl_Welcome";
            this.lbl_Welcome.Size = new System.Drawing.Size(120, 34);
            this.lbl_Welcome.TabIndex = 6;
            this.lbl_Welcome.Text = "Notepad";
            // 
            // NewNoteIconbtn
            // 
            this.NewNoteIconbtn.FlatAppearance.BorderSize = 0;
            this.NewNoteIconbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewNoteIconbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewNoteIconbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NewNoteIconbtn.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.NewNoteIconbtn.IconColor = System.Drawing.Color.White;
            this.NewNoteIconbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.NewNoteIconbtn.IconSize = 50;
            this.NewNoteIconbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NewNoteIconbtn.Location = new System.Drawing.Point(314, 230);
            this.NewNoteIconbtn.Name = "NewNoteIconbtn";
            this.NewNoteIconbtn.Size = new System.Drawing.Size(161, 67);
            this.NewNoteIconbtn.TabIndex = 7;
            this.NewNoteIconbtn.Text = "Create Note";
            this.NewNoteIconbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NewNoteIconbtn.UseVisualStyleBackColor = true;
            this.NewNoteIconbtn.Click += new System.EventHandler(this.NewNoteIconbtn_Click);
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
            this.Btn_BackIcon.Location = new System.Drawing.Point(12, 10);
            this.Btn_BackIcon.Name = "Btn_BackIcon";
            this.Btn_BackIcon.Size = new System.Drawing.Size(138, 56);
            this.Btn_BackIcon.TabIndex = 8;
            this.Btn_BackIcon.Text = "Return to Home";
            this.Btn_BackIcon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_BackIcon.UseVisualStyleBackColor = true;
            this.Btn_BackIcon.Click += new System.EventHandler(this.Btn_BackIcon_Click);
            // 
            // btn_Sort
            // 
            this.btn_Sort.FlatAppearance.BorderSize = 0;
            this.btn_Sort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sort.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Sort.IconChar = FontAwesome.Sharp.IconChar.Sort;
            this.btn_Sort.IconColor = System.Drawing.Color.White;
            this.btn_Sort.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Sort.IconSize = 50;
            this.btn_Sort.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sort.Location = new System.Drawing.Point(314, 177);
            this.btn_Sort.Name = "btn_Sort";
            this.btn_Sort.Size = new System.Drawing.Size(100, 47);
            this.btn_Sort.TabIndex = 10;
            this.btn_Sort.Text = "Sort ";
            this.btn_Sort.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Sort.UseVisualStyleBackColor = true;
            this.btn_Sort.Click += new System.EventHandler(this.btn_Sort_Click);
            // 
            // sort_type
            // 
            this.sort_type.FormattingEnabled = true;
            this.sort_type.Location = new System.Drawing.Point(314, 150);
            this.sort_type.Name = "sort_type";
            this.sort_type.Size = new System.Drawing.Size(119, 21);
            this.sort_type.TabIndex = 11;
            this.sort_type.SelectedIndexChanged += new System.EventHandler(this.sort_type_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(300, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 34);
            this.label1.TabIndex = 12;
            this.label1.Text = "Select Option";
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
            this.iconButton1.Location = new System.Drawing.Point(314, 306);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(138, 56);
            this.iconButton1.TabIndex = 13;
            this.iconButton1.Text = "Trash";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // MainNotePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(486, 418);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sort_type);
            this.Controls.Add(this.btn_Sort);
            this.Controls.Add(this.Btn_BackIcon);
            this.Controls.Add(this.NewNoteIconbtn);
            this.Controls.Add(this.lbl_Welcome);
            this.Controls.Add(this.notes_list);
            this.Name = "MainNotePage";
            this.Text = "MainNotePage";
            this.Load += new System.EventHandler(this.MainNotePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox notes_list;
        private System.Windows.Forms.Label lbl_Welcome;
        private FontAwesome.Sharp.IconButton NewNoteIconbtn;
        private FontAwesome.Sharp.IconButton Btn_BackIcon;
        private FontAwesome.Sharp.IconButton btn_Sort;
        private System.Windows.Forms.ComboBox sort_type;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}