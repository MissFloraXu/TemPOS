﻿#pragma checksum "..\..\..\ItemMaintenanceViewContextMenuControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8B56ADBD07DAF4BE3BEF28A170620345"
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
    /// ItemMaintenanceViewContextMenuControl
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class ItemMaintenanceViewContextMenuControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\ItemMaintenanceViewContextMenuControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel mainPane;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\ItemMaintenanceViewContextMenuControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PointOfSale.ConfigurationManager Configuration;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\ItemMaintenanceViewContextMenuControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.PushRadioButton buttonAllCategories;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\ItemMaintenanceViewContextMenuControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.PushRadioButton buttonAllItemsInCategory;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\ItemMaintenanceViewContextMenuControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.PushRadioButton buttonAllItems;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\ItemMaintenanceViewContextMenuControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.PushRadioButton buttonAllItemOptionsSets;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\ItemMaintenanceViewContextMenuControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.PushRadioButton buttonAllIngredients;
        
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
            System.Uri resourceLocater = new System.Uri("/PointOfSale;component/itemmaintenanceviewcontextmenucontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ItemMaintenanceViewContextMenuControl.xaml"
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
            this.buttonAllCategories = ((PosControls.PushRadioButton)(target));
            
            #line 20 "..\..\..\ItemMaintenanceViewContextMenuControl.xaml"
            this.buttonAllCategories.SelectionGained += new System.EventHandler(this.buttonAllCategories_SelectionGained);
            
            #line default
            #line hidden
            return;
            case 4:
            this.buttonAllItemsInCategory = ((PosControls.PushRadioButton)(target));
            
            #line 21 "..\..\..\ItemMaintenanceViewContextMenuControl.xaml"
            this.buttonAllItemsInCategory.SelectionGained += new System.EventHandler(this.buttonAllItemsInCategory_SelectionGained);
            
            #line default
            #line hidden
            return;
            case 5:
            this.buttonAllItems = ((PosControls.PushRadioButton)(target));
            
            #line 22 "..\..\..\ItemMaintenanceViewContextMenuControl.xaml"
            this.buttonAllItems.SelectionGained += new System.EventHandler(this.buttonAllItems_SelectionGained);
            
            #line default
            #line hidden
            return;
            case 6:
            this.buttonAllItemOptionsSets = ((PosControls.PushRadioButton)(target));
            
            #line 23 "..\..\..\ItemMaintenanceViewContextMenuControl.xaml"
            this.buttonAllItemOptionsSets.SelectionGained += new System.EventHandler(this.buttonAllItemOptionsSets_SelectionGained);
            
            #line default
            #line hidden
            return;
            case 7:
            this.buttonAllIngredients = ((PosControls.PushRadioButton)(target));
            
            #line 24 "..\..\..\ItemMaintenanceViewContextMenuControl.xaml"
            this.buttonAllIngredients.SelectionGained += new System.EventHandler(this.buttonAllIngredients_SelectionGained);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
