using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RiigipuhadFil
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class February : ContentPage
    {
        public February()
        {
            Button btn1;
            InitializeComponent();
            AbsoluteLayout absoluteLayout = new AbsoluteLayout();
            absoluteLayout.Children.Add(
                new Label { Text = "Февраль 2021", FontSize = 30 },
                new Rectangle(240, 20, 200, 60)
            );
            absoluteLayout.Children.Add(
                new Label { Text = "Дни в месяце", FontSize = 25 },
                new Rectangle(30, 100, 200, 60)
            );
            absoluteLayout.Children.Add(
                new Label { Text = "В к алендаре: 28 дней", FontSize = 15 },
                new Rectangle(30, 150, 200, 60)
            );
            absoluteLayout.Children.Add(
                new Label { Text = "Рабочие дни: 19 дней", FontSize = 15 },
                new Rectangle(30, 200, 200, 60)
            );
            absoluteLayout.Children.Add(
                new Label { Text = "Выходные и праздники: 9 дней", FontSize = 15 },
                new Rectangle(30, 250, 230, 60)
            );
            absoluteLayout.Children.Add(
                new Label { Text = "Выходные и праздники", FontSize = 25 },
                new Rectangle(380, 100, 280, 60)
            );
            absoluteLayout.Children.Add(
                new Label { Text = "23 : День защитника Отечества", FontSize = 15 },
                new Rectangle(380, 150, 280, 60)

            );
            absoluteLayout.Children.Add(
                btn1 = new Button { Text = "Ёще", FontSize = 10, BackgroundColor = Color.FromHex("#00CCFF") },
                new Rectangle(315, 143, 60, 35)
            
            );
            btn1.Clicked += Btn1_Clicked;
            Content = absoluteLayout;
        }

        private void Btn1_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Defender of the Fatherland Day", "Defender of the Fatherland Day is a holiday observed in Russia, Turkmenistan, Belarus, Kyrgyzstan, Kazakhstan and Tajikistan." +
                " It is celebrated on 23 February, except in Kazakhstan, where it is celebrated on 7 May.", "OK");
        }
        
    }
}