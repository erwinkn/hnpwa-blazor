using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace HnpwaBlazor.Shared.Models
{
    // Represents stories, polls, comments, asks, jobs
    // API used: https://github.com/cheeaun/node-hnapi
    public record Item : IComment, IPollOption, IStory, IPost
    {
        public int Id { get; set; }
        // Can be link, job, poll, pollopt (or ask but seems broken)
        public string Type { get; set; } = "link";

        public string Title { get; set; } = "";
        public string User { get; set; } = "";
        // Score for stories, votes for poll options
        public int? Points { get; set; }
        // Preformatted in the API
        [JsonPropertyName("time_ago")]
        public string TimeAgo { get; set; } = "some undefined time ago";
        // HTML content
        public string Content { get; set; } = "";
        // Example: https://www.cl.cam.ac.uk/techreports/UCAM-CL-TR-954.html
        public string Url { get; set; } = "";
        // Example: cam.ac.uk
        public string Domain { get; set; } = "";

        // Nesting level for comments
        public int Level { get; set; }
        [JsonPropertyName("comments_count")]
        public int CommentsCount { get; set; }
        public List<Item> Comments { get; set; } = new List<Item>();

        // List of poll options, if applicable
        // To find the IDs of the poll options, iterate from this object's ID
        public List<PollOptionScore> Poll { get; set; } = new List<PollOptionScore>();
    }
}