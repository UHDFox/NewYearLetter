using System.Data;

namespace NoteTakingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        DataTable notes = new DataTable();
        private void Form1_Load(object sender, EventArgs e)
        {
            notes.Columns.Add("NoteName");
            notes.Columns.Add("NoteText");
            StoredNotes.DataSource = notes;
            StoredNotes.Columns["NoteText"].Visible = false;
            StoredNotes.Columns["NoteName"].Width = 250;
        }
        private void NoteName_TextChanged(object sender, EventArgs e)
        {



        }
        private void NoteText_TextChanged(object sender, EventArgs e)
        {

        }
        private void NewNoteButton_Click(object sender, EventArgs e)
        {
            NoteName.Clear();
            NoteText.Clear();
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (NoteName.Text.Length != 0)
                try
                {
                
                        notes.Rows.Add(NoteName.Text, NoteText.Text);
                    //else throw new Exception WrongInputException() 
                }
           catch(Exception ex) { Console.WriteLine("CArpincho"); }
        }

        private void LoadNote_Click(object sender, EventArgs e)
        {
            int noteIndex = StoredNotes.CurrentCell.RowIndex;
            if (noteIndex > -1)
            {
                NoteName.Text = notes.Rows[noteIndex].ItemArray[0].ToString();
                NoteText.Text = notes.Rows[noteIndex].ItemArray[1].ToString();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            notes.Rows[StoredNotes.CurrentCell.RowIndex].Delete();
            NewNoteButton.PerformClick();
        }

        private void StoredNotes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadNote.PerformClick();
         
        }


    }
}