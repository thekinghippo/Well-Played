using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Well_Played.Models;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Store;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

namespace Well_Played
{

    public sealed partial class Shell : Page
    {
        Windows.Storage.ApplicationDataContainer localSettings =
            Windows.Storage.ApplicationData.Current.LocalSettings;
        Windows.Storage.StorageFolder localFolder =
            Windows.Storage.ApplicationData.Current.LocalFolder;

        public LicenseInformation licenseInformation { get; set; }

        public bool InitialAccountCreation;

        public Shell()
        {
            this.InitializeComponent();

            //List of localsettings
            //localSettings.Values["SummonerName"] = null;
            //localSettings.Values["SummonerID"] = null;
            //localSettings.Values["SummonerIconID"] = null;
            //localSettings.Values["SummonerRegion"] = "na";
            //localSettings.Values["Filter"] = Champion;

            if (localSettings.Values["SummonerRegion"] == null)
            {
                localSettings.Values["SummonerRegion"] = "na";
            }
            if (localSettings.Values["LookUpRegion"] == null)
            {
                localSettings.Values["LookUpRegion"] = "na";
            }

            localSettings.Values["Filter"] = "Champions";

            //opening navigation to SignIn or Summoner page depending if the user is signed in
            if (localSettings.Values["SummonerName"] != null)
            {
                PageFrame.Navigate(typeof(Summoner));
            }
            else
            {
                PageFrame.Navigate(typeof(SignIn));
            }
            
            //Backstack
            SystemNavigationManager.GetForCurrentView().BackRequested += OnBackRequested;
        }

        //Icon is pulled when shell loads as well as after first login
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
            }
            else
            {
                AdMediator_A46236.Visibility = Visibility.Visible;
            }

            if (localSettings.Values["SummonerName"] != null)
            {
                SummonerTextBlock.Text = (string)localSettings.Values["SummonerName"];
                string Icon = String.Format("http://ddragon.leagueoflegends.com/cdn/5.20.1/img/profileicon/{0}.png", localSettings.Values["SummonerIconID"]);
                SummonerIconBrush.ImageSource = new BitmapImage(new Uri(Icon, UriKind.Absolute));
                SummonerButton.Visibility = Visibility.Collapsed;
                SummonerIconGrid.Visibility = Visibility.Visible;
                InitialAccountCreation = false;
            }
        }

        //Changes the Account icon to the summoner's icon when first logged in.
        private void PageFrame_Navigated(object sender, NavigationEventArgs e)
        {
            if (localSettings.Values["SummonerName"] != null)
            {
                if (InitialAccountCreation == true)
                {
                    SummonerTextBlock.Text = (string)localSettings.Values["SummonerName"];
                    string Icon = String.Format("http://ddragon.leagueoflegends.com/cdn/5.20.1/img/profileicon/{0}.png", localSettings.Values["SummonerIconID"]);
                    SummonerIconBrush.ImageSource = new BitmapImage(new Uri(Icon, UriKind.Absolute));
                    SummonerButton.Visibility = Visibility.Collapsed;
                    SummonerIconGrid.Visibility = Visibility.Visible;
                    InitialAccountCreation = false;
                }
            }
            else
            {
                SummonerIconGrid.Visibility = Visibility.Collapsed;
                SummonerButton.Visibility = Visibility.Visible;
                InitialAccountCreation = true;

                SummonerTextBlock.Text = "Sign In";
            }
        }

        //Handles Back navigation
        private void OnBackRequested(object sender, BackRequestedEventArgs e)
        {
            Frame rootFrame = Window.Current.Content as Frame;

            if ((PageFrame as Frame).CanGoBack)
            {
                e.Handled = true;
                (PageFrame as Frame).GoBack();
                ShellListBox.SelectedItem = null;
            }
        }

        private void Burger_Click(object sender, RoutedEventArgs e)
        {
            ShellSplitView.IsPaneOpen = !ShellSplitView.IsPaneOpen;
        }
        private void ShellListBox_Tapped(object sender, TappedRoutedEventArgs e)
        {
            //Clears Bottom Item Selections
            Settings.IsSelected = false;
            Summoner.IsSelected = false;
        }

        private void TopShellListBox_Tapped(object sender, TappedRoutedEventArgs e)
        {
            //Clears Top Item Selections
            Lookup.IsSelected = false;
            Champions.IsSelected = false;
            Items.IsSelected = false;
            Spells.IsSelected = false;
            Maps.IsSelected = false;
        }

        private void Summoner_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (localSettings.Values["SummonerName"] != null)
            {
                PageFrame.Navigate(typeof(Summoner));

                ShellSplitView.IsPaneOpen = false;
            }
            else
            {
                PageFrame.Navigate(typeof(SignIn));

                ShellSplitView.IsPaneOpen = false;
            }
        }

        private void Champions_Tapped(object sender, TappedRoutedEventArgs e)
        {
            PageFrame.Navigate(typeof(Champions));
            ShellSplitView.IsPaneOpen = false;
        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            if (PageFrame.CanGoBack)
            {
                //localSettings.Values["Error"] = "true";
                PageFrame.GoBack();
                PageFrame.GoForward();
            }
            else if (localSettings.Values["SummonerName"] != null)
            {
                PageFrame.Navigate(typeof(Summoner));
            }
            else
            {
                PageFrame.Navigate(typeof(SignIn));
            }
        }

        private void Items_Tapped(object sender, TappedRoutedEventArgs e)
        {
            PageFrame.Navigate(typeof(Items));
            ShellSplitView.IsPaneOpen = false;
        }

        private void Maps_Tapped(object sender, TappedRoutedEventArgs e)
        {
            PageFrame.Navigate(typeof(Maps));
            ShellSplitView.IsPaneOpen = false;
        }

        private void Spells_Tapped(object sender, TappedRoutedEventArgs e)
        {
            PageFrame.Navigate(typeof(Spells));
            ShellSplitView.IsPaneOpen = false;
        }

        private void Lookup_Tapped(object sender, TappedRoutedEventArgs e)
        {
            PageFrame.Navigate(typeof(LookUp));
            ShellSplitView.IsPaneOpen = false;
        }

        private void Settings_Tapped(object sender, TappedRoutedEventArgs e)
        {
            PageFrame.Navigate(typeof(Options));
            ShellSplitView.IsPaneOpen = false;
        }

        /**private void Home_Tapped(object sender, TappedRoutedEventArgs e)
        {
            PageFrame.Navigate(typeof(Home));
            ShellSplitView.IsPaneOpen = false;
        }**/
    }
}
