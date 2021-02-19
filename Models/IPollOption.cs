namespace HnpwaBlazor.Models
{
    // For clear separation between poll options and posts
    // Poll options have an id equal to the poll's id + their position in the poll
    // API used: https://github.com/cheeaun/node-hnapi
    public interface IPollOption
    {
        public int Id { get; set; }
        public string Type { get; set; }
        // Text of the poll option, in HTML format
        public string Content { get; set; }
        public int? Points { get; set; }
        // There are other properties but they are not useful for us
    }
}