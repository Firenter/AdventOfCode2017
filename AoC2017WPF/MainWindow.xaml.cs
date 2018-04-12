using AoC2017WPF.Days;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AoC2017WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            for (int i = 1; i < 26; i++)
            {
                DayInput inputSimple = new DayInput()
                {
                    Day = i,
                    ExecutionType = ExecutionType.Simple
                };

                DayInput inputAdvanced = new DayInput()
                {
                    Day = i,
                    ExecutionType = ExecutionType.Advanced
                };

                Button dayButtonSimple = new Button
                {
                    Name = "Day" + i + "SimpleButton",
                    Content = "Day " + i + " Simple",
                    Tag = inputSimple,
                    Width = 100,
                    Height = 25
                };

                Button dayButtonAdvanced = new Button
                {
                    Name = "Day" + i + "AdvancedButton",
                    Content = "Day " + i + " Advanced",
                    Tag = inputAdvanced,
                    Width = 100,
                    Height = 25
                };

                dayButtonSimple.Click += DoDay;

                dayButtonAdvanced.Click += DoDay;

                SimplePanel.Children.Add(dayButtonSimple);
                AdvancedPanel.Children.Add(dayButtonAdvanced);
            }


        }

        public void DoDay(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;

            DayInput day = (DayInput)btn.Tag;
            IDay dayToDo;

            switch (day.Day)
            {
                case 1:
                    dayToDo = new Day1();
                    break;
                case 2:
                    dayToDo = new Day2();
                    break;
                default:
                    dayToDo = null;
                    break;
            }

            if (dayToDo != null)
            {
                string solution = "";
                if (day.ExecutionType == ExecutionType.Simple)
                    solution = dayToDo.ExecuteSimple();
                else
                    solution = dayToDo.ExecuteAdvanced();

                MessageBox.Show(solution, "Solution");
            }
            else
            {
                MessageBox.Show("Day not found!", "Error");
            }
        }
    }
}
