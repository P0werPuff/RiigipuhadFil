using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RiigipuhadFil
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class June : ContentPage
    {
        public June()
        {
            Button btn1;
            InitializeComponent();
            AbsoluteLayout absoluteLayout = new AbsoluteLayout();
            absoluteLayout.Children.Add(
                new Label { Text = "Июнь 2021", FontSize = 30 },
                new Rectangle(250, 20, 200, 60)
            );
            absoluteLayout.Children.Add(
                new Label { Text = "Дни в месяце", FontSize = 25 },
                new Rectangle(30, 100, 200, 60)
            );
            absoluteLayout.Children.Add(
                new Label { Text = "Календаре: 30 дней", FontSize = 15 },
                new Rectangle(30, 150, 200, 60)
            );
            absoluteLayout.Children.Add(
                new Label { Text = "Рабочие дни: 21 дней", FontSize = 15 },
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
                new Label { Text = "1-ого: День защиты детей", FontSize = 15 },
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
            DisplayAlert("Children Protection Day", "Child protection is the safeguarding of " +
            "children from violence, exploitation, abuse, and neglect." +
            " One of the ways to ensure this is by giving them quality education, the fourth " +
            "of the United Nations Sustainable Development Goals, in addition to other child protection systems.", "OK");
        }
    }
}