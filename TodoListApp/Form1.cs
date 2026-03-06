using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace TodoListApp
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(
@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TodoDB;Integrated Security=True");

        int selectedTaskId = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadTasks();
        }

        void LoadTasks()
        {
            conn.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tasks", conn);
            DataTable dt = new DataTable();

            da.Fill(dt);

            taskGrid.DataSource = dt;

            conn.Close();

            UpdateTaskCounter();
        }

        void UpdateTaskCounter()
        {
            int total = taskGrid.Rows.Count;
            int done = 0;
            int pending = 0;

            foreach (DataGridViewRow row in taskGrid.Rows)
            {
                if (row.Cells["Status"].Value != null)
                {
                    string status = row.Cells["Status"].Value.ToString();

                    if (status == "Done")
                        done++;
                    else
                        pending++;
                }
            }

            lblTotal.Text = "Total Tasks: " + total;
            lblDone.Text = "Completed: " + done;
            lblPending.Text = "Pending: " + pending;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            conn.Open();

            string query = "INSERT INTO Tasks (Title, Description, Status) VALUES (@title, @desc, 'Pending')";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@title", txtTaskName.Text);
            cmd.Parameters.AddWithValue("@desc", txtDescription.Text);

            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Task Added Successfully!");

            LoadTasks();
        }

        private void taskGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = taskGrid.Rows[e.RowIndex];

                selectedTaskId = Convert.ToInt32(row.Cells["TaskID"].Value);

                txtTaskName.Text = row.Cells["Title"].Value.ToString();
                txtDescription.Text = row.Cells["Description"].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            conn.Open();

            string query = "DELETE FROM Tasks WHERE TaskID=@id";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@id", selectedTaskId);

            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Task Deleted!");

            LoadTasks();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            conn.Open();

            string query = "UPDATE Tasks SET Title=@title, Description=@desc WHERE TaskID=@id";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@title", txtTaskName.Text);
            cmd.Parameters.AddWithValue("@desc", txtDescription.Text);
            cmd.Parameters.AddWithValue("@id", selectedTaskId);

            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Task Updated!");

            LoadTasks();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            conn.Open();

            string query = "UPDATE Tasks SET Status='Done' WHERE TaskID=@id";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@id", selectedTaskId);

            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Task Marked as Done!");

            LoadTasks();
        }

        private void taskGrid_RowPrePaint_1(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (taskGrid.Rows[e.RowIndex].Cells["Status"].Value != null)
            {
                string status = taskGrid.Rows[e.RowIndex].Cells["Status"].Value.ToString();

                if (status == "Done")
                {
                    taskGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                }
            }
        }
    }
}