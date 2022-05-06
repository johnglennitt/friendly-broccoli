namespace Web.API.Data
{
    public class ItemEntity
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string PhotoUrl { get; set; }

        public DateTime ExpirationTimeUtc { get; set; }
            = DateTime.UtcNow.AddMinutes(
                Random.Shared.Next(3, Config.Constants.MAX_EXPIRATION_MINUTES)
                );
    }
}
