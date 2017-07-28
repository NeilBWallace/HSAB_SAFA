﻿
using System;
using System.Collections.Generic;

using System.Text;

using Xamarin.Forms;

namespace HSAB.SAFA
{


    

    

    public class What_Is_Safeguarding : ContentPage
    {
     

       


        public void refresh()
        {
            //         listView.ItemsSource = _database.GetContents();
        }

 

        public What_Is_Safeguarding(String Titles)
        {


            App.app_title = Titles;
            Title = Titles;
            BackgroundColor = Color.White;

            Label title = null;

            //  BackgroundColor = Color.FromHex("#e6b9b8");


            if (Device.OS == TargetPlatform.Windows)
            { 
                NavigationPage.SetHasNavigationBar(this, false);
            }

                BackgroundColor = Color.White;

                title = new Label
                {
                Text = "What Is Safeguarding",
                XAlign = TextAlignment.Center,
                 Font = Font.SystemFontOfSize(30),
                    BackgroundColor=Color.White
                };

                title.TextColor = Color.FromHex("#953735");

            //  var pharm = database.GetContents();

            //  BackgroundImage = "people.jpg";

            ContentView Physical_Abuse = new ContentView
            {
                Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5),
                BackgroundColor = Color.FromHex("#7D4D68"),
            Content = new Label { Text = "Safeguarding means protecting an adult's right to live in safety, free from abuse and neglect.", BackgroundColor = Color.FromHex("#7D4D68"), TextColor = Color.White, VerticalOptions = LayoutOptions.FillAndExpand, HorizontalOptions = LayoutOptions.FillAndExpand, FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)) }
            };



            ContentView Domestic_Abuse = new ContentView
            {
                Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5),
                BackgroundColor = Color.FromHex("#31859C"),

                Content = new Label { Text = "Stop abuse or neglect where possible.", TextColor = Color.White, VerticalOptions = LayoutOptions.FillAndExpand, HorizontalOptions = LayoutOptions.FillAndExpand, FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)) }
            };


            ContentView Sexual_Abuse = new ContentView
            {
                Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5),
                BackgroundColor = Color.FromHex("#C0504D"),
               Content = new Label { Text = "Prevent harm and reduce the risk of abuse or neglect in a way that supports them in making choices and having control about how they want to live.", BackgroundColor = Color.FromHex("#C0504D"), TextColor = Color.White, HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.FillAndExpand, FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)) }
            };

            ContentView Psychological_Abuse = new ContentView
            {
                Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5),
                BackgroundColor = Color.FromHex("#9BBB59"),
                Content = new Label { Text = "Raise public awareness to enable communities as a whole, together with professionals, help to prevent, identify and respond to abuse and neglect.", BackgroundColor = Color.FromHex("#9BBB59"), TextColor = Color.White, HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.FillAndExpand, FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)) }
            };
             
            var grid = new Grid
            { 
                Padding=10,
                RowSpacing = 10
            };


            grid.Children.Add(Physical_Abuse, 0, 0); // Left, First element 
            grid.Children.Add(Domestic_Abuse, 1, 0); // Right, First element 
            grid.Children.Add(Sexual_Abuse, 0, 1); // Left, Second element 
            grid.Children.Add(Psychological_Abuse, 1, 1); // Right, Second element 
          


            if (Device.OS == TargetPlatform.Windows)
            {
               Physical_Abuse.HeightRequest = 90;
               Domestic_Abuse.HeightRequest = 90;
               Sexual_Abuse.HeightRequest = 90;
                Psychological_Abuse.HeightRequest = 90;
                     }


              

            Content = grid;
        }
    }
}