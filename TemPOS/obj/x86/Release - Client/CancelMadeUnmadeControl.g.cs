﻿#pragma checksum "..\..\..\CancelMadeUnmadeControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "69A23EB1DFFEF3FF97CC4436CC1E1378"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PointOfSale;
using PosControls;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace PointOfSale {
    
    
    /// <summary>
    /// CancelMadeUnmadeControl
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class CancelMadeUnmadeControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\CancelMadeUnmadeControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel mainPane;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\CancelMadeUnmadeControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PointOfSale.ConfigurationManager Configuration;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\CancelMadeUnmadeControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.PushButton buttonReopen;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\CancelMadeUnmadeControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.PushButton buttonMade;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\CancelMadeUnmadeControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.PushButton buttonUnmade;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\CancelMadeUnmadeControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.PushButton buttonVoid;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\CancelMadeUnmadeControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.PushButton buttonDontCancel;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\CancelMadeUnmadeControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.PushButton buttonDontRefund;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/PointOfSale;component/cancelmadeunmadecontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\CancelMadeUnmadeControl.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.mainPane = ((System.Windows.Controls.DockPanel)(target));
            return;
            case 2:
            this.Configuration = ((PointOfSale.ConfigurationManager)(target));
            return;
            case 3:
            this.buttonReopen = ((PosControls.PushButton)(target));
            
            #line 17 "..\..\..\CancelMadeUnmadeControl.xaml"
            this.buttonReopen.Selected += new System.EventHandler(this.buttonReopen_Selected);
            
            #line default
            #line hidden
            return;
            case 4:
            this.buttonMade = ((PosControls.PushButton)(target));
            
            #line 18 "..\..\..\CancelMadeUnmadeControl.xaml"
            this.buttonMade.Selected += new System.EventHandler(this.buttonMade_Selected);
            
            #line default
            #line hidden
            return;
            case 5:
            this.buttonUnmade = ((PosControls.PushButton)(target));
            
            #line 19 "..\..\..\CancelMadeUnmadeControl.xaml"
            this.buttonUnmade.Selected += new System.EventHandler(this.buttonUnmade_Selected);
            
            #line default
            #line hidden
            return;
            case 6:
            this.buttonVoid = ((PosControls.PushButton)(target));
            
            #line 20 "..\..\..\CancelMadeUnmadeControl.xaml"
            this.buttonVoid.Selected += new System.EventHandler(this.buttonVoid_Selected);
            
            #line default
            #line hidden
            return;
            case 7:
            this.buttonDontCancel = ((PosControls.PushButton)(target));
            
            #line 21 "..\..\..\CancelMadeUnmadeControl.xaml"
            this.buttonDontCancel.Selected += new System.EventHandler(this.buttonDontCancel_Selected);
            
            #line default
            #line hidden
            return;
            case 8:
            this.buttonDontRefund = ((PosControls.PushButton)(target));
            
            #line 22 "..\..\..\CancelMadeUnmadeControl.xaml"
            this.buttonDontRefund.Selected += new System.EventHandler(this.buttonDontCancel_Selected);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

