using Prism.Regions;
using System.Windows;

namespace MySQLConnection.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(IRegionManager regionManager)
        {
            InitializeComponent();
            //view discovery for buttons
            regionManager.RegisterViewWithRegion("ButtonRegion", typeof(ButtonsView));
            //view discovery for data grid and fields region
            regionManager.RegisterViewWithRegion("DataRegion", typeof(DataView));
        }
    }
}
