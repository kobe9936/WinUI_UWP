﻿#pragma checksum "C:\Users\kobe9\source\repos\WinUI_UWP\XamlControlsGallery\SearchResultsPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "605047A4680AADC98602A31E204BF45F59F94C098A284933E6AF5E1B839A9749"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppUIBasics
{
    partial class SearchResultsPage : 
        global::AppUIBasics.ItemsPageBase, 
        global::Microsoft.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Microsoft_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Microsoft.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
            public static void Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(global::Microsoft.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class SearchResultsPage_obj11_Bindings :
            global::Microsoft.UI.Xaml.IDataTemplateExtension,
            global::Microsoft.UI.Xaml.Markup.IDataTemplateComponent,
            global::Microsoft.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Microsoft.UI.Xaml.Markup.IComponentConnector,
            ISearchResultsPage_Bindings
        {
            private global::AppUIBasics.Filter dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::System.WeakReference<global::Microsoft.UI.Xaml.Controls.TextBlock> obj11;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj11TextDisabled = false;

            public SearchResultsPage_obj11_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 55 && columnNumber == 32)
                {
                    isobj11TextDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 11: // SearchResultsPage.xaml line 55
                        this.obj11 = new global::System.WeakReference<global::Microsoft.UI.Xaml.Controls.TextBlock>((Microsoft.UI.Xaml.Controls.TextBlock)target);
                        break;
                    default:
                        break;
                }
            }
                        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 0.0.0.0")]
                        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
                        public global::Microsoft.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target) 
                        {
                            return null;
                        }

            public void DataContextChangedHandler(global::Microsoft.UI.Xaml.FrameworkElement sender, global::Microsoft.UI.Xaml.DataContextChangedEventArgs args)
            {
                 if (this.SetDataRoot(args.NewValue))
                 {
                    this.Update();
                 }
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Microsoft.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                ProcessBindings(args.Item, args.ItemIndex, (int)args.Phase, out nextPhase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
                Recycle();
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
                switch(phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(item);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            (GetWeakRefTarget(this.obj11) as global::Microsoft.UI.Xaml.Controls.TextBlock).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((AppUIBasics.Filter)item, 1 << phase);
            }

            public void Recycle()
            {
            }

            // ISearchResultsPage_Bindings

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

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (AppUIBasics.Filter)newDataRoot;
                    return true;
                }
                return false;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::AppUIBasics.Filter obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_Description(obj.Description, phase);
                    }
                }
            }
            private void Update_Description(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // SearchResultsPage.xaml line 55
                    if (!isobj11TextDisabled)
                    {
                        if ((GetWeakRefTarget(this.obj11) as global::Microsoft.UI.Xaml.Controls.TextBlock) != null)
                        {
                            XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text((GetWeakRefTarget(this.obj11) as global::Microsoft.UI.Xaml.Controls.TextBlock), obj, null);
                        }
                    }
                }
            }
 
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class SearchResultsPage_obj13_Bindings :
            global::Microsoft.UI.Xaml.IDataTemplateExtension,
            global::Microsoft.UI.Xaml.Markup.IDataTemplateComponent,
            global::Microsoft.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Microsoft.UI.Xaml.Markup.IComponentConnector,
            ISearchResultsPage_Bindings
        {
            private global::AppUIBasics.Filter dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::System.WeakReference<global::Microsoft.UI.Xaml.Controls.UserControl> obj13;
            private global::Microsoft.UI.Xaml.Controls.GridView obj14;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj14ItemsSourceDisabled = false;

            public SearchResultsPage_obj13_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 73 && columnNumber == 29)
                {
                    isobj14ItemsSourceDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 13: // SearchResultsPage.xaml line 60
                        this.obj13 = new global::System.WeakReference<global::Microsoft.UI.Xaml.Controls.UserControl>((Microsoft.UI.Xaml.Controls.UserControl)target);
                        break;
                    case 14: // SearchResultsPage.xaml line 61
                        this.obj14 = (Microsoft.UI.Xaml.Controls.GridView)target;
                        break;
                    default:
                        break;
                }
            }
                        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 0.0.0.0")]
                        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
                        public global::Microsoft.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target) 
                        {
                            return null;
                        }

            public void DataContextChangedHandler(global::Microsoft.UI.Xaml.FrameworkElement sender, global::Microsoft.UI.Xaml.DataContextChangedEventArgs args)
            {
                 if (this.SetDataRoot(args.NewValue))
                 {
                    this.Update();
                 }
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Microsoft.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                ProcessBindings(args.Item, args.ItemIndex, (int)args.Phase, out nextPhase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
                Recycle();
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
                switch(phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(item);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            (GetWeakRefTarget(this.obj13) as global::Microsoft.UI.Xaml.Controls.UserControl).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((AppUIBasics.Filter)item, 1 << phase);
            }

            public void Recycle()
            {
            }

            // ISearchResultsPage_Bindings

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

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (AppUIBasics.Filter)newDataRoot;
                    return true;
                }
                return false;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::AppUIBasics.Filter obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_Items(obj.Items, phase);
                    }
                }
            }
            private void Update_Items(global::System.Collections.Generic.List<global::AppUIBasics.Data.ControlInfoDataItem> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // SearchResultsPage.xaml line 61
                    if (!isobj14ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj14, obj, null);
                    }
                }
            }
 
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class SearchResultsPage_obj1_Bindings :
            global::Microsoft.UI.Xaml.Markup.IDataTemplateComponent,
            global::Microsoft.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Microsoft.UI.Xaml.Markup.IComponentConnector,
            ISearchResultsPage_Bindings
        {
            private global::AppUIBasics.SearchResultsPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Microsoft.UI.Xaml.Controls.Pivot obj8;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj8ItemsSourceDisabled = false;

            private SearchResultsPage_obj1_BindingsTracking bindingsTracking;

            public SearchResultsPage_obj1_Bindings()
            {
                this.bindingsTracking = new SearchResultsPage_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 51 && columnNumber == 13)
                {
                    isobj8ItemsSourceDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 8: // SearchResultsPage.xaml line 48
                        this.obj8 = (Microsoft.UI.Xaml.Controls.Pivot)target;
                        break;
                    default:
                        break;
                }
            }
                        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 0.0.0.0")]
                        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
                        public global::Microsoft.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target) 
                        {
                            return null;
                        }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
            }

            public void Recycle()
            {
                return;
            }

            // ISearchResultsPage_Bindings

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
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = (AppUIBasics.SearchResultsPage)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Activated(object obj, global::Microsoft.UI.Xaml.WindowActivatedEventArgs data)
            {
                this.Initialize();
            }

            public void Loading(global::Microsoft.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::AppUIBasics.SearchResultsPage obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_Filters(obj.Filters, phase);
                    }
                }
            }
            private void Update_Filters(global::System.Collections.Generic.IEnumerable<global::AppUIBasics.Filter> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // SearchResultsPage.xaml line 48
                    if (!isobj8ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj8, obj, null);
                    }
                }
            }
 

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 0.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class SearchResultsPage_obj1_BindingsTracking
            {
                private global::System.WeakReference<SearchResultsPage_obj1_Bindings> weakRefToBindingObj; 

                public SearchResultsPage_obj1_BindingsTracking(SearchResultsPage_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<SearchResultsPage_obj1_Bindings>(obj);
                }

                public SearchResultsPage_obj1_Bindings TryGetBindingObject()
                {
                    SearchResultsPage_obj1_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_(null);
                }

                public void PropertyChanged_(object sender, global::Microsoft.UI.Xaml.Data.PropertyChangedEventArgs e)
                {
                    SearchResultsPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::AppUIBasics.SearchResultsPage obj = sender as global::AppUIBasics.SearchResultsPage;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_Filters(obj.Filters, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "Filters":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_Filters(obj.Filters, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                public void UpdateChildListeners_(global::AppUIBasics.SearchResultsPage obj)
                {
                    SearchResultsPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        if (bindings.dataRoot != null)
                        {
                            ((global::Microsoft.UI.Xaml.Data.INotifyPropertyChanged)bindings.dataRoot).PropertyChanged -= PropertyChanged_;
                        }
                        if (obj != null)
                        {
                            bindings.dataRoot = obj;
                            ((global::Microsoft.UI.Xaml.Data.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// GetWeakRefTarget()
        /// </summary>
        private static T GetWeakRefTarget<T>(global::System.WeakReference<T> weakRef) where T : class
        {
            if (weakRef.TryGetTarget(out T weakRefValue))
            {
                return weakRefValue;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // SearchResultsPage.xaml line 20
                {
                    this.ResultStates = (Microsoft.UI.Xaml.VisualStateGroup)target;
                }
                break;
            case 3: // SearchResultsPage.xaml line 30
                {
                    this.LayoutVisualStates = (Microsoft.UI.Xaml.VisualStateGroup)target;
                }
                break;
            case 4: // SearchResultsPage.xaml line 31
                {
                    this.WideLayout = (Microsoft.UI.Xaml.VisualState)target;
                }
                break;
            case 5: // SearchResultsPage.xaml line 36
                {
                    this.NarrowLayout = (Microsoft.UI.Xaml.VisualState)target;
                }
                break;
            case 6: // SearchResultsPage.xaml line 21
                {
                    this.ResultsFound = (Microsoft.UI.Xaml.VisualState)target;
                }
                break;
            case 7: // SearchResultsPage.xaml line 23
                {
                    this.NoResultsFound = (Microsoft.UI.Xaml.VisualState)target;
                }
                break;
            case 8: // SearchResultsPage.xaml line 48
                {
                    this.resultsPivot = (Microsoft.UI.Xaml.Controls.Pivot)target;
                    ((global::Microsoft.UI.Xaml.Controls.Pivot)this.resultsPivot).Loaded += this.OnResultsPivotLoaded;
                }
                break;
            case 9: // SearchResultsPage.xaml line 104
                {
                    this.noResultsTextBlock = (Microsoft.UI.Xaml.Controls.TextBlock)target;
                }
                break;
            case 14: // SearchResultsPage.xaml line 61
                {
                    global::Microsoft.UI.Xaml.Controls.GridView element14 = (Microsoft.UI.Xaml.Controls.GridView)target;
                    ((global::Microsoft.UI.Xaml.Controls.GridView)element14).ContainerContentChanging += this.OnItemGridViewContainerContentChanging;
                    ((global::Microsoft.UI.Xaml.Controls.GridView)element14).ItemClick += this.OnItemGridViewItemClick;
                    ((global::Microsoft.UI.Xaml.Controls.GridView)element14).KeyDown += this.OnItemGridViewKeyDown;
                    ((global::Microsoft.UI.Xaml.Controls.GridView)element14).Loaded += this.OnItemGridViewLoaded;
                    ((global::Microsoft.UI.Xaml.Controls.GridView)element14).SizeChanged += this.OnItemGridViewSizeChanged;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Microsoft.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Microsoft.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // SearchResultsPage.xaml line 1
                {                    
                    global::AppUIBasics.ItemsPageBase element1 = (global::AppUIBasics.ItemsPageBase)target;
                    SearchResultsPage_obj1_Bindings bindings = new SearchResultsPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            case 11: // SearchResultsPage.xaml line 55
                {                    
                    global::Microsoft.UI.Xaml.Controls.TextBlock element11 = (global::Microsoft.UI.Xaml.Controls.TextBlock)target;
                    SearchResultsPage_obj11_Bindings bindings = new SearchResultsPage_obj11_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(element11.DataContext);
                    element11.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Microsoft.UI.Xaml.DataTemplate.SetExtensionInstance(element11, bindings);
                    global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element11, bindings);
                }
                break;
            case 13: // SearchResultsPage.xaml line 60
                {                    
                    global::Microsoft.UI.Xaml.Controls.UserControl element13 = (global::Microsoft.UI.Xaml.Controls.UserControl)target;
                    SearchResultsPage_obj13_Bindings bindings = new SearchResultsPage_obj13_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(element13.DataContext);
                    element13.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Microsoft.UI.Xaml.DataTemplate.SetExtensionInstance(element13, bindings);
                    global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element13, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

