using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Well_Played.Models;
using Well_Played.Facades;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Threading.Tasks;
using Windows.ApplicationModel.Store;
using Windows.Storage;
using Windows.ApplicationModel;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Well_Played
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Items : Page
    {
        public LicenseInformation licenseInformation { get; set; }

        Windows.Storage.ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
        Windows.Storage.StorageFolder localFolder = Windows.Storage.ApplicationData.Current.LocalFolder;

        bool diditwork = true;
        public string MapFilter = "SR";
        public Dictionary<string, bool> ChkBoxFilters = new Dictionary<string, bool>(16);
        public ObservableCollection<Models.Item> LeagueItems { get; set; }
        public ObservableCollection<Models.Item> FullLeagueItems { get; set; }
        public Models.ItemList ListOfItems { get; set; }

        public Items()
        {
            this.InitializeComponent();

            ChkBoxFilters.Add("Damage", false);
            ChkBoxFilters.Add("CritStrike", false);
            ChkBoxFilters.Add("AtkSpeed", false);
            ChkBoxFilters.Add("LifeSteal", false);
            ChkBoxFilters.Add("AbilityPower", false);
            ChkBoxFilters.Add("CDR", false);
            ChkBoxFilters.Add("Mana", false);
            ChkBoxFilters.Add("ManaRegen", false);
            ChkBoxFilters.Add("Health", false);
            ChkBoxFilters.Add("MagicResist", false);
            ChkBoxFilters.Add("HealthRegen", false);
            ChkBoxFilters.Add("Armor", false);
            ChkBoxFilters.Add("Movement", false);
            ChkBoxFilters.Add("Consumables", false);
            ChkBoxFilters.Add("GoldIncome", false);
            ChkBoxFilters.Add("Vision", false);

            LeagueItems = new ObservableCollection<Well_Played.Models.Item>();
            FullLeagueItems = new ObservableCollection<Well_Played.Models.Item>();
            ListOfItems = new Models.ItemList();
        }

        public async void Page_Loaded(object sender, RoutedEventArgs e)
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
                ItemGridAdSpace.Padding = new Thickness(12,4,12,4);
            }

            MyProgressRing.IsActive = true;
            MyProgressRing.Visibility = Visibility.Visible;

            //resets page
            if (diditwork == false)
            {
                LeagueItems.Clear();
                FullLeagueItems.Clear();
                MapFilter = "SR";
                SRFilter.Background.Opacity = 0.5;
                TTFilter.Background.Opacity = 0;
                HAFilter.Background.Opacity = 0;
                CSFilter.Background.Opacity = 0;
                SRFilterGrid.Background.Opacity = 0;
                TTFilterGrid.Background.Opacity = 1;
                HAFilterGrid.Background.Opacity = 1;
                CSFilterGrid.Background.Opacity = 1;
                DamageChkBox.IsChecked = false;
                CritChkBox.IsChecked = false;
                ASChkBox.IsChecked = false;
                LSChkBox.IsChecked = false;
                APChkBox.IsChecked = false;
                CDRChkBox.IsChecked = false;
                ManaChkBox.IsChecked = false;
                ManaRegenChkBox.IsChecked = false;
                HealthChkBox.IsChecked = false;
                MRChkBox.IsChecked = false;
                HealthRegenChkBox.IsChecked = false;
                ArmorChkBox.IsChecked = false;
                Movement.IsChecked = false;
                ConsumableChkBox.IsChecked = false;
                GoldIncome.IsChecked = false;
                Vision.IsChecked = false;
                Error.Visibility = Visibility.Collapsed;
            }

            if (LeagueItems.Count == 0 || diditwork == false)
            {
                try
                {
                    switch (MapFilter)
                    {
                        case "SR":
                            TitleBar.Text = "Summoner's Rift";
                            break;
                        case "HA":
                            TitleBar.Text = "Howling Abyss";
                            break;
                        case "TT":
                            TitleBar.Text = "Twisted Treeline";
                            break;
                        case "CS":
                            TitleBar.Text = "Crystal Scar";
                            break;
                    }
                    Models.ItemList ListOfItems = await ItemFacade.GetItemList();
                    await ItemFacade.PopulateLeagueItems(LeagueItems, FullLeagueItems, ListOfItems, MapFilter, ChkBoxFilters);
                    //await ItemFacade.FilterLeagueItems(LeagueItems, FullLeagueItems, MapFilter, ChkBoxFilters);
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

        private void MasterGridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var selectedItem = (Well_Played.Models.Item)e.ClickedItem;
            localSettings.Values["ItemID"] = selectedItem.id.ToString();
            localSettings.Values["ItemName"] = selectedItem.name;
            Frame.Navigate(typeof(Item));
        }

        public async void FilterGrid()
        {
            MyProgressRing.IsActive = true;
            MyProgressRing.Visibility = Visibility.Visible;

            try
            {
                switch (MapFilter)
                {
                    case "SR":
                        TitleBar.Text = "Summoner's Rift";
                        break;
                    case "HA":
                        TitleBar.Text = "Howling Abyss";
                        break;
                    case "TT":
                        TitleBar.Text = "Twisted Treeline";
                        break;
                    case "CS":
                        TitleBar.Text = "Crystal Scar";
                        break;
                }
                LeagueItems.Clear();
                await ItemFacade.FilterLeagueItems(LeagueItems, FullLeagueItems, MapFilter, ChkBoxFilters);
            }
            catch
            {
                Error.Visibility = Visibility.Visible;
                diditwork = false;
            }

            MyProgressRing.IsActive = false;
            MyProgressRing.Visibility = Visibility.Collapsed;
        }

        private void Error_Click(object sender, RoutedEventArgs e)
        {
            FlyoutBase.ShowAttachedFlyout((FrameworkElement)sender);
        }

        private void SRFilterGrid_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (MapFilter != "SR")
            {
                MapFilter = "SR";                
                SRFilter.Background.Opacity = 0.5;
                TTFilter.Background.Opacity = 0;
                HAFilter.Background.Opacity = 0;
                CSFilter.Background.Opacity = 0;
                SRFilterGrid.Background.Opacity = 0;
                TTFilterGrid.Background.Opacity = 1;
                HAFilterGrid.Background.Opacity = 1;
                CSFilterGrid.Background.Opacity = 1;
                FilterGrid();
            }
        }

        private void TTFilterGrid_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (MapFilter != "TT")
            {
                MapFilter = "TT";
                SRFilter.Background.Opacity = 0;
                TTFilter.Background.Opacity = 0.5;
                HAFilter.Background.Opacity = 0;
                CSFilter.Background.Opacity = 0;
                SRFilterGrid.Background.Opacity = 1;
                TTFilterGrid.Background.Opacity = 0;
                HAFilterGrid.Background.Opacity = 1;
                CSFilterGrid.Background.Opacity = 1;
                FilterGrid();
            }
        }

        private void HAFilterGrid_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (MapFilter != "HA")
            {
                MapFilter = "HA";
                SRFilter.Background.Opacity = 0;
                TTFilter.Background.Opacity = 0;
                HAFilter.Background.Opacity = 0.5;
                CSFilter.Background.Opacity = 0;
                SRFilterGrid.Background.Opacity = 1;
                TTFilterGrid.Background.Opacity = 1;
                HAFilterGrid.Background.Opacity = 0;
                CSFilterGrid.Background.Opacity = 1;
                FilterGrid();
            }
        }

        private void CSFilterGrid_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (MapFilter != "CS")
            {
                MapFilter = "CS";
                SRFilter.Background.Opacity = 0;
                TTFilter.Background.Opacity = 0;
                HAFilter.Background.Opacity = 0;
                CSFilter.Background.Opacity = 0.5;
                SRFilterGrid.Background.Opacity = 1;
                TTFilterGrid.Background.Opacity = 1;
                HAFilterGrid.Background.Opacity = 1;
                CSFilterGrid.Background.Opacity = 0;
                FilterGrid();
            }
        }


        private void FilterFlyout_Opened(object sender, object e)
        {
            switch (MapFilter)
            {
                case "SR":
                    SRFilter.Background.Opacity = 0.5;
                    SRFilterGrid.Background.Opacity = 0;
                    break;
                case "TT":
                    TTFilter.Background.Opacity = 0.5;
                    TTFilterGrid.Background.Opacity = 0;
                    break;
                case "HA":
                    HAFilter.Background.Opacity = 0.5;
                    HAFilterGrid.Background.Opacity = 0;
                    break;
                case "CS":
                    CSFilter.Background.Opacity = 0.5;
                    CSFilterGrid.Background.Opacity = 0;
                    break;
            }
        }

        private void DamageChkBox_Checked(object sender, RoutedEventArgs e)
        {
            ChkBoxFilters["Damage"] = true;
            FilterGrid();
        }
        private void DamageChkBox_Unchecked(object sender, RoutedEventArgs e)
        {
            ChkBoxFilters["Damage"] = false;
            FilterGrid();
        }
        private void CritChkBox_Checked(object sender, RoutedEventArgs e)
        {
            ChkBoxFilters["CritStrike"] = true;
            FilterGrid();
        }
        private void CritChkBox_Unchecked(object sender, RoutedEventArgs e)
        {
            ChkBoxFilters["CritStrike"] = false;
            FilterGrid();
        }
        private void ASChkBox_Checked(object sender, RoutedEventArgs e)
        {
            ChkBoxFilters["AtkSpeed"] = true;
            FilterGrid();
        }
        private void ASChkBox_Unchecked(object sender, RoutedEventArgs e)
        {
            ChkBoxFilters["AtkSpeed"] = false;
            FilterGrid();
        }
        private void LSChkBox_Checked(object sender, RoutedEventArgs e)
        {
            ChkBoxFilters["LifeSteal"] = true;
            FilterGrid();
        }
        private void LSChkBox_Unchecked(object sender, RoutedEventArgs e)
        {
            ChkBoxFilters["LifeSteal"] = false;
            FilterGrid();
        }
        private void APChkBox_Checked(object sender, RoutedEventArgs e)
        {
            ChkBoxFilters["AbilityPower"] = true;
            FilterGrid();
        }

        private void APChkBox_Unchecked(object sender, RoutedEventArgs e)
        {
            ChkBoxFilters["AbilityPower"] = false;
            FilterGrid();
        }
        private void CDRChkBox_Checked(object sender, RoutedEventArgs e)
        {
            ChkBoxFilters["CDR"] = true;
            FilterGrid();
        }

        private void CDRChkBox_Unchecked(object sender, RoutedEventArgs e)
        {
            ChkBoxFilters["CDR"] = false;
            FilterGrid();
        }
        private void ManaChkBox_Checked(object sender, RoutedEventArgs e)
        {
            ChkBoxFilters["Mana"] = true;
            FilterGrid();
        }
        private void ManaChkBox_Unchecked(object sender, RoutedEventArgs e)
        {
            ChkBoxFilters["Mana"] = false;
            FilterGrid();
        }
        private void ManaRegenChkBox_Checked(object sender, RoutedEventArgs e)
        {
            ChkBoxFilters["ManaRegen"] = true;
            FilterGrid();
        }
        private void ManaRegenChkBox_Unchecked(object sender, RoutedEventArgs e)
        {
            ChkBoxFilters["ManaRegen"] = false;
            FilterGrid();
        }
        private void HealthChkBox_Checked(object sender, RoutedEventArgs e)
        {
            ChkBoxFilters["Health"] = true;
            FilterGrid();
        }
        private void HealthChkBox_Unchecked(object sender, RoutedEventArgs e)
        {
            ChkBoxFilters["Health"] = false;
            FilterGrid();
        }
        private void MRChkBox_Checked(object sender, RoutedEventArgs e)
        {
            ChkBoxFilters["MagicResist"] = true;
            FilterGrid();
        }
        private void MRChkBox_Unchecked(object sender, RoutedEventArgs e)
        {
            ChkBoxFilters["MagicResist"] = false;
            FilterGrid();
        }
        private void HealthRegenChkBox_Checked(object sender, RoutedEventArgs e)
        {
            ChkBoxFilters["HealthRegen"] = true;
            FilterGrid();
        }
        private void HealthRegenChkBox_Unchecked(object sender, RoutedEventArgs e)
        {
            ChkBoxFilters["HealthRegen"] = false;
            FilterGrid();
        }
        private void ArmorChkBox_Checked(object sender, RoutedEventArgs e)
        {
            ChkBoxFilters["Armor"] = true;
            FilterGrid();
        }
        private void ArmorChkBox_Unchecked(object sender, RoutedEventArgs e)
        {
            ChkBoxFilters["Armor"] = false;
            FilterGrid();
        }
        private void Movement_Checked(object sender, RoutedEventArgs e)
        {
            ChkBoxFilters["Movement"] = true;
            FilterGrid();
        }
        private void Movement_Unchecked(object sender, RoutedEventArgs e)
        {
            ChkBoxFilters["Movement"] = false;
            FilterGrid();
        }
        private void ConsumableChkBox_Checked(object sender, RoutedEventArgs e)
        {
            ChkBoxFilters["Consumables"] = true;
            FilterGrid();
        }
        private void ConsumableChkBox_Unchecked(object sender, RoutedEventArgs e)
        {
            ChkBoxFilters["Consumables"] = false;
            FilterGrid();
        }
        private void GoldIncome_Checked(object sender, RoutedEventArgs e)
        {
            ChkBoxFilters["GoldIncome"] = true;
            FilterGrid();
        }
        private void GoldIncome_Unchecked(object sender, RoutedEventArgs e)
        {
            ChkBoxFilters["GoldIncome"] = false;
            FilterGrid();
        }
        private void Vision_Checked(object sender, RoutedEventArgs e)
        {
            ChkBoxFilters["Vision"] = true;
            FilterGrid();
        }
        private void Vision_Unchecked(object sender, RoutedEventArgs e)
        {
            ChkBoxFilters["Vision"] = false;
            FilterGrid();
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
