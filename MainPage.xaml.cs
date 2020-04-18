using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


//for RadialController 
using Windows.UI.Input;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SurfaceDial_Demo
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            InitializeController();
        }

        private RadialController radialController;
        private RadialControllerConfiguration radialControllerConfig;
        private RadialControllerMenuItem defend = RadialControllerMenuItem.CreateFromFontGlyph("Defend", "\xE1A7", "Segoe MDL2 Assets");
        private RadialControllerMenuItem cmd = RadialControllerMenuItem.CreateFromFontGlyph("Commands", "\xE756", "Segoe MDL2 Assets");

        private void InitializeController()
        {
            radialController = RadialController.CreateForCurrentView();
            radialController.RotationResolutionInDegrees = 10;

            radialController.Menu.Items.Add(defend);
            radialController.Menu.Items.Add(cmd);


            //remove defaults so only the added menu items above shows up.
            radialControllerConfig = RadialControllerConfiguration.GetForCurrentView();
            radialControllerConfig.SetDefaultMenuItems(new RadialControllerSystemMenuItemKind[] { });
        }
    }
}
