﻿#pragma checksum "C:\Users\kobe9\source\repos\Xaml-Controls-Gallery\XamlControlsGallery\ControlPages\ButtonPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "835F92BBAC3DE9528915FC5B375E96C7F49DFEF3A0D0F70D929A3C5C3E3961FD"
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
    partial class ButtonPage : 
        global::Microsoft.UI.Xaml.Controls.Page, 
        global::Microsoft.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Microsoft_UI_Xaml_Controls_FontIcon_FontWeight(global::Microsoft.UI.Xaml.Controls.FontIcon obj, global::Windows.UI.Text.FontWeight value)
            {
                obj.FontWeight = value;
            }
            public static void Set_AppUIBasics_ControlExampleSubstitution_IsEnabled(global::AppUIBasics.ControlExampleSubstitution obj, global::System.Boolean value)
            {
                obj.IsEnabled = value;
            }
            public static void Set_Microsoft_UI_Xaml_Controls_Control_IsEnabled(global::Microsoft.UI.Xaml.Controls.Control obj, global::System.Boolean value)
            {
                obj.IsEnabled = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class ButtonPage_obj1_Bindings :
            global::Microsoft.UI.Xaml.Markup.IComponentConnector,
            IButtonPage_Bindings
        {
            private global::AppUIBasics.ControlPages.ButtonPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Microsoft.UI.Xaml.Controls.FontIcon obj7;
            private global::Microsoft.UI.Xaml.Controls.Button obj10;
            private global::AppUIBasics.ControlExampleSubstitution obj13;

            private ButtonPage_obj1_BindingsTracking bindingsTracking;

            public ButtonPage_obj1_Bindings()
            {
                this.bindingsTracking = new ButtonPage_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 7: // ControlPages\ButtonPage.xaml line 141
                        this.obj7 = (Microsoft.UI.Xaml.Controls.FontIcon)target;
                        break;
                    case 10: // ControlPages\ButtonPage.xaml line 22
                        this.obj10 = (Microsoft.UI.Xaml.Controls.Button)target;
                        break;
                    case 13: // ControlPages\ButtonPage.xaml line 39
                        this.obj13 = (AppUIBasics.ControlExampleSubstitution)target;
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

            // IButtonPage_Bindings

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
                    this.dataRoot = (AppUIBasics.ControlPages.ButtonPage)newDataRoot;
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

            private delegate void InvokeFunctionDelegate(int phase);
            private global::System.Collections.Generic.Dictionary<string, InvokeFunctionDelegate> PendingFunctionBindings = new global::System.Collections.Generic.Dictionary<string, InvokeFunctionDelegate>();

            private void Invoke_DisableButton1_IsChecked_Value_M_Equals_3875955625(int phase)
            {
                global::System.Boolean p0 = false;
                global::System.Boolean result = this.dataRoot.DisableButton1.IsChecked.Value.Equals(p0);
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // ControlPages\ButtonPage.xaml line 22
                    XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_Control_IsEnabled(this.obj10, result);
                }
            }

            private void CompleteUpdate(int phase)
            {
                var functions = this.PendingFunctionBindings;
                this.PendingFunctionBindings = new global::System.Collections.Generic.Dictionary<string, InvokeFunctionDelegate>();
                foreach (var function in functions.Values)
                {
                    function.Invoke(phase);
                }
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::AppUIBasics.ControlPages.ButtonPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_FontWeight(obj.FontWeight, phase);
                    }
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_DisableButton1(obj.DisableButton1, phase);
                    }
                }
                this.CompleteUpdate(phase);
            }
            private void Update_FontWeight(global::Windows.UI.Text.FontWeight obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // ControlPages\ButtonPage.xaml line 141
                    XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_FontIcon_FontWeight(this.obj7, obj);
                }
            }
            private void Update_DisableButton1(global::Microsoft.UI.Xaml.Controls.CheckBox obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_DisableButton1(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_DisableButton1_IsChecked(obj.IsChecked, phase);
                    }
                }
            }
            private void Update_DisableButton1_IsChecked(global::System.Nullable<global::System.Boolean> obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_DisableButton1_IsChecked_Value(obj.Value, phase);
                    }
                }
            }
            private void Update_DisableButton1_IsChecked_Value(global::System.Boolean obj, int phase)
            {
                if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                {
                    this.Update_DisableButton1_IsChecked_Value_M_Equals_3875955625(phase);
                }
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // ControlPages\ButtonPage.xaml line 39
                    XamlBindingSetters.Set_AppUIBasics_ControlExampleSubstitution_IsEnabled(this.obj13, obj);
                }
            }
            private void Update_DisableButton1_IsChecked_Value_M_Equals_3875955625(int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    this.PendingFunctionBindings["DisableButton1_IsChecked_Value_M_Equals_3875955625"] = new InvokeFunctionDelegate(this.Invoke_DisableButton1_IsChecked_Value_M_Equals_3875955625); 
                }
            }
 

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 0.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class ButtonPage_obj1_BindingsTracking
            {
                private global::System.WeakReference<ButtonPage_obj1_Bindings> weakRefToBindingObj; 

                public ButtonPage_obj1_BindingsTracking(ButtonPage_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<ButtonPage_obj1_Bindings>(obj);
                }

                public ButtonPage_obj1_Bindings TryGetBindingObject()
                {
                    ButtonPage_obj1_Bindings bindingObject = null;
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
                    UpdateChildListeners_DisableButton1(null);
                }

                public void DependencyPropertyChanged_DisableButton1_IsChecked(global::Microsoft.UI.Xaml.DependencyObject sender, global::Microsoft.UI.Xaml.DependencyProperty prop)
                {
                    ButtonPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::Microsoft.UI.Xaml.Controls.CheckBox obj = sender as global::Microsoft.UI.Xaml.Controls.CheckBox;
                        if (obj != null)
                        {
                            bindings.Update_DisableButton1_IsChecked(obj.IsChecked, DATA_CHANGED);
                        }
                        bindings.CompleteUpdate(DATA_CHANGED);
                    }
                }
                private global::Microsoft.UI.Xaml.Controls.CheckBox cache_DisableButton1 = null;
                private long tokenDPC_DisableButton1_IsChecked = 0;
                public void UpdateChildListeners_DisableButton1(global::Microsoft.UI.Xaml.Controls.CheckBox obj)
                {
                    if (obj != cache_DisableButton1)
                    {
                        if (cache_DisableButton1 != null)
                        {
                            cache_DisableButton1.UnregisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton.IsCheckedProperty, tokenDPC_DisableButton1_IsChecked);
                            cache_DisableButton1 = null;
                        }
                        if (obj != null)
                        {
                            cache_DisableButton1 = obj;
                            tokenDPC_DisableButton1_IsChecked = obj.RegisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton.IsCheckedProperty, DependencyPropertyChanged_DisableButton1_IsChecked);
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
            case 2: // ControlPages\ButtonPage.xaml line 19
                {
                    this.Example1 = (AppUIBasics.ControlExample)target;
                }
                break;
            case 3: // ControlPages\ButtonPage.xaml line 43
                {
                    this.Example2 = (AppUIBasics.ControlExample)target;
                }
                break;
            case 4: // ControlPages\ButtonPage.xaml line 80
                {
                    this.Example3 = (AppUIBasics.ControlExample)target;
                }
                break;
            case 5: // ControlPages\ButtonPage.xaml line 83
                {
                    this.Button3 = (Microsoft.UI.Xaml.Controls.Button)target;
                    ((global::Microsoft.UI.Xaml.Controls.Button)this.Button3).Click += this.Button_Click;
                }
                break;
            case 6: // ControlPages\ButtonPage.xaml line 146
                {
                    this.Control3Output = (Microsoft.UI.Xaml.Controls.TextBlock)target;
                }
                break;
            case 8: // ControlPages\ButtonPage.xaml line 46
                {
                    this.Button2 = (Microsoft.UI.Xaml.Controls.Button)target;
                    ((global::Microsoft.UI.Xaml.Controls.Button)this.Button2).Click += this.Button_Click;
                }
                break;
            case 9: // ControlPages\ButtonPage.xaml line 49
                {
                    this.Control2Output = (Microsoft.UI.Xaml.Controls.TextBlock)target;
                }
                break;
            case 10: // ControlPages\ButtonPage.xaml line 22
                {
                    this.Button1 = (Microsoft.UI.Xaml.Controls.Button)target;
                    ((global::Microsoft.UI.Xaml.Controls.Button)this.Button1).Click += this.Button_Click;
                }
                break;
            case 11: // ControlPages\ButtonPage.xaml line 24
                {
                    this.Control1Output = (Microsoft.UI.Xaml.Controls.TextBlock)target;
                }
                break;
            case 12: // ControlPages\ButtonPage.xaml line 30
                {
                    this.DisableButton1 = (Microsoft.UI.Xaml.Controls.CheckBox)target;
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
            case 1: // ControlPages\ButtonPage.xaml line 12
                {                    
                    global::Microsoft.UI.Xaml.Controls.Page element1 = (global::Microsoft.UI.Xaml.Controls.Page)target;
                    ButtonPage_obj1_Bindings bindings = new ButtonPage_obj1_Bindings();
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

