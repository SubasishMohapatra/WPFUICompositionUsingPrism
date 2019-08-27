using ListingModule.Model;
using Prism.Commands;
using Prism.Modularity;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace ListingModule.ViewModels
{
    public class ListingMenuItemViewModel : BindableBase
    {
        private readonly ICommand loadListingContentCommand;
        private readonly IRegionManager regionManager;

        public ListingMenuItemViewModel(IRegionManager regionManager)
        {
            loadListingContentCommand = new DelegateCommand(LoadListingContent);
            this.regionManager = regionManager;
        }
        public ICommand LoadListingContentCommand => loadListingContentCommand;

        private void LoadListingContent()
        {
            regionManager.RequestNavigate("ContentRegion", "ListingContentView");
        }
    }
}
