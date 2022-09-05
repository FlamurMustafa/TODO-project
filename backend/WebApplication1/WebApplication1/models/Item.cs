namespace WebApplication1.models
{
    public record Item
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public string Description { get; init; }
        public int Completed { get; init; }

        public DateTimeOffset DateCreated { get; init;}

    }

}
