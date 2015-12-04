using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Well_Played.Facades;
using Well_Played.Models;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Store;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Well_Played
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Summoner : Page
    {
        public LicenseInformation licenseInformation { get; set; }

        Windows.Storage.ApplicationDataContainer localSettings =
            Windows.Storage.ApplicationData.Current.LocalSettings;
        Windows.Storage.StorageFolder localFolder =
            Windows.Storage.ApplicationData.Current.LocalFolder;

        bool diditwork = true;
        public ObservableCollection<Well_Played.Models.Champion> MostPlayedChampions { get; set; }
        public ObservableCollection<Well_Played.Models.Game> SummonerMatches { get; set; }
        public Models.MatchList ListOfMatches { get; set; }

        public Summoner()
        {
            this.InitializeComponent();

            //if (localSettings.Values["LookUpName"] != null)
            //{
            //    TitleBar.Text = (string)localSettings.Values["LookUpName"];
            //}
            //else
            //{
                if (localSettings.Values["SummonerName"] != null)
                {
                    TitleBar.Text = (string)localSettings.Values["SummonerName"];
                }
            //}

            MostPlayedChampions = new ObservableCollection<Well_Played.Models.Champion>();
            SummonerMatches = new ObservableCollection<Game>();
            ListOfMatches = new Models.MatchList();
        }

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            // Remove these lines of code before publishing!
            // The actual CurrentApp will create a WindowsStoreProxy.xml
            // in the package's \LocalState\Microsoft\Windows Store\ApiData
            // folder where it stores the actual purchases.
            // Here we're just giving it a fake version of that file
            // for testing.
            //StorageFolder proxyDataFolder = await Package.Current.InstalledLocation.GetFolderAsync("Assets");
            //StorageFile proxyFile = await proxyDataFolder.GetFileAsync("test.xml");
            //await CurrentAppSimulator.ReloadSimulatorAsync(proxyFile);
            //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            licenseInformation = CurrentApp.LicenseInformation;
            //licenseInformation = CurrentAppSimulator.LicenseInformation;
            //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            if (licenseInformation.ProductLicenses["RemoveAds"].IsActive)
            {
                SummaryAdSpace.Padding = new Thickness(0);
                MatchHistoryAdSpace.Padding = new Thickness(0);
            }

            MyProgressRing.IsActive = true;
            MyProgressRing.Visibility = Visibility.Visible;

            //resets page
            if (diditwork == false)
            {
                MostPlayedChampions.Clear();
                SummonerMatches.Clear();
                Error.Visibility = Visibility.Collapsed;
            }
            if (SummonerMatches.Count == 0 || diditwork == false)
            { 
                try
                {
                    //if (localSettings.Values["LookUpName"] == null)
                    //{
                    //    localSettings.Values["LookUpName"] = localSettings.Values["SummonerName"].ToString();
                    //    localSettings.Values["LookUpRegion"] = localSettings.Values["SummonerRegion"].ToString();
                    //    localSettings.Values["LookUpID"] = localSettings.Values["SummonerID"].ToString();
                    //}

                    //Get Ranked stats
                    string Version = await ChampionFacade.GetVersion();
                    Models.MatchList ListOfMatches = await MatchFacade.GetMatchList((string)localSettings.Values["SummonerID"]);
                    await Facades.LeagueFacade.GetSummonerMostPlayedChamps(MostPlayedChampions, (string)localSettings.Values["SummonerID"], (string)localSettings.Values["SummonerRegion"], Version);

                    Models.Champion LastPlayed = await ChampionFacade.GetNameImage(ListOfMatches.games[0].championId.ToString(), Version);
                    //String Portrait = String.Format("http://ddragon.leagueoflegends.com/cdn/img/champion/splash/{0}", MostPlayedChampions[0].image.full);
                    String Portrait = String.Format("http://ddragon.leagueoflegends.com/cdn/img/champion/splash/{0}", LastPlayed.image.full);
                    Portrait = Portrait.Replace(".png", "_0.jpg");
                    LastPlayedPortrait.Source = new BitmapImage(new Uri(Portrait, UriKind.Absolute));

                    string AverageKillsString = "";
                    string AverageDeathsString = "";
                    string AverageAssistsString = "";

                    //Get Player Information
                    RankedStats TotalStats = await Facades.LeagueFacade.GetRankedStatTotals((string)localSettings.Values["SummonerID"], (string)localSettings.Values["SummonerRegion"]);

                    if (TotalStats.totalSessionsPlayed != 0)
                    {
                        double AverageKills = ((double)TotalStats.totalChampionKills / (double)TotalStats.totalSessionsPlayed);
                        if (AverageKills.ToString().Length >= 4)
                        {
                            AverageKillsString = AverageKills.ToString().Substring(0, 4);
                        }
                        else
                        {
                            AverageKillsString = AverageKills.ToString();
                        }
                        Kills.Text = "Kills:  " + AverageKillsString;

                        double AverageDeaths = ((double)TotalStats.totalDeathsPerSession / (double)TotalStats.totalSessionsPlayed);
                        if (AverageKills.ToString().Length >= 4)
                        {
                            AverageDeathsString = AverageDeaths.ToString().Substring(0, 4);
                        }
                        else
                        {
                            AverageDeathsString = AverageDeaths.ToString();
                        }
                        Deaths.Text = "Deaths:  " + AverageDeathsString;

                        double AverageAssists = ((double)TotalStats.totalAssists / (double)TotalStats.totalSessionsPlayed);
                        if (AverageKills.ToString().Length >= 4)
                        {
                            AverageAssistsString = AverageAssists.ToString().Substring(0, 4);
                        }
                        else
                        {
                            AverageAssistsString = AverageAssists.ToString();
                        }
                        Assists.Text = "Assists:  " + AverageAssistsString;

                        double AverageKDA = ((AverageKills + AverageAssists) / AverageDeaths);
                        string AverageKDAString = AverageKDA.ToString().Substring(0, 4);
                        KDA.Text = AverageKDAString;
                        switch ((int)AverageKDA)
                        {
                            case 0:
                                KDA.Foreground = new SolidColorBrush(Colors.Red);
                                break;
                            case 1:
                                KDA.Foreground = new SolidColorBrush(Colors.Orange);
                                break;
                            case 2:
                                KDA.Foreground = new SolidColorBrush(Colors.Green);
                                break;
                            case 3:
                                KDA.Foreground = new SolidColorBrush(Colors.Blue);
                                break;
                            default:
                                KDA.Foreground = new SolidColorBrush(Colors.Purple);
                                break;
                        }
                        Symbol.Text = @"{";
                    }
                    else
                    {
                        KDABlock.Visibility = Visibility.Collapsed;
                        Apologies.Visibility = Visibility.Visible;
                    }

                    //League Info
                    Well_Played.Models.Summoner leagueEntry = await Facades.LeagueFacade.GetEntry((string)localSettings.Values["SummonerID"], (string)localSettings.Values["SummonerRegion"]);
                    
                    LeagueName.Text = leagueEntry.name;

                    String Icon = String.Format("ms-appx:///Assets/LeagueIcons/{0}.png", leagueEntry.tier);
                    LeagueImage.Source = new BitmapImage(new Uri(Icon, UriKind.Absolute));

                    Division.Text = leagueEntry.division;
                    Points.Text = leagueEntry.leaguePoints.ToString();


                    String Square = String.Format("http://ddragon.leagueoflegends.com/cdn/5.22.1/img/champion/{0}", MostPlayedChampions[0].image.full);
                    n0Champ.ImageSource = new BitmapImage(new Uri(Square, UriKind.Absolute));
                    if (MostPlayedChampions.Count > 1)
                    {
                        Square = String.Format("http://ddragon.leagueoflegends.com/cdn/5.22.1/img/champion/{0}", MostPlayedChampions[1].image.full);
                        n1Champ.ImageSource = new BitmapImage(new Uri(Square, UriKind.Absolute));
                    }
                    if (MostPlayedChampions.Count > 2)
                    {
                        Square = String.Format("http://ddragon.leagueoflegends.com/cdn/5.22.1/img/champion/{0}", MostPlayedChampions[2].image.full);
                        n2Champ.ImageSource = new BitmapImage(new Uri(Square, UriKind.Absolute));
                    }
                    if (MostPlayedChampions.Count > 3)
                    {
                        Square = String.Format("http://ddragon.leagueoflegends.com/cdn/5.22.1/img/champion/{0}", MostPlayedChampions[3].image.full);
                        n3Champ.ImageSource = new BitmapImage(new Uri(Square, UriKind.Absolute));
                    }
                    if (MostPlayedChampions.Count > 4)
                    {
                        Square = String.Format("http://ddragon.leagueoflegends.com/cdn/5.22.1/img/champion/{0}", MostPlayedChampions[4].image.full);
                        n4Champ.ImageSource = new BitmapImage(new Uri(Square, UriKind.Absolute));
                    }

                    /** MatchList **/
                    Models.ItemList ListOfItems = await ItemFacade.GetItemList();
                    await MatchFacade.PopulateSummonerMatches(SummonerMatches, ListOfMatches, ListOfItems, Version);

                    //if (localSettings.Values["LookUpName"] != null)
                    //{
                    //    localSettings.Values["LookUpName"] = null;
                    //    localSettings.Values["LookUpRegion"] = null;
                    //    localSettings.Values["LookUpID"] = null;
                    //}
                    diditwork = true;
                }
                catch
                {
                    Error.Visibility = Visibility.Visible;
                    diditwork = false;
                }
            }

            MyProgressRing.IsActive = false;
            MyProgressRing.Visibility = Visibility.Collapsed;
        }


        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            localSettings.Values["SummonerName"] = null;
            Frame.Navigate(typeof(SignIn));
        }

        private void Error_Click(object sender, RoutedEventArgs e)
        {
            FlyoutBase.ShowAttachedFlyout((FrameworkElement)sender);
        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            if (Frame.CanGoBack)
            {
                //localSettings.Values["Error"] = "true";
                Frame.GoBack();
                Frame.GoForward();
            }
            else if (localSettings.Values["SummonerName"] != null)
            {
                Frame.Navigate(typeof(Summoner));
            }
            else
            {
                Frame.Navigate(typeof(SignIn));
            }
        }
    }
}
