﻿#pragma checksum "..\..\InfoPlayers.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B7AECC475DB8FCC9EF3EC492FE2408F2B5DCE6294C09241C103066414B8A5C58"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using WindowsPresentationFoundation;
using WindowsPresentationFoundation.Properties;


namespace WindowsPresentationFoundation {
    
    
    /// <summary>
    /// InfoPlayers
    /// </summary>
    public partial class InfoPlayers : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 37 "..\..\InfoPlayers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnIzadi;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\InfoPlayers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblPlayerName;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\InfoPlayers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblShirtNumber;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\InfoPlayers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblPosition;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\InfoPlayers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblCaptain;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\InfoPlayers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblGoalsScored;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\InfoPlayers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblYellowCard;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\InfoPlayers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgPlayer;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WindowsPresentationFoundation;component/infoplayers.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\InfoPlayers.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.btnIzadi = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\InfoPlayers.xaml"
            this.btnIzadi.Click += new System.Windows.RoutedEventHandler(this.btnIzadi_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lblPlayerName = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.lblShirtNumber = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.lblPosition = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.lblCaptain = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.lblGoalsScored = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.lblYellowCard = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.imgPlayer = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

