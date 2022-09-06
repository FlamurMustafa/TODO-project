namespace WebApplication1.models
{
    public class UpdateItemModel
    {
        public UpdateItemModel(int Id, string Name, string Description, string completed, string dateCreated)
        {
            this.Id = Id;
            this.Name = Name;
            this.Description = Description;
            this.DateCreated = dateCreated;
            this.Completed = completed;
        }
        public string Name { get; set; }
        public string Description { get; set; }

        public int Id { get; set; }

        public string DateCreated { get; set; }

        public string Completed { get; set; }
    }
}
