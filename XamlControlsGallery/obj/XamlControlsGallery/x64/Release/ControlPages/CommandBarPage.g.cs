﻿#pragma checksum "C:\Users\kobe9\source\repos\Xaml-Controls-Gallery\XamlControlsGallery\ControlPages\CommandBarPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8896E369FF347AB1FEE5E5256C429E7C276908C42FE9C56D15AD519E6FB86FC9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppUIBasics.ControlPages
{
    partial class CommandBarPage : 
        global::Microsoft.UI.Xaml.Controls.Page, 
        global::Microsoft.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_AppUIBasics_ControlExampleSubstitution_Value(global::AppUIBasics.ControlExampleSubstitution obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.Value = value;
            }
            public static void Set_AppUIBasics_ControlExampleSubstitution_IsEnabled(global::AppUIBasics.ControlExampleSubstitution obj, global::System.Boolean value)
            {
                obj.IsEnabled = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class CommandBarPage_obj1_Bindings :
            global::Microsoft.UI.Xaml.Markup.IComponentConnector,
            ICommandBarPage_Bindings
        {
            private global::AppUIBasics.ControlPages.CommandBarPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::AppUIBasics.ControlExampleSubstitution obj12;
            private global::AppUIBasics.ControlExampleSubstitution obj13;
            private global::AppUIBasics.ControlExampleSubstitution obj14;

            private CommandBarPage_obj1_BindingsTracking bindingsTracking;

            public CommandBarPage_obj1_Bindings()
            {
                this.bindingsTracking = new CommandBarPage_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 12: // ControlPages\CommandBarPage.xaml line 90
                        this.obj12 = (AppUIBasics.ControlExampleSubstitution)target;
                        break;
                    case 13: // ControlPages\CommandBarPage.xaml line 91
                        this.obj13 = (AppUIBasics.ControlExampleSubstitution)target;
                        break;
                    case 14: // ControlPages\CommandBarPage.xaml line 92
                        this.obj14 = (AppUIBasics.ControlExampleSubstitution)target;
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

            // ICommandBarPage_Bindings

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
                    this.dataRoot = (AppUIBasics.ControlPages.CommandBarPage)newDataRoot;
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
            private void Update_(global::AppUIBasics.ControlPages.CommandBarPage obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_PrimaryCommandBar(obj.PrimaryCommandBar, phase);
                        this.Update_MultipleButtons(obj.MultipleButtons, phase);
                    }
                }
            }
            private void Update_PrimaryCommandBar(global::Microsoft.UI.Xaml.Controls.CommandBar obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_PrimaryCommandBar(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_PrimaryCommandBar_IsOpen(obj.IsOpen, phase);
                        this.Update_PrimaryCommandBar_IsSticky(obj.IsSticky, phase);
                    }
                }
            }
            private void Update_PrimaryCommandBar_IsOpen(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // ControlPages\CommandBarPage.xaml line 90
                    XamlBindingSetters.Set_AppUIBasics_ControlExampleSubstitution_Value(this.obj12, obj, null);
                }
            }
            private void Update_PrimaryCommandBar_IsSticky(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // ControlPages\CommandBarPage.xaml line 91
                    XamlBindingSetters.Set_AppUIBasics_ControlExampleSubstitution_IsEnabled(this.obj13, obj);
                }
            }
            private void Update_MultipleButtons(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // ControlPages\CommandBarPage.xaml line 92
                    XamlBindingSetters.Set_AppUIBasics_ControlExampleSubstitution_IsEnabled(this.obj14, obj);
                }
            }
 

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 0.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class CommandBarPage_obj1_BindingsTracking
            {
                private global::System.WeakReference<CommandBarPage_obj1_Bindings> weakRefToBindingObj; 

                public CommandBarPage_obj1_BindingsTracking(CommandBarPage_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<CommandBarPage_obj1_Bindings>(obj);
                }

                public CommandBarPage_obj1_Bindings TryGetBindingObject()
                {
                    CommandBarPage_obj1_Bindings bindingObject = null;
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
                    UpdateChildListeners_PrimaryCommandBar(null);
                }

                public void PropertyChanged_(object sender, global::Microsoft.UI.Xaml.Data.PropertyChangedEventArgs e)
                {
                    CommandBarPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::AppUIBasics.ControlPages.CommandBarPage obj = sender as global::AppUIBasics.ControlPages.CommandBarPage;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_PrimaryCommandBar(obj.PrimaryCommandBar, DATA_CHANGED);
                                bindings.Update_MultipleButtons(obj.MultipleButtons, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "MultipleButtons":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_MultipleButtons(obj.MultipleButtons, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                public void UpdateChildListeners_(global::AppUIBasics.ControlPages.CommandBarPage obj)
                {
                    CommandBarPage_obj1_Bindings bindings = TryGetBindingObject();
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
                public void DependencyPropertyChanged_PrimaryCommandBar_IsOpen(global::Microsoft.UI.Xaml.DependencyObject sender, global::Microsoft.UI.Xaml.DependencyProperty prop)
                {
                    CommandBarPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::Microsoft.UI.Xaml.Controls.CommandBar obj = sender as global::Microsoft.UI.Xaml.Controls.CommandBar;
                        if (obj != null)
                        {
                            bindings.Update_PrimaryCommandBar_IsOpen(obj.IsOpen, DATA_CHANGED);
                        }
                    }
                }
                public void DependencyPropertyChanged_PrimaryCommandBar_IsSticky(global::Microsoft.UI.Xaml.DependencyObject sender, global::Microsoft.UI.Xaml.DependencyProperty prop)
                {
                    CommandBarPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::Microsoft.UI.Xaml.Controls.CommandBar obj = sender as global::Microsoft.UI.Xaml.Controls.CommandBar;
                        if (obj != null)
                        {
                            bindings.Update_PrimaryCommandBar_IsSticky(obj.IsSticky, DATA_CHANGED);
                        }
                    }
                }
                private global::Microsoft.UI.Xaml.Controls.CommandBar cache_PrimaryCommandBar = null;
                private long tokenDPC_PrimaryCommandBar_IsOpen = 0;
                private long tokenDPC_PrimaryCommandBar_IsSticky = 0;
                public void UpdateChildListeners_PrimaryCommandBar(global::Microsoft.UI.Xaml.Controls.CommandBar obj)
                {
                    if (obj != cache_PrimaryCommandBar)
                    {
                        if (cache_PrimaryCommandBar != null)
                        {
                            cache_PrimaryCommandBar.UnregisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.AppBar.IsOpenProperty, tokenDPC_PrimaryCommandBar_IsOpen);
                            cache_PrimaryCommandBar.UnregisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.AppBar.IsStickyProperty, tokenDPC_PrimaryCommandBar_IsSticky);
                            cache_PrimaryCommandBar = null;
                        }
                        if (obj != null)
                        {
                            cache_PrimaryCommandBar = obj;
                            tokenDPC_PrimaryCommandBar_IsOpen = obj.RegisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.AppBar.IsOpenProperty, DependencyPropertyChanged_PrimaryCommandBar_IsOpen);
                            tokenDPC_PrimaryCommandBar_IsSticky = obj.RegisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.AppBar.IsStickyProperty, DependencyPropertyChanged_PrimaryCommandBar_IsSticky);
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
            case 2: // ControlPages\CommandBarPage.xaml line 46
                {
                    this.Example3 = (AppUIBasics.ControlExample)target;
                }
                break;
            case 3: // ControlPages\CommandBarPage.xaml line 48
                {
                    this.PrimaryCommandBar = (Microsoft.UI.Xaml.Controls.CommandBar)target;
                }
                break;
            case 4: // ControlPages\CommandBarPage.xaml line 49
                {
                    this.addButton = (Microsoft.UI.Xaml.Controls.AppBarButton)target;
                }
                break;
            case 5: // ControlPages\CommandBarPage.xaml line 50
                {
                    this.shareButton = (Microsoft.UI.Xaml.Controls.AppBarButton)target;
                }
                break;
            case 6: // ControlPages\CommandBarPage.xaml line 51
                {
                    this.editButton = (Microsoft.UI.Xaml.Controls.AppBarButton)target;
                }
                break;
            case 7: // ControlPages\CommandBarPage.xaml line 53
                {
                    this.settingsButton = (Microsoft.UI.Xaml.Controls.AppBarButton)target;
                }
                break;
            case 8: // ControlPages\CommandBarPage.xaml line 65
                {
                    global::Microsoft.UI.Xaml.Controls.Button element8 = (Microsoft.UI.Xaml.Controls.Button)target;
                    ((global::Microsoft.UI.Xaml.Controls.Button)element8).Click += this.OpenButton_Click;
                }
                break;
            case 9: // ControlPages\CommandBarPage.xaml line 66
                {
                    global::Microsoft.UI.Xaml.Controls.Button element9 = (Microsoft.UI.Xaml.Controls.Button)target;
                    ((global::Microsoft.UI.Xaml.Controls.Button)element9).Click += this.CloseButton_Click;
                }
                break;
            case 10: // ControlPages\CommandBarPage.xaml line 68
                {
                    global::Microsoft.UI.Xaml.Controls.Button element10 = (Microsoft.UI.Xaml.Controls.Button)target;
                    ((global::Microsoft.UI.Xaml.Controls.Button)element10).Click += this.AddSecondaryCommands_Click;
                }
                break;
            case 11: // ControlPages\CommandBarPage.xaml line 69
                {
                    global::Microsoft.UI.Xaml.Controls.Button element11 = (Microsoft.UI.Xaml.Controls.Button)target;
                    ((global::Microsoft.UI.Xaml.Controls.Button)element11).Click += this.RemoveSecondaryCommands_Click;
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
            case 1: // ControlPages\CommandBarPage.xaml line 12
                {                    
                    global::Microsoft.UI.Xaml.Controls.Page element1 = (global::Microsoft.UI.Xaml.Controls.Page)target;
                    CommandBarPage_obj1_Bindings bindings = new CommandBarPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            }
            return returnValue;
        }
    }
}

