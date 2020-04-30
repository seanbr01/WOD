using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WOD_CharacterSheet_2nd
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<CheckBox> MoralityCheckBoxes { get; set; } = new List<CheckBox>();
        public List<CheckBox> SpentWillpowerCheckBoxes { get; set; } = new List<CheckBox>();
        MainWindowVM mainWindowVM = new MainWindowVM();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (CheckBox checkBox in mainWindowVM.FindVisualChildren<CheckBox>(GetWindow(this)))
            {
                switch (mainWindowVM.GetControllerFamily(checkBox))
                {
                    case "MoralityCheckBox":
                        MoralityCheckBoxes.Add(checkBox);
                        break;
                    case "SpentWillpower":
                        SpentWillpowerCheckBoxes.Add(checkBox);
                        break;
                    default:
                        break;
                }
            }

            MoralityCheckBoxes = MoralityCheckBoxes.OrderBy(cb => mainWindowVM.GetControllerValue(cb)).ToList();
            SpentWillpowerCheckBoxes = SpentWillpowerCheckBoxes.OrderBy(cb => mainWindowVM.GetControllerValue(cb)).ToList();
        }

        private void MoralityCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            var checkBox = (CheckBox)sender;
            mainWindowVM.DisplayCheckBoxes(checkBox, MoralityCheckBoxes);
        }

        private void WillpowerCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            var checkBox = (CheckBox)sender;
            mainWindowVM.DisplayCheckBoxes(checkBox, SpentWillpowerCheckBoxes);
        }
    }
}
