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
                                new Label {
                                    Text = "About Rick",
                                    FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
                                    HorizontalOptions = LayoutOptions.CenterAndExpand,
                                }
                            }
                        },
                        new StackLayout
                        {
                            Orientation = StackOrientation.Horizontal,
                            HorizontalOptions = LayoutOptions.StartAndExpand,
                            Children =
                            {
                                new Label {
                                    Text = "My name is Rick Creemers, 22 years old, from Utrecht. Nice to meet you! My big adventure with lots of up's and downs started when I was 16 years old. My sister started studying and decided to move to Amsterdam. My mother, stepfather and little sister also moved out, they followed their life long dream and emigrated to France. I stayed in Holland and after graduating from secondary school I started living on my own in Utrecht. ",
                                    FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                                    HorizontalOptions = LayoutOptions.CenterAndExpand,
                                }
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
