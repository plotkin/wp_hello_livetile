using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using WP8_LiveTiles.Resources;

namespace WP8_LiveTiles
{
    public partial class MainPage : PhoneApplicationPage
    {

        // Constructor
        public MainPage()
        {
            InitializeComponent();
            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }



        private void btnFlipTile_Click(object sender, RoutedEventArgs e)
        {
            // find the tile object for the application tile that using "flip" contains string in it.
            ShellTile oTile = ShellTile.ActiveTiles.FirstOrDefault(x => x.NavigationUri.ToString().Contains("flip".ToString()));


            if (oTile != null && oTile.NavigationUri.ToString().Contains("flip"))
            {
                FlipTileData oFliptile = new FlipTileData();
                oFliptile.Title = "Hello WP8!!";
                oFliptile.Count = 11;
                oFliptile.BackTitle = "Updated Flip Tile";

                oFliptile.BackContent = "back of tile";
                oFliptile.WideBackContent = "back of the wide tile";

                oFliptile.SmallBackgroundImage = new Uri("Assets/Tiles/Flip/159x159.png", UriKind.Relative);
                oFliptile.BackgroundImage = new Uri("Assets/Tiles/Flip/336x336.png", UriKind.Relative);
                oFliptile.WideBackgroundImage = new Uri("Assets/Tiles/Flip/691x336.png", UriKind.Relative);

                oFliptile.BackBackgroundImage = new Uri("/Assets/Tiles/Flip/A336.png", UriKind.Relative);
                oFliptile.WideBackBackgroundImage = new Uri("/Assets/Tiles/Flip/A691.png", UriKind.Relative);
                oTile.Update(oFliptile);
                MessageBox.Show("Flip Tile Data successfully update.");
            }
            else
            {
                // once it is created flip tile
                Uri tileUri = new Uri("/MainPage.xaml?tile=flip", UriKind.Relative);
                ShellTileData tileData = this.CreateFlipTileData();
                ShellTile.Create(tileUri, tileData, true);
            }
        }

        private ShellTileData CreateFlipTileData()
        {
            return new FlipTileData()
            {
                Title = "Hi Flip Tile",
                BackTitle = "This is WP8 flip tile",
                BackContent = "Live Tile Demo",
                WideBackContent = "Hello Nokia Lumia 920",
                Count = 8,
                SmallBackgroundImage = new Uri("/Assets/Tiles/Flip/A159.png", UriKind.Relative),
                BackgroundImage = new Uri("/Assets/Tiles/Flip/A336.png", UriKind.Relative),
                WideBackgroundImage = new Uri("/Assets/Tiles/Flip/A691.png", UriKind.Relative),
            };
        }


        private void btnIconicTile_Click(object sender, RoutedEventArgs e)
        {
            IconicTileData oIcontile = new IconicTileData();
            oIcontile.Title = "Hello Iconic Tile!!";
            oIcontile.Count = 7;

            oIcontile.IconImage = new Uri("Assets/Tiles/Iconic/202x202.png", UriKind.Relative);
            oIcontile.SmallIconImage = new Uri("Assets/Tiles/Iconic/110x110.png", UriKind.Relative);

            oIcontile.WideContent1 = "windows phone 8 Live tile";
            oIcontile.WideContent2 = "Icon tile";
            oIcontile.WideContent3 = "All about Live tiles By WmDev";
            oIcontile.BackgroundColor = System.Windows.Media.Colors.Orange;

            // find the tile object for the application tile that using "Iconic" contains string in it.
            ShellTile TileToFind = ShellTile.ActiveTiles.FirstOrDefault(x => x.NavigationUri.ToString().Contains("Iconic".ToString()));

            if (TileToFind != null && TileToFind.NavigationUri.ToString().Contains("Iconic"))
            {
                TileToFind.Delete();
                ShellTile.Create(new Uri("/MainPage.xaml?id=Iconic", UriKind.Relative), oIcontile, true);
            }
            else
            {
                ShellTile.Create(new Uri("/MainPage.xaml?id=Iconic", UriKind.Relative), oIcontile, true);
            }

        }


        private void btnCycleTile_Click(object sender, RoutedEventArgs e)
        {
            CycleTileData oCycleicon = new CycleTileData();
            oCycleicon.Title = "Hello Cycle Icon!!";
            oCycleicon.Count = 9;

            oCycleicon.SmallBackgroundImage = new Uri("Assets/Tiles/Cycle/159x159.png", UriKind.Relative);

           
            //List<Uri> images = new List<Uri>();
            //images.Add(new Uri("Assets/Tiles/Cycle/001.jpg", UriKind.Relative));
            //images.Add(new Uri("Assets/Tiles/Cycle/002.jpg", UriKind.Relative));
            //images.Add(new Uri("Assets/Tiles/Cycle/003.jpg", UriKind.Relative));
            //images.Add(new Uri("Assets/Tiles/Cycle/004.jpg", UriKind.Relative));
            //images.Add(new Uri("Assets/Tiles/Cycle/005.jpg", UriKind.Relative));
            //images.Add(new Uri("Assets/Tiles/Cycle/006.jpg", UriKind.Relative));
            //images.Add(new Uri("Assets/Tiles/Cycle/007.jpg", UriKind.Relative));
            //images.Add(new Uri("Assets/Tiles/Cycle/008.jpg", UriKind.Relative));
            //images.Add(new Uri("Assets/Tiles/Cycle/009.jpg", UriKind.Relative));
            //oCycleicon.CycleImages = images;

            //// Images could be max Nine images.
            oCycleicon.CycleImages = new Uri[]
               {
                  new Uri("Assets/Tiles/Cycle/001.jpg", UriKind.Relative), 
                  new Uri("Assets/Tiles/Cycle/002.jpg", UriKind.Relative), 
                  new Uri("Assets/Tiles/Cycle/003.jpg", UriKind.Relative), 
                  new Uri("Assets/Tiles/Cycle/004.jpg", UriKind.Relative), 
                  new Uri("Assets/Tiles/Cycle/005.jpg", UriKind.Relative), 
                  new Uri("Assets/Tiles/Cycle/006.jpg", UriKind.Relative), 
                  new Uri("Assets/Tiles/Cycle/007.jpg", UriKind.Relative), 
                  new Uri("Assets/Tiles/Cycle/008.jpg", UriKind.Relative), 
                  new Uri("Assets/Tiles/Cycle/009.jpg", UriKind.Relative), 
               };



            // find the tile object for the application tile that using "cycle" contains string in it.
            ShellTile TileToFind = ShellTile.ActiveTiles.FirstOrDefault(x => x.NavigationUri.ToString().Contains("cycle".ToString()));

            if (TileToFind != null && TileToFind.NavigationUri.ToString().Contains("cycle"))
            {
                TileToFind.Delete();
                ShellTile.Create(new Uri("/MainPage.xaml?id=cycle", UriKind.Relative), oCycleicon, true);
            }
            else
            {
                ShellTile.Create(new Uri("/MainPage.xaml?id=cycle", UriKind.Relative), oCycleicon, true);
            }
        }


       

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}