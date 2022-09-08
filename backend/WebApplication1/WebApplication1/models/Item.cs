namespace WebApplication1.models
{
    public class Item
    {

        public Item() { }
        

        public Item(int v1, string v2, string v3, int v4, DateTime dateTime)
        {
            this.Id = v1;
            this.Name = v2;
            this.Description = v3;
            this.Completed = v4;
            this.DateCreated = dateTime;
        }

        public int Id { get; init; }
        public string Name { get; init; }
        public string Description { get; init; }
        public int Completed { get; init; }
        public DateTime DateCreated { get; init;}

    }

}
