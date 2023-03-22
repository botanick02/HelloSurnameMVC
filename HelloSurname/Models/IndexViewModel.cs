namespace HelloSurname.Models
{
    public class IndexViewModel
    {
        public string? Name { get; set; }

        public IndexViewModel(string name)
        {
            Name = name;
        }
    }
}