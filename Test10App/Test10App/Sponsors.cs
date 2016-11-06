using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Test10App
{
    class Sponsors
    {
        public Sponsors()
        {
            Image xsocks = new Image
            {
                Aspect = Aspect.AspectFit,
                Source = ImageSource.FromFile("x_socks_logo.png"),
                WidthRequest = 180,
                HeightRequest = 170,
                HorizontalOptions = LayoutOptions.Start,
            };
            xsocks.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(() =>
                {
                    Device.OpenUri(new Uri("https://www.x-socks.com/"));
                }),
                NumberOfTapsRequired = 1
            });

            Image ortlieb = new Image
            {
                Aspect = Aspect.AspectFit,
                Source = ImageSource.FromFile("ortlieb_logo.png"),
                WidthRequest = 220,
                HeightRequest = 170,
                HorizontalOptions = LayoutOptions.End,
            };
            ortlieb.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(() =>
                {
                    Device.OpenUri(new Uri("https://www.ortlieb.com"));
                }),
                NumberOfTapsRequired = 1
            });

            Image technolyt = new Image
            {
                Aspect = Aspect.AspectFit,
                Source = ImageSource.FromFile("logo_Technolyt_payoff_FC.png"),
                WidthRequest = 180,
                HeightRequest = 170,
                HorizontalOptions = LayoutOptions.Start,
            };
            technolyt.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(() =>
                {
                    Device.OpenUri(new Uri("http://www.technolyt.nl/"));
                }),
                NumberOfTapsRequired = 1
            });

            Image santos = new Image
            {
                Aspect = Aspect.AspectFit,
                Source = ImageSource.FromFile("logo_santos_built_for_life_kader.png"),
                WidthRequest = 200,
                HeightRequest = 170,
                HorizontalOptions = LayoutOptions.End
            };
            santos.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(() =>
                {
                    Device.OpenUri(new Uri("http://www.santosbikes.com/"));
                }),
                NumberOfTapsRequired = 1
            });

            Image kok = new Image
            {
                Aspect = Aspect.AspectFit,
                Source = ImageSource.FromFile("logo_kok_fietsen.png"),
                WidthRequest = 200,
                HeightRequest = 170,
                HorizontalOptions = LayoutOptions.Start
            };
            kok.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(() =>
                {
                    Device.OpenUri(new Uri("http://kokfietsen.nl/"));
                }),
                NumberOfTapsRequired = 1
            });

            Image xtorm = new Image
            {
                Aspect = Aspect.AspectFit,
                Source = ImageSource.FromFile("xtorm_logo_nobg_tc_greyfc_hr.png"),
                WidthRequest = 200,
                HeightRequest = 170,
                HorizontalOptions = LayoutOptions.End
            };
            xtorm.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(() =>
                {
                    Device.OpenUri(new Uri("http://www.xtorm.eu/nl/home/"));
                }),
                NumberOfTapsRequired = 1
            });

            // The root page of your application
            //MainPage = new ContentPage
            //{
            //    BackgroundImage = "blauwe_achtergrond.jpg",
            //    Content = new StackLayout
            //    {
            //        VerticalOptions = LayoutOptions.Center,
            //        Children = {
            //            new StackLayout
            //            {
            //                Orientation = StackOrientation.Horizontal,
            //                HorizontalOptions = LayoutOptions.StartAndExpand,
            //                Children =
            //                {
            //                    ortlieb,
            //                    xsocks,
            //                }
            //            },
            //            new StackLayout
            //            {
            //                Orientation = StackOrientation.Horizontal,
            //                HorizontalOptions = LayoutOptions.StartAndExpand,
            //                Children =
            //                {
            //                    kok,
            //                    santos
            //                }
            //            },
            //            new StackLayout
            //            {
            //                Orientation = StackOrientation.Horizontal,
            //                HorizontalOptions = LayoutOptions.StartAndExpand,
            //                Children =
            //                {
            //                    technolyt,
            //                    xtorm
            //                }
            //            },

            //        }
            //    }
            //};
        }
    }
}
