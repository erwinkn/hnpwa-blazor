using System.Collections.Generic;

namespace Hnpwa.Shared
{
    // Comment object with nested comments
    // API used: https://github.com/cheeaun/node-hnapi
    public interface IComment
    {
        public int Id { get; set; }
        public string Type { get; set; }
        // Nesting level
        public int Level { get; set; }
        public string User { get; set; }
        public string TimeAgo { get; set; }
        // HTML content
        public string Content { get; set; }
        public List<Item> Comments { get; set; }
    }
}