﻿#pragma checksum "..\..\Ventana3.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "386E0AE2FDF676C2DCAA9C76CB4443EF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PruebaWPF;
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


namespace PruebaWPF {
    
    
    /// <summary>
    /// Ventana3
    /// </summary>
    public partial class Ventana3 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\Ventana3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel PilaContenedor;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\Ventana3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.InkCanvas LiensoTinta;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Ventana3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnCambiaColor;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Ventana3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider SldrGrosorTrazo;
        
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
            System.Uri resourceLocater = new System.Uri("/PruebaWPF;component/ventana3.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Ventana3.xaml"
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
            
            #line 8 "..\..\Ventana3.xaml"
            ((PruebaWPF.Ventana3)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.PilaContenedor = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 3:
            this.LiensoTinta = ((System.Windows.Controls.InkCanvas)(target));
            return;
            case 4:
            this.BtnCambiaColor = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\Ventana3.xaml"
            this.BtnCambiaColor.Click += new System.Windows.RoutedEventHandler(this.BtnCambiaColor_Click);
            
            #line default
            #line hidden
            
            #line 15 "..\..\Ventana3.xaml"
            this.BtnCambiaColor.TouchEnter += new System.EventHandler<System.Windows.Input.TouchEventArgs>(this.EntrarEnControl_TouchEnter);
            
            #line default
            #line hidden
            return;
            case 5:
            this.SldrGrosorTrazo = ((System.Windows.Controls.Slider)(target));
            
            #line 16 "..\..\Ventana3.xaml"
            this.SldrGrosorTrazo.TouchEnter += new System.EventHandler<System.Windows.Input.TouchEventArgs>(this.EntrarEnControl_TouchEnter);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

