using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
namespace Test10App
{
    class main
    {
        public main()
        {
            Image logo = new Image
            {
                Aspect = Aspect.AspectFit,
                Source = ImageSource.FromFile("logo.png"),
                WidthRequest = 180,
                HeightRequest = 170,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
            };
            Image tracker = new Image
            {
                Aspect = Aspect.AspectFit,
                Source = ImageSource.FromFile("icon_tracker.png"),
                WidthRequest = 120,
                HeightRequest = 170,
                HorizontalOptions = LayoutOptions.Start,
            };
            Image updates = new Image
            {
                Aspect = Aspect.AspectFit,
                Source = ImageSource.FromFile("icon_updates.png"),
                WidthRequest = 120,
                HeightRequest = 170,
                HorizontalOptions = LayoutOptions.Start,
            };
            Image more = new Image
            {
                Aspect = Aspect.AspectFit,
                Source = ImageSource.FromFile("icon_more.png"),
                WidthRequest = 120,
                HeightRequest = 170,
                HorizontalOptions = LayoutOptions.Start,
            };
            // The root page of your application
            //MainPage = new ContentPage
            //{
            //    BackgroundImage = "blauwe_achtergrond.jpg",
            //    Content = new StackLayout
            //    {
            //        VerticalOptions = LayoutOptions.StartAndExpand,
            //        Children = {
            //            new StackLayout
            //            {
            //                Orientation = StackOrientation.Horizontal,
            //                HorizontalOptions = LayoutOptions.StartAndExpand,
            //                Children =
            //                {
            //                    logo
            //                }
            //            },
            //            new StackLayout
            //            {
            //                Orientation = StackOrientation.Horizontal,
            //                HorizontalOptions = LayoutOptions.StartAndExpand,
            //                Children =
            //                {
            //                    tracker,
            //                    updates,
            //                    more
            //                }
            //            }
            //        }
            //    }
            //};
        }
    }
}
