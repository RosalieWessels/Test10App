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
            Image about_me = new Image
            {
                Aspect = Aspect.AspectFit,
                Source = ImageSource.FromFile("icon_about_me.png"),
                WidthRequest = 120,
                HeightRequest = 170,
                HorizontalOptions = LayoutOptions.Start,
            };
            Image images = new Image
            {
                Aspect = Aspect.AspectFit,
                Source = ImageSource.FromFile("icon_camera.png"),
                WidthRequest = 120,
                HeightRequest = 170,
                HorizontalOptions = LayoutOptions.Start,
            };
            Image support= new Image
            {
                Aspect = Aspect.AspectFit,
                Source = ImageSource.FromFile("icon_support.png"),
                WidthRequest = 120,
                HeightRequest = 170,
                HorizontalOptions = LayoutOptions.Start,
            };
            Image movies = new Image
            {
                Aspect = Aspect.AspectFit,
                Source = ImageSource.FromFile("icon_movies.png"),
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
                                about_me,
                                images,
                            }
                        },
                        new StackLayout
                        {
                            Orientation = StackOrientation.Horizontal,
                            HorizontalOptions = LayoutOptions.StartAndExpand,
                            Children =
                            {
                                support,
                                movies
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
