﻿#pragma checksum "..\..\..\app.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "DD71B49ED9C5B15A952A549D46F817079A63B99D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Windows.Themes;
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


namespace XamlGeneratedNamespace {
    
    
    /// <summary>
    /// GeneratedApplication
    /// </summary>
    public partial class GeneratedApplication : System.Windows.Application {
        
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
            
            #line 2 "..\..\..\app.xaml"
            this.StartupUri = new System.Uri("Window1.xaml", System.UriKind.Relative);
            
            #line default
            #line hidden
            System.Uri resourceLocater = new System.Uri("/WPFChat;component/app.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\app.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        /// <summary>
        /// Application Entry Point.
        /// </summary>
        [System.STAThreadAttribute()]
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public static void Main() {
            XamlGeneratedNamespace.GeneratedApplication app = new XamlGeneratedNamespace.GeneratedApplication();
            app.InitializeComponent();
            app.Run();
        }
    }
}

