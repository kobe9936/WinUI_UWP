﻿#pragma checksum "C:\Users\kobe9\source\repos\WinUI_UWP\XamlControlsGallery\ItemTemplates.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "303F884D1D4AC76542387BD7DF2621FEDB06DB7C673E2DAE70E67D4E07674647"
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
    partial class ItemTemplates : 
        global::Microsoft.UI.Xaml.ResourceDictionary, 
        global::Microsoft.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Microsoft_UI_Xaml_Automation_AutomationProperties_Name(global::Microsoft.UI.Xaml.DependencyObject obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                global::Microsoft.UI.Xaml.Automation.AutomationProperties.SetName(obj, value);
            }
            public static void Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(global::Microsoft.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
            public static void Set_Microsoft_UI_Xaml_Controls_Image_Source(global::Microsoft.UI.Xaml.Controls.Image obj, global::Microsoft.UI.Xaml.Media.ImageSource value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Microsoft.UI.Xaml.Media.ImageSource) global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Microsoft.UI.Xaml.Media.ImageSource), targetNullValue);
                }
                obj.Source = value;
            }
            public static void Set_Microsoft_UI_Xaml_UIElement_Visibility(global::Microsoft.UI.Xaml.UIElement obj, global::Microsoft.UI.Xaml.Visibility value)
            {
                obj.Visibility = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class ItemTemplates_obj3_Bindings :
            global::Microsoft.UI.Xaml.IDataTemplateExtension,
            global::Microsoft.UI.Xaml.Markup.IDataTemplateComponent,
            global::Microsoft.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Microsoft.UI.Xaml.Markup.IComponentConnector,
            IItemTemplates_Bindings
        {
            private global::AppUIBasics.Data.ControlInfoDataItem dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private global::Microsoft.UI.Xaml.ResourceDictionary localResources;
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::System.WeakReference<global::Microsoft.UI.Xaml.Controls.UserControl> obj3;
            private global::Microsoft.UI.Xaml.Controls.Image obj8;
            private global::Microsoft.UI.Xaml.Controls.Grid obj9;
            private global::Microsoft.UI.Xaml.Controls.TextBlock obj10;
            private global::Microsoft.UI.Xaml.Controls.TextBlock obj11;
            private global::Microsoft.UI.Xaml.Controls.TextBlock obj12;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj8NameDisabled = false;
            private static bool isobj8SourceDisabled = false;
            private static bool isobj9VisibilityDisabled = false;
            private static bool isobj10TextDisabled = false;
            private static bool isobj11TextDisabled = false;
            private static bool isobj12TextDisabled = false;

            public ItemTemplates_obj3_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 44 && columnNumber == 21)
                {
                    isobj8NameDisabled = true;
                }
                else if (lineNumber == 45 && columnNumber == 21)
                {
                    isobj8SourceDisabled = true;
                }
                else if (lineNumber == 69 && columnNumber == 21)
                {
                    isobj9VisibilityDisabled = true;
                }
                else if (lineNumber == 72 && columnNumber == 32)
                {
                    isobj10TextDisabled = true;
                }
                else if (lineNumber == 52 && columnNumber == 25)
                {
                    isobj11TextDisabled = true;
                }
                else if (lineNumber == 61 && columnNumber == 25)
                {
                    isobj12TextDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 3: // ItemTemplates.xaml line 8
                        this.obj3 = new global::System.WeakReference<global::Microsoft.UI.Xaml.Controls.UserControl>((Microsoft.UI.Xaml.Controls.UserControl)target);
                        break;
                    case 8: // ItemTemplates.xaml line 40
                        this.obj8 = (Microsoft.UI.Xaml.Controls.Image)target;
                        break;
                    case 9: // ItemTemplates.xaml line 65
                        this.obj9 = (Microsoft.UI.Xaml.Controls.Grid)target;
                        break;
                    case 10: // ItemTemplates.xaml line 72
                        this.obj10 = (Microsoft.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 11: // ItemTemplates.xaml line 49
                        this.obj11 = (Microsoft.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 12: // ItemTemplates.xaml line 56
                        this.obj12 = (Microsoft.UI.Xaml.Controls.TextBlock)target;
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
                            (GetWeakRefTarget(this.obj3) as global::Microsoft.UI.Xaml.Controls.UserControl).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((AppUIBasics.Data.ControlInfoDataItem)item, 1 << phase);
            }

            public void Recycle()
            {
            }

            // IItemTemplates_Bindings

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
                    this.dataRoot = (AppUIBasics.Data.ControlInfoDataItem)newDataRoot;
                    return true;
                }
                return false;
            }
            public void SetConverterLookupRoot(global::Microsoft.UI.Xaml.ResourceDictionary resources)
            {
                this.localResources = resources;
            }

            public global::Microsoft.UI.Xaml.Data.IValueConverter LookupConverter(string key)
            {
                return (global::Microsoft.UI.Xaml.Data.IValueConverter) (this.localResources.ContainsKey(key) ? this.localResources[key] : global::Microsoft.UI.Xaml.Application.Current.Resources[key]);
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::AppUIBasics.Data.ControlInfoDataItem obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_Title(obj.Title, phase);
                        this.Update_ImagePath(obj.ImagePath, phase);
                        this.Update_BadgeString(obj.BadgeString, phase);
                        this.Update_Description(obj.Description, phase);
                    }
                }
            }
            private void Update_Title(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // ItemTemplates.xaml line 40
                    if (!isobj8NameDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Automation_AutomationProperties_Name(this.obj8, obj, null);
                    }
                    // ItemTemplates.xaml line 49
                    if (!isobj11TextDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(this.obj11, obj, null);
                    }
                }
            }
            private void Update_ImagePath(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // ItemTemplates.xaml line 40
                    if (!isobj8SourceDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_Image_Source(this.obj8, (global::Microsoft.UI.Xaml.Media.ImageSource) global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Microsoft.UI.Xaml.Media.ImageSource), obj), null);
                    }
                }
            }
            private void Update_BadgeString(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // ItemTemplates.xaml line 65
                    if (!isobj9VisibilityDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_UIElement_Visibility(this.obj9, (global::Microsoft.UI.Xaml.Visibility)this.LookupConverter("nullToVisibilityConverter").Convert(obj, typeof(global::Microsoft.UI.Xaml.Visibility), null, null));
                    }
                    // ItemTemplates.xaml line 72
                    if (!isobj10TextDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(this.obj10, obj, null);
                    }
                }
            }
            private void Update_Description(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // ItemTemplates.xaml line 56
                    if (!isobj12TextDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(this.obj12, obj, null);
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
            case 3: // ItemTemplates.xaml line 8
                {                    
                    global::Microsoft.UI.Xaml.Controls.UserControl element3 = (global::Microsoft.UI.Xaml.Controls.UserControl)target;
                    ItemTemplates_obj3_Bindings bindings = new ItemTemplates_obj3_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(element3.DataContext);
                    bindings.SetConverterLookupRoot(this);
                    element3.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Microsoft.UI.Xaml.DataTemplate.SetExtensionInstance(element3, bindings);
                    global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element3, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

