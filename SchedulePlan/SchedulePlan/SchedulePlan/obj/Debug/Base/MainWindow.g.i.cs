﻿#pragma checksum "..\..\..\Base\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E95CFB7D8A58B1B0C75F9102C1A4F4D41C98523940FD75DDF3CA86463C088D1B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SchedulePlan;
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


namespace SchedulePlan {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\Base\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RowDefinition RowDefenition1;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Base\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label UserNameLabel;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Base\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddElementButton;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Base\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CloseWindowButton;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Base\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox NameDepComboBox;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\Base\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel ListViewStackPanel;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\Base\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ObjectListBox;
        
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
            System.Uri resourceLocater = new System.Uri("/SchedulePlan;component/base/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Base\MainWindow.xaml"
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
            this.RowDefenition1 = ((System.Windows.Controls.RowDefinition)(target));
            return;
            case 2:
            this.UserNameLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.AddElementButton = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\Base\MainWindow.xaml"
            this.AddElementButton.Click += new System.Windows.RoutedEventHandler(this.AddElementButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.CloseWindowButton = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\Base\MainWindow.xaml"
            this.CloseWindowButton.Click += new System.Windows.RoutedEventHandler(this.CloseWindowButton_Click_1);
            
            #line default
            #line hidden
            return;
            case 5:
            this.NameDepComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.ListViewStackPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 7:
            this.ObjectListBox = ((System.Windows.Controls.ListBox)(target));
            
            #line 95 "..\..\..\Base\MainWindow.xaml"
            this.ObjectListBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ObjectListBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
