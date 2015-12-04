using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Well_Played.Models;
using Windows.Foundation;
using Windows.Foundation.Collections;
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
    public sealed partial class LookUp : Page
    {
        Windows.Storage.ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
        Windows.Storage.StorageFolder localFolder = Windows.Storage.ApplicationData.Current.LocalFolder;


        public LookUp()
        {
            this.InitializeComponent();
        }

        private async void AppBarButton_Accept(object sender, RoutedEventArgs e)
        {
            MyProgressRing.IsActive = true;
            MyProgressRing.Visibility = Visibility.Visible;

            try
            {
                if (SummonerName.Text != "")
                {
                    try
                    {
                        Well_Played.Models.Summoner mySummonerData = await Facades.LeagueFacade.GetSummonerData(SummonerName.Text, (string)localSettings.Values["LookUpRegion"]);

                        if (mySummonerData.name != "ThisIsNotTheSummonerYoureLookingFor" && mySummonerData.name.Count() >= 4)
                        {
                            localSettings.Values["LookUpName"] = mySummonerData.name;
                            localSettings.Values["LookUpID"] = mySummonerData.id.ToString();
                            localSettings.Values["LookUpIconID"] = mySummonerData.profileIconId;
                            Frame.Navigate(typeof(SummonerLookUp));
                        }
                        else
                        {
                            SummonerName.Text = "";
                            FlyoutBase.ShowAttachedFlyout((FrameworkElement)sender);
                        }
                    }
                    catch
                    {
                        SummonerName.Text = "";
                        FlyoutBase.ShowAttachedFlyout((FrameworkElement)sender);
                    }
                }
            }
            catch { }

            MyProgressRing.IsActive = false;
            MyProgressRing.Visibility = Visibility.Collapsed;
        }

        private void BR_Tapped(object sender, TappedRoutedEventArgs e)
        {
            localSettings.Values["LookUpRegion"] = "br";
            BR_Rect.Fill.Opacity = .5;
            EUNE_Rect.Fill.Opacity = 0;
            EUW_Rect.Fill.Opacity = 0;
            KR_Rect.Fill.Opacity = 0;
            LAN_Rect.Fill.Opacity = 0;
            LAS_Rect.Fill.Opacity = 0;
            NA_Rect.Fill.Opacity = 0;
            OCE_Rect.Fill.Opacity = 0;
            RU_Rect.Fill.Opacity = 0;
            TR_Rect.Fill.Opacity = 0;
        }

        private void EUNE_Tapped(object sender, TappedRoutedEventArgs e)
        {
            localSettings.Values["LookUpRegion"] = "eune";
            BR_Rect.Fill.Opacity = 0;
            EUNE_Rect.Fill.Opacity = 0.5;
            EUW_Rect.Fill.Opacity = 0;
            KR_Rect.Fill.Opacity = 0;
            LAN_Rect.Fill.Opacity = 0;
            LAS_Rect.Fill.Opacity = 0;
            NA_Rect.Fill.Opacity = 0;
            OCE_Rect.Fill.Opacity = 0;
            RU_Rect.Fill.Opacity = 0;
            TR_Rect.Fill.Opacity = 0;
        }

        private void EUW_Tapped(object sender, TappedRoutedEventArgs e)
        {
            localSettings.Values["LookUpRegion"] = "euw";
            BR_Rect.Fill.Opacity = 0;
            EUNE_Rect.Fill.Opacity = 0;
            EUW_Rect.Fill.Opacity = 0.5;
            KR_Rect.Fill.Opacity = 0;
            LAN_Rect.Fill.Opacity = 0;
            LAS_Rect.Fill.Opacity = 0;
            NA_Rect.Fill.Opacity = 0;
            OCE_Rect.Fill.Opacity = 0;
            RU_Rect.Fill.Opacity = 0;
            TR_Rect.Fill.Opacity = 0;
        }

        private void KR_Tapped(object sender, TappedRoutedEventArgs e)
        {
            localSettings.Values["LookUpRegion"] = "kr";
            BR_Rect.Fill.Opacity = 0;
            EUNE_Rect.Fill.Opacity = 0;
            EUW_Rect.Fill.Opacity = 0;
            KR_Rect.Fill.Opacity = 0.5;
            LAN_Rect.Fill.Opacity = 0;
            LAS_Rect.Fill.Opacity = 0;
            NA_Rect.Fill.Opacity = 0;
            OCE_Rect.Fill.Opacity = 0;
            RU_Rect.Fill.Opacity = 0;
            TR_Rect.Fill.Opacity = 0;
        }

        private void LAN_Tapped(object sender, TappedRoutedEventArgs e)
        {
            localSettings.Values["LookUpRegion"] = "lan";
            BR_Rect.Fill.Opacity = 0;
            EUNE_Rect.Fill.Opacity = 0;
            EUW_Rect.Fill.Opacity = 0;
            KR_Rect.Fill.Opacity = 0;
            LAN_Rect.Fill.Opacity = 0.5;
            LAS_Rect.Fill.Opacity = 0;
            NA_Rect.Fill.Opacity = 0;
            OCE_Rect.Fill.Opacity = 0;
            RU_Rect.Fill.Opacity = 0;
            TR_Rect.Fill.Opacity = 0;
        }

        private void LAS_Tapped(object sender, TappedRoutedEventArgs e)
        {
            localSettings.Values["LookUpRegion"] = "las";
            BR_Rect.Fill.Opacity = 0;
            EUNE_Rect.Fill.Opacity = 0;
            EUW_Rect.Fill.Opacity = 0;
            KR_Rect.Fill.Opacity = 0;
            LAN_Rect.Fill.Opacity = 0;
            LAS_Rect.Fill.Opacity = 0.5;
            NA_Rect.Fill.Opacity = 0;
            OCE_Rect.Fill.Opacity = 0;
            RU_Rect.Fill.Opacity = 0;
            TR_Rect.Fill.Opacity = 0;
        }

        private void NA_Tapped(object sender, TappedRoutedEventArgs e)
        {
            localSettings.Values["LookUpRegion"] = "na";
            BR_Rect.Fill.Opacity = 0;
            EUNE_Rect.Fill.Opacity = 0;
            EUW_Rect.Fill.Opacity = 0;
            KR_Rect.Fill.Opacity = 0;
            LAN_Rect.Fill.Opacity = 0;
            LAS_Rect.Fill.Opacity = 0;
            NA_Rect.Fill.Opacity = 0.5;
            OCE_Rect.Fill.Opacity = 0;
            RU_Rect.Fill.Opacity = 0;
            TR_Rect.Fill.Opacity = 0;
        }

        private void OCE_Tapped(object sender, TappedRoutedEventArgs e)
        {
            localSettings.Values["LookUpRegion"] = "oce";
            BR_Rect.Fill.Opacity = 0;
            EUNE_Rect.Fill.Opacity = 0;
            EUW_Rect.Fill.Opacity = 0;
            KR_Rect.Fill.Opacity = 0;
            LAN_Rect.Fill.Opacity = 0;
            LAS_Rect.Fill.Opacity = 0;
            NA_Rect.Fill.Opacity = 0;
            OCE_Rect.Fill.Opacity = 0.5;
            RU_Rect.Fill.Opacity = 0;
            TR_Rect.Fill.Opacity = 0;
        }
        private void RU_Tapped(object sender, TappedRoutedEventArgs e)
        {
            localSettings.Values["LookUpRegion"] = "ru";
            BR_Rect.Fill.Opacity = 0;
            EUNE_Rect.Fill.Opacity = 0;
            EUW_Rect.Fill.Opacity = 0;
            KR_Rect.Fill.Opacity = 0;
            LAN_Rect.Fill.Opacity = 0;
            LAS_Rect.Fill.Opacity = 0;
            NA_Rect.Fill.Opacity = 0;
            OCE_Rect.Fill.Opacity = 0;
            RU_Rect.Fill.Opacity = 0.5;
            TR_Rect.Fill.Opacity = 0;
        }
        private void TR_Tapped(object sender, TappedRoutedEventArgs e)
        {
            localSettings.Values["LookUpRegion"] = "tr";
            BR_Rect.Fill.Opacity = 0;
            EUNE_Rect.Fill.Opacity = 0;
            EUW_Rect.Fill.Opacity = 0;
            KR_Rect.Fill.Opacity = 0;
            LAN_Rect.Fill.Opacity = 0;
            LAS_Rect.Fill.Opacity = 0;
            NA_Rect.Fill.Opacity = 0;
            OCE_Rect.Fill.Opacity = 0;
            RU_Rect.Fill.Opacity = 0;
            TR_Rect.Fill.Opacity = 0.5;
        }

        private void Flyout_Opened(object sender, object e)
        {
            switch (localSettings.Values["LookUpRegion"].ToString())
            {
                case "br":
                    BR_Rect.Fill.Opacity = .5;
                    EUNE_Rect.Fill.Opacity = 0;
                    EUW_Rect.Fill.Opacity = 0;
                    KR_Rect.Fill.Opacity = 0;
                    LAN_Rect.Fill.Opacity = 0;
                    LAS_Rect.Fill.Opacity = 0;
                    NA_Rect.Fill.Opacity = 0;
                    OCE_Rect.Fill.Opacity = 0;
                    RU_Rect.Fill.Opacity = 0;
                    TR_Rect.Fill.Opacity = 0; break;
                case "eune":
                    BR_Rect.Fill.Opacity = 0;
                    EUNE_Rect.Fill.Opacity = 0.5;
                    EUW_Rect.Fill.Opacity = 0;
                    KR_Rect.Fill.Opacity = 0;
                    LAN_Rect.Fill.Opacity = 0;
                    LAS_Rect.Fill.Opacity = 0;
                    NA_Rect.Fill.Opacity = 0;
                    OCE_Rect.Fill.Opacity = 0;
                    RU_Rect.Fill.Opacity = 0;
                    TR_Rect.Fill.Opacity = 0; break;
                case "euw":
                    BR_Rect.Fill.Opacity = 0;
                    EUNE_Rect.Fill.Opacity = 0;
                    EUW_Rect.Fill.Opacity = 0.5;
                    KR_Rect.Fill.Opacity = 0;
                    LAN_Rect.Fill.Opacity = 0;
                    LAS_Rect.Fill.Opacity = 0;
                    NA_Rect.Fill.Opacity = 0;
                    OCE_Rect.Fill.Opacity = 0;
                    RU_Rect.Fill.Opacity = 0;
                    TR_Rect.Fill.Opacity = 0; break;
                case "kr":
                    BR_Rect.Fill.Opacity = 0;
                    EUNE_Rect.Fill.Opacity = 0;
                    EUW_Rect.Fill.Opacity = 0;
                    KR_Rect.Fill.Opacity = 0.5;
                    LAN_Rect.Fill.Opacity = 0;
                    LAS_Rect.Fill.Opacity = 0;
                    NA_Rect.Fill.Opacity = 0;
                    OCE_Rect.Fill.Opacity = 0;
                    RU_Rect.Fill.Opacity = 0;
                    TR_Rect.Fill.Opacity = 0; break;
                case "lan":
                    BR_Rect.Fill.Opacity = 0;
                    EUNE_Rect.Fill.Opacity = 0;
                    EUW_Rect.Fill.Opacity = 0;
                    KR_Rect.Fill.Opacity = 0;
                    LAN_Rect.Fill.Opacity = 0.5;
                    LAS_Rect.Fill.Opacity = 0;
                    NA_Rect.Fill.Opacity = 0;
                    OCE_Rect.Fill.Opacity = 0;
                    RU_Rect.Fill.Opacity = 0;
                    TR_Rect.Fill.Opacity = 0; break;
                case "las":
                    BR_Rect.Fill.Opacity = 0;
                    EUNE_Rect.Fill.Opacity = 0;
                    EUW_Rect.Fill.Opacity = 0;
                    KR_Rect.Fill.Opacity = 0;
                    LAN_Rect.Fill.Opacity = 0;
                    LAS_Rect.Fill.Opacity = 0.5;
                    NA_Rect.Fill.Opacity = 0;
                    OCE_Rect.Fill.Opacity = 0;
                    RU_Rect.Fill.Opacity = 0;
                    TR_Rect.Fill.Opacity = 0; break;
                case "na":
                    BR_Rect.Fill.Opacity = 0;
                    EUNE_Rect.Fill.Opacity = 0;
                    EUW_Rect.Fill.Opacity = 0;
                    KR_Rect.Fill.Opacity = 0;
                    LAN_Rect.Fill.Opacity = 0;
                    LAS_Rect.Fill.Opacity = 0;
                    NA_Rect.Fill.Opacity = 0.5;
                    OCE_Rect.Fill.Opacity = 0;
                    RU_Rect.Fill.Opacity = 0;
                    TR_Rect.Fill.Opacity = 0; break;
                case "oce":
                    BR_Rect.Fill.Opacity = 0;
                    EUNE_Rect.Fill.Opacity = 0;
                    EUW_Rect.Fill.Opacity = 0;
                    KR_Rect.Fill.Opacity = 0;
                    LAN_Rect.Fill.Opacity = 0;
                    LAS_Rect.Fill.Opacity = 0;
                    NA_Rect.Fill.Opacity = 0;
                    OCE_Rect.Fill.Opacity = 0.5;
                    RU_Rect.Fill.Opacity = 0;
                    TR_Rect.Fill.Opacity = 0; break;
                case "ru":
                    BR_Rect.Fill.Opacity = 0;
                    EUNE_Rect.Fill.Opacity = 0;
                    EUW_Rect.Fill.Opacity = 0;
                    KR_Rect.Fill.Opacity = 0;
                    LAN_Rect.Fill.Opacity = 0;
                    LAS_Rect.Fill.Opacity = 0;
                    NA_Rect.Fill.Opacity = 0;
                    OCE_Rect.Fill.Opacity = 0;
                    RU_Rect.Fill.Opacity = 0.5;
                    TR_Rect.Fill.Opacity = 0; break;
                case "tr":
                    BR_Rect.Fill.Opacity = 0;
                    EUNE_Rect.Fill.Opacity = 0;
                    EUW_Rect.Fill.Opacity = 0;
                    KR_Rect.Fill.Opacity = 0;
                    LAN_Rect.Fill.Opacity = 0;
                    LAS_Rect.Fill.Opacity = 0;
                    NA_Rect.Fill.Opacity = 0;
                    OCE_Rect.Fill.Opacity = 0;
                    RU_Rect.Fill.Opacity = 0;
                    TR_Rect.Fill.Opacity = 0.5; break;
            }
        }
        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            if (Frame.CanGoBack)
            {
                //localSettings.Values["Error"] = "true";
                Frame.GoBack();
                Frame.GoForward();
            }
            else if (localSettings.Values["LookUpName"] != null)
            {
                Frame.Navigate(typeof(SummonerLookUp));
            }
            else
            {
                Frame.Navigate(typeof(LookUp));
            }
        }
    }
}
