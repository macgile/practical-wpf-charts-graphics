﻿#pragma checksum "..\..\AreaCharts.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "176E683C3D3F60C87AB88A5064FB0E79"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3074
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


namespace Specialized2DCharts {
    
    
    /// <summary>
    /// AreaCharts
    /// </summary>
    public partial class AreaCharts : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 5 "..\..\AreaCharts.xaml"
        internal System.Windows.Controls.Grid grid1;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\AreaCharts.xaml"
        internal System.Windows.Controls.ColumnDefinition column1;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\AreaCharts.xaml"
        internal System.Windows.Controls.RowDefinition row1;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\AreaCharts.xaml"
        internal System.Windows.Controls.TextBlock tbTitle;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\AreaCharts.xaml"
        internal System.Windows.Controls.TextBlock tbXLabel;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\AreaCharts.xaml"
        internal System.Windows.Controls.TextBlock tbYLabel;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\AreaCharts.xaml"
        internal System.Windows.Controls.Grid chartGrid;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\AreaCharts.xaml"
        internal System.Windows.Controls.Canvas textCanvas;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\AreaCharts.xaml"
        internal System.Windows.Controls.Canvas chartCanvas;
        
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
            System.Uri resourceLocater = new System.Uri("/Specialized2DCharts;component/areacharts.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AreaCharts.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.grid1 = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.column1 = ((System.Windows.Controls.ColumnDefinition)(target));
            return;
            case 3:
            this.row1 = ((System.Windows.Controls.RowDefinition)(target));
            return;
            case 4:
            this.tbTitle = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.tbXLabel = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.tbYLabel = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.chartGrid = ((System.Windows.Controls.Grid)(target));
            
            #line 33 "..\..\AreaCharts.xaml"
            this.chartGrid.SizeChanged += new System.Windows.SizeChangedEventHandler(this.chartGrid_SizeChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.textCanvas = ((System.Windows.Controls.Canvas)(target));
            return;
            case 9:
            this.chartCanvas = ((System.Windows.Controls.Canvas)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
