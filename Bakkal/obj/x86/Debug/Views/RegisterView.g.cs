﻿#pragma checksum "C:\Users\onurcelikeng\Documents\Visual Studio 2015\Projects\Bakkal\Bakkal\Views\RegisterView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "20654D16534E5F64EECAAEB962F5EA47"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bakkal.Views
{
    partial class RegisterView : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
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
                    this.register = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    #line 110 "..\..\..\Views\RegisterView.xaml"
                    ((global::Windows.UI.Xaml.Controls.Grid)this.register).Tapped += this.register_Tapped;
                    #line default
                }
                break;
            case 2:
                {
                    this.exit = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    #line 118 "..\..\..\Views\RegisterView.xaml"
                    ((global::Windows.UI.Xaml.Controls.Grid)this.exit).Tapped += this.exit_Tapped;
                    #line default
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
            return returnValue;
        }
    }
}
