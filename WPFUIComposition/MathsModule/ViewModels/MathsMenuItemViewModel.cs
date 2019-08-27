using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MathsModule.ViewModels
{
    public class MathsMenuItemViewModel
    {
        ICommand loadMathsContentCommand;
        private readonly IRegionManager regionManager;

        public MathsMenuItemViewModel(IRegionManager regionManager)
        {
            loadMathsContentCommand = new DelegateCommand(LoadMathsContent);
            this.regionManager = regionManager;
        }
        public ICommand LoadMathsContentCommand { get { return loadMathsContentCommand; } }

        public void Initialize()
        {
            
        }
        private void LoadMathsContent()
        {            
            regionManager.RequestNavigate("ContentRegion", "MathsContentView");
        }
    }
}
