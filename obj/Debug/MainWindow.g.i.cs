// Updated by XamlIntelliSenseFileGenerator 03.12.2020 19:03:45
#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E314548D205FCDF3B2773269D3EEAF63F05C96E0DEFB1407560E235700887F82"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using EmergenceGuardian.MpvPlayerUI;
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


namespace WpfApp1
{


    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector
    {

#line default
#line hidden


#line 27 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Grid1;

#line default
#line hidden


#line 34 "..\..\MainWindow.xaml"
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
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/PeersTV;component/mainwindow.xaml", System.UriKind.Relative);

#line 1 "..\..\MainWindow.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.main = ((WpfApp1.MainWindow)(target));
                    return;
                case 2:

#line 12 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LaunchTelegram);

#line default
#line hidden
                    return;
                case 3:

#line 15 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DevChannel);

#line default
#line hidden
                    return;
                case 4:
                    this.Grid1 = ((System.Windows.Controls.Grid)(target));
                    return;
                case 5:
                    this.vlcPlayer = ((Vlc.DotNet.Wpf.VlcControl)(target));
                    return;
                case 6:

#line 36 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.kanal12);

#line default
#line hidden
                    return;
                case 7:

#line 39 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.hd1music);

#line default
#line hidden
                    return;
                case 8:

#line 42 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.day365);

#line default
#line hidden
                    return;
                case 9:

#line 45 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.nsk49);

#line default
#line hidden
                    return;
                case 10:

#line 48 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.kanal8);

#line default
#line hidden
                    return;
                case 11:

#line 51 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.kanal8krasn);

#line default
#line hidden
                    return;
                case 12:

#line 54 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.amedia1);

#line default
#line hidden
                    return;
                case 13:

#line 57 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.amedia2);

#line default
#line hidden
                    return;
                case 14:

#line 60 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.amediahit);

#line default
#line hidden
                    return;
                case 15:

#line 63 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.amediapremium);

#line default
#line hidden
                    return;
                case 16:

#line 66 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.animalplanet);

#line default
#line hidden
                    return;
                case 17:

#line 69 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.animalplanethd);

#line default
#line hidden
                    return;
                case 18:

#line 72 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.bridgetv);

#line default
#line hidden
                    return;
                case 19:

#line 75 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.bridgetvclassic);

#line default
#line hidden
                    return;
                case 20:

#line 78 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.bridgetvdeluxe);

#line default
#line hidden
                    return;
                case 21:

#line 81 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.bridgetvhits);

#line default
#line hidden
                    return;
                case 22:

#line 84 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.bridgetvrus);

#line default
#line hidden
                    return;
                case 23:

#line 87 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.cartoonnetwork);

#line default
#line hidden
                    return;
                case 24:

#line 90 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.cinema);

#line default
#line hidden
                    return;
                case 25:

#line 93 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.davinchi);

#line default
#line hidden
                    return;
                case 26:

#line 96 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.discoverychannel);

#line default
#line hidden
                    return;
                case 27:

#line 99 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.discoveryhd);

#line default
#line hidden
                    return;
                case 28:

#line 102 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.disney);

#line default
#line hidden
                    return;
                case 29:

#line 105 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.docubox);

#line default
#line hidden
                    return;
                case 30:

#line 108 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.dtx);

#line default
#line hidden
                    return;
                case 31:

#line 111 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.euronews);

#line default
#line hidden
                    return;
                case 32:

#line 114 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.eurosport1);

#line default
#line hidden
                    return;
                case 33:

#line 117 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.eurosport1hd);

#line default
#line hidden
                    return;
                case 34:

#line 120 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.eurosport2);

#line default
#line hidden
                    return;
                case 35:

#line 123 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.eurosport2hd);

#line default
#line hidden
                    return;
                case 36:

#line 126 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.extremesports);

#line default
#line hidden
                    return;
                case 37:

#line 129 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.fashiontv);

#line default
#line hidden
                    return;
                case 38:

#line 132 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.filmbox);

#line default
#line hidden
                    return;
                case 39:

#line 135 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.filmboxart);

#line default
#line hidden
                    return;
                case 40:

#line 138 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.fox);

#line default
#line hidden
                    return;
                case 41:

#line 141 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.foxlife);

#line default
#line hidden
                    return;
                case 42:

#line 144 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.mtvdance);

#line default
#line hidden
                    return;
                case 43:

#line 147 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.mtvlivehd);

#line default
#line hidden
                    return;
                case 44:

#line 150 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.mtvrus);

#line default
#line hidden
                    return;
                case 45:

#line 153 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.natgeowild);

#line default
#line hidden
                    return;
                case 46:

#line 156 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.nationalgeographic);

#line default
#line hidden
                    return;
                case 47:

#line 159 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.nationalgeographichd);

#line default
#line hidden
                    return;
                case 48:

#line 162 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.nickjr);

#line default
#line hidden
                    return;
                case 49:

#line 165 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.nick);

#line default
#line hidden
                    return;
                case 50:

#line 168 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.nickhd);

#line default
#line hidden
                    return;
                case 51:

#line 171 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.rutv);

#line default
#line hidden
                    return;
                case 52:

#line 174 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.russiatoday);

#line default
#line hidden
                    return;
                case 53:

#line 177 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.russiatodaydoc);

#line default
#line hidden
                    return;
                case 54:

#line 180 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.rtg);

#line default
#line hidden
                    return;
                case 55:

#line 183 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.setsd);

#line default
#line hidden
                    return;
                case 56:

#line 186 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.sonyscifi);

#line default
#line hidden
                    return;
                case 57:

#line 189 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.tiji);

#line default
#line hidden
                    return;
                case 58:

#line 192 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.tlc);

#line default
#line hidden
                    return;
                case 59:

#line 195 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.tlchd);

#line default
#line hidden
                    return;
                case 60:

#line 198 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.traveladventure);

#line default
#line hidden
                    return;
                case 61:

#line 201 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.eurokino);

#line default
#line hidden
                    return;
                case 62:

#line 204 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.tvxxi);

#line default
#line hidden
                    return;
                case 63:

#line 207 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.tv1000);

#line default
#line hidden
                    return;
                case 64:

#line 210 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.tv1000action);

#line default
#line hidden
                    return;
                case 65:

#line 213 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.tv1000ruskino);

#line default
#line hidden
                    return;
                case 66:

#line 216 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.mtv80s);

#line default
#line hidden
                    return;
                case 67:

#line 219 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.viasatexplore);

#line default
#line hidden
                    return;
                case 68:

#line 222 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.viasathistory);

#line default
#line hidden
                    return;
                case 69:

#line 225 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.viasatnature);

#line default
#line hidden
                    return;
                case 70:

#line 228 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.viasatsporthd);

#line default
#line hidden
                    return;
                case 71:

#line 231 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.tv1000comedy);

#line default
#line hidden
                    return;
                case 72:

#line 234 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.tv1000megahit);

#line default
#line hidden
                    return;
                case 73:

#line 237 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.tv1000premiere);

#line default
#line hidden
                    return;
                case 74:

#line 240 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.tv1000serial);

#line default
#line hidden
                    return;
                case 75:

#line 243 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.zoopark);

#line default
#line hidden
                    return;
                case 76:

#line 246 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.auto24);

#line default
#line hidden
                    return;
                case 77:

#line 249 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.autoplus);

#line default
#line hidden
                    return;
                case 78:

#line 252 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.bash24);

#line default
#line hidden
                    return;
                case 79:

#line 255 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.boxtv);

#line default
#line hidden
                    return;
                case 80:

#line 258 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.muzkoi);

#line default
#line hidden
                    return;
                case 81:

#line 261 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.vremya);

#line default
#line hidden
                    return;
                case 82:

#line 264 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.vsyaufa);

#line default
#line hidden
                    return;
                case 83:

#line 267 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.unikum);

#line default
#line hidden
                    return;
                case 84:

#line 270 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.detmir);

#line default
#line hidden
                    return;
                case 85:

#line 273 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.dialogioribalke);

#line default
#line hidden
                    return;
                case 86:

#line 276 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.domkino);

#line default
#line hidden
                    return;
                case 87:

#line 279 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.domasnii);

#line default
#line hidden
                    return;
                case 88:

#line 282 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.don24);

#line default
#line hidden
                    return;
                case 89:

#line 285 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.evpatoriatv);

#line default
#line hidden
                    return;
                case 90:

#line 288 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ege);

#line default
#line hidden
                    return;
                case 91:

#line 291 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.jivayaplaneta);

#line default
#line hidden
                    return;
                case 92:

#line 294 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.jivi);

#line default
#line hidden
                    return;
                case 93:

#line 297 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.zagorodlive);

#line default
#line hidden
                    return;
                case 94:

#line 300 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.zvezda);

#line default
#line hidden
                    return;
                case 95:

#line 303 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.yamalregion);

#line default
#line hidden
                    return;
                case 96:

#line 306 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.zootv);

#line default
#line hidden
                    return;
                case 97:

#line 309 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.rusillussion);

#line default
#line hidden
                    return;
                case 98:

#line 312 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.illussionplus);

#line default
#line hidden
                    return;
                case 99:

#line 315 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.inndiiskoekino);

#line default
#line hidden
                    return;
                case 100:

#line 318 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.june);

#line default
#line hidden
                    return;
                case 101:

#line 321 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.kaleidoscopetv);

#line default
#line hidden
                    return;
                case 102:

#line 324 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.karusel);

#line default
#line hidden
                    return;
                case 103:

#line 327 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.karusel);

#line default
#line hidden
                    return;
                case 104:

#line 330 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.kinocomedy);

#line default
#line hidden
                    return;
                case 105:

#line 333 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.kinomix);

#line default
#line hidden
                    return;
                case 106:

#line 336 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.classickino);

#line default
#line hidden
                    return;
                case 107:

#line 339 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.controlzakup);

#line default
#line hidden
                    return;
                case 108:

#line 342 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.kriktv);

#line default
#line hidden
                    return;
                case 109:

#line 345 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.krym24);

#line default
#line hidden
                    return;
                case 110:

#line 348 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.kubal24orbita);

#line default
#line hidden
                    return;
                case 111:

#line 351 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.kithentv);

#line default
#line hidden
                    return;
                case 112:

#line 354 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.khl);

#line default
#line hidden
                    return;
                case 113:

#line 357 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.khlhd);

#line default
#line hidden
                    return;
                case 114:

#line 360 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ldprtv);

#line default
#line hidden
                    return;
                case 115:

#line 363 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.lubimoekino);

#line default
#line hidden
                    return;
                case 116:

#line 366 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.laminor);

#line default
#line hidden
                    return;
                case 117:

#line 369 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.mama);

#line default
#line hidden
                    return;
                case 118:

#line 372 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.match);

#line default
#line hidden
                    return;
                case 119:

#line 375 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.matchhd);

#line default
#line hidden
                    return;
                case 120:

#line 378 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.matcharena);

#line default
#line hidden
                    return;
                case 121:

#line 381 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.matcharenahd);

#line default
#line hidden
                    return;
                case 122:

#line 384 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.matchboew);

#line default
#line hidden
                    return;
                case 123:

#line 387 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.matchigra);

#line default
#line hidden
                    return;
                case 124:

#line 390 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.matchnashsport);

#line default
#line hidden
                    return;
                case 125:

#line 393 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.matchfootball1);

#line default
#line hidden
                    return;
                case 126:

#line 396 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.matchfootball2);

#line default
#line hidden
                    return;
                case 127:

#line 399 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.matchfootball3);

#line default
#line hidden
                    return;
                case 128:

#line 402 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.mir);

#line default
#line hidden
                    return;
                case 129:

#line 405 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.mir24);

#line default
#line hidden
                    return;
                case 130:

#line 408 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.mirseriala);

#line default
#line hidden
                    return;
                case 131:

#line 411 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.moscow24);

#line default
#line hidden
                    return;
                case 132:

#line 414 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.myplannet);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }

        internal MahApps.Metro.Controls.MetroWindow main;
    }
}

