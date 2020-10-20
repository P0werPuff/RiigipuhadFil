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
    public partial class July : ContentPage
    {
        public July()
        {
            InitializeComponent();
            AbsoluteLayout absoluteLayout = new AbsoluteLayout();
            absoluteLayout.Children.Add(
                new Label { Text = "Июль 2021", FontSize = 30 },
                new Rectangle(250, 20, 200, 60)
            );
            absoluteLayout.Children.Add(
                new Label { Text = "Дни в месяце", FontSize = 25 },
                new Rectangle(30, 100, 200, 60)
            );
            absoluteLayout.Children.Add(
                new Label { Text = "В к алендаре: 31 день", FontSize = 15 },
                new Rectangle(30, 150, 200, 60)
            );
            absoluteLayout.Children.Add(
                new Label { Text = "Рабочие дни: 22 Дня", FontSize = 15 },
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
                new Label { Text = "В этом месяце нет выходных", FontSize = 15 },
                new Rectangle(380, 150, 280, 60)
            );
            Content = absoluteLayout;
        }
    }
}