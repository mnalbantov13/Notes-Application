using System.Data.SqlClient;
using System.Web;

namespace NoteTakingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadNotes();
        }

        private void btnNewNote_Click(object sender, EventArgs e)
        {
            txtNoteContent.Clear();
            txtNoteTitle.Clear();
            LoadNotes();
        }

        private void btnSaveNote_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNoteTitle.Text))
            {
                MessageBox.Show("Please enter a title for the note.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=MARTY; Initial Catalog=NoteDB; Integrated Security=True;"))
            {
                sqlCon.Open();

                string query = "INSERT INTO Notes (Title, Content, Timestamp) VALUES (@Title, @Content, @Timestamp)";

                SqlCommand cmd = new SqlCommand(query, sqlCon);

                cmd.Parameters.AddWithValue("@Title", txtNoteTitle.Text);
                cmd.Parameters.AddWithValue("@Content", txtNoteContent.Text);
                cmd.Parameters.AddWithValue("@Timestamp", DateTime.Now);

                cmd.ExecuteNonQuery();
                LoadNotes();

                MessageBox.Show("Note saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDeleteNote_Click(object sender, EventArgs e)
        {
            if (lvNotes.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a note to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int selectedNoteID = (int)lvNotes.SelectedItems[0].Tag;

            DialogResult result = MessageBox.Show("Are you sure you want to delete this note?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DeleteNoteFromDatabase(selectedNoteID);

                MessageBox.Show("Note deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadNotes();
            }
        }
        private void LoadNotes()
        {
            lvNotes.Items.Clear(); 
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=MARTY; Initial Catalog=NoteDB; Integrated Security=True;"))
            {
                sqlCon.Open(); 

                string query = "SELECT NoteID, Title, Content,Timestamp FROM Notes";

                using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["Title"].ToString());

                            item.SubItems.Add(reader["Content"].ToString());
                            item.SubItems.Add(((DateTime)reader["Timestamp"]).ToString()); 

                            item.Tag = (int)reader["NoteID"];

                            lvNotes.Items.Add(item);
                        }
                    }
                }
            }
            lvNotes.Columns[0].Width = 150;
            lvNotes.Columns[1].Width = 230;
            lvNotes.Columns[2].Width = 180;
        }

        private void DeleteNoteFromDatabase(int noteID)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=MARTY; Initial Catalog=NoteDB; Integrated Security=True;"))
            {
                sqlCon.Open();

                string query = "DELETE FROM Notes WHERE NoteID = @NoteID";

                SqlCommand cmd = new SqlCommand(query, sqlCon);

                cmd.Parameters.AddWithValue("@NoteID", noteID);

                cmd.ExecuteNonQuery();
            }
        }
        private void lvNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvNotes.SelectedItems.Count > 0)
            {
                int selectedNoteID = (int)lvNotes.SelectedItems[0].Tag;

                string noteContent = GetNoteContent(selectedNoteID);
                string noteTitle = GetNoteContent(selectedNoteID);
            }
        }
        private void lvNotes_DoubleClick(object sender, EventArgs e)
        {
            if (lvNotes.SelectedItems.Count > 0)
            {
                string noteContent = lvNotes.SelectedItems[0].SubItems[1].Text;
                string noteTitle = lvNotes.SelectedItems[0].Text;

                txtNoteContent.Text = noteContent;
                txtNoteTitle.Text = noteTitle;
            }
        }

        private string GetNoteContent(int noteID)
        {
            string noteContent = string.Empty;

            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=MARTY; Initial Catalog=NoteDB; Integrated Security=True;"))
            {
                sqlCon.Open();

                string query = "SELECT Content FROM Notes WHERE NoteID = @NoteID";

                using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                {
                    cmd.Parameters.AddWithValue("@NoteID", noteID);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        noteContent = result.ToString();
                    }
                }
            }
            return noteContent;
        }

        private void btnUpdateNote_Click(object sender, EventArgs e)
        {
            if (lvNotes.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a note to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int selectedNoteID = (int)lvNotes.SelectedItems[0].Tag;

            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=MARTY; Initial Catalog=NoteDB; Integrated Security=True;"))
            {
                sqlCon.Open();

                string query = "UPDATE Notes SET Title = @Title, Content = @Content WHERE NoteID = @NoteID";

                SqlCommand cmd = new SqlCommand(query, sqlCon);

                DateTime currentTimestamp = DateTime.Now;
                cmd.Parameters.AddWithValue("@Title", txtNoteTitle.Text);
                cmd.Parameters.AddWithValue("@Content", txtNoteContent.Text);
                cmd.Parameters.AddWithValue("@Timestamp", currentTimestamp);
                cmd.Parameters.AddWithValue("@NoteID", selectedNoteID);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Note updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadNotes();
        }
    }
}