namespace WebApplication1.models
{
    public record CreateItemModel
    {
        public CreateItemModel(string Name, string Description)
        {
            this.Name = Name;
            this.Description = Description;
        }
       public string Name { get; set; }
       public string Description { get; set; }
        
    }
}
