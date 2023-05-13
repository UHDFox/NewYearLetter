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
            NoteName = new TextBox();
            NoteText = new TextBox();
            SaveButton = new Button();
            DeleteButton = new Button();
            StoredNotes = new DataGridView();
            LoadNote = new Button();
            NewNoteButton = new Button();
            ((System.ComponentModel.ISupportInitialize)StoredNotes).BeginInit();
            SuspendLayout();
            // 
            // NoteName
            // 
            NoteName.Location = new Point(382, 45);
            NoteName.Multiline = true;
            NoteName.Name = "NoteName";
            NoteName.Size = new Size(395, 19);
            NoteName.TabIndex = 0;
            NoteName.TextChanged += NoteName_TextChanged;
            // 
            // NoteText
            // 
            NoteText.Location = new Point(382, 90);
            NoteText.Multiline = true;
            NoteText.Name = "NoteText";
            NoteText.Size = new Size(395, 282);
            NoteText.TabIndex = 1;
            NoteText.TextChanged += NoteText_TextChanged;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(115, 396);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(96, 37);
            SaveButton.TabIndex = 2;
            SaveButton.Text = "Save note";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(301, 396);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(93, 37);
            DeleteButton.TabIndex = 3;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // StoredNotes
            // 
            StoredNotes.AllowUserToAddRows = false;
            StoredNotes.AllowUserToDeleteRows = false;
            StoredNotes.AllowUserToResizeColumns = false;
            StoredNotes.AllowUserToResizeRows = false;
            StoredNotes.BackgroundColor = SystemColors.ActiveCaption;
            StoredNotes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StoredNotes.Location = new Point(26, 45);
            StoredNotes.Name = "StoredNotes";
            StoredNotes.ReadOnly = true;
            StoredNotes.RowHeadersVisible = false;
            StoredNotes.RowHeadersWidth = 45;
            StoredNotes.RowTemplate.Height = 27;
            StoredNotes.Size = new Size(256, 327);
            StoredNotes.TabIndex = 4;
            StoredNotes.CellContentClick += StoredNotes_CellContentClick;
            // 
            // LoadNote
            // 
            LoadNote.Location = new Point(217, 396);
            LoadNote.Name = "LoadNote";
            LoadNote.Size = new Size(78, 37);
            LoadNote.TabIndex = 5;
            LoadNote.Text = "Load";
            LoadNote.UseVisualStyleBackColor = true;
            LoadNote.Click += LoadNote_Click;
            // 
            // NewNoteButton
            // 
            NewNoteButton.Location = new Point(22, 396);
            NewNoteButton.Name = "NewNoteButton";
            NewNoteButton.Size = new Size(87, 37);
            NewNoteButton.TabIndex = 6;
            NewNoteButton.Text = "New note";
            NewNoteButton.UseVisualStyleBackColor = true;
            NewNoteButton.Click += NewNoteButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(NewNoteButton);
            Controls.Add(LoadNote);
            Controls.Add(StoredNotes);
            Controls.Add(DeleteButton);
            Controls.Add(SaveButton);
            Controls.Add(NoteText);
            Controls.Add(NoteName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)StoredNotes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NoteName;
        private TextBox NoteText;
        private Button SaveButton;
        private Button DeleteButton;
        private DataGridView StoredNotes;
        private Button LoadNote;
        private Button NewNoteButton;
    }
}