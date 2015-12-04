using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public sealed partial class Champion : Page
    {
        public LicenseInformation licenseInformation { get; set; }

        Windows.Storage.ApplicationDataContainer localSettings =
            Windows.Storage.ApplicationData.Current.LocalSettings;
        Windows.Storage.StorageFolder localFolder =
            Windows.Storage.ApplicationData.Current.LocalFolder;

        double Health, Healthregen, Mana, ManaRegen, AttackDamage, AttackSpeed, Armor, MagicResist;

        double HealthPerLevel, HealthRegenPerLevel, ManaPerLevel, ManaRegenPerLevel, AttackDamagerPerLevel, AttackSpeedPerLevel, ArmorPerLevel, MagicResistPerLevel;

        private void slider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            HealthNum.Text = (Health + (HealthPerLevel * (slider.Value - 1))).ToString();
            HealthRegenNum.Text = (Healthregen + (HealthRegenPerLevel * (slider.Value - 1))).ToString();
            ManaNum.Text = (Mana + (ManaPerLevel * (slider.Value - 1))).ToString();
            ManaRegenNum.Text = (ManaRegen + (ManaRegenPerLevel * (slider.Value - 1))).ToString();
            AttackDamageNum.Text = (AttackDamage + (AttackDamagerPerLevel * (slider.Value - 1))).ToString();
            AttackSpeedNum.Text = (AttackSpeed + (AttackSpeedPerLevel * (slider.Value - 1))).ToString();
            DefenseNum.Text = (Armor + (ArmorPerLevel * (slider.Value - 1))).ToString();
            MagicResistNum.Text = (MagicResist + (MagicResistPerLevel * (slider.Value - 1))).ToString();
        }

        public Champion()
        {
            this.InitializeComponent();

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
                AbilitiesAdSpace.Padding = new Thickness(0);
                StatsAdSpace.Padding = new Thickness(0);
            }

            MyProgressRing.IsActive = true;
            MyProgressRing.Visibility = Visibility.Visible;

            try
            {
                TitleBar.Text = (string)localSettings.Values["ChampName"];
                Well_Played.Models.Champion myChampion = await Facades.ChampionFacade.GetChampion((string)localSettings.Values["ChampID"]);
                string version = await Facades.ChampionFacade.GetVersion();

                String Portrait = String.Format("http://ddragon.leagueoflegends.com/cdn/img/champion/splash/{0}", myChampion.image.full);
                Portrait = Portrait.Replace(".png", "_0.jpg");
                ChampionPortrait.Source = new BitmapImage(new Uri(Portrait, UriKind.Absolute));

                ChampTitle.Text = myChampion.title;

                myChampion.lore = myChampion.lore.Replace("<br>", @"
");
                ChampLore.Text = myChampion.lore;

                bool initial = true;
                foreach (string tags in myChampion.tags)
                {
                    if (initial == true)
                    {
                        PrimaryTag.Text = tags;
                        initial = false;
                        switch (tags)
                        {
                            case "Assassin":
                                PrimaryTag.Foreground = new SolidColorBrush(Colors.DarkMagenta);
                                break;
                            case "Fighter":
                                PrimaryTag.Foreground = new SolidColorBrush(Colors.DarkRed);
                                break;
                            case "Mage":
                                PrimaryTag.Foreground = new SolidColorBrush(Colors.DarkBlue);
                                break;
                            case "Marksman":
                                PrimaryTag.Foreground = new SolidColorBrush(Colors.DarkOrange);
                                break;
                            case "Support":
                                PrimaryTag.Foreground = new SolidColorBrush(Colors.DarkSalmon);
                                break;
                            case "Tank":
                                PrimaryTag.Foreground = new SolidColorBrush(Colors.DarkGreen);
                                break;
                        }
                    }
                    else
                    {
                        SecondaryTag.Text = " " + tags;
                        switch (tags)
                        {
                            case "Assassin":
                                SecondaryTag.Foreground = new SolidColorBrush(Colors.DarkMagenta);
                                break;
                            case "Fighter":
                                SecondaryTag.Foreground = new SolidColorBrush(Colors.DarkRed);
                                break;
                            case "Mage":
                                SecondaryTag.Foreground = new SolidColorBrush(Colors.DarkBlue);
                                break;
                            case "Marksman":
                                SecondaryTag.Foreground = new SolidColorBrush(Colors.DarkOrange);
                                break;
                            case "Support":
                                SecondaryTag.Foreground = new SolidColorBrush(Colors.DarkSalmon);
                                break;
                            case "Tank":
                                SecondaryTag.Foreground = new SolidColorBrush(Colors.DarkGreen);
                                break;
                        }
                    }
                }


                AttackBar.Width = myChampion.info.attack * 24;
                DefenseBar.Width = myChampion.info.defense * 24;
                AbilityBar.Width = myChampion.info.magic * 24;
                DifficultyBar.Width = myChampion.info.difficulty * 24;

                /** Abilities **/
                //@Effect1Amount*2@ Health Per Sec" : Mundo W

                SpellNameP.Text = myChampion.passive.name;
                String IconP = String.Format("http://ddragon.leagueoflegends.com/cdn/{1}/img/passive/{0}", myChampion.passive.image.full, version);
                SpellIconP.ImageSource = new BitmapImage(new Uri(IconP, UriKind.Absolute));
                SpellDescriptionP.Text = myChampion.passive.sanitizedDescription;


                SpellName0.Text = myChampion.spells[0].name;
                String Icon0 = String.Format("http://ddragon.leagueoflegends.com/cdn/{1}/img/spell/{0}", myChampion.spells[0].image.full, version);
                SpellIcon0.ImageSource = new BitmapImage(new Uri(Icon0, UriKind.Absolute));
                SpellCooldown0.Text = @" " + myChampion.spells[0].cooldownBurn;
                if (myChampion.spells[0].resource != "No Cost"
                    && myChampion.spells[0].resource != "No Cost or 50 Fury")
                {
                    var startOfSubstring = myChampion.spells[0].resource.IndexOf("{{ ") + 3;
                    var lengthOfSubstring = myChampion.spells[0].resource.IndexOf(" }}") - startOfSubstring;
                    var resource = myChampion.spells[0].resource.Substring(startOfSubstring, lengthOfSubstring);

                    switch (resource.Substring(0, 1))
                    {
                        case "c":
                            resource = myChampion.spells[0].resource.Replace("{{ cost }}", "{0}");
                            SpellCost0.Text = @" " + string.Format(resource, myChampion.spells[0].costBurn);
                            break;
                        case "e":
                            var effectNumber = resource.Substring(1, 1);
                            resource = myChampion.spells[0].resource.Replace("{{ " + resource + " }}", "{0}");
                            SpellCost0.Text = @" " + string.Format(resource, myChampion.spells[0].effectBurn[Int32.Parse(effectNumber)]);
                            break;
                        default:
                            Error.Visibility = Visibility.Visible;
                            break;
                    }
                }
                else if (myChampion.spells[0].resource == "No Cost or 50 Fury")
                {
                    SpellCost0.Text = @" " + "No Cost or 50 Fury";
                }
                else if (myChampion.spells[0].resource == "No Cost")
                {
                    SpellCost0.Text = @" " + "No Cost";
                }
                else
                {
                    FlyoutBase.ShowAttachedFlyout((FrameworkElement)sender);
                }
                SpellRange0.Text = @" " + myChampion.spells[0].rangeBurn;
                SpellDescription0.Text = myChampion.spells[0].sanitizedDescription;



                SpellName1.Text = myChampion.spells[1].name;
                String Icon1 = String.Format("http://ddragon.leagueoflegends.com/cdn/{1}/img/spell/{0}", myChampion.spells[1].image.full, version);
                SpellIcon1.ImageSource = new BitmapImage(new Uri(Icon1, UriKind.Absolute));
                SpellCooldown1.Text = @" " + myChampion.spells[1].cooldownBurn;
                if (myChampion.spells[1].resource != "No Cost"
                    && myChampion.spells[1].resource != "No Cost or 50 Fury"
                    && myChampion.spells[1].resource != "@Effect1Amount*2@ Health Per Sec")
                {
                    string resource = string.Empty;
                    if (myChampion.spells[1].resource.Contains("{{"))
                    {
                        var startOfSubstring = myChampion.spells[1].resource.IndexOf("{{ ") + 3;
                        var lengthOfSubstring = myChampion.spells[1].resource.IndexOf(" }}") - startOfSubstring;
                        resource = myChampion.spells[1].resource.Substring(startOfSubstring, lengthOfSubstring);
                    }
                    else
                    { resource = myChampion.spells[1].resource; }

                    switch (resource.Substring(0, 1))
                    {
                        case "c":
                            resource = myChampion.spells[1].resource.Replace("{{ cost }}", "{0}");
                            SpellCost1.Text = @" " + string.Format(resource, myChampion.spells[1].costBurn);
                            break;
                        case "e":
                            var effectNumber = resource.Substring(1, 1);
                            resource = myChampion.spells[1].resource.Replace("{{ " + resource + " }}", "{0}");
                            SpellCost1.Text = @" " + string.Format(resource, myChampion.spells[1].effectBurn[Int32.Parse(effectNumber)]);
                            break;
                        case "P":
                            SpellCost1.Text = @" 0";
                            break;
                        default:
                            Error.Visibility = Visibility.Visible;
                            break;
                    }
                }
                else if (myChampion.spells[1].resource == "No Cost or 50 Fury")
                {
                    SpellCost1.Text = @" " + "No Cost or 50 Fury";
                }
                else if (myChampion.spells[1].resource == "No Cost")
                {
                    SpellCost1.Text = @" " + "No Cost";
                }
                else if (myChampion.spells[1].resource == @"@Effect1Amount*2@ Health Per Sec")
                {
                    SpellCost1.Text = @" " + string.Format("{0} Health per second", myChampion.spells[1].effectBurn[1]);
                }
                else
                {
                    FlyoutBase.ShowAttachedFlyout((FrameworkElement)sender);
                }
                SpellRange1.Text = @" " + myChampion.spells[1].rangeBurn;
                SpellDescription1.Text = myChampion.spells[1].sanitizedDescription;

                SpellName2.Text = myChampion.spells[2].name;
                String Icon2 = String.Format("http://ddragon.leagueoflegends.com/cdn/{1}/img/spell/{0}", myChampion.spells[2].image.full, version);
                SpellIcon2.ImageSource = new BitmapImage(new Uri(Icon2, UriKind.Absolute));
                SpellCooldown2.Text = @" " + myChampion.spells[2].cooldownBurn;
                if (myChampion.spells[2].resource != @"No Cost"
                    && myChampion.spells[2].resource != @"No Cost or 50 Fury")
                {
                    var startOfSubstring = myChampion.spells[2].resource.IndexOf("{{ ") + 3;
                    var lengthOfSubstring = myChampion.spells[2].resource.IndexOf(" }}") - startOfSubstring;
                    var resource = myChampion.spells[2].resource.Substring(startOfSubstring, lengthOfSubstring);

                    switch (resource.Substring(0, 1))
                    {
                        case "c":
                            resource = myChampion.spells[2].resource.Replace("{{ cost }}", "{0}");
                            SpellCost2.Text = @" " + string.Format(resource, myChampion.spells[2].costBurn);
                            break;
                        case "e":
                            var effectNumber = resource.Substring(1, 1);
                            resource = myChampion.spells[2].resource.Replace("{{ " + resource + " }}", "{0}");
                            SpellCost2.Text = @" " + string.Format(resource, myChampion.spells[2].effectBurn[Int32.Parse(effectNumber)]);
                            break;
                        default:
                            Error.Visibility = Visibility.Visible;
                            break;
                    }
                }
                else if (myChampion.spells[2].resource == "No Cost or 50 Fury")
                {
                    SpellCost2.Text = @" " + "No Cost or 50 Fury";
                }
                else if (myChampion.spells[2].resource == "No Cost")
                {
                    SpellCost2.Text = @" " + "No Cost";
                }
                else
                {
                    FlyoutBase.ShowAttachedFlyout((FrameworkElement)sender);
                }
                SpellRange2.Text = @" " + myChampion.spells[2].rangeBurn;
                SpellDescription2.Text = myChampion.spells[2].sanitizedDescription;

                SpellName3.Text = myChampion.spells[3].name;
                String Icon3 = String.Format("http://ddragon.leagueoflegends.com/cdn/{1}/img/spell/{0}", myChampion.spells[3].image.full, version);
                SpellIcon3.ImageSource = new BitmapImage(new Uri(Icon3, UriKind.Absolute));
                SpellCooldown3.Text = @" " + myChampion.spells[3].cooldownBurn;
                if (myChampion.spells[3].resource != @"No Cost"
                    && myChampion.spells[3].resource != @"No Cost or 50 Fury")
                {
                    var startOfSubstring = myChampion.spells[3].resource.IndexOf("{{ ") + 3;
                    var lengthOfSubstring = myChampion.spells[3].resource.IndexOf(" }}") - startOfSubstring;
                    var resource = myChampion.spells[3].resource.Substring(startOfSubstring, lengthOfSubstring);

                    switch (resource.Substring(0, 1))
                    {
                        case "c":
                            resource = myChampion.spells[3].resource.Replace("{{ cost }}", "{0}");
                            SpellCost3.Text = @" " + string.Format(resource, myChampion.spells[3].costBurn);
                            break;
                        case "e":
                            var effectNumber = resource.Substring(1, 1);
                            resource = myChampion.spells[3].resource.Replace("{{ " + resource + " }}", "{0}");
                            SpellCost3.Text = @" " + string.Format(resource, myChampion.spells[3].effectBurn[Int32.Parse(effectNumber)]);
                            break;
                        default:
                            Error.Visibility = Visibility.Visible;
                            break;
                    }
                }
                else if (myChampion.spells[3].resource == "No Cost or 50 Fury")
                {
                    SpellCost3.Text = @" " + "No Cost or 50 Fury";
                }
                else if (myChampion.spells[3].resource == "No Cost")
                {
                    SpellCost3.Text = @" " + "No Cost";
                }
                else
                {
                    FlyoutBase.ShowAttachedFlyout((FrameworkElement)sender);
                }
                SpellRange3.Text = @" " + myChampion.spells[3].rangeBurn;
                SpellDescription3.Text = myChampion.spells[3].sanitizedDescription;


                /** STATS **/

                RangeNum.Text = myChampion.stats.attackrange.ToString();
                Health = myChampion.stats.hp;
                HealthPerLevel = myChampion.stats.hpperlevel;
                HealthNum.Text = Health.ToString();
                Healthregen = myChampion.stats.hpregen;
                HealthRegenPerLevel = myChampion.stats.hpregenperlevel;
                HealthRegenNum.Text = Healthregen.ToString();
                Mana = myChampion.stats.mp;
                ManaPerLevel = myChampion.stats.mpperlevel;
                ManaNum.Text = Mana.ToString();
                ManaRegen = myChampion.stats.mpregen;
                ManaRegenPerLevel = myChampion.stats.mpregenperlevel;
                ManaRegenNum.Text = ManaRegen.ToString();
                MovespeedNum.Text = myChampion.stats.movespeed.ToString();
                AttackDamage = myChampion.stats.attackdamage;
                AttackDamagerPerLevel = myChampion.stats.attackdamageperlevel;
                AttackDamageNum.Text = AttackDamage.ToString();
                AttackSpeed = myChampion.stats.attackspeedoffset;
                AttackSpeedPerLevel = myChampion.stats.attackspeedperlevel;
                AttackSpeedNum.Text = AttackSpeed.ToString();
                Armor = myChampion.stats.armor;
                ArmorPerLevel = myChampion.stats.armorperlevel;
                DefenseNum.Text = Armor.ToString();
                MagicResist = myChampion.stats.spellblock;
                MagicResistPerLevel = myChampion.stats.spellblockperlevel;
                MagicResistNum.Text = MagicResist.ToString();
            }
            catch
            {
                Error.Visibility = Visibility.Visible;
            }

            MyProgressRing.IsActive = false;
            MyProgressRing.Visibility = Visibility.Collapsed;
        }

        private void Grid_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (MoreBlock.Text == "more")
            {
                ChampLore.MaxHeight = 5000;
                MoreBlock.Text = "less";
            }
            else
            {
                ChampLore.MaxHeight = 200;
                MoreBlock.Text = "more";
            }
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
