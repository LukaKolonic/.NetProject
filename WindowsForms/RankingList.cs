using DataLayer;
using DataLayer.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms.Models;

namespace WindowsForms
{
    public partial class RankingList : Form
    {

        private const string Path_woman = "http://worldcup.sfg.io/matches/country?fifa_code=";
        private const string Path_man = "http://world-cup-json-2018.herokuapp.com/matches/country?fifa_code=";


        private Object favouriteCountry;
        private Object gender;
        private Object language;

       
        List<Player> players;
        List<Match> matches = new List<Match>();

        //printanje pdf
        PrintDocument doc;


        public RankingList(Object country, Object gender, Object language)
        {
            InitializeComponent();
            this.favouriteCountry = country;
            this.gender = gender;
            this.language = language;
            //printanje pdf
            doc = new PrintDocument();
            doc.PrintPage += Doc_PrintPage;
            doc.EndPrint += Doc_EndPrint;
            
        }

       

        private void RankingList_Load(object sender, EventArgs e)
        {
            GetData();
           
        }

        private void CreateGridView()
        {
 
            dgvGoals.DataSource = players;
            players.Sort((x, y) => -x.YellowCards.CompareTo(y.YellowCards));
            players.Sort((x, y) => -x.Goals.CompareTo(y.Goals));

            dgvMatch.DataSource = matches;
            matches.Sort((x, y) => -x.Attendance.CompareTo(y.Attendance));

            HideColumns();
        }

        private void HideColumns()
        {
            foreach (DataGridViewColumn column in dgvMatch.Columns)
            {
                column.Visible = false;
            }
            dgvMatch.Columns["Location"].Visible = true;
            dgvMatch.Columns["Attendance"].Visible = true;
            dgvMatch.Columns["HomeTeamCountry"].Visible = true;
            dgvMatch.Columns["AwayTeamCountry"].Visible = true;

        }

        private async void GetData()
        {
            try
            {
                if (gender.ToString() == "muško")
                {
                    await GetResults(Path_man);
                }
                else if (gender.ToString() == "žensko")
                {
                    await GetResults(Path_woman);
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        private async Task GetResults(string path)
        {
           
            int zagradaOtvarajuca = favouriteCountry.ToString().IndexOf('('); 
            var fifaCode = favouriteCountry.ToString().Substring(zagradaOtvarajuca+1, 3); 

            var data = await Repository.GetData<Match>($"{path}{fifaCode}"); //tu su stigli podaci u obliku json-a
            var deserializedData = JsonConvert.DeserializeObject<List<Match>>(data.Content);

            GetPlayers(deserializedData, zagradaOtvarajuca);
            GetAttendence(deserializedData, zagradaOtvarajuca);

            foreach (var match in deserializedData)
            {
               

                if (favouriteCountry.ToString().Substring(0, zagradaOtvarajuca-1) == match.HomeTeam.CountryName)
                {

                    //odi u hometeam evente
                    foreach (var homeEvent in match.HomeTeamEvents)
                    {
                        foreach (var player in players)
                        {
                            if (homeEvent.TypeOfEvent == "goal" && homeEvent.Player == player.Name)
                            {
                                player.Goals++;
                            }
                            else if (homeEvent.TypeOfEvent == "yellow-card" && homeEvent.Player == player.Name)
                            {
                                player.YellowCards++;
                            }
                        }
                    }
                  
                }
                else if (favouriteCountry.ToString().Substring(0, zagradaOtvarajuca-1) == match.AwayTeam.CountryName)
                {

                    //odi u awayteam evente
                    foreach (var awayEvent in match.AwayTeamEvents)
                    {
                        foreach (var player in players)
                        {
                            if (awayEvent.TypeOfEvent == "goal" && awayEvent.Player == player.Name)
                            {
                                player.Goals++;
                            }
                            else if (awayEvent.TypeOfEvent == "yellow-card" && awayEvent.Player == player.Name)
                            {
                                player.YellowCards++;
                            }
                        }
                    }
                }

                CreateGridView();
            }
        }

        private void GetAttendence(List<Match> deserializedData, int zagrada)
        {
            foreach (var match in deserializedData)
            {
                if (match.HomeTeamCountry == favouriteCountry.ToString().Substring(0, zagrada-1) || match.AwayTeamCountry == favouriteCountry.ToString().Substring(0, zagrada-1))
                {
                    matches.Add(match);
                }
            }
        }

        private void GetPlayers(List<Match> matches, int zagrada)
        {
           
            foreach (var match in matches)
            {
                if (favouriteCountry.ToString().Substring(0, zagrada-1) == match.HomeTeam.CountryName)
                {
                    players = match.HomeTeamStatistics.StartingEleven;
                    match.HomeTeamStatistics.Substitutes.ForEach(s => players.Add(s)); 
                }
                else if (favouriteCountry.ToString().Substring(0, zagrada-1) == match.AwayTeam.CountryName)
                {
                    players = match.AwayTeamStatistics.StartingEleven;
                    match.AwayTeamStatistics.Substitutes.ForEach(s => players.Add(s));
                }
            }
        }

        //printanje pdf
        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDialog.Document = doc; //printdiaog mora imati referencu na doc koji ce mjenjati
            if(printDialog.ShowDialog() == DialogResult.OK)
            {
                doc.Print();
            }

            
        }

        
        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            //crtamo nase printanje
            Graphics page=e.Graphics; //nasa stranica na koju printamo
            int x = 60;
            int y = 60;
            page.DrawString("Statistika igrača", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(155, 25));
            page.DrawString("Broj golova", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(350, 30));
            page.DrawString("Broj žutih kartona", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(455, 30));

            foreach (var player in players)
            {
                page.DrawString(player.Format(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(x, y));
                x += 300;
                page.DrawString(player.Goals.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(x, y));
                x += 105;
                page.DrawString(player.YellowCards.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(x, y));

                y += 20;
                x -= 405;
            }
            y += 50;
            page.DrawString("Statistika utakmica", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(155, y-10));
            foreach (var match in matches)
            {
                y += 20;
                page.DrawString(match.Format(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(x, y));
               
            }



        }

        private void Doc_EndPrint(object sender, PrintEventArgs e)
        {
            MessageBox.Show("End printing");
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings settings = new Settings(gender, language);
            settings.ShowDialog();
            this.Close();
           
        }
    }
}
