
using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StudentManagementSystem
{
    public partial class MainForm : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;user id=root;password=yourpassword;database=student_db");

        public MainForm()
        {
            InitializeComponent();
        }

        // Add your CRUD operations here
    }
}
