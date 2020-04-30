using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WOD_CharacterSheet_2nd
{
    public class MainWindowVM
    {
        public MainWindowVM()
        {
            
        }

        public void BuildCheckBoxLists(DependencyObject dependencyObject)
        {
            foreach (CheckBox cb in FindVisualChildren<CheckBox>(dependencyObject))
            {

            }
        }

        public int GetControllerValue(CheckBox controller)
        {
            string[] numbers = Regex.Split(controller.Name, @"\D+");
            foreach (string value in numbers)
            {
                if (!string.IsNullOrEmpty(value))
                {
                    int i = int.Parse(value);
                    return i;
                }
            }

            return 0;
        }

        public string GetControllerFamily(CheckBox controller)
        {
            Regex regex = new Regex(@"[a-zA-Z]+");
            Match match = regex.Match(controller.Name);

            return match.Value;
        }

        public void DisplayCheckBoxes(CheckBox selectedCheckBox, List<CheckBox> checkBoxes)
        {
            int input = GetControllerValue(selectedCheckBox);

            if (selectedCheckBox.IsChecked == true)
            {
                foreach (CheckBox checkBox in checkBoxes)
                {
                    checkBox.IsChecked = (GetControllerValue(checkBox) <= input) ? true : false;
                }
            }
            else
            {
                foreach (CheckBox checkBox in checkBoxes)
                {
                    checkBox.IsChecked = (GetControllerValue(checkBox) < input) ? true : false;
                }
            }
        }

        public IEnumerable<T> FindVisualChildren<T>(DependencyObject depObj) where T : DependencyObject
        {
            if (depObj != null)
            {
                for (int i = 0; i < VisualTreeHelper.GetChildrenCount(depObj); i++)
                {
                    DependencyObject child = VisualTreeHelper.GetChild(depObj, i);
                    if (child != null && child is T)
                    {
                        yield return (T)child;
                    }

                    foreach (T childOfChild in FindVisualChildren<T>(child))
                    {
                        yield return childOfChild;
                    }
                }
            }
        }

    }
}
