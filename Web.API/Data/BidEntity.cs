namespace Web.API.Data
{
    public class BidEntity
    {
        public int Id { get; set; }

        public int ItemId { get; set; }

        public ItemEntity Item { get; set; }

        public decimal Amount { get; set; }

        public DateTimeOffset TimeReceived { get; set; }
    }
}
