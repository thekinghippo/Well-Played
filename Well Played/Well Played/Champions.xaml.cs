using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Store;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Well_Played
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Champions : Page
    {
        public LicenseInformation licenseInformation { get; set; }

        Windows.Storage.ApplicationDataContainer localSettings =
            Windows.Storage.ApplicationData.Current.LocalSettings;
        Windows.Storage.StorageFolder localFolder =
            Windows.Storage.ApplicationData.Current.LocalFolder;

        bool diditwork = true;
        public string ChampFilter = "All";
        public ObservableCollection<Well_Played.Models.Champion> LeagueChampions { get; set; }
        public ObservableCollection<Well_Played.Models.Champion> FullLeagueChampions { get; set; }
        public Models.ChampionList ListOfChampions { get; set; }

        public Champions()
        {
            this.InitializeComponent();

            LeagueChampions = new ObservableCollection<Well_Played.Models.Champion>();
            FullLeagueChampions = new ObservableCollection<Well_Played.Models.Champion>();
            ListOfChampions = new Models.ChampionList();
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
                ChampionListAdSpace.Padding = new Thickness(0, 8, 0, 2);
            }

            MyProgressRing.IsActive = true;
            MyProgressRing.Visibility = Visibility.Visible;

            //reset page
            if (diditwork == false)
            {
                LeagueChampions.Clear();
                FullLeagueChampions.Clear();
                ChampFilter = "All";
                All_Rect.Fill.Opacity = 0.5;
                Assassin_Rect.Fill.Opacity = 0;
                Fighter_Rect.Fill.Opacity = 0;
                Mage_Rect.Fill.Opacity = 0;
                Marksman_Rect.Fill.Opacity = 0;
                Support_Rect.Fill.Opacity = 0;
                Tank_Rect.Fill.Opacity = 0;
                Error.Visibility = Visibility.Collapsed;
            }

            if (LeagueChampions.Count == 0 || diditwork == false)
            {
                try
                {
                    Models.ChampionList ListOfChampions = await Facades.ChampionFacade.GetChampionFullDataList();
                    await Facades.ChampionFacade.PopulateLeagueChampionsAsync(LeagueChampions, FullLeagueChampions, ListOfChampions);
                    //await Facades.ChampionFacade.FilterLeagueChampions(LeagueChampions, FullLeagueChampions, ChampFilter);
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

        public async void FilterList()
        {
            MyProgressRing.IsActive = true;
            MyProgressRing.Visibility = Visibility.Visible;

            try
            {
                if (ChampFilter != "Marksman")
                {
                    if (ChampFilter != "All")
                    {
                        if (ChampFilter != string.Empty)
                        {
                            TitleBar.Text = ChampFilter + "s";
                        }
                        else
                        {
                            ChampFilter = "All";
                            TitleBar.Text = "Champions";
                        }
                    }
                    else
                    {
                        ChampFilter = "All";
                        TitleBar.Text = "Champions";
                    }
                }
                else
                {
                    TitleBar.Text = "Marksmen";
                }
                LeagueChampions.Clear();
                await Facades.ChampionFacade.FilterLeagueChampions(LeagueChampions, FullLeagueChampions, ChampFilter);
            }
            catch
            {
                Error.Visibility = Visibility.Visible;
                diditwork = false;
            }

            MyProgressRing.IsActive = false;
            MyProgressRing.Visibility = Visibility.Collapsed;
        }

        private void All_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (ChampFilter != "All")
            {
                All_Rect.Fill.Opacity = 0.5;
                Assassin_Rect.Fill.Opacity = 0;
                Fighter_Rect.Fill.Opacity = 0;
                Mage_Rect.Fill.Opacity = 0;
                Marksman_Rect.Fill.Opacity = 0;
                Support_Rect.Fill.Opacity = 0;
                Tank_Rect.Fill.Opacity = 0;
                ChampFilter = "All";
                FilterList();
            }
        }

        private void Assassin_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (ChampFilter != "Assassin")
            {
                All_Rect.Fill.Opacity = 0;
                Assassin_Rect.Fill.Opacity = 0.5;
                Fighter_Rect.Fill.Opacity = 0;
                Mage_Rect.Fill.Opacity = 0;
                Marksman_Rect.Fill.Opacity = 0;
                Support_Rect.Fill.Opacity = 0;
                Tank_Rect.Fill.Opacity = 0;
                ChampFilter = "Assassin";
                FilterList();
            }
        }

        private void Fighter_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (ChampFilter != "Fighter")
            {
                All_Rect.Fill.Opacity = 0;
                Assassin_Rect.Fill.Opacity = 0;
                Fighter_Rect.Fill.Opacity = 0.5;
                Mage_Rect.Fill.Opacity = 0;
                Marksman_Rect.Fill.Opacity = 0;
                Support_Rect.Fill.Opacity = 0;
                Tank_Rect.Fill.Opacity = 0;
                ChampFilter = "Fighter";
                FilterList();
            }
        }

        private void Mage_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (ChampFilter != "Mage")
            {
                All_Rect.Fill.Opacity = 0;
                Assassin_Rect.Fill.Opacity = 0;
                Fighter_Rect.Fill.Opacity = 0;
                Mage_Rect.Fill.Opacity = 0.5;
                Marksman_Rect.Fill.Opacity = 0;
                Support_Rect.Fill.Opacity = 0;
                Tank_Rect.Fill.Opacity = 0;
                ChampFilter = "Mage";
                FilterList();
            }
        }

        private void Marksman_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (ChampFilter != "Marksman")
            {
                All_Rect.Fill.Opacity = 0;
                Assassin_Rect.Fill.Opacity = 0;
                Fighter_Rect.Fill.Opacity = 0;
                Mage_Rect.Fill.Opacity = 0;
                Marksman_Rect.Fill.Opacity = 0.5;
                Support_Rect.Fill.Opacity = 0;
                Tank_Rect.Fill.Opacity = 0;
                ChampFilter = "Marksman";
                FilterList();
            }
        }

        private void Support_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (ChampFilter != "Support")
            {
                All_Rect.Fill.Opacity = 0;
                Assassin_Rect.Fill.Opacity = 0;
                Fighter_Rect.Fill.Opacity = 0;
                Mage_Rect.Fill.Opacity = 0;
                Marksman_Rect.Fill.Opacity = 0;
                Support_Rect.Fill.Opacity = 0.5;
                Tank_Rect.Fill.Opacity = 0;
                ChampFilter = "Support";
                FilterList();
            }
        }

        private void Tank_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (ChampFilter != "Tank")
            {
                All_Rect.Fill.Opacity = 0;
                Assassin_Rect.Fill.Opacity = 0;
                Fighter_Rect.Fill.Opacity = 0;
                Mage_Rect.Fill.Opacity = 0;
                Marksman_Rect.Fill.Opacity = 0;
                Support_Rect.Fill.Opacity = 0;
                Tank_Rect.Fill.Opacity = 0.5;
                ChampFilter = "Tank";
                FilterList();
            }
        }

        private void Flyout_Opened(object sender, object e)
        {
            All_Rect.Fill.Opacity = 0;
            Assassin_Rect.Fill.Opacity = 0;
            Fighter_Rect.Fill.Opacity = 0;
            Mage_Rect.Fill.Opacity = 0;
            Marksman_Rect.Fill.Opacity = 0;
            Support_Rect.Fill.Opacity = 0;
            Tank_Rect.Fill.Opacity = 0;
            switch (ChampFilter)
            {
                case "All":
                    All_Rect.Fill.Opacity = .5;
                    break;
                case "Assassin":
                    Assassin_Rect.Fill.Opacity = .5;
                    break;
                case "Fighter":
                    Fighter_Rect.Fill.Opacity = .5;
                    break;
                case "Mage":
                    Mage_Rect.Fill.Opacity = .5;
                    break;
                case "Marksman":
                    Marksman_Rect.Fill.Opacity = .5;
                    break;
                case "Support":
                    Support_Rect.Fill.Opacity = .5;
                    break;
                case "Tank":
                    Tank_Rect.Fill.Opacity = .5;
                    break;
            }
        }

        private void MasterListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var selectedChampion = (Well_Played.Models.Champion)e.ClickedItem;
            localSettings.Values["ChampID"] = selectedChampion.id.ToString();
            localSettings.Values["ChampName"] = selectedChampion.name;
            Frame.Navigate(typeof(Champion));
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