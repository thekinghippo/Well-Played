using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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
    public sealed partial class Home : Page
    {
        bool diditwork = true;
        public ObservableCollection<Well_Played.Models.Champion> FreeWeekChampions { get; set; }
        public Models.ChampionList ListOfFreeWeekChampions { get; set; }

        public Home()
        {
            this.InitializeComponent();
            FreeWeekChampions = new ObservableCollection<Well_Played.Models.Champion>();
            ListOfFreeWeekChampions = new Models.ChampionList();
        }
        
        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            MyProgressRing.IsActive = true;
            MyProgressRing.Visibility = Visibility.Visible;

            //reset page
            if (diditwork == false)
            {
                FreeWeekChampions.Clear();
                Error.Visibility = Visibility.Collapsed;
            }

            if (FreeWeekChampions.Count == 0 || diditwork == false)
            {
                try
                {
                    Models.ChampionList ListOfFreeWeekChampions = await Facades.ChampionFacade.GetFreeWeekChampionList();

                    await Facades.ChampionFacade.PopulateFreeWeekChampionsList(FreeWeekChampions, ListOfFreeWeekChampions);
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

        private void Error_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MasterGridView_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}
