﻿#pragma checksum "..\..\..\channels\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "080C782B05E60E204239B5021CE09B65FE7F766985F854F6EECB913041A14D44"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro.Controls;
using MahApps.Metro.IconPacks;
using MahApps.Metro.IconPacks.Converter;
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
using Vlc.DotNet.Wpf;


namespace WpfApp1 {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\..\channels\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal WpfApp1.MainWindow main;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\channels\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Vlc.DotNet.Wpf.VlcControl vlcPlayer;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/channels/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\channels\MainWindow.xaml"
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
            this.main = ((WpfApp1.MainWindow)(target));
            return;
            case 2:
            
            #line 12 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LaunchTelegram);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 15 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DevChannel);
            
            #line default
            #line hidden
            return;
            case 4:
            this.vlcPlayer = ((Vlc.DotNet.Wpf.VlcControl)(target));
            return;
            case 5:
            
            #line 34 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.kanal12);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 38 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.hd1music);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 41 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.day365);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 44 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.nsk49);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 47 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.kanal8);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 50 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.kanal8krasn);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 53 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.amedia1);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 56 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.amedia2);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 59 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.amediahit);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 62 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.amediapremium);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 65 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.animalplanet);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 68 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.animalplanethd);
            
            #line default
            #line hidden
            return;
            case 17:
            
            #line 71 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.bridgetv);
            
            #line default
            #line hidden
            return;
            case 18:
            
            #line 74 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.bridgetvclassic);
            
            #line default
            #line hidden
            return;
            case 19:
            
            #line 77 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.bridgetvdeluxe);
            
            #line default
            #line hidden
            return;
            case 20:
            
            #line 80 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.bridgetvhits);
            
            #line default
            #line hidden
            return;
            case 21:
            
            #line 83 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.bridgetvrus);
            
            #line default
            #line hidden
            return;
            case 22:
            
            #line 86 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.cartoonnetwork);
            
            #line default
            #line hidden
            return;
            case 23:
            
            #line 89 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.cinema);
            
            #line default
            #line hidden
            return;
            case 24:
            
            #line 92 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.davinchi);
            
            #line default
            #line hidden
            return;
            case 25:
            
            #line 95 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.discoverychannel);
            
            #line default
            #line hidden
            return;
            case 26:
            
            #line 98 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.discoveryhd);
            
            #line default
            #line hidden
            return;
            case 27:
            
            #line 101 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.disney);
            
            #line default
            #line hidden
            return;
            case 28:
            
            #line 104 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.docubox);
            
            #line default
            #line hidden
            return;
            case 29:
            
            #line 107 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.dtx);
            
            #line default
            #line hidden
            return;
            case 30:
            
            #line 110 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.euronews);
            
            #line default
            #line hidden
            return;
            case 31:
            
            #line 113 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.eurosport1);
            
            #line default
            #line hidden
            return;
            case 32:
            
            #line 116 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.eurosport1hd);
            
            #line default
            #line hidden
            return;
            case 33:
            
            #line 119 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.eurosport2);
            
            #line default
            #line hidden
            return;
            case 34:
            
            #line 122 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.eurosport2hd);
            
            #line default
            #line hidden
            return;
            case 35:
            
            #line 125 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.extremesports);
            
            #line default
            #line hidden
            return;
            case 36:
            
            #line 128 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.fashiontv);
            
            #line default
            #line hidden
            return;
            case 37:
            
            #line 131 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.filmbox);
            
            #line default
            #line hidden
            return;
            case 38:
            
            #line 134 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.filmboxart);
            
            #line default
            #line hidden
            return;
            case 39:
            
            #line 137 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.fox);
            
            #line default
            #line hidden
            return;
            case 40:
            
            #line 140 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.foxlife);
            
            #line default
            #line hidden
            return;
            case 41:
            
            #line 143 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.mtvdance);
            
            #line default
            #line hidden
            return;
            case 42:
            
            #line 146 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.mtvlivehd);
            
            #line default
            #line hidden
            return;
            case 43:
            
            #line 149 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.mtvrus);
            
            #line default
            #line hidden
            return;
            case 44:
            
            #line 152 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.natgeowild);
            
            #line default
            #line hidden
            return;
            case 45:
            
            #line 155 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.nationalgeographic);
            
            #line default
            #line hidden
            return;
            case 46:
            
            #line 158 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.nationalgeographichd);
            
            #line default
            #line hidden
            return;
            case 47:
            
            #line 161 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.nickjr);
            
            #line default
            #line hidden
            return;
            case 48:
            
            #line 164 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.nick);
            
            #line default
            #line hidden
            return;
            case 49:
            
            #line 167 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.nickhd);
            
            #line default
            #line hidden
            return;
            case 50:
            
            #line 170 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.rutv);
            
            #line default
            #line hidden
            return;
            case 51:
            
            #line 173 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.russiatoday);
            
            #line default
            #line hidden
            return;
            case 52:
            
            #line 176 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.russiatodaydoc);
            
            #line default
            #line hidden
            return;
            case 53:
            
            #line 179 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.rtg);
            
            #line default
            #line hidden
            return;
            case 54:
            
            #line 182 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.setsd);
            
            #line default
            #line hidden
            return;
            case 55:
            
            #line 185 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.sonyscifi);
            
            #line default
            #line hidden
            return;
            case 56:
            
            #line 188 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.tiji);
            
            #line default
            #line hidden
            return;
            case 57:
            
            #line 191 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.tlc);
            
            #line default
            #line hidden
            return;
            case 58:
            
            #line 194 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.tlchd);
            
            #line default
            #line hidden
            return;
            case 59:
            
            #line 197 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.traveladventure);
            
            #line default
            #line hidden
            return;
            case 60:
            
            #line 200 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.eurokino);
            
            #line default
            #line hidden
            return;
            case 61:
            
            #line 203 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.tvxxi);
            
            #line default
            #line hidden
            return;
            case 62:
            
            #line 206 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.tv1000);
            
            #line default
            #line hidden
            return;
            case 63:
            
            #line 209 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.tv1000action);
            
            #line default
            #line hidden
            return;
            case 64:
            
            #line 212 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.tv1000ruskino);
            
            #line default
            #line hidden
            return;
            case 65:
            
            #line 215 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.mtv80s);
            
            #line default
            #line hidden
            return;
            case 66:
            
            #line 218 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.viasatexplore);
            
            #line default
            #line hidden
            return;
            case 67:
            
            #line 221 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.viasathistory);
            
            #line default
            #line hidden
            return;
            case 68:
            
            #line 224 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.viasatnature);
            
            #line default
            #line hidden
            return;
            case 69:
            
            #line 227 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.viasatsporthd);
            
            #line default
            #line hidden
            return;
            case 70:
            
            #line 230 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.tv1000comedy);
            
            #line default
            #line hidden
            return;
            case 71:
            
            #line 233 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.tv1000megahit);
            
            #line default
            #line hidden
            return;
            case 72:
            
            #line 236 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.tv1000premiere);
            
            #line default
            #line hidden
            return;
            case 73:
            
            #line 239 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.tv1000serial);
            
            #line default
            #line hidden
            return;
            case 74:
            
            #line 242 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.zoopark);
            
            #line default
            #line hidden
            return;
            case 75:
            
            #line 245 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.auto24);
            
            #line default
            #line hidden
            return;
            case 76:
            
            #line 248 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.autoplus);
            
            #line default
            #line hidden
            return;
            case 77:
            
            #line 251 "..\..\..\channels\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.bash24);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

