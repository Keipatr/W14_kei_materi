using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace W14_kei
{
    public partial class form_Team : Form
    {
        public form_Team()
        {
            InitializeComponent();
        }
        public static string sqlConnection = "server=localhost;uid=root;pwd=; database=premier_league";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;
        public string sqlQuery2;
        public int urutan;
        public int urutan2;

        DataTable dtDataTeam = new DataTable();
        DataTable dtTeamScorer = new DataTable();
        DataTable dtTeamWorst = new DataTable();
        DataTable dtRecentMatch = new DataTable();


        private void form_Team_Load(object sender, EventArgs e)
        {
            sqlQuery = "select team_name as 'team', concat(manager_name,' (',nation,')') as 'manager', concat(home_stadium,', ',city,' (',capacity,')') as 'stadium' from team t, manager m, nationality n where t.manager_id = m.manager_id and m.nationality_id = n.nationality_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtDataTeam);

            lb_TeamName.Text = dtDataTeam.Rows[urutan]["team"].ToString();
            lb_Manager.Text = dtDataTeam.Rows[urutan]["manager"].ToString();
            lb_Stadium.Text = dtDataTeam.Rows[urutan]["stadium"].ToString();

            sqlQuery = "select concat(player_name ,' ', sum(if(type = 'GO',1,0)),'(', sum(if(type = 'GP',1,0)),')') as 'scorer'  from dmatch d, player p, team t where p.player_id = d.player_id and d.team_id = t.team_id and t.team_name = '" + lb_TeamName.Text + "' group by player_name order by sum(if(type = 'GO',1,0)) + sum(if(type = 'GP',1,0)) desc;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeamScorer);
            lb_TopScorer.Text = dtTeamScorer.Rows[urutan]["scorer"].ToString();

            sqlQuery = "select concat(player_name, ', ', sum(if(type = 'CY',1,0)),' Yellow Card and ',  sum(if(type = 'CR',3,0)),' Red Card') as 'worst' from dmatch d, player p, team t where p.player_id = d.player_id and d.team_id = t.team_id and t.team_name = '" + lb_TeamName.Text + "' group by player_name order by sum(if(type = 'CY',1,0)) + sum(if(type = 'CR',3,0)) desc;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeamWorst);
            lb_Worst.Text = dtTeamWorst.Rows[urutan]["worst"].ToString();

            //sqlQuery2 = "select date_format(match_date,'%d/%c/%Y') as 'match_date', if (team_home = '"+dtDataTeam.Rows[urutan]["ID"].ToString()+ "','HOME','AWAY') as 'Home/Away', concat('vs ', team_name) as 'lawan', concat(goal_home, ' - ', goal_away) as 'score' from `match` m, team t, dmatch d where  d.match_id = m.match_id and d.team_id = '" + dtDataTeam.Rows[urutan]["ID"].ToString() + "' order by match_date asc limit 5";
            //sqlCommand = new MySqlCommand(sqlQuery2,sqlConnect);
            //sqlAdapter = new MySqlDataAdapter(sqlCommand);
            //sqlAdapter.Fill(dtRecentMatch);
            //dtg_Match.DataSource = dtRecentMatch;
        }

        private void btn_First_Click(object sender, EventArgs e)
        {
            if (urutan == 0)
            {
                MessageBox.Show("Data sudah paling awal");
            }
            else
            {
                urutan = 0;
                lb_TeamName.Text = dtDataTeam.Rows[urutan]["team"].ToString();
                lb_Manager.Text = dtDataTeam.Rows[urutan]["manager"].ToString();
                lb_Stadium.Text = dtDataTeam.Rows[urutan]["stadium"].ToString();
                lb_TopScorer.Text = dtTeamScorer.Rows[urutan]["scorer"].ToString();
                lb_Worst.Text = dtTeamWorst.Rows[urutan]["worst"].ToString();

                //DataTable dtRecentMatch = new DataTable();
                //sqlQuery2 = "select date_format(match_date,'%d/%c/%Y') as 'match_date', if (team_home = '" + dtDataTeam.Rows[urutan]["ID"].ToString() + "','HOME','AWAY') as 'Home/Away', concat('vs ', team_name) as 'lawan', concat(goal_home, ' - ', goal_away) as 'score' from `match` m, team t, dmatch d where  d.match_id = m.match_id and d.team_id = '" + dtDataTeam.Rows[urutan]["ID"].ToString() + "' order by match_date asc limit 5";
                //sqlCommand = new MySqlCommand(sqlQuery2, sqlConnect);
                //sqlAdapter = new MySqlDataAdapter(sqlCommand);
                //sqlAdapter.Fill(dtRecentMatch);
                //dtg_Match.DataSource = dtRecentMatch;
            }
        }

        private void btn_Prev_Click(object sender, EventArgs e)
        {
            if (urutan == 0)
            {
                MessageBox.Show("Data sudah paling awal");
            }
            else
            {
                urutan -= 1;
                lb_TeamName.Text = dtDataTeam.Rows[urutan]["team"].ToString();
                lb_Manager.Text = dtDataTeam.Rows[urutan]["manager"].ToString();
                lb_Stadium.Text = dtDataTeam.Rows[urutan]["stadium"].ToString();
                lb_TopScorer.Text = dtTeamScorer.Rows[urutan]["scorer"].ToString();
                lb_Worst.Text = dtTeamWorst.Rows[urutan]["worst"].ToString();

                //DataTable dtRecentMatch = new DataTable();
                //sqlQuery2 = "select date_format(match_date,'%d/%c/%Y') as 'match_date', if (team_home = '" + dtDataTeam.Rows[urutan]["ID"].ToString() + "','HOME','AWAY') as 'Home/Away', concat('vs ', team_name) as 'lawan', concat(goal_home, ' - ', goal_away) as 'score' from `match` m, team t, dmatch d where  d.match_id = m.match_id and d.team_id = '" + dtDataTeam.Rows[urutan]["ID"].ToString() + "' order by match_date asc limit 5";
                //sqlCommand = new MySqlCommand(sqlQuery2, sqlConnect);
                //sqlAdapter = new MySqlDataAdapter(sqlCommand);
                //sqlAdapter.Fill(dtRecentMatch);
                //dtg_Match.DataSource = dtRecentMatch;
            }
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (urutan == dtDataTeam.Rows.Count - 1)
            {
                MessageBox.Show("Data sudah paling akhir");
            }
            else
            {
                urutan += 1;
                lb_TeamName.Text = dtDataTeam.Rows[urutan]["team"].ToString();
                lb_Manager.Text = dtDataTeam.Rows[urutan]["manager"].ToString();
                lb_Stadium.Text = dtDataTeam.Rows[urutan]["stadium"].ToString();
                lb_TopScorer.Text = dtTeamScorer.Rows[urutan]["scorer"].ToString();
                lb_Worst.Text = dtTeamWorst.Rows[urutan]["worst"].ToString();

                //DataTable dtRecentMatch = new DataTable();
                //sqlQuery2 = "select date_format(match_date,'%d/%c/%Y') as 'match_date', if (team_home = '" + dtDataTeam.Rows[urutan]["ID"].ToString() + "','HOME','AWAY') as 'Home/Away', concat('vs ', team_name) as 'lawan', concat(goal_home, ' - ', goal_away) as 'score' from `match` m, team t, dmatch d where  d.match_id = m.match_id and d.team_id = '" + dtDataTeam.Rows[urutan]["ID"].ToString() + "' order by match_date asc limit 5";
                //sqlCommand = new MySqlCommand(sqlQuery2, sqlConnect);
                //sqlAdapter = new MySqlDataAdapter(sqlCommand);
                //sqlAdapter.Fill(dtRecentMatch);
                //dtg_Match.DataSource = dtRecentMatch;
            }
        }

        private void btn_Last_Click(object sender, EventArgs e)
        {
            if (urutan == dtDataTeam.Rows.Count - 1)
            {
                MessageBox.Show("Data sudah paling akhir");
            }
            else
            {
                urutan = dtDataTeam.Rows.Count - 1;
                urutan2 = dtTeamWorst.Rows.Count - 1;
                lb_TeamName.Text = dtDataTeam.Rows[urutan]["team"].ToString();
                lb_Manager.Text = dtDataTeam.Rows[urutan]["manager"].ToString();
                lb_Stadium.Text = dtDataTeam.Rows[urutan]["stadium"].ToString();
                lb_TopScorer.Text = dtTeamScorer.Rows[urutan2]["scorer"].ToString();
                lb_Worst.Text = dtTeamWorst.Rows[urutan2]["worst"].ToString();

                //DataTable dtRecentMatch = new DataTable();
                //sqlQuery2 = "select date_format(match_date,'%d/%c/%Y') as 'match_date', if (team_home = '" + dtDataTeam.Rows[urutan]["ID"].ToString() + "','HOME','AWAY') as 'Home/Away', concat('vs ', team_name) as 'lawan', concat(goal_home, ' - ', goal_away) as 'score' from `match` m, team t, dmatch d where  d.match_id = m.match_id and d.team_id = '" + dtDataTeam.Rows[urutan]["ID"].ToString() + "' order by match_date asc limit 5";
                //sqlCommand = new MySqlCommand(sqlQuery2, sqlConnect);
                //sqlAdapter = new MySqlDataAdapter(sqlCommand);
                //sqlAdapter.Fill(dtRecentMatch);
                //dtg_Match.DataSource = dtRecentMatch;
            }
        }
    }
}
