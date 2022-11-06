using DataLayer;
using DataLayer.Models;
using System;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using WindowsForms.Models;

namespace WindowsPresentationFoundation
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        private static readonly string directory = AppDomain.CurrentDomain.BaseDirectory;
        private static readonly string fileName = Path.Combine(directory, @"..\..\..\postavke.txt");
        private static readonly string path = Path.GetFullPath(fileName);

        object selectedResolution;

        public Menu()
        {
            InitializeComponent();
            Init();
            ReadFile();

        }

        private void Init()
        {
            cbGender.Items.Add(Gender.muško);
            cbGender.Items.Add(Gender.žensko);
            cbLanguage.Items.Add(EnumLanguage.hrvatski);
            cbLanguage.Items.Add(EnumLanguage.engleski);
            cbScreen.Items.Add(Resolution.small);
            cbScreen.Items.Add(Resolution.large);
            cbScreen.Items.Add(Resolution.fullscreen);

            cbGender.SelectedIndex = 0;
            cbLanguage.SelectedIndex = 0;
            cbScreen.SelectedIndex = 0;
        }

        private void ReadFile()
        {
            if (File.Exists(path))
            {
                var result = File.ReadAllLines(path);
                var gender= result[0];
                var language = result[1];

                if (gender == Gender.žensko.ToString())
                {
                    cbGender.SelectedItem = Gender.žensko;
                }
                else if (gender == Gender.muško.ToString())
                {
                    cbGender.SelectedItem = Gender.muško;
                }

                if (language == EnumLanguage.engleski.ToString())
                {
                    cbLanguage.SelectedItem = EnumLanguage.engleski;
                }
                else if (language == EnumLanguage.hrvatski.ToString())
                {
                    cbLanguage.SelectedItem = EnumLanguage.hrvatski;
                }

            }

        }

        //rezolucija
        private void cbScreen_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedResolution = cbScreen.SelectedItem;

            switch (selectedResolution)
            {
                case Resolution.small:
                    SetResolution(350, 300);
                    break;
                case Resolution.large:
                    SetResolution(650, 500);
                    break;
                case Resolution.fullscreen:
                    WindowState = WindowState.Maximized;
                    break;
                default:
                    break;
            }
        }

        private void SetResolution(int width, int height)
        {
            WindowState = WindowState.Normal;
            Application.Current.MainWindow.Width = width;
            Application.Current.MainWindow.Height = height;
           
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            var selectedGender = cbGender.SelectedItem;
            var selectedLanguage = cbLanguage.SelectedItem;
            selectedResolution = cbScreen.SelectedItem;
            Repository.WriteInFile(selectedGender, selectedLanguage, path);
            this.Hide();
            FavouriteNationalTeam fnt = new FavouriteNationalTeam(selectedGender, selectedLanguage, selectedResolution);
            fnt.ShowDialog();
            this.Close();
        }

        private void cbLanguage_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedLanguage = cbLanguage.SelectedItem;

            if (selectedLanguage.ToString() == "engleski")
            {
                Repository.SetLanguageCulture("");
            } 
            else {

                Repository.SetLanguageCulture("hr");
                
            }
        }
    }
}
