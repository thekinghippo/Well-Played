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
    public sealed partial class Item : Page
    {
        public LicenseInformation licenseInformation { get; set; }

        Windows.Storage.ApplicationDataContainer localSettings =
            Windows.Storage.ApplicationData.Current.LocalSettings;
        Windows.Storage.StorageFolder localFolder =
            Windows.Storage.ApplicationData.Current.LocalFolder;

        public ObservableCollection<Well_Played.Models.Item> buildsInto { get; set; }
        public ObservableCollection<Well_Played.Models.Item> buildsFrom { get; set; }

        public Item()
        {
            this.InitializeComponent();

            buildsInto = new ObservableCollection<Well_Played.Models.Item>();
            buildsFrom = new ObservableCollection<Well_Played.Models.Item>();
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
                AdSpace.Padding = new Thickness(0);
            }

            MyProgressRing.IsActive = true;
            MyProgressRing.Visibility = Visibility.Visible;

            try
            {
                TitleBar.Text = (string)localSettings.Values["ItemName"];

                Models.ItemList ListOfItems = await ItemFacade.GetItemList();

                Models.Item myItem = ListOfItems.data[localSettings.Values["ItemID"].ToString()];

                string version = ListOfItems.version;
                //Well_Played.Models.Item myItem = await LeagueFacade.GetItemFromList(localSettings.Values["ItemID"].ToString(), ListOfItems);
                //string version = await LeagueFacade.GetVersion();


                if (myItem.into != null)
                {
                    foreach (string itemId in myItem.into)
                    {
                        if (itemId != "3290" && itemId != "3718" && itemId != "3722")
                        {
                            Models.Item myItemInto = ListOfItems.data[itemId];
                            //Well_Played.Models.Item myItemInto = await LeagueFacade.GetItemFromList(itemId, ListOfItems);
                            myItemInto.imageURL = string.Format("http://ddragon.leagueoflegends.com/cdn/{1}/img/item/{0}", myItemInto.image.full, version);
                            buildsInto.Add(myItemInto);
                        }
                    }
                }
                else
                {
                    BuildsIntoGrid.Visibility = Visibility.Collapsed;
                    BuildsIntoItemsGrid.Visibility = Visibility.Collapsed;
                }
                myItem.imageURL = string.Format("http://ddragon.leagueoflegends.com/cdn/{1}/img/item/{0}", myItem.image.full, version);
                ItemImage.Source = new BitmapImage(new Uri(myItem.imageURL, UriKind.Absolute));

                if (myItem.from != null)
                {

                    switch (myItem.from.Count)
                    {
                        case 1:
                            Symbol1.Visibility = Visibility.Visible;
                            Symbol2.Visibility = Visibility.Collapsed;
                            Symbol3.Visibility = Visibility.Collapsed;
                            Symbol4.Visibility = Visibility.Collapsed;
                            break;
                        case 2:
                            Symbol1.Visibility = Visibility.Collapsed;
                            Symbol2.Visibility = Visibility.Visible;
                            Symbol3.Visibility = Visibility.Collapsed;
                            Symbol4.Visibility = Visibility.Collapsed;
                            break;
                        case 3:
                            Symbol1.Visibility = Visibility.Visible;
                            Symbol2.Visibility = Visibility.Collapsed;
                            Symbol3.Visibility = Visibility.Visible;
                            Symbol4.Visibility = Visibility.Collapsed;
                            break;
                        case 4:
                            Symbol1.Visibility = Visibility.Collapsed;
                            Symbol2.Visibility = Visibility.Visible;
                            Symbol3.Visibility = Visibility.Collapsed;
                            Symbol4.Visibility = Visibility.Visible;
                            break;
                    }

                    foreach (string itemId in myItem.from)
                    {
                        Models.Item myItemFrom = ListOfItems.data[itemId];
                        //Well_Played.Models.Item myItemFrom = await LeagueFacade.GetItemFromList(itemId, ListOfItems);
                        myItemFrom.imageURL = string.Format("http://ddragon.leagueoflegends.com/cdn/5.22.3/img/item/{0}", myItemFrom.image.full);
                        buildsFrom.Add(myItemFrom);
                    }
                }

                goldTotal.Text = "Total: " + myItem.gold.total.ToString();
                goldRecipe.Text = "Recipe: " + myItem.gold.baseGold.ToString();
                goldSell.Text = "Sell: " + myItem.gold.sell.ToString();

                myItem.description = myItem.description.Replace("<br>", @"
");
                myItem.description = myItem.description.Replace("<stats>", "");
                myItem.description = myItem.description.Replace("</stats>", "");
                myItem.description = myItem.description.Replace("<mana>", "");
                myItem.description = myItem.description.Replace("</mana>", "");
                myItem.description = myItem.description.Replace("<unique>", "");
                myItem.description = myItem.description.Replace("</unique>", "");
                myItem.description = myItem.description.Replace("<active>", "");
                myItem.description = myItem.description.Replace("</active>", "");
                myItem.description = myItem.description.Replace("<aura>", "");
                myItem.description = myItem.description.Replace("</aura>", "");
                myItem.description = myItem.description.Replace("<groupLimit>", "");
                myItem.description = myItem.description.Replace("</groupLimit>", "");
                myItem.description = myItem.description.Replace("<i>", "");
                myItem.description = myItem.description.Replace("</i>", "");
                myItem.description = myItem.description.Replace("<font color='#447777'>", "");
                myItem.description = myItem.description.Replace("</font>", "");
                myItem.description = myItem.description.Replace("<passive>", "");
                myItem.description = myItem.description.Replace("</passive>", "");
                myItem.description = myItem.description.Replace("<levelLimit>", "");
                myItem.description = myItem.description.Replace("</levelLimit>", "");
                myItem.description = myItem.description.Replace("<consumable>", "");
                myItem.description = myItem.description.Replace("</consumable>", "");
                myItem.description = myItem.description.Replace("<font color='#FF8811'>", "");
                myItem.description = myItem.description.Replace("<u>", "");
                myItem.description = myItem.description.Replace("</u>", "");
                myItem.description = myItem.description.Replace("<font color='#FFDD00'>", "");
                myItem.description = myItem.description.Replace("<font color='#FDD017'>", "");
                myItem.description = myItem.description.Replace("<font color='#BBFFFF'>", "");
                myItem.description = myItem.description.Replace("<rules>", "");
                myItem.description = myItem.description.Replace("<\rules>", "");
                myItem.description = myItem.description.Replace("<\a>", "");
                myItem.description = myItem.description.Replace("<a href='BonusArmorPen'>", "");
                myItem.description = myItem.description.Replace("<a href='GrievousWounds'>", "");
                myItem.description = myItem.description.Replace("<font color='#FFFFFFF'>", "");
                myItem.description = myItem.description.Replace("<font color='#00FF00'>", "");
                myItem.description = myItem.description.Replace("<font color='#FF0000'>", "");
                myItem.description = myItem.description.Replace("<font color='#FF6600'>", "");
                myItem.description = myItem.description.Replace("<levelScale>", "");
                myItem.description = myItem.description.Replace(@"<\levelScale>", "");
                myItem.description = myItem.description.Replace("<flavorText>", "");
                myItem.description = myItem.description.Replace("<\flavorText>", "");


                ItemDescription.Text = myItem.description;
            }
            catch
            {
                Error.Visibility = Visibility.Visible;
            }

            MyProgressRing.IsActive = false;
            MyProgressRing.Visibility = Visibility.Collapsed;
            
        }

        private void Error_Click(object sender, RoutedEventArgs e)
        {
            FlyoutBase.ShowAttachedFlyout((FrameworkElement)sender);
        }

        private void GridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var selectedItem = (Well_Played.Models.Item)e.ClickedItem;
            localSettings.Values["ItemID"] = selectedItem.id.ToString();
            localSettings.Values["ItemName"] = selectedItem.name;
            Frame.Navigate(typeof(Item));
            Frame.BackStack.RemoveAt(Frame.BackStack.Count - 1);
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
