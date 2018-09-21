using System.Windows.Controls;
using System.Windows.Input;

namespace Mcap.Helper
{
    public static class Extensions
    {
        public static void MakeComboBoxSearchable(this ComboBox targetComboBox)
        {
            targetComboBox.Loaded += (ls, le) =>
            {
                targetComboBox.Items.IsLiveFiltering = true;

                var targetTextBox = targetComboBox.Template.FindName("PART_EditableTextBox", targetComboBox) as TextBox;
                if (targetTextBox == null) return;

                targetComboBox.IsEditable = true;
                targetComboBox.IsTextSearchEnabled = false;

                targetTextBox.Tag = "Selection";

                targetTextBox.PreviewKeyDown += (se, ev) =>
                {
                    if (ev.Key == Key.Enter || ev.Key == Key.Return || ev.Key == Key.Tab)
                        return;

                    targetTextBox.Tag = "Typed";

                    if (targetComboBox.SelectedItem != null)
                    {
                        targetComboBox.SelectedItem = null;
                        targetComboBox.Text = string.Empty;
                    }
                };

                targetTextBox.TextChanged += (se, ev) =>
                {
                    var searchTerm = string.Empty;

                    if (string.IsNullOrWhiteSpace(targetTextBox.Text) == false && (string)targetTextBox.Tag == "Typed")
                    {
                        targetComboBox.SelectedItem = null;
                        targetComboBox.IsDropDownOpen = true;
                        searchTerm = targetTextBox.Text.ToLowerInvariant();

                        targetTextBox.Select(targetTextBox.Text.Length, 0);
                        targetComboBox.Items.Filter = (filterItem) =>
                        {
                            return filterItem.ToString().ToLowerInvariant().Contains(searchTerm);
                        };
                    }
                    else
                    {
                        targetComboBox.Items.Filter = (filterItem) => { return true; };
                    }

                    targetComboBox.Items.Refresh();
                };

                targetComboBox.SelectionChanged += (se, ev) =>
                {
                    if (targetComboBox.SelectedItem != null)
                    {
                        targetTextBox.Tag = "Selection";
                        targetComboBox.Items.Filter = (filterItem) => { return true; };
                        targetComboBox.Items.Refresh();
                    }
                };
            };
        }
    }
}
