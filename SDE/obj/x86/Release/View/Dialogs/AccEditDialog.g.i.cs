﻿#pragma checksum "..\..\..\..\..\View\Dialogs\AccEditDialog.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25B8B255D8A42BC9B0E4A95C28514A46B15B8E97"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Windows.Controls;
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
using TokeiLibrary;
using TokeiLibrary.WPF.Styles;
using TokeiLibrary.WPF.Styles.ListView;


namespace SDE.View.Dialogs {
    
    
    /// <summary>
    /// AccEditDialog
    /// </summary>
    public partial class AccEditDialog : TokeiLibrary.WPF.Styles.TkWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\..\..\View\Dialogs\AccEditDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid _jobGrid;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\..\View\Dialogs\AccEditDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Windows.Controls.DataGrid _dataGrid;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\..\View\Dialogs\AccEditDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button _buttonAdd;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\..\View\Dialogs\AccEditDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button _buttonDelete;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\..\View\Dialogs\AccEditDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button _buttonAuto;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\..\..\View\Dialogs\AccEditDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button _buttonAutoAll;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\..\..\View\Dialogs\AccEditDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button _buttonSave;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\..\..\View\Dialogs\AccEditDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button _buttonExport;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\..\..\View\Dialogs\AccEditDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal TokeiLibrary.WPF.Styles.TkProgressBar _progressBar;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\..\..\View\Dialogs\AccEditDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button _buttonCancel;
        
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
            System.Uri resourceLocater = new System.Uri("/SDE;component/view/dialogs/acceditdialog.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\View\Dialogs\AccEditDialog.xaml"
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
            this._jobGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this._dataGrid = ((Microsoft.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this._buttonAdd = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\..\..\View\Dialogs\AccEditDialog.xaml"
            this._buttonAdd.Click += new System.Windows.RoutedEventHandler(this._buttonAdd_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this._buttonDelete = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\..\..\View\Dialogs\AccEditDialog.xaml"
            this._buttonDelete.Click += new System.Windows.RoutedEventHandler(this._buttonDelete_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this._buttonAuto = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\..\..\View\Dialogs\AccEditDialog.xaml"
            this._buttonAuto.Click += new System.Windows.RoutedEventHandler(this._buttonAuto_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this._buttonAutoAll = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\..\..\..\View\Dialogs\AccEditDialog.xaml"
            this._buttonAutoAll.Click += new System.Windows.RoutedEventHandler(this._buttonAutoAll_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this._buttonSave = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\..\..\..\View\Dialogs\AccEditDialog.xaml"
            this._buttonSave.Click += new System.Windows.RoutedEventHandler(this._buttonSave_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this._buttonExport = ((System.Windows.Controls.Button)(target));
            
            #line 76 "..\..\..\..\..\View\Dialogs\AccEditDialog.xaml"
            this._buttonExport.Click += new System.Windows.RoutedEventHandler(this._buttonExport_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this._progressBar = ((TokeiLibrary.WPF.Styles.TkProgressBar)(target));
            return;
            case 10:
            this._buttonCancel = ((System.Windows.Controls.Button)(target));
            
            #line 97 "..\..\..\..\..\View\Dialogs\AccEditDialog.xaml"
            this._buttonCancel.Click += new System.Windows.RoutedEventHandler(this._buttonCancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

