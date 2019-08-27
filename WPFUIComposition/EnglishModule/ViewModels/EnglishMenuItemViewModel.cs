using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EnglishModule.ViewModels
{
    public class EnglishMenuItemViewModel
    {
        ICommand loadEnglishContentCommand = null;
        private readonly IRegionManager regionManager;

        public EnglishMenuItemViewModel(IRegionManager regionManager)
        {
            loadEnglishContentCommand = new DelegateCommand(LoadEnglishContent);
            this.regionManager = regionManager;
        }
        public ICommand LoadEnglishContentCommand { get { return loadEnglishContentCommand; } }

        private void LoadEnglishContent()
        {
            this.regionManager.RequestNavigate("ContentRegion", "EnglishContentView");

        }
    }
}
