using System;

namespace ListingModule.Model
{
    internal class AKVOpenItem
    {
        public Guid ID { get; set; }
        public string AKVName { get; set; }
        public string FunctionName { get; set; }
        public string Message { get; set; }
        public virtual string ActionTaken { get; set; }
    }
}
