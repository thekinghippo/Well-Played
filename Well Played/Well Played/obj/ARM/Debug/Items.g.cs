﻿#pragma checksum "C:\Users\Mark\OneDrive\Documents\Coding\Well Played(v0.00.038)\Well Played\Items.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "25B294CB83D67D244A83676F4DCFDB6D"
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
    partial class Items : 
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
            public static void Set_Windows_UI_Xaml_Controls_Image_Source(global::Windows.UI.Xaml.Controls.Image obj, global::Windows.UI.Xaml.Media.ImageSource value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), targetNullValue);
                }
                obj.Source = value;
            }
        };

        private class Items_obj8_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IItems_Bindings
        {
            private global::Well_Played.Models.Item dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.TextBlock obj9;
            private global::Windows.UI.Xaml.Controls.Image obj10;

            public Items_obj8_Bindings()
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
                        this.obj10 = (global::Windows.UI.Xaml.Controls.Image)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 global::Well_Played.Models.Item data = args.NewValue as global::Well_Played.Models.Item;
                 if (args.NewValue != null && data == null)
                 {
                    throw new global::System.ArgumentException("Incorrect type passed into template. Based on the x:DataType global::Well_Played.Models.Item was expected.");
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
                        this.SetDataRoot(args.Item as global::Well_Played.Models.Item);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            ((global::Windows.UI.Xaml.Controls.StackPanel)args.ItemContainer.ContentTemplateRoot).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::Well_Played.Models.Item) args.Item, 1 << (int)args.Phase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
            }

            // IItems_Bindings

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

            // Items_obj8_Bindings

            public void SetDataRoot(global::Well_Played.Models.Item newDataRoot)
            {
                this.dataRoot = newDataRoot;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Well_Played.Models.Item obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_name(obj.name, phase);
                        this.Update_imageURL(obj.imageURL, phase);
                    }
                }
            }
            private void Update_name(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj9, obj, null);
                }
            }
            private void Update_imageURL(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Image_Source(this.obj10, (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), obj), null);
                }
            }
        }

        private class Items_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IItems_Bindings
        {
            private global::Well_Played.Items dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.GridView obj7;

            public Items_obj1_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 7:
                        this.obj7 = (global::Windows.UI.Xaml.Controls.GridView)target;
                        break;
                    default:
                        break;
                }
            }

            // IItems_Bindings

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

            // Items_obj1_Bindings

            public void SetDataRoot(global::Well_Played.Items newDataRoot)
            {
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Well_Played.Items obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_LeagueItems(obj.LeagueItems, phase);
                    }
                }
            }
            private void Update_LeagueItems(global::System.Collections.ObjectModel.ObservableCollection<global::Well_Played.Models.Item> obj, int phase)
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
                    #line 11 "..\..\..\Items.xaml"
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
                    this.ItemGridAdSpace = (global::Windows.UI.Xaml.Controls.GridView)(target);
                    #line 226 "..\..\..\Items.xaml"
                    ((global::Windows.UI.Xaml.Controls.GridView)this.ItemGridAdSpace).ItemClick += this.MasterGridView_ItemClick;
                    #line default
                }
                break;
            case 11:
                {
                    this.TitleBar = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 12:
                {
                    this.MyProgressRing = (global::Windows.UI.Xaml.Controls.ProgressRing)(target);
                }
                break;
            case 13:
                {
                    this.Error = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 174 "..\..\..\Items.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Error).Click += this.Error_Click;
                    #line default
                }
                break;
            case 14:
                {
                    this.Refresh = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 76 "..\..\..\Items.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.Refresh).Click += this.Refresh_Click;
                    #line default
                }
                break;
            case 15:
                {
                    this.Search = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                }
                break;
            case 16:
                {
                    this.FilterFlyout = (global::Windows.UI.Xaml.Controls.Flyout)(target);
                    #line 80 "..\..\..\Items.xaml"
                    ((global::Windows.UI.Xaml.Controls.Flyout)this.FilterFlyout).Opened += this.FilterFlyout_Opened;
                    #line default
                }
                break;
            case 17:
                {
                    this.___No_Name_ = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 18:
                {
                    this.SRFilterGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    #line 93 "..\..\..\Items.xaml"
                    ((global::Windows.UI.Xaml.Controls.Grid)this.SRFilterGrid).Tapped += this.SRFilterGrid_Tapped;
                    #line default
                }
                break;
            case 19:
                {
                    this.TTFilterGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    #line 100 "..\..\..\Items.xaml"
                    ((global::Windows.UI.Xaml.Controls.Grid)this.TTFilterGrid).Tapped += this.TTFilterGrid_Tapped;
                    #line default
                }
                break;
            case 20:
                {
                    this.HAFilterGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    #line 107 "..\..\..\Items.xaml"
                    ((global::Windows.UI.Xaml.Controls.Grid)this.HAFilterGrid).Tapped += this.HAFilterGrid_Tapped;
                    #line default
                }
                break;
            case 21:
                {
                    this.CSFilterGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    #line 114 "..\..\..\Items.xaml"
                    ((global::Windows.UI.Xaml.Controls.Grid)this.CSFilterGrid).Tapped += this.CSFilterGrid_Tapped;
                    #line default
                }
                break;
            case 22:
                {
                    this.Movement = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    #line 144 "..\..\..\Items.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.Movement).Checked += this.Movement_Checked;
                    #line 144 "..\..\..\Items.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.Movement).Unchecked += this.Movement_Unchecked;
                    #line default
                }
                break;
            case 23:
                {
                    this.ConsumableChkBox = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    #line 145 "..\..\..\Items.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.ConsumableChkBox).Checked += this.ConsumableChkBox_Checked;
                    #line 145 "..\..\..\Items.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.ConsumableChkBox).Unchecked += this.ConsumableChkBox_Unchecked;
                    #line default
                }
                break;
            case 24:
                {
                    this.GoldIncome = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    #line 146 "..\..\..\Items.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.GoldIncome).Checked += this.GoldIncome_Checked;
                    #line 146 "..\..\..\Items.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.GoldIncome).Unchecked += this.GoldIncome_Unchecked;
                    #line default
                }
                break;
            case 25:
                {
                    this.Vision = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    #line 147 "..\..\..\Items.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.Vision).Checked += this.Vision_Checked;
                    #line 147 "..\..\..\Items.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.Vision).Unchecked += this.Vision_Unchecked;
                    #line default
                }
                break;
            case 26:
                {
                    this.HealthChkBox = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    #line 137 "..\..\..\Items.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.HealthChkBox).Checked += this.HealthChkBox_Checked;
                    #line 137 "..\..\..\Items.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.HealthChkBox).Unchecked += this.HealthChkBox_Unchecked;
                    #line default
                }
                break;
            case 27:
                {
                    this.MRChkBox = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    #line 138 "..\..\..\Items.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.MRChkBox).Checked += this.MRChkBox_Checked;
                    #line 138 "..\..\..\Items.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.MRChkBox).Unchecked += this.MRChkBox_Unchecked;
                    #line default
                }
                break;
            case 28:
                {
                    this.HealthRegenChkBox = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    #line 139 "..\..\..\Items.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.HealthRegenChkBox).Checked += this.HealthRegenChkBox_Checked;
                    #line 139 "..\..\..\Items.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.HealthRegenChkBox).Unchecked += this.HealthRegenChkBox_Unchecked;
                    #line default
                }
                break;
            case 29:
                {
                    this.ArmorChkBox = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    #line 140 "..\..\..\Items.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.ArmorChkBox).Checked += this.ArmorChkBox_Checked;
                    #line 140 "..\..\..\Items.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.ArmorChkBox).Unchecked += this.ArmorChkBox_Unchecked;
                    #line default
                }
                break;
            case 30:
                {
                    this.APChkBox = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    #line 130 "..\..\..\Items.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.APChkBox).Checked += this.APChkBox_Checked;
                    #line 130 "..\..\..\Items.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.APChkBox).Unchecked += this.APChkBox_Unchecked;
                    #line default
                }
                break;
            case 31:
                {
                    this.CDRChkBox = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    #line 131 "..\..\..\Items.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.CDRChkBox).Checked += this.CDRChkBox_Checked;
                    #line 131 "..\..\..\Items.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.CDRChkBox).Unchecked += this.CDRChkBox_Unchecked;
                    #line default
                }
                break;
            case 32:
                {
                    this.ManaChkBox = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    #line 132 "..\..\..\Items.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.ManaChkBox).Checked += this.ManaChkBox_Checked;
                    #line 132 "..\..\..\Items.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.ManaChkBox).Unchecked += this.ManaChkBox_Unchecked;
                    #line default
                }
                break;
            case 33:
                {
                    this.ManaRegenChkBox = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    #line 133 "..\..\..\Items.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.ManaRegenChkBox).Checked += this.ManaRegenChkBox_Checked;
                    #line 133 "..\..\..\Items.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.ManaRegenChkBox).Unchecked += this.ManaRegenChkBox_Unchecked;
                    #line default
                }
                break;
            case 34:
                {
                    this.DamageChkBox = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    #line 123 "..\..\..\Items.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.DamageChkBox).Checked += this.DamageChkBox_Checked;
                    #line 123 "..\..\..\Items.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.DamageChkBox).Unchecked += this.DamageChkBox_Unchecked;
                    #line default
                }
                break;
            case 35:
                {
                    this.CritChkBox = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    #line 124 "..\..\..\Items.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.CritChkBox).Checked += this.CritChkBox_Checked;
                    #line 124 "..\..\..\Items.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.CritChkBox).Unchecked += this.CritChkBox_Unchecked;
                    #line default
                }
                break;
            case 36:
                {
                    this.ASChkBox = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    #line 125 "..\..\..\Items.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.ASChkBox).Checked += this.ASChkBox_Checked;
                    #line 125 "..\..\..\Items.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.ASChkBox).Unchecked += this.ASChkBox_Unchecked;
                    #line default
                }
                break;
            case 37:
                {
                    this.LSChkBox = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    #line 126 "..\..\..\Items.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.LSChkBox).Checked += this.LSChkBox_Checked;
                    #line 126 "..\..\..\Items.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.LSChkBox).Unchecked += this.LSChkBox_Unchecked;
                    #line default
                }
                break;
            case 38:
                {
                    this.CSFilter = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 39:
                {
                    this.HAFilter = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 40:
                {
                    this.TTFilter = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 41:
                {
                    this.SRFilter = (global::Windows.UI.Xaml.Controls.Button)(target);
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
                    Items_obj1_Bindings bindings = new Items_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            case 8:
                {
                    global::Windows.UI.Xaml.Controls.StackPanel element8 = (global::Windows.UI.Xaml.Controls.StackPanel)target;
                    Items_obj8_Bindings bindings = new Items_obj8_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot((global::Well_Played.Models.Item) element8.DataContext);
                    element8.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element8, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

