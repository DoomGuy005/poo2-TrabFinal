﻿#pragma checksum "..\..\VendasWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "EC7A7312ACADAE3E805BB4097A6FCE2A"
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
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
using Windows;


namespace Windows {
    
    
    /// <summary>
    /// VendasWindow
    /// </summary>
    public partial class VendasWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\VendasWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtQnt;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\VendasWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnVender;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\VendasWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbClientes;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\VendasWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid PeçasList;
        
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
            System.Uri resourceLocater = new System.Uri("/Windows;component/vendaswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\VendasWindow.xaml"
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
            this.txtQnt = ((System.Windows.Controls.TextBox)(target));
            
            #line 15 "..\..\VendasWindow.xaml"
            this.txtQnt.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtQnt_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnVender = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\VendasWindow.xaml"
            this.btnVender.Click += new System.Windows.RoutedEventHandler(this.btnVender_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cmbClientes = ((System.Windows.Controls.ComboBox)(target));
            
            #line 17 "..\..\VendasWindow.xaml"
            this.cmbClientes.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbClientes_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.PeçasList = ((System.Windows.Controls.DataGrid)(target));
            
            #line 18 "..\..\VendasWindow.xaml"
            this.PeçasList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.PeçasList_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

