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
    public class EditModelViewModel
    {
        public Model Model { get; set; }
        public ObservableCollection<Brand> Brands { get; set; }

        private readonly TuningPartsDbContext _dbContext;

        public EditModelViewModel(Model model)
        {
            Model = model;
            _dbContext = TuningPartsDbContext.getInstance();
            _dbContext.Brands.Load();
            Brands = _dbContext.Brands.Local.ToObservableCollection();
        }

        public void Save()
        {
            if (Model.Id == Guid.Empty)
            {
                _dbContext.Models.Add(Model);
            }
            _dbContext.SaveChanges();
        }

        public void DontSave()
        {
            _dbContext.Entry<Model>(Model).Reload();
        }
    }
}
