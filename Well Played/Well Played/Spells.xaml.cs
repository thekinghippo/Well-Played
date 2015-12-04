using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Well_Played.Facades;
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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Well_Played
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Spells : Page
    {
        public LicenseInformation licenseInformation { get; set; }

        Windows.Storage.ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
        Windows.Storage.StorageFolder localFolder = Windows.Storage.ApplicationData.Current.LocalFolder;

        bool diditwork = true;
        public ObservableCollection<Models.SummonerSpell> SummonerSpells { get; set; }
        public Models.SpellList ListOfSpells { get; set; }

        public Spells()
        {
            this.InitializeComponent();

            SummonerSpells = new ObservableCollection<Models.SummonerSpell>();
            ListOfSpells = new Models.SpellList();
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
                SpellListAdSpace.Padding = new Thickness(0);
            }

            MyProgressRing.IsActive = true;
            MyProgressRing.Visibility = Visibility.Visible;

            //resets page
            if (diditwork == false)
            {
                SummonerSpells.Clear();
                Error.Visibility = Visibility.Collapsed;
            }

            if (SummonerSpells.Count == 0 || diditwork == false)
            {
                try
                {
                    Models.SpellList ListOfSpells = await SpellFacade.GetSpellList();
                    await SpellFacade.PopulateSummonerSpells(SummonerSpells, ListOfSpells);

                    //TitleBar.Text = ListOfSpells.data["SummonerBoost"].name;
                    //ssIcon.ImageSource = new BitmapImage(new Uri(ListOfSpells.data["SummonerBoost"].image.url, UriKind.Absolute));
                    //ssCooldown.Text = @" " + ListOfSpells.data["SummonerBoost"].cooldownBurn;
                    //ssRange.Text = @" " + ListOfSpells.data["SummonerBoost"].rangeBurn;
                    //ssrequiredLevel.Text = @" " + ListOfSpells.data["SummonerBoost"].summonerLevel;
                    //ssDescription.Text = ListOfSpells.data["SummonerBoost"].description;
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
            TopLeftGrid.Visibility = Visibility.Visible;
            Grid.Visibility = Visibility.Collapsed;
            Models.SummonerSpell selectedSpell = (Well_Played.Models.SummonerSpell)e.ClickedItem;
            TitleBar.Text = selectedSpell.name;
            ssIcon.ImageSource = new BitmapImage(new Uri(selectedSpell.image.url, UriKind.Absolute));
            ssCooldown.Text = @" " + selectedSpell.cooldownBurn;
            ssRange.Text = @" " + selectedSpell.rangeBurn;
            ssrequiredLevel.Text = @" " + selectedSpell.summonerLevel;
            ssDescription.Text = selectedSpell.description;
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
