using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Year_14_CA_SSD
{
    public partial class TestDriveDataForm : Form
    {
        public event EventHandler TestDrive;
        public TestDriveDataForm()
        {
            InitializeComponent();
        }
        public List<int> Ids = new List<int>();

        private void TestDriveDataForm_Load(object sender, EventArgs e)
        {
            Test_Drives_ListView.Items.Clear();

            Test_Drives_ListView.Columns.Add("Customer Name", 150);
            Test_Drives_ListView.Columns.Add("Employee Name",150);
            Test_Drives_ListView.Columns.Add("Car",125);
            Test_Drives_ListView.Columns.Add("Start Time", 150);
            Test_Drives_ListView.Columns.Add("End Time", 150);

            Load_Test_Drives();

        }
        private void Load_Test_Drives()
        {
            using (SqlConnection conn = new SqlConnection(Globals.connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT TestDriveTable.TestDriveId, CustomerTable.FirstName + ' ' + CustomerTable.LastName AS CustomerName, " +
                    "TestDriveTable.EmployeeId, " +
                    "CarTable.Make + ' ' + CarTable.Model AS Car, CarUnavailabiltyTable.StartTime, CarUnavailabiltyTable.EndTime " +
                    "FROM TestDriveTable " +
                    "INNER JOIN CustomerTable ON TestDriveTable.CustomerId = CustomerTable.CustomerId " +
                    "INNER JOIN CarUnavailabiltyTable ON TestDriveTable.CarUnavailabiltyId = CarUnavailabiltyTable.CarUnavailabiltyId " +
                    "INNER JOIN CarTable ON CarUnavailabiltyTable.CarId = CarTable.CarId";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Ids.Add(Convert.ToInt32(reader["TestDriveId"].ToString()));
                        ListViewItem row = new ListViewItem(Globals.removeWhitespace(reader["CustomerName"].ToString()));
                        row.SubItems.Add(Get_Employee_Name(reader["EmployeeId"].ToString().Trim()));
                        row.SubItems.Add(Globals.removeWhitespace(reader["Car"].ToString()));
                        row.SubItems.Add(Globals.removeSeconds(reader["StartTime"].ToString()));
                        row.SubItems.Add(Globals.removeSeconds(reader["EndTime"].ToString()));
                        Test_Drives_ListView.Items.Add(row);
                    }
                    conn.Close();
                }
                catch (SqlException e)
                {
                    MessageBox.Show("An error occured when loading the test drives");
                }
            }
        }

        string Get_Employee_Name(string id)
        {
            try
            {
                int employeeId = Convert.ToInt32(id);
                string[] values = SQL_Operation.ReadEntry(employeeId, "EmployeeId", "EmployeeTable");
                string name = Globals.removeWhitespace(values[1] + " " + values[2] + " " + values[3]);
                return name;
            }
            catch
            {
                return "N/A";
            }
        }

        private void Edit_Button_Click(object sender, EventArgs e)
        {
            try
            {
                int index = Test_Drives_ListView.SelectedItems[0].Index;

                DateTime startTime = Convert.ToDateTime(Test_Drives_ListView.SelectedItems[0].SubItems[3].Text);
                if (Globals.timeIsInFuture(startTime))
                {
                    if (TestDrive != null)
                    {
                        TestDrive.Invoke(this, new TestDrive_EventArgs { Id = Ids[index], AddMode = false });
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Test drive has already started, cannot be edited");
                }
            }
            catch
            {
                MessageBox.Show("A entry had not been selected");
            }
            
        }
    

        private void Add_Customer_Button_Click(object sender, EventArgs e)
        {
            if (TestDrive != null)
            {
                TestDrive.Invoke(this, new TestDrive_EventArgs { AddMode = true });
            }
            this.Close();
        }
       
    }
    public class TestDrive_EventArgs : EventArgs
    {
        public int Id { get; set; }
        public bool AddMode { get; set; }
    }
}
