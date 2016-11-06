using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Test10App
{
    public class App : Application
    {
        public App()
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
            MainPage = new ContentPage
            {
                BackgroundImage = "blauwe_achtergrond.jpg",
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.StartAndExpand,
                    Children = {
                        new StackLayout
                        {
                            Orientation = StackOrientation.Horizontal,
                            HorizontalOptions = LayoutOptions.StartAndExpand,
                            Children =
                            { 
                                logo
                            }
                        },
                        new StackLayout
                        {
                            Orientation = StackOrientation.Horizontal,
                            HorizontalOptions = LayoutOptions.StartAndExpand,
                            Children =
                            {
                                tracker,
                                updates,
                                more
                            }
                        }
                    }
                }
            };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
