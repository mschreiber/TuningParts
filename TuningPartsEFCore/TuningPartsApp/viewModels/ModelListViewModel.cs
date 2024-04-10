using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuningPartsApp.models;
using TuningPartsApp.persistence;

namespace TuningPartsApp.viewModels
{
    public class ModelListViewModel
    {
        private readonly TuningPartsDbContext _dbContext;

        public Model? SelectedModel { get; set; }

        public ObservableCollection<Model> Models { get; set; }

        public ModelListViewModel()
        {
            _dbContext = TuningPartsDbContext.getInstance();
            _dbContext.Models.Include(model => model.Brand).Load();
            Models = _dbContext.Models.Local.ToObservableCollection();
        }

        public void deleteSelectedModel()
        {
            if (SelectedModel != null)
            {
                _dbContext.Models.Remove(SelectedModel);
                _dbContext.SaveChanges();
            }
        }
    }
}
