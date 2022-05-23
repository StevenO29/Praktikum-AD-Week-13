using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Praktikum_AD_Week_13
{
    public partial class PraktikumWeek13 : Form
    {
        public PraktikumWeek13()
        {
            InitializeComponent();
        }

        public static string sqlConnection = "server = localhost;uid=root;pwd=;database=premier_league";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection); //Sebagai data koneksi ke DBMS
        public MySqlCommand sqlCommand; //Sebagai perintah SQL (select, insert, update, delete)
        public MySqlDataAdapter sqlAdapter; //Sebagai menampung hasil query
        string sqlQuery;
        int counter = 0;
        string simpanIDBuatNanti = "";

        private void PraktikumWeek13_Load(object sender, EventArgs e)
        {
            DataTable player = new DataTable();
            sqlQuery = "select p.player_id as `Player`, p.player_name as `Player Name`, p.birthdate as `Birthdate`, n.nation as `Nationality`, n.nationality_id as `Nationality ID`, t.team_name as `Team`, t.team_id as `Team ID`,p.team_number as `Team Number` from player p, nationality n, team t where n.nationality_id = p.nationality_id and t.team_id = p.team_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(player);
            txtBoxPlayerID.Text = player.Rows[0][0].ToString();
            txtBoxPlayerName.Text = player.Rows[0][1].ToString();
            dtPickerBirthDate.Text = player.Rows[0][2].ToString();
            numUpDownTeamNumber.Text = player.Rows[counter][7].ToString();

            DataTable nationality = new DataTable();
            sqlQuery = "select  n.nation as `Nationality`, n.nationality_id as `Nationality ID` from nationality n";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(nationality);
            cbBoxNationality.DataSource = nationality;
            cbBoxNationality.ValueMember = "Nationality ID";
            cbBoxNationality.DisplayMember = "Nationality";
            cbBoxNationality.SelectedValue = player.Rows[counter][4].ToString();

            DataTable teamName = new DataTable();
            sqlQuery = "select  t.team_name as `Team`, t.team_id as `Team ID` from team t";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(teamName);
            cBoxTeam.DataSource = teamName;
            cBoxTeam.ValueMember = "Team ID";
            cBoxTeam.DisplayMember = "Team";
            cBoxTeam.SelectedValue = player.Rows[counter][6].ToString();
            simpanIDBuatNanti = cBoxTeam.SelectedValue.ToString();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            counter = 0;
            DataTable player = new DataTable();
            sqlQuery = "select p.player_id as `Player`, p.player_name as `Player Name`, p.birthdate as `Birthdate`, n.nation as `Nationality`, n.nationality_id as `Nationality ID`, t.team_name as `Team`, t.team_id as `Team ID`,p.team_number as `Team Number` from player p, nationality n, team t where n.nationality_id = p.nationality_id and t.team_id = p.team_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(player);
            txtBoxPlayerID.Text = player.Rows[counter][0].ToString();
            txtBoxPlayerName.Text = player.Rows[counter][1].ToString();
            dtPickerBirthDate.Text = player.Rows[counter][2].ToString();
            numUpDownTeamNumber.Text = player.Rows[counter][7].ToString();
            cBoxTeam.SelectedValue = player.Rows[counter][6].ToString();
            cbBoxNationality.SelectedValue = player.Rows[counter][4].ToString();
            simpanIDBuatNanti = cBoxTeam.SelectedValue.ToString();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (counter <= 0)
            {
                counter = 0;
                MessageBox.Show("Ini sudah data pertama");
            }
            else
                counter--;
            DataTable player = new DataTable();
            sqlQuery = "select p.player_id as `Player`, p.player_name as `Player Name`, p.birthdate as `Birthdate`, n.nation as `Nationality`, n.nationality_id as `Nationality ID`, t.team_name as `Team`, t.team_id as `Team ID`,p.team_number as `Team Number` from player p, nationality n, team t where n.nationality_id = p.nationality_id and t.team_id = p.team_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(player);
            txtBoxPlayerID.Text = player.Rows[counter][0].ToString();
            txtBoxPlayerName.Text = player.Rows[counter][1].ToString();
            dtPickerBirthDate.Text = player.Rows[counter][2].ToString();
            numUpDownTeamNumber.Text = player.Rows[counter][7].ToString();
            cBoxTeam.SelectedValue = player.Rows[counter][6].ToString();
            cbBoxNationality.SelectedValue = player.Rows[counter][4].ToString();
            simpanIDBuatNanti = cBoxTeam.SelectedValue.ToString();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (counter >= 858)
            {
                counter = 858;
                MessageBox.Show("Ini sudah data terakhir");
            }
            else
                counter++;
            DataTable player = new DataTable();
            sqlQuery = "select p.player_id as `Player`, p.player_name as `Player Name`, p.birthdate as `Birthdate`, n.nation as `Nationality`, n.nationality_id as `Nationality ID`, t.team_name as `Team`, t.team_id as `Team ID`,p.team_number as `Team Number` from player p, nationality n, team t where n.nationality_id = p.nationality_id and t.team_id = p.team_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(player);
            txtBoxPlayerID.Text = player.Rows[counter][0].ToString();
            txtBoxPlayerName.Text = player.Rows[counter][1].ToString();
            dtPickerBirthDate.Text = player.Rows[counter][2].ToString();
            numUpDownTeamNumber.Text = player.Rows[counter][7].ToString();
            cBoxTeam.SelectedValue = player.Rows[counter][6].ToString();
            cbBoxNationality.SelectedValue = player.Rows[counter][4].ToString();
            simpanIDBuatNanti = cBoxTeam.SelectedValue.ToString();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            counter = 858;
            DataTable player = new DataTable();
            sqlQuery = "select p.player_id as `Player`, p.player_name as `Player Name`, p.birthdate as `Birthdate`, n.nation as `Nationality`, n.nationality_id as `Nationality ID`, t.team_name as `Team`, t.team_id as `Team ID`,p.team_number as `Team Number` from player p, nationality n, team t where n.nationality_id = p.nationality_id and t.team_id = p.team_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(player);
            txtBoxPlayerID.Text = player.Rows[counter][0].ToString();
            txtBoxPlayerName.Text = player.Rows[counter][1].ToString();
            dtPickerBirthDate.Text = player.Rows[counter][2].ToString();
            numUpDownTeamNumber.Text = player.Rows[counter][7].ToString();
            cBoxTeam.SelectedValue = player.Rows[counter][6].ToString();
            cbBoxNationality.SelectedValue = player.Rows[counter][4].ToString();
            simpanIDBuatNanti = cBoxTeam.SelectedValue.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lblAvailable.Text == "Not Available")
            {
                MessageBox.Show("Team Number sudah dipakai");
            }
            else
            {
                sqlQuery = "update player set team_number = '" + numUpDownTeamNumber.Value.ToString() + "', player_name = '" + txtBoxPlayerName.Text + "', nationality_id = '" + cbBoxNationality.SelectedValue.ToString() + "', birthdate = '" + dtPickerBirthDate.Value.ToString("yyyMMdd") + "', team_id = '" + cBoxTeam.SelectedValue.ToString() + "' where player_id = '" + txtBoxPlayerID.Text + "'";
                sqlConnect.Open();
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
                MessageBox.Show("Data Player bernama " + txtBoxPlayerName.Text + " berhasil diupdate.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void numUpDownTeamNumber_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable teamNum = new DataTable();
                string simpanID = simpanIDBuatNanti;
                sqlQuery = "select p.player_name as `Name`, p.team_number as `Number` from team t, player p where p.team_id = t.team_id and t.team_id = '"+simpanID+"' having p.team_number = "+numUpDownTeamNumber.Value.ToString()+"";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(teamNum);
                if (teamNum.Rows.Count == 0)
                {
                    lblAvailable.Text = "Available";
                }
                else
                {
                    lblAvailable.Text = "Not Available";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
