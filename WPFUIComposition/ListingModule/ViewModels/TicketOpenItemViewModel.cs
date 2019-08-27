namespace ListingModule.ViewModels
{
    internal class TicketOpenItemViewModel : IOpenItemViewModel
    {
        public TicketOpenItemViewModel()
        {
        }

        public string Header => "Ticket Open Items";

        public IOpenItem OpenItems { get; set; }
    }
}

