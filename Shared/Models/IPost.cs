using System.Collections.Generic;

namespace Hnpwa.Shared
{
    // Full post with content and nested comments
    // API used: https://github.com/cheeaun/node-hnapi
    public interface IPost : IStory
    {
        public string Content { get; set; }
        public List<Item> Comments { get; set; }
        // To find the IDs of the poll options, iterate from this object's ID
        public List<PollOptionScore> Poll { get; set; }
    }
}