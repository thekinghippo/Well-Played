﻿#pragma checksum "C:\Users\Mark\OneDrive\Documents\Coding\Well Played(Recode)\Well Played\Well Played\Summoner.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "13FECFC2B426FF4645BE150637B43C92"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Well_Played
{
    partial class Summoner : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        internal class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
            public static void Set_Windows_UI_Xaml_Media_ImageBrush_ImageSource(global::Windows.UI.Xaml.Media.ImageBrush obj, global::Windows.UI.Xaml.Media.ImageSource value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), targetNullValue);
                }
                obj.ImageSource = value;
            }
            public static void Set_Windows_UI_Xaml_Shapes_Shape_Fill(global::Windows.UI.Xaml.Shapes.Shape obj, global::Windows.UI.Xaml.Media.Brush value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Windows.UI.Xaml.Media.Brush) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.Brush), targetNullValue);
                }
                obj.Fill = value;
            }
            public static void Set_Windows_UI_Xaml_Media_SolidColorBrush_Color(global::Windows.UI.Xaml.Media.SolidColorBrush obj, global::Windows.UI.Color value)
            {
                obj.Color = value;
            }
        };

        private class Summoner_obj8_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ISummoner_Bindings
        {
            private global::Well_Played.Models.Game dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.TextBlock obj9;
            private global::Windows.UI.Xaml.Controls.TextBlock obj10;
            private global::Windows.UI.Xaml.Controls.TextBlock obj11;
            private global::Windows.UI.Xaml.Controls.TextBlock obj12;
            private global::Windows.UI.Xaml.Controls.TextBlock obj13;
            private global::Windows.UI.Xaml.Media.ImageBrush obj14;
            private global::Windows.UI.Xaml.Media.ImageBrush obj15;
            private global::Windows.UI.Xaml.Media.ImageBrush obj16;
            private global::Windows.UI.Xaml.Media.ImageBrush obj17;
            private global::Windows.UI.Xaml.Media.ImageBrush obj18;
            private global::Windows.UI.Xaml.Media.ImageBrush obj19;
            private global::Windows.UI.Xaml.Media.ImageBrush obj20;
            private global::Windows.UI.Xaml.Controls.TextBlock obj21;
            private global::Windows.UI.Xaml.Controls.TextBlock obj22;
            private global::Windows.UI.Xaml.Controls.TextBlock obj23;
            private global::Windows.UI.Xaml.Shapes.Ellipse obj24;
            private global::Windows.UI.Xaml.Controls.TextBlock obj25;
            private global::Windows.UI.Xaml.Media.ImageBrush obj26;
            private global::Windows.UI.Xaml.Controls.TextBlock obj27;
            private global::Windows.UI.Xaml.Media.SolidColorBrush obj28;

            public Summoner_obj8_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 9:
                        this.obj9 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 10:
                        this.obj10 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 11:
                        this.obj11 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 12:
                        this.obj12 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 13:
                        this.obj13 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 14:
                        this.obj14 = (global::Windows.UI.Xaml.Media.ImageBrush)target;
                        break;
                    case 15:
                        this.obj15 = (global::Windows.UI.Xaml.Media.ImageBrush)target;
                        break;
                    case 16:
                        this.obj16 = (global::Windows.UI.Xaml.Media.ImageBrush)target;
                        break;
                    case 17:
                        this.obj17 = (global::Windows.UI.Xaml.Media.ImageBrush)target;
                        break;
                    case 18:
                        this.obj18 = (global::Windows.UI.Xaml.Media.ImageBrush)target;
                        break;
                    case 19:
                        this.obj19 = (global::Windows.UI.Xaml.Media.ImageBrush)target;
                        break;
                    case 20:
                        this.obj20 = (global::Windows.UI.Xaml.Media.ImageBrush)target;
                        break;
                    case 21:
                        this.obj21 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 22:
                        this.obj22 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 23:
                        this.obj23 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 24:
                        this.obj24 = (global::Windows.UI.Xaml.Shapes.Ellipse)target;
                        break;
                    case 25:
                        this.obj25 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 26:
                        this.obj26 = (global::Windows.UI.Xaml.Media.ImageBrush)target;
                        break;
                    case 27:
                        this.obj27 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 28:
                        this.obj28 = (global::Windows.UI.Xaml.Media.SolidColorBrush)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 global::Well_Played.Models.Game data = args.NewValue as global::Well_Played.Models.Game;
                 if (args.NewValue != null && data == null)
                 {
                    throw new global::System.ArgumentException("Incorrect type passed into template. Based on the x:DataType global::Well_Played.Models.Game was expected.");
                 }
                 this.SetDataRoot(data);
                 this.Update();
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                switch(args.Phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(args.Item as global::Well_Played.Models.Game);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            ((global::Windows.UI.Xaml.Controls.Grid)args.ItemContainer.ContentTemplateRoot).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::Well_Played.Models.Game) args.Item, 1 << (int)args.Phase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
            }

            // ISummoner_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            // Summoner_obj8_Bindings

            public void SetDataRoot(global::Well_Played.Models.Game newDataRoot)
            {
                this.dataRoot = newDataRoot;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Well_Played.Models.Game obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_subType(obj.subType, phase);
                        this.Update_gameDate(obj.gameDate, phase);
                        this.Update_stats(obj.stats, phase);
                        this.Update_color(obj.color, phase);
                        this.Update_thumbnail(obj.thumbnail, phase);
                        this.Update_win(obj.win, phase);
                    }
                }
            }
            private void Update_subType(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj9, obj, null);
                }
            }
            private void Update_gameDate(global::System.DateTime obj, int phase)
            {
            if ((phase & (NOT_PHASED | (1 << 0))) != 0)
            {
                this.Update_gameDate_Month(obj.Month, phase);
                this.Update_gameDate_Day(obj.Day, phase);
                this.Update_gameDate_Year(obj.Year, phase);
            }
            }
            private void Update_gameDate_Month(global::System.Int32 obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj10, obj.ToString(), null);
                }
            }
            private void Update_gameDate_Day(global::System.Int32 obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj11, obj.ToString(), null);
                }
            }
            private void Update_gameDate_Year(global::System.Int32 obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj12, obj.ToString(), null);
                }
            }
            private void Update_stats(global::Well_Played.Models.RawStats obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_stats_gameTime(obj.gameTime, phase);
                        this.Update_stats_item6imageURL(obj.item6imageURL, phase);
                        this.Update_stats_item5imageURL(obj.item5imageURL, phase);
                        this.Update_stats_item4imageURL(obj.item4imageURL, phase);
                        this.Update_stats_item3imageURL(obj.item3imageURL, phase);
                        this.Update_stats_item2imageURL(obj.item2imageURL, phase);
                        this.Update_stats_item1imageURL(obj.item1imageURL, phase);
                        this.Update_stats_item0imageURL(obj.item0imageURL, phase);
                        this.Update_stats_championsKilled(obj.championsKilled, phase);
                        this.Update_stats_numDeaths(obj.numDeaths, phase);
                        this.Update_stats_assists(obj.assists, phase);
                        this.Update_stats_level(obj.level, phase);
                    }
                }
            }
            private void Update_stats_gameTime(global::System.Int32 obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj13, obj.ToString(), null);
                }
            }
            private void Update_stats_item6imageURL(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Media_ImageBrush_ImageSource(this.obj14, (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), obj), null);
                }
            }
            private void Update_stats_item5imageURL(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Media_ImageBrush_ImageSource(this.obj15, (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), obj), null);
                }
            }
            private void Update_stats_item4imageURL(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Media_ImageBrush_ImageSource(this.obj16, (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), obj), null);
                }
            }
            private void Update_stats_item3imageURL(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Media_ImageBrush_ImageSource(this.obj17, (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), obj), null);
                }
            }
            private void Update_stats_item2imageURL(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Media_ImageBrush_ImageSource(this.obj18, (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), obj), null);
                }
            }
            private void Update_stats_item1imageURL(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Media_ImageBrush_ImageSource(this.obj19, (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), obj), null);
                }
            }
            private void Update_stats_item0imageURL(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Media_ImageBrush_ImageSource(this.obj20, (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), obj), null);
                }
            }
            private void Update_stats_championsKilled(global::System.Int32 obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj21, obj.ToString(), null);
                }
            }
            private void Update_stats_numDeaths(global::System.Int32 obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj22, obj.ToString(), null);
                }
            }
            private void Update_stats_assists(global::System.Int32 obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj23, obj.ToString(), null);
                }
            }
            private void Update_color(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Shapes_Shape_Fill(this.obj24, (global::Windows.UI.Xaml.Media.Brush) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.Brush), obj), null);
                    XamlBindingSetters.Set_Windows_UI_Xaml_Media_SolidColorBrush_Color(this.obj28, (global::Windows.UI.Color) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Color), obj));
                }
            }
            private void Update_stats_level(global::System.Int32 obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj25, obj.ToString(), null);
                }
            }
            private void Update_thumbnail(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Media_ImageBrush_ImageSource(this.obj26, (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), obj), null);
                }
            }
            private void Update_win(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj27, obj, null);
                }
            }
        }

        private class Summoner_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ISummoner_Bindings
        {
            private global::Well_Played.Summoner dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.ListView obj7;

            public Summoner_obj1_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 7:
                        this.obj7 = (global::Windows.UI.Xaml.Controls.ListView)target;
                        break;
                    default:
                        break;
                }
            }

            // ISummoner_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            // Summoner_obj1_Bindings

            public void SetDataRoot(global::Well_Played.Summoner newDataRoot)
            {
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Well_Played.Summoner obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_SummonerMatches(obj.SummonerMatches, phase);
                    }
                }
            }
            private void Update_SummonerMatches(global::System.Collections.ObjectModel.ObservableCollection<global::Well_Played.Models.Game> obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj7, obj, null);
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)(target);
                    #line 9 "..\..\..\Summoner.xaml"
                    ((global::Windows.UI.Xaml.Controls.Page)element1).Loaded += this.Page_Loaded;
                    #line default
                }
                break;
            case 2:
                {
                    this.WindowStates = (global::Windows.UI.Xaml.VisualStateGroup)(target);
                }
                break;
            case 3:
                {
                    this.NarrowState = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 4:
                {
                    this.MediumState = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 5:
                {
                    this.WideState = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 6:
                {
                    this.CommandBar = (global::Windows.UI.Xaml.Controls.CommandBar)(target);
                }
                break;
            case 7:
                {
                    this.MasterListView = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 29:
                {
                    this.n4Champ = (global::Windows.UI.Xaml.Media.ImageBrush)(target);
                }
                break;
            case 30:
                {
                    this.n3Champ = (global::Windows.UI.Xaml.Media.ImageBrush)(target);
                }
                break;
            case 31:
                {
                    this.n2Champ = (global::Windows.UI.Xaml.Media.ImageBrush)(target);
                }
                break;
            case 32:
                {
                    this.n1Champ = (global::Windows.UI.Xaml.Media.ImageBrush)(target);
                }
                break;
            case 33:
                {
                    this.n0Champ = (global::Windows.UI.Xaml.Media.ImageBrush)(target);
                }
                break;
            case 34:
                {
                    this.LeagueName = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 35:
                {
                    this.LeagueImage = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 36:
                {
                    this.PointsBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 37:
                {
                    this.Points = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 38:
                {
                    this.DivisionBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 39:
                {
                    this.Division = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 40:
                {
                    this.KDA = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 41:
                {
                    this.Kills = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 42:
                {
                    this.Deaths = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 43:
                {
                    this.Assists = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 44:
                {
                    this.Symbol = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 45:
                {
                    this.LastPlayedPortrait = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 46:
                {
                    this.TitleBar = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 47:
                {
                    this.MyProgressRing = (global::Windows.UI.Xaml.Controls.ProgressRing)(target);
                }
                break;
            case 48:
                {
                    this.Error = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 102 "..\..\..\Summoner.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Error).Click += this.Error_Click;
                    #line default
                }
                break;
            case 49:
                {
                    this.Refresh = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 76 "..\..\..\Summoner.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.Refresh).Click += this.Refresh_Click;
                    #line default
                }
                break;
            case 50:
                {
                    this.Search = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                }
                break;
            case 51:
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element51 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 78 "..\..\..\Summoner.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element51).Click += this.AppBarButton_Click;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1:
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    Summoner_obj1_Bindings bindings = new Summoner_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            case 8:
                {
                    global::Windows.UI.Xaml.Controls.Grid element8 = (global::Windows.UI.Xaml.Controls.Grid)target;
                    Summoner_obj8_Bindings bindings = new Summoner_obj8_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot((global::Well_Played.Models.Game) element8.DataContext);
                    element8.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element8, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

