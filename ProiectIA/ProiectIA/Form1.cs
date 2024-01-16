using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProiectIA
{
    public partial class Form1 : Form
    {

        DataTable dt = new DataTable();
        bool isUserLoggedIn = false;
        String connectInfo = "Data Source = localhost; Initial Catalog = master; Integrated Security = True; TrustServerCertificate=True";
        String username_saved;
        int savedState = 0;
        int action = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void HideNavigation()
        {
            meniu_navigatie.Hide();
            buton_nav_1.Hide();
            buton_nav_2.Hide();
            buton_nav_3.Hide();
            buton_nav_4.Hide();
            buton_nav_6.Hide();
            buton_nav_5.Show();
            label2.Hide();
        }

        private void ShowNavigation()
        {
            meniu_navigatie.Show();
            buton_nav_1.Show();
            buton_nav_2.Show();
            if (isUserLoggedIn == false)
            {
                HideWelcomeMessage();
                buton_nav_3.Show();
                buton_nav_4.Show();
            }
            else
            { 
                ShowWelcomeMessage();
            }
            buton_nav_6.Show();
            buton_nav_5.Hide();
        }

        private void HideLoginForm()
        {
            titlu_logare.Hide();
            username_label.Hide();
            parola_label.Hide();
            username.Hide();
            username.Text = "";
            parola.Hide();
            parola.Text = "";
            buton_logare.Hide();
            label1.Hide();
        }

        private void ShowLoginForm()
        {
            titlu_logare.Text = "Logare";
            buton_logare.Text = "Login";

            titlu_logare.Show();
            username_label.Show();
            parola_label.Show();
            username.Show();
            parola.Show();
            buton_logare.Show();
        }

        private void ShowRegisterForm()
        {
            titlu_logare.Text = "Inregistrare";
            buton_logare.Text = "Register";

            titlu_logare.Show();
            username_label.Show();
            parola_label.Show();
            username.Show();
            parola.Show();
            buton_logare.Show();
        }

        private void ShowWelcomeMessage()
        {
            label2.Text = "Buna, " + username_saved;
            label2.Show();
        }

        private void HideWelcomeMessage()
        {
            label2.Hide();
        }

        private void LoadData(String query)
        {
            SqlConnection con = new SqlConnection(connectInfo);
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            con.Open();
            adapter.Fill(dt);
            con.Close();

            adapter.Dispose();
            cmd.Dispose();
            con.Dispose();
        }

        private void LoadSpecificData(String table, String condition = null)
        {
            String query;
            if (condition != null)
            {
                query = "SELECT " + table + ".* FROM " + table + " WHERE " + condition;
            }
            else
            {
                query = "SELECT " + table + ".* FROM " + table;
            }

            LoadData(query);
        }

        private void InsertIntoUseri(String table, String username, String password)
        {
            String query = "INSERT INTO " + table + "(Nume, Parola) VALUES (@username, @password)";
            
            InsertData(query, username, password);
        }

        private void InsertData(String query, String username, String password)
        {
            SqlConnection con = new SqlConnection(connectInfo);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con; ;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("username", username);
            cmd.Parameters.AddWithValue ("password", password);

            try 
            {
                con.Open();
                int recordsAffected = cmd.ExecuteNonQuery();

                if(recordsAffected > 0)
                {
                    action = 1;
                    HideLoginForm();
                    ShowLoginForm();
                }
            }
            catch(SqlException ex)
            {

            }
            finally { con.Close(); }

            con.Open();
            con.Close();

            cmd.Dispose();
            con.Dispose();
        }

        private void ShowGridDataView()
        {
            dt.Clear();
            LoadSpecificData("Museu");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                listview.Items.Add(new ListViewItem(new string[] { Convert.ToString(dt.Rows[i]["Id"]), Convert.ToString(dt.Rows[i]["Nume"]),
                Convert.ToString(dt.Rows[i]["Oras"]), Convert.ToString(dt.Rows[i]["Data_infiintari"]), Convert.ToString(dt.Rows[i]["Program"])
                }));
            }

            listview.Show();
        }

        private void HideGridDataView()
        {
            listview.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet1.Museu' table. You can move, or remove it, as needed.
            this.museuTableAdapter1.Fill(this.masterDataSet1.Museu);
            HideNavigation();
            HideLoginForm();
            HideWelcomeMessage();

            HideGridDataView();

            listview.View = View.Details;

            listview.Columns.Add("Id");
            listview.Columns.Add("Nume");
            listview.Columns.Add("Oras");
            listview.Columns.Add("Data Infiintari");
            listview.Columns.Add("Program");
        }

        private void buton_nav_1_Click(object sender, EventArgs e)
        {
            if (isUserLoggedIn == false)
            {
                savedState = 1;
                action = 1;
                ShowLoginForm();
                HideNavigation();
            }
            else
            {
                ShowGridDataView();
                HideNavigation();
            }    
        }

        private void buton_nav_6_Click(object sender, EventArgs e)
        {
            HideNavigation();
        }

        private void buton_nav_5_Click(object sender, EventArgs e)
        {
            ShowNavigation();
        }

        private void buton_nav_3_Click(object sender, EventArgs e)
        {
            ShowLoginForm();
            HideNavigation();
            action = 1;     // actiune de logare
        }

        private void buton_logare_Click(object sender, EventArgs e)
        {
            String username_read = username.Text;
            String password_read = parola.Text;

            if (action == 1)
            {
                LoadSpecificData("Useri", "Nume=" + "'" + username_read + "'");

                if (dt.Rows.Count > 0)
                {
                    String password_from_db = Convert.ToString(dt.Rows[0]["Parola"]).Replace(" ", "");
                    if (password_from_db == password_read)
                    {
                        isUserLoggedIn = true;
                        username_saved = username_read;
                        HideLoginForm();
                        if (savedState == 1)
                        {
                            ShowGridDataView();
                        }
                    }
                    else
                    {
                        label1.Text = "Parola incorecta!";
                        label1.Show();
                    }
                }
                else
                {
                    if (dt.Rows.Count == 0)
                    {
                        label1.Text = "Utilizatorul nu exista!";
                        label1.Show();
                    }
                }
                action = 0;
            }
            else
            {
                if (action == 2)
                { 
                    InsertIntoUseri("Useri", username_read, password_read);
                }
            }
            

            dt.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buton_nav_2_Click(object sender, EventArgs e)
        {
            if (isUserLoggedIn == false)
            {
                savedState = 2;
                ShowLoginForm();
            }
        }

        private void buton_nav_4_Click(object sender, EventArgs e)
        {
            ShowRegisterForm();
            HideNavigation();
            action = 2;     // actiune de inregistrare
        }
    }
}
