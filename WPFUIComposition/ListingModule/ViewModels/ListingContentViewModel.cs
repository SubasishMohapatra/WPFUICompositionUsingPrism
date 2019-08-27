using ListingModule.Model;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace ListingModule.ViewModels
{
    public class ListingContentViewModel : BindableBase
    {
        private readonly ICommand loadListingContentCommand;

        public ListingContentViewModel()
        {

        }

        public void Initialize()
        {
            TotalItems = 10;
            OpenItemsCollection = new ObservableCollection<IOpenItemViewModel>();
            LoadData();
            RaisePropertyChanged("OpenItemsCollection");
        }
        private void LoadData()
        {
            AKVOpenItemViewModel akvOpenItemViewModel = new AKVOpenItemViewModel();
            UserOpenItemViewModel userOpenItemViewModel = new UserOpenItemViewModel();
            TicketOpenItemViewModel ticketOpenItemViewModel = new TicketOpenItemViewModel();
            IEnumerable<AKVOpenItem> akvOpenItems = Enumerable.Range(1, TotalItems).Select(index => new AKVOpenItem()
            {
                ID = Guid.NewGuid(),
                AKVName = $"AKV-{(index%3)}",
                FunctionName = $"Function-{(index % 3)}",
                Message = $"V{index} for function changed",
                ActionTaken = index % 2 == 0 ? "Closed" : "Open"
            });
            IEnumerable<UserOpenItem> userOpenItems = Enumerable.Range(1, TotalItems).Select(index => new UserOpenItem()
            {
                ID = Guid.NewGuid(),
                OpenItemType = (UserOpenItemTypeEnum)Enum.Parse(typeof(UserOpenItemTypeEnum), index.ToString()),
                Message = $"{(UserOpenItemTypeEnum)Enum.Parse(typeof(UserOpenItemTypeEnum), index.ToString())}"
            });
            IEnumerable<TicketOpenItem> ticketOpenItems = Enumerable.Range(1, TotalItems).Select(index => new TicketOpenItem()
            {
                ID = Guid.NewGuid(),
                TicketID = index,
                Status = (TicketStatus)Enum.Parse(typeof(TicketStatus), index.ToString()),
                Message = $"Status change: {(TicketStatus)Enum.Parse(typeof(TicketStatus), index.ToString())}"
            });
            akvOpenItemViewModel.OpenItems = new AKVOpenItems(akvOpenItems);
            userOpenItemViewModel.OpenItems = new UserOpenItems(userOpenItems);
            ticketOpenItemViewModel.OpenItems = new TicketOpenItems(ticketOpenItems);
            OpenItemsCollection.Add(akvOpenItemViewModel);
            OpenItemsCollection.Add(userOpenItemViewModel);
            OpenItemsCollection.Add(ticketOpenItemViewModel);
        }

        public void ReloadContent()
        {
            IEnumerable<AKVOpenItem> akvOpenItems = Enumerable.Range(1, TotalItems).Select(index => new AKVOpenItem()
            {
                ID = Guid.NewGuid(),
                AKVName = $"AKV-{(index % 3)}",
                FunctionName = $"Function-{(index % 3)}",
                Message = $"V{index} for function changed",
                ActionTaken = index % 2 == 0 ? "Closed" : "Open"
            });
            IEnumerable<UserOpenItem> userOpenItems = Enumerable.Range(1, TotalItems).Select(index => new UserOpenItem()
            {
                ID = Guid.NewGuid(),
                OpenItemType = (UserOpenItemTypeEnum)Enum.Parse(typeof(UserOpenItemTypeEnum), index.ToString()),
                Message = $"{(UserOpenItemTypeEnum)Enum.Parse(typeof(UserOpenItemTypeEnum), index.ToString())}"
            });
            IEnumerable<TicketOpenItem> ticketOpenItems = Enumerable.Range(1, TotalItems).Select(index => new TicketOpenItem()
            {
                ID = Guid.NewGuid(),
                TicketID = index,
                Status = (TicketStatus)Enum.Parse(typeof(TicketStatus), index.ToString()),
                Message = $"Status change: {(TicketStatus)Enum.Parse(typeof(TicketStatus), index.ToString())}"
            });
            OpenItemsCollection[0].OpenItems = new AKVOpenItems(akvOpenItems);
            OpenItemsCollection[1].OpenItems = new UserOpenItems(userOpenItems);
            OpenItemsCollection[2].OpenItems = new TicketOpenItems(ticketOpenItems);
            RaisePropertyChanged("OpenItemsCollection");
        }


        public ObservableCollection<IOpenItemViewModel> OpenItemsCollection { get; set; }

        public int TotalItems{ get; set; }

    }
}
