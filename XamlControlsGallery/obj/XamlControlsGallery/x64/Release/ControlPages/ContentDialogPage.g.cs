﻿#pragma checksum "C:\Users\kobe9\source\repos\Xaml-Controls-Gallery\XamlControlsGallery\ControlPages\ContentDialogPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0138E08B704FCABEEABBB3676716F5CDB6337EE320051CFB58B905C65632B1FF"
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
    partial class ContentDialogPage : 
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
            case 2: // ControlPages\ContentDialogPage.xaml line 10
                {
                    this.Example1 = (AppUIBasics.ControlExample)target;
                }
                break;
            case 3: // ControlPages\ContentDialogPage.xaml line 13
                {
                    this.ShowDialog = (Microsoft.UI.Xaml.Controls.Button)target;
                    ((global::Microsoft.UI.Xaml.Controls.Button)this.ShowDialog).Click += this.ShowDialog_Click;
                }
                break;
            case 4: // ControlPages\ContentDialogPage.xaml line 14
                {
                    this.DialogResult = (Microsoft.UI.Xaml.Controls.TextBlock)target;
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

