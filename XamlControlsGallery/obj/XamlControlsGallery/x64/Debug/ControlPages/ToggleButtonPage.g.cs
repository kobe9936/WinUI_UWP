﻿#pragma checksum "C:\Users\kobe9\source\repos\WinUI_UWP\XamlControlsGallery\ControlPages\ToggleButtonPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "67E28CBB9CC5C90FDD26948CB42EBBFF38F25C9C3190315DF6C92D296E456498"
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
    partial class ToggleButtonPage : 
        global::Microsoft.UI.Xaml.Controls.Page, 
        global::Microsoft.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
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
        private class ToggleButtonPage_obj1_Bindings :
            global::Microsoft.UI.Xaml.Markup.IDataTemplateComponent,
            global::Microsoft.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Microsoft.UI.Xaml.Markup.IComponentConnector,
            IToggleButtonPage_Bindings
        {
            private global::AppUIBasics.ControlPages.ToggleButtonPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton obj2;
            private global::AppUIBasics.ControlExampleSubstitution obj5;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj2IsEnabledDisabled = false;
            private static bool isobj5IsEnabledDisabled = false;

            private ToggleButtonPage_obj1_BindingsTracking bindingsTracking;

            public ToggleButtonPage_obj1_Bindings()
            {
                this.bindingsTracking = new ToggleButtonPage_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 24 && columnNumber == 21)
                {
                    isobj2IsEnabledDisabled = true;
                }
                else if (lineNumber == 39 && columnNumber == 67)
                {
                    isobj5IsEnabledDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2: // ControlPages\ToggleButtonPage.xaml line 23
                        this.obj2 = (Microsoft.UI.Xaml.Controls.Primitives.ToggleButton)target;
                        break;
                    case 5: // ControlPages\ToggleButtonPage.xaml line 39
                        this.obj5 = (AppUIBasics.ControlExampleSubstitution)target;
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

            // IToggleButtonPage_Bindings

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
                    this.dataRoot = (AppUIBasics.ControlPages.ToggleButtonPage)newDataRoot;
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

            private void Invoke_DisableToggle1_IsChecked_Value_M_Equals_3875955625(int phase)
            {
                global::System.Boolean p0 = false;
                global::System.Boolean result = this.dataRoot.DisableToggle1.IsChecked.Value.Equals(p0);
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // ControlPages\ToggleButtonPage.xaml line 23
                    if (!isobj2IsEnabledDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_Control_IsEnabled(this.obj2, result);
                    }
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
            private void Update_(global::AppUIBasics.ControlPages.ToggleButtonPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_DisableToggle1(obj.DisableToggle1, phase);
                    }
                }
                this.CompleteUpdate(phase);
            }
            private void Update_DisableToggle1(global::Microsoft.UI.Xaml.Controls.CheckBox obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_DisableToggle1(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_DisableToggle1_IsChecked(obj.IsChecked, phase);
                    }
                }
            }
            private void Update_DisableToggle1_IsChecked(global::System.Nullable<global::System.Boolean> obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_DisableToggle1_IsChecked_Value(obj.Value, phase);
                    }
                }
            }
            private void Update_DisableToggle1_IsChecked_Value(global::System.Boolean obj, int phase)
            {
                if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                {
                    this.Update_DisableToggle1_IsChecked_Value_M_Equals_3875955625(phase);
                }
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // ControlPages\ToggleButtonPage.xaml line 39
                    if (!isobj5IsEnabledDisabled)
                    {
                        XamlBindingSetters.Set_AppUIBasics_ControlExampleSubstitution_IsEnabled(this.obj5, obj);
                    }
                }
            }
            private void Update_DisableToggle1_IsChecked_Value_M_Equals_3875955625(int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    if (!isobj2IsEnabledDisabled)
                    {
                        this.PendingFunctionBindings["DisableToggle1_IsChecked_Value_M_Equals_3875955625"] = new InvokeFunctionDelegate(this.Invoke_DisableToggle1_IsChecked_Value_M_Equals_3875955625); 
                    }
                }
            }
 

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 0.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class ToggleButtonPage_obj1_BindingsTracking
            {
                private global::System.WeakReference<ToggleButtonPage_obj1_Bindings> weakRefToBindingObj; 

                public ToggleButtonPage_obj1_BindingsTracking(ToggleButtonPage_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<ToggleButtonPage_obj1_Bindings>(obj);
                }

                public ToggleButtonPage_obj1_Bindings TryGetBindingObject()
                {
                    ToggleButtonPage_obj1_Bindings bindingObject = null;
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
                    UpdateChildListeners_DisableToggle1(null);
                }

                public void DependencyPropertyChanged_DisableToggle1_IsChecked(global::Microsoft.UI.Xaml.DependencyObject sender, global::Microsoft.UI.Xaml.DependencyProperty prop)
                {
                    ToggleButtonPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::Microsoft.UI.Xaml.Controls.CheckBox obj = sender as global::Microsoft.UI.Xaml.Controls.CheckBox;
                        if (obj != null)
                        {
                            bindings.Update_DisableToggle1_IsChecked(obj.IsChecked, DATA_CHANGED);
                        }
                        bindings.CompleteUpdate(DATA_CHANGED);
                    }
                }
                private global::Microsoft.UI.Xaml.Controls.CheckBox cache_DisableToggle1 = null;
                private long tokenDPC_DisableToggle1_IsChecked = 0;
                public void UpdateChildListeners_DisableToggle1(global::Microsoft.UI.Xaml.Controls.CheckBox obj)
                {
                    if (obj != cache_DisableToggle1)
                    {
                        if (cache_DisableToggle1 != null)
                        {
                            cache_DisableToggle1.UnregisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton.IsCheckedProperty, tokenDPC_DisableToggle1_IsChecked);
                            cache_DisableToggle1 = null;
                        }
                        if (obj != null)
                        {
                            cache_DisableToggle1 = obj;
                            tokenDPC_DisableToggle1_IsChecked = obj.RegisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton.IsCheckedProperty, DependencyPropertyChanged_DisableToggle1_IsChecked);
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
            case 2: // ControlPages\ToggleButtonPage.xaml line 23
                {
                    this.Toggle1 = (Microsoft.UI.Xaml.Controls.Primitives.ToggleButton)target;
                    ((global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton)this.Toggle1).Checked += this.ToggleButton_Checked;
                    ((global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton)this.Toggle1).Unchecked += this.ToggleButton_Unchecked;
                }
                break;
            case 3: // ControlPages\ToggleButtonPage.xaml line 26
                {
                    this.Control1Output = (Microsoft.UI.Xaml.Controls.TextBlock)target;
                }
                break;
            case 4: // ControlPages\ToggleButtonPage.xaml line 30
                {
                    this.DisableToggle1 = (Microsoft.UI.Xaml.Controls.CheckBox)target;
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
            case 1: // ControlPages\ToggleButtonPage.xaml line 12
                {                    
                    global::Microsoft.UI.Xaml.Controls.Page element1 = (global::Microsoft.UI.Xaml.Controls.Page)target;
                    ToggleButtonPage_obj1_Bindings bindings = new ToggleButtonPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

