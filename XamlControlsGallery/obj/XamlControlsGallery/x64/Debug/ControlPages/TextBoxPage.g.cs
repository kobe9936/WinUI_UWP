﻿#pragma checksum "C:\Users\kobe9\source\repos\WinUI_UWP\XamlControlsGallery\ControlPages\TextBoxPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0BB3B989A5DDD6A6CA8A11FCB51EE426FC0C040BFA73D1D5EEE2289839159077"
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
    partial class TextBoxPage : 
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
            case 2: // ControlPages\TextBoxPage.xaml line 17
                {
                    this.Example1 = (AppUIBasics.ControlExample)target;
                }
                break;
            case 3: // ControlPages\TextBoxPage.xaml line 25
                {
                    this.Example2 = (AppUIBasics.ControlExample)target;
                }
                break;
            case 4: // ControlPages\TextBoxPage.xaml line 35
                {
                    this.Example3 = (AppUIBasics.ControlExample)target;
                }
                break;
            case 5: // ControlPages\TextBoxPage.xaml line 48
                {
                    this.Example4 = (AppUIBasics.ControlExample)target;
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

