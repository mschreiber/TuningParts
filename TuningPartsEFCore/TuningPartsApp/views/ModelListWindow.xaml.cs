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
    /// Interaktionslogik für ModelListWindow.xaml
    /// </summary>
    public partial class ModelListWindow : Window
    {

        private readonly ModelListViewModel _modelListViewModel = new();

        public ModelListWindow()
        {
            InitializeComponent();
            this.DataContext = _modelListViewModel;
        }

        private void deleteModel(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Soll das Model wirklich gelöscht werden?", "Löschen", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                _modelListViewModel.deleteSelectedModel();
            }
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            EditModelWindow brandWindow = new(new Model());
            brandWindow.Owner = this;
            brandWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            brandWindow.ShowDialog();
        }

        private void editModel(object sender, RoutedEventArgs e)
        {
            if (_modelListViewModel.SelectedModel != null)
            {
                EditModelWindow brandWindow = new(_modelListViewModel.SelectedModel);
                brandWindow.Owner = this;
                brandWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
                brandWindow.ShowDialog();
                dataGrid.Items.Refresh();
            }
        }
    }
}
