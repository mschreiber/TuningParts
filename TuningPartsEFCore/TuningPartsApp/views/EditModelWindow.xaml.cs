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
using System.Windows.Shapes;
using TuningPartsApp.models;
using TuningPartsApp.viewModels;

namespace TuningPartsApp.views
{
    /// <summary>
    /// Interaktionslogik für EditModelWindow.xaml
    /// </summary>
    public partial class EditModelWindow : Window
    {

        private readonly EditModelViewModel _viewModel;

        public EditModelWindow(Model model)
        {
            _viewModel = new EditModelViewModel(model);
            InitializeComponent();
            this.DataContext = _viewModel;
        }

        public void save(object sender,  RoutedEventArgs e)
        {
            _viewModel.Save();
            this.Close();
        }

        public void cancel(object sender, RoutedEventArgs e)
        {
            _viewModel.DontSave();
            yearCombo.GetBindingExpression(TextBox.TextProperty).UpdateTarget();
            nameTxt.GetBindingExpression(TextBox.TextProperty).UpdateTarget();
            brandCombo.GetBindingExpression(ComboBox.SelectedItemProperty).UpdateTarget();
            this.Close();
        }
    }
}
