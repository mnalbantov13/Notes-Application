namespace NoteTakingApp
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
            txtNoteContent = new RichTextBox();
            lvNotes = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            btnNewNote = new Button();
            btnSaveNote = new Button();
            btnDeleteNote = new Button();
            txtNoteTitle = new TextBox();
            label1 = new Label();
            btnUpdateNote = new Button();
            SuspendLayout();
            // 
            // txtNoteContent
            // 
            txtNoteContent.Font = new Font("HelveticaNeueLT Std Med", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            txtNoteContent.Location = new Point(12, 114);
            txtNoteContent.Name = "txtNoteContent";
            txtNoteContent.Size = new Size(261, 260);
            txtNoteContent.TabIndex = 0;
            txtNoteContent.Text = "";
            // 
            // lvNotes
            // 
            lvNotes.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lvNotes.Font = new Font("HelveticaNeueLT Std Med", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            lvNotes.FullRowSelect = true;
            lvNotes.GridLines = true;
            lvNotes.Location = new Point(279, 78);
            lvNotes.Name = "lvNotes";
            lvNotes.Size = new Size(552, 296);
            lvNotes.TabIndex = 1;
            lvNotes.UseCompatibleStateImageBehavior = false;
            lvNotes.View = View.Details;
            lvNotes.DoubleClick += lvNotes_DoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Title";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Content";
            columnHeader2.Width = 300;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Timestamp";
            columnHeader3.Width = 100;
            // 
            // btnNewNote
            // 
            btnNewNote.Font = new Font("HelveticaNeueLT Std", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnNewNote.Location = new Point(95, 385);
            btnNewNote.Name = "btnNewNote";
            btnNewNote.Size = new Size(129, 53);
            btnNewNote.TabIndex = 2;
            btnNewNote.Text = "New Note";
            btnNewNote.UseVisualStyleBackColor = true;
            btnNewNote.Click += btnNewNote_Click;
            // 
            // btnSaveNote
            // 
            btnSaveNote.Font = new Font("HelveticaNeueLT Std", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaveNote.Location = new Point(255, 385);
            btnSaveNote.Name = "btnSaveNote";
            btnSaveNote.Size = new Size(126, 53);
            btnSaveNote.TabIndex = 3;
            btnSaveNote.Text = "Save Note";
            btnSaveNote.UseVisualStyleBackColor = true;
            btnSaveNote.Click += btnSaveNote_Click;
            // 
            // btnDeleteNote
            // 
            btnDeleteNote.Font = new Font("HelveticaNeueLT Std", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteNote.Location = new Point(580, 385);
            btnDeleteNote.Name = "btnDeleteNote";
            btnDeleteNote.Size = new Size(140, 53);
            btnDeleteNote.TabIndex = 4;
            btnDeleteNote.Text = "Delete Note";
            btnDeleteNote.UseVisualStyleBackColor = true;
            btnDeleteNote.Click += btnDeleteNote_Click;
            // 
            // txtNoteTitle
            // 
            txtNoteTitle.Font = new Font("HelveticaNeueLT Std", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtNoteTitle.Location = new Point(12, 78);
            txtNoteTitle.Name = "txtNoteTitle";
            txtNoteTitle.PlaceholderText = "Title ";
            txtNoteTitle.Size = new Size(261, 30);
            txtNoteTitle.TabIndex = 5;
            txtNoteTitle.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Calligraphy", 32.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(196, 19);
            label1.Name = "label1";
            label1.Size = new Size(439, 56);
            label1.TabIndex = 6;
            label1.Text = "Note Taking App";
            // 
            // btnUpdateNote
            // 
            btnUpdateNote.Font = new Font("HelveticaNeueLT Std", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateNote.Location = new Point(400, 385);
            btnUpdateNote.Name = "btnUpdateNote";
            btnUpdateNote.Size = new Size(152, 53);
            btnUpdateNote.TabIndex = 7;
            btnUpdateNote.Text = "Update Note";
            btnUpdateNote.UseVisualStyleBackColor = true;
            btnUpdateNote.Click += btnUpdateNote_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(887, 450);
            Controls.Add(btnUpdateNote);
            Controls.Add(label1);
            Controls.Add(txtNoteTitle);
            Controls.Add(btnDeleteNote);
            Controls.Add(btnSaveNote);
            Controls.Add(btnNewNote);
            Controls.Add(lvNotes);
            Controls.Add(txtNoteContent);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtNoteContent;
        private ListView lvNotes;
        private Button btnNewNote;
        private Button btnSaveNote;
        private Button btnDeleteNote;
        private TextBox txtNoteTitle;
        private Label label1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Button btnUpdateNote;
        private ColumnHeader columnHeader3;
    }
}