﻿#pragma checksum "C:\Users\kobe9\source\repos\Xaml-Controls-Gallery\XamlControlsGallery\ControlPages\RatingsControlPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "25CCFE9BA26E921A84A5C8ECFE6B859FF58F5F495CAE6D857B0F07021D2645D7"
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
    partial class RatingControlPage : 
        global::Microsoft.UI.Xaml.Controls.Page, 
        global::Microsoft.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Microsoft_UI_Xaml_Controls_RatingControl_PlaceholderValue(global::Microsoft.UI.Xaml.Controls.RatingControl obj, global::System.Double value)
            {
                obj.PlaceholderValue = value;
            }
            public static void Set_AppUIBasics_ControlExampleSubstitution_Value(global::AppUIBasics.ControlExampleSubstitution obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.Value = value;
            }
            public static void Set_Microsoft_UI_Xaml_Controls_RatingControl_IsClearEnabled(global::Microsoft.UI.Xaml.Controls.RatingControl obj, global::System.Boolean value)
            {
                obj.IsClearEnabled = value;
            }
            public static void Set_Microsoft_UI_Xaml_Controls_RatingControl_IsReadOnly(global::Microsoft.UI.Xaml.Controls.RatingControl obj, global::System.Boolean value)
            {
                obj.IsReadOnly = value;
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
        private class RatingControlPage_obj1_Bindings :
            global::Microsoft.UI.Xaml.Markup.IComponentConnector,
            IRatingControlPage_Bindings
        {
            private global::AppUIBasics.ControlPages.RatingControlPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Microsoft.UI.Xaml.Controls.RatingControl obj4;
            private global::AppUIBasics.ControlExampleSubstitution obj6;
            private global::Microsoft.UI.Xaml.Controls.RatingControl obj7;
            private global::Microsoft.UI.Xaml.Controls.TextBlock obj8;
            private global::AppUIBasics.ControlExampleSubstitution obj11;
            private global::AppUIBasics.ControlExampleSubstitution obj12;

            private RatingControlPage_obj1_BindingsTracking bindingsTracking;

            public RatingControlPage_obj1_Bindings()
            {
                this.bindingsTracking = new RatingControlPage_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 4: // ControlPages\RatingsControlPage.xaml line 41
                        this.obj4 = (Microsoft.UI.Xaml.Controls.RatingControl)target;
                        this.bindingsTracking.RegisterTwoWayListener_4(this.obj4);
                        break;
                    case 6: // ControlPages\RatingsControlPage.xaml line 57
                        this.obj6 = (AppUIBasics.ControlExampleSubstitution)target;
                        break;
                    case 7: // ControlPages\RatingsControlPage.xaml line 10
                        this.obj7 = (Microsoft.UI.Xaml.Controls.RatingControl)target;
                        break;
                    case 8: // ControlPages\RatingsControlPage.xaml line 16
                        this.obj8 = (Microsoft.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 11: // ControlPages\RatingsControlPage.xaml line 34
                        this.obj11 = (AppUIBasics.ControlExampleSubstitution)target;
                        break;
                    case 12: // ControlPages\RatingsControlPage.xaml line 35
                        this.obj12 = (AppUIBasics.ControlExampleSubstitution)target;
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

            // IRatingControlPage_Bindings

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
                    this.dataRoot = (AppUIBasics.ControlPages.RatingControlPage)newDataRoot;
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
            private void Update_(global::AppUIBasics.ControlPages.RatingControlPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_slider(obj.slider, phase);
                        this.Update_clearEnabledCheck(obj.clearEnabledCheck, phase);
                        this.Update_readOnlyCheck(obj.readOnlyCheck, phase);
                        this.Update_RatingControl1(obj.RatingControl1, phase);
                    }
                }
            }
            private void Update_slider(global::Microsoft.UI.Xaml.Controls.Slider obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_slider(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_slider_Value(obj.Value, phase);
                    }
                }
            }
            private void Update_slider_Value(global::System.Double obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // ControlPages\RatingsControlPage.xaml line 41
                    XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_RatingControl_PlaceholderValue(this.obj4, obj);
                    // ControlPages\RatingsControlPage.xaml line 57
                    XamlBindingSetters.Set_AppUIBasics_ControlExampleSubstitution_Value(this.obj6, obj, null);
                }
            }
            private void Update_clearEnabledCheck(global::Microsoft.UI.Xaml.Controls.CheckBox obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_clearEnabledCheck(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_clearEnabledCheck_IsChecked(obj.IsChecked, phase);
                    }
                }
            }
            private void Update_clearEnabledCheck_IsChecked(global::System.Nullable<global::System.Boolean> obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_clearEnabledCheck_IsChecked_Value(obj.Value, phase);
                    }
                }
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // ControlPages\RatingsControlPage.xaml line 34
                    XamlBindingSetters.Set_AppUIBasics_ControlExampleSubstitution_Value(this.obj11, obj, null);
                }
            }
            private void Update_clearEnabledCheck_IsChecked_Value(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // ControlPages\RatingsControlPage.xaml line 10
                    XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_RatingControl_IsClearEnabled(this.obj7, obj);
                }
            }
            private void Update_readOnlyCheck(global::Microsoft.UI.Xaml.Controls.CheckBox obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_readOnlyCheck(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_readOnlyCheck_IsChecked(obj.IsChecked, phase);
                    }
                }
            }
            private void Update_readOnlyCheck_IsChecked(global::System.Nullable<global::System.Boolean> obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_readOnlyCheck_IsChecked_Value(obj.Value, phase);
                    }
                }
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // ControlPages\RatingsControlPage.xaml line 35
                    XamlBindingSetters.Set_AppUIBasics_ControlExampleSubstitution_Value(this.obj12, obj, null);
                }
            }
            private void Update_readOnlyCheck_IsChecked_Value(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // ControlPages\RatingsControlPage.xaml line 10
                    XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_RatingControl_IsReadOnly(this.obj7, obj);
                }
            }
            private void Update_RatingControl1(global::Microsoft.UI.Xaml.Controls.RatingControl obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_RatingControl1(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_RatingControl1_Value(obj.Value, phase);
                    }
                }
            }
            private void Update_RatingControl1_Value(global::System.Double obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // ControlPages\RatingsControlPage.xaml line 16
                    XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(this.obj8, obj.ToString(), null);
                }
            }
            private void UpdateTwoWay_4_PlaceholderValue()
            {
                if (this.initialized)
                {
                    if (this.dataRoot != null)
                    {
                        if (this.dataRoot.slider != null)
                        {
                            this.dataRoot.slider.Value = this.obj4.PlaceholderValue;
                        }
                    }
                }
            }
 

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 0.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class RatingControlPage_obj1_BindingsTracking
            {
                private global::System.WeakReference<RatingControlPage_obj1_Bindings> weakRefToBindingObj; 

                public RatingControlPage_obj1_BindingsTracking(RatingControlPage_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<RatingControlPage_obj1_Bindings>(obj);
                }

                public RatingControlPage_obj1_Bindings TryGetBindingObject()
                {
                    RatingControlPage_obj1_Bindings bindingObject = null;
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
                    UpdateChildListeners_slider(null);
                    UpdateChildListeners_clearEnabledCheck(null);
                    UpdateChildListeners_readOnlyCheck(null);
                    UpdateChildListeners_RatingControl1(null);
                }

                public void DependencyPropertyChanged_slider_Value(global::Microsoft.UI.Xaml.DependencyObject sender, global::Microsoft.UI.Xaml.DependencyProperty prop)
                {
                    RatingControlPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::Microsoft.UI.Xaml.Controls.Slider obj = sender as global::Microsoft.UI.Xaml.Controls.Slider;
                        if (obj != null)
                        {
                            bindings.Update_slider_Value(obj.Value, DATA_CHANGED);
                        }
                    }
                }
                private global::Microsoft.UI.Xaml.Controls.Slider cache_slider = null;
                private long tokenDPC_slider_Value = 0;
                public void UpdateChildListeners_slider(global::Microsoft.UI.Xaml.Controls.Slider obj)
                {
                    if (obj != cache_slider)
                    {
                        if (cache_slider != null)
                        {
                            cache_slider.UnregisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.Primitives.RangeBase.ValueProperty, tokenDPC_slider_Value);
                            cache_slider = null;
                        }
                        if (obj != null)
                        {
                            cache_slider = obj;
                            tokenDPC_slider_Value = obj.RegisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.Primitives.RangeBase.ValueProperty, DependencyPropertyChanged_slider_Value);
                        }
                    }
                }
                public void DependencyPropertyChanged_clearEnabledCheck_IsChecked(global::Microsoft.UI.Xaml.DependencyObject sender, global::Microsoft.UI.Xaml.DependencyProperty prop)
                {
                    RatingControlPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::Microsoft.UI.Xaml.Controls.CheckBox obj = sender as global::Microsoft.UI.Xaml.Controls.CheckBox;
                        if (obj != null)
                        {
                            bindings.Update_clearEnabledCheck_IsChecked(obj.IsChecked, DATA_CHANGED);
                        }
                    }
                }
                private global::Microsoft.UI.Xaml.Controls.CheckBox cache_clearEnabledCheck = null;
                private long tokenDPC_clearEnabledCheck_IsChecked = 0;
                public void UpdateChildListeners_clearEnabledCheck(global::Microsoft.UI.Xaml.Controls.CheckBox obj)
                {
                    if (obj != cache_clearEnabledCheck)
                    {
                        if (cache_clearEnabledCheck != null)
                        {
                            cache_clearEnabledCheck.UnregisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton.IsCheckedProperty, tokenDPC_clearEnabledCheck_IsChecked);
                            cache_clearEnabledCheck = null;
                        }
                        if (obj != null)
                        {
                            cache_clearEnabledCheck = obj;
                            tokenDPC_clearEnabledCheck_IsChecked = obj.RegisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton.IsCheckedProperty, DependencyPropertyChanged_clearEnabledCheck_IsChecked);
                        }
                    }
                }
                public void DependencyPropertyChanged_readOnlyCheck_IsChecked(global::Microsoft.UI.Xaml.DependencyObject sender, global::Microsoft.UI.Xaml.DependencyProperty prop)
                {
                    RatingControlPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::Microsoft.UI.Xaml.Controls.CheckBox obj = sender as global::Microsoft.UI.Xaml.Controls.CheckBox;
                        if (obj != null)
                        {
                            bindings.Update_readOnlyCheck_IsChecked(obj.IsChecked, DATA_CHANGED);
                        }
                    }
                }
                private global::Microsoft.UI.Xaml.Controls.CheckBox cache_readOnlyCheck = null;
                private long tokenDPC_readOnlyCheck_IsChecked = 0;
                public void UpdateChildListeners_readOnlyCheck(global::Microsoft.UI.Xaml.Controls.CheckBox obj)
                {
                    if (obj != cache_readOnlyCheck)
                    {
                        if (cache_readOnlyCheck != null)
                        {
                            cache_readOnlyCheck.UnregisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton.IsCheckedProperty, tokenDPC_readOnlyCheck_IsChecked);
                            cache_readOnlyCheck = null;
                        }
                        if (obj != null)
                        {
                            cache_readOnlyCheck = obj;
                            tokenDPC_readOnlyCheck_IsChecked = obj.RegisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton.IsCheckedProperty, DependencyPropertyChanged_readOnlyCheck_IsChecked);
                        }
                    }
                }
                public void DependencyPropertyChanged_RatingControl1_Value(global::Microsoft.UI.Xaml.DependencyObject sender, global::Microsoft.UI.Xaml.DependencyProperty prop)
                {
                    RatingControlPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::Microsoft.UI.Xaml.Controls.RatingControl obj = sender as global::Microsoft.UI.Xaml.Controls.RatingControl;
                        if (obj != null)
                        {
                            bindings.Update_RatingControl1_Value(obj.Value, DATA_CHANGED);
                        }
                    }
                }
                private global::Microsoft.UI.Xaml.Controls.RatingControl cache_RatingControl1 = null;
                private long tokenDPC_RatingControl1_Value = 0;
                public void UpdateChildListeners_RatingControl1(global::Microsoft.UI.Xaml.Controls.RatingControl obj)
                {
                    if (obj != cache_RatingControl1)
                    {
                        if (cache_RatingControl1 != null)
                        {
                            cache_RatingControl1.UnregisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.RatingControl.ValueProperty, tokenDPC_RatingControl1_Value);
                            cache_RatingControl1 = null;
                        }
                        if (obj != null)
                        {
                            cache_RatingControl1 = obj;
                            tokenDPC_RatingControl1_Value = obj.RegisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.RatingControl.ValueProperty, DependencyPropertyChanged_RatingControl1_Value);
                        }
                    }
                }
                public void RegisterTwoWayListener_4(global::Microsoft.UI.Xaml.Controls.RatingControl sourceObject)
                {
                    sourceObject.RegisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.RatingControl.PlaceholderValueProperty, (sender, prop) =>
                    {
                        var bindingObj = this.TryGetBindingObject();
                        if (bindingObj != null)
                        {
                            bindingObj.UpdateTwoWay_4_PlaceholderValue();
                        }
                    });
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
            case 2: // ControlPages\RatingsControlPage.xaml line 7
                {
                    this.Example1 = (AppUIBasics.ControlExample)target;
                }
                break;
            case 3: // ControlPages\RatingsControlPage.xaml line 39
                {
                    this.Example2 = (AppUIBasics.ControlExample)target;
                }
                break;
            case 4: // ControlPages\RatingsControlPage.xaml line 41
                {
                    this.RatingControl2 = (Microsoft.UI.Xaml.Controls.RatingControl)target;
                }
                break;
            case 5: // ControlPages\RatingsControlPage.xaml line 46
                {
                    this.slider = (Microsoft.UI.Xaml.Controls.Slider)target;
                }
                break;
            case 7: // ControlPages\RatingsControlPage.xaml line 10
                {
                    this.RatingControl1 = (Microsoft.UI.Xaml.Controls.RatingControl)target;
                }
                break;
            case 9: // ControlPages\RatingsControlPage.xaml line 22
                {
                    this.clearEnabledCheck = (Microsoft.UI.Xaml.Controls.CheckBox)target;
                }
                break;
            case 10: // ControlPages\RatingsControlPage.xaml line 24
                {
                    this.readOnlyCheck = (Microsoft.UI.Xaml.Controls.CheckBox)target;
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
            case 1: // ControlPages\RatingsControlPage.xaml line 1
                {                    
                    global::Microsoft.UI.Xaml.Controls.Page element1 = (global::Microsoft.UI.Xaml.Controls.Page)target;
                    RatingControlPage_obj1_Bindings bindings = new RatingControlPage_obj1_Bindings();
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

