﻿#pragma checksum "..\..\ExistingPersonPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "74B801A1D4B4751B4420E9F77E3D9DF9266833A51026A5BB87DEEF9BA36128BF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ExamenOpdrachtVersie2;
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


namespace ExamenOpdrachtVersie2 {
    
    
    /// <summary>
    /// ExistingPersonPage
    /// </summary>
    public partial class ExistingPersonPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\ExistingPersonPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FirstNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\ExistingPersonPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LastNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\ExistingPersonPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button showAllPerson;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\ExistingPersonPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FindPersonBtn;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\ExistingPersonPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox PersonListBox;
        
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
            System.Uri resourceLocater = new System.Uri("/ExamenOpdrachtVersie2;component/existingpersonpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ExistingPersonPage.xaml"
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
            
            #line 10 "..\..\ExistingPersonPage.xaml"
            ((ExamenOpdrachtVersie2.ExistingPersonPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.FirstNameTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 28 "..\..\ExistingPersonPage.xaml"
            this.FirstNameTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.FirstNameTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.LastNameTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 35 "..\..\ExistingPersonPage.xaml"
            this.LastNameTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.LastNameTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.showAllPerson = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.FindPersonBtn = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\ExistingPersonPage.xaml"
            this.FindPersonBtn.Click += new System.Windows.RoutedEventHandler(this.FindPersonBtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.PersonListBox = ((System.Windows.Controls.ListBox)(target));
            
            #line 50 "..\..\ExistingPersonPage.xaml"
            this.PersonListBox.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.PersonListBox_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

