using Microsoft.Data.SqlClient;
using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ASP_task1
{
    public partial class student_Login : Form
    {
        public static string contactAdminPhone = "+47 815 493 00";
        public static string contactAdminEmail = "agatha.trunchbull@school.edu";
        public static string contactAdminTimings = "Mon to Fri between 08:00 and 16:00";
        public student_Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show($"Administrator Contact Details:\r\n" + // To use \r\n is old, \n is universally adopted as new line
                            $"Phone: {contactAdminPhone}\r\n" +
                            $"Email: {contactAdminEmail}\r\n" +
                            $"Timings: {contactAdminTimings}",
                            "Contact Administrator",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
                                          // || betyr ELLER  && betyr OG
            if (textbox_StudentId.Text == "" || textbox_StudentName.Text == "" || textbox_StudentName.Text.Length < 5) // you can use string.Empty instead of ""
            {
                MessageBox.Show("You need to enter both Student ID and Student Name to search", "Missing data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int forranettelleraentsaaerdetgoodshit = 0;


            //try
            //{
            //    forranettelleraentsaaerdetgoodshit = int.Parse(textbox_StudentId.Text);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("You need to enter valid data for Student ID and Student Name to search");
            //    return;
            //}   

            // 3 måter å teste for om verdien er større enn 0
            // !(forranettelleraentsaaerdetgoodshit > 0) - ! betyr not    !(true) == false
            // (forranettelleraentsaaerdetgoodshit <= 0) - er tallet mindre eller lik 0
            // (forranettelleraentsaaerdetgoodshit > 0) == false  -- tall ikke større enn 0 = false  -- (false) == false

            if (int.TryParse(textbox_StudentId.Text, out forranettelleraentsaaerdetgoodshit) == false || !(forranettelleraentsaaerdetgoodshit > 0))
            {
                MessageBox.Show("You need to enter valid data for Student ID and Student Name to search");
                return;
            }

                                                                          // Initial Catalog betyr Database
            SqlConnection sqlConnection = new SqlConnection("Data Source=.\\;Initial Catalog=Students;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=True");
            sqlConnection.Open();

            SqlCommand sqlCommand = sqlConnection.CreateCommand();

            sqlCommand.CommandText = "select * from [dbo].[StudLogin] where StudId = @studid and FullName = @studname and IsActive = 1";

            sqlCommand.Parameters.Add("@studid", System.Data.SqlDbType.Int).Value = forranettelleraentsaaerdetgoodshit;
            sqlCommand.Parameters.Add("@studname", System.Data.SqlDbType.VarChar).Value = textbox_StudentName.Text;

            // MÅ IKKE GJØRES PÅ DENNE MÅTEN            ' OR 'True' = 'True        
            // NORTON REAGERTE PÅ PROGRAMMET, SQL INJECTION ER HER MULIG
            //sqlCommand.CommandText = "select * from [dbo].[StudLogin] where StudId = " + forranettelleraentsaaerdetgoodshit + " and FullName = '" + textbox_StudentName.Text + "' and IsActive = 1";


            SqlDataReader sqlReader = sqlCommand.ExecuteReader(System.Data.CommandBehavior.Default);
            if (sqlReader != null) 
            {
                if (sqlReader.HasRows)
                {
                    MessageBox.Show("Student is Enrolled in the Study program", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Unknown Data or Re-enter correct ID and name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            //string salt = "MainaErAwesome;)";
            //string textToHash = salt + forranettelleraentsaaerdetgoodshit + salt + textbox_StudentName.Text + salt;
            
            //byte[] hashed = SHA512.HashData(System.Text.Encoding.UTF8.GetBytes(textToHash));

            //string hashString = BitConverter.ToString(hashed).Replace("-", string.Empty);
            ////MessageBox.Show(textToHash + " = " + hashString);


            sqlConnection.Close();


        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            
            this.Close();           // closes the window
            Environment.Exit(0);    // closes the application
        }
    }
}
