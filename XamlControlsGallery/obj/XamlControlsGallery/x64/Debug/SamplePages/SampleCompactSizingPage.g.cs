﻿#pragma checksum "C:\Users\kobe9\source\repos\WinUI_UWP\XamlControlsGallery\SamplePages\SampleCompactSizingPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "508FEFD0F74E90BB68438723D4CE2322C33E1BF928D87F12BF5060F345603690"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppUIBasics.SamplePages
{
    partial class SampleCompactSizingPage : 
        global::Microsoft.UI.Xaml.Controls.Page, 
        global::Microsoft.UI.Xaml.Markup.IComponentConnector
    {
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
            case 2: // SamplePages\SampleCompactSizingPage.xaml line 26
                {
                    this.HeaderBlock = (Microsoft.UI.Xaml.Controls.TextBlock)target;
                }
                break;
            case 3: // SamplePages\SampleCompactSizingPage.xaml line 27
                {
                    this.txtfirstName = (Microsoft.UI.Xaml.Controls.TextBox)target;
                }
                break;
            case 4: // SamplePages\SampleCompactSizingPage.xaml line 28
                {
                    this.txtLastName = (Microsoft.UI.Xaml.Controls.TextBox)target;
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
            return returnValue;
        }
    }
}

