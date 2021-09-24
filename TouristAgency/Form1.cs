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
using System.Configuration;

namespace TouristAgency
{
    public partial class Form1 : Form
    {
        string connectionString;
        SqlConnection connection;
        private bool checkCountryName()
        {
            if (String.IsNullOrWhiteSpace(countryField.Text))
            {
                MessageBox.Show("You didn`t enter country name","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        public Form1()
        {
            InitializeComponent();
            connectionString =
                ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            connection = new SqlConnection(connectionString);
        }

        private void addCountry_button_Click(object sender, EventArgs e)
        {
            string countryName = "";
            if (checkCountryName())
            {
                countryName = countryField.Text;
                connection.Open();
                SqlCommand cmd = new SqlCommand("AddCountry",connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@CountryName", SqlDbType.VarChar).Value = countryName;
                cmd.ExecuteNonQuery();
                connection.Close();
                LoadCountries();
                MessageBox.Show("Country added", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void LoadCountries() {
            CountriesList.Items.Clear();
            connection.Open();
            SqlCommand cmd = new SqlCommand("getCountries", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) {
                CountriesList.Items.Add(reader["Name"]);
            }
            connection.Close();
        }
        private void reset_countryButton_Click(object sender, EventArgs e)
        {
            countryField.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCountries();
        }

        private void editCountry_button_Click(object sender, EventArgs e)
        {
            string countryName = "";
            if (CountriesList.SelectedIndex != -1)
            {
                if (CountriesList?.SelectedIndex != -1)
                    countryName = CountriesList?.SelectedItem.ToString();
                else
                    return;
                connection.Open();
                SqlCommand cmd = new SqlCommand("UPDATE_COUNTRY", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@OldName", SqlDbType.VarChar).Value = countryName;
                cmd.Parameters.Add("@NewName", SqlDbType.VarChar).Value = countryField.Text;
                cmd.ExecuteNonQuery();
                connection.Close();
                LoadCountries();
                MessageBox.Show("Country updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Item not selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void delCountry_button_Click(object sender, EventArgs e)
        {
            string countryName = "";
            if (CountriesList.SelectedIndex!=-1)
            {
                if (CountriesList?.SelectedIndex != -1)
                    countryName = CountriesList?.SelectedItem.ToString();
                else
                    return;
                connection.Open();
                SqlCommand cmd = new SqlCommand("DELETE_COUNTRY", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Country", SqlDbType.VarChar).Value = countryName;
                cmd.ExecuteNonQuery();
                connection.Close();
                LoadCountries();
                MessageBox.Show("Country deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Item not selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CountriesList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
