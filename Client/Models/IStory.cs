using System.Text.Json.Serialization;

namespace HnpwaBlazor.Client.Models
{
    // Represents stories, polls, ask, jobs in list form
    // API used: https://github.com/cheeaun/node-hnapi
    public interface IStory
    {
        public int Id { get; set; }
        public string Title { get; set; }
        // Example: https://www.cl.cam.ac.uk/techreports/UCAM-CL-TR-954.html
        public string Url { get; set; }
        // Example: cam.ac.uk
        public string Domain { get; set; }
        // Score. Null for jobs.
        public int? Points { get; set; }
        // Null for jobs.
        public string User { get; set; }
        // Already formatted
        public string TimeAgo { get; set; }
        public int CommentsCount { get; set; }
        // Possibles values: "link", "job". Default = "link"
        // Technically "ask" is also a possible value but it doesn't seem to work
        public string Type { get; set; }
    }
}