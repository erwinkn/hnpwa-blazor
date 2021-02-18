namespace Hnpwa.Shared
{
    // See https://hackernews.api-docs.io/v0/overview 
    public record User
    {
        public string Id { get; set; } = "";
        // In Unix time
        public int Created { get; set; }
        public int Karma { get; set; }
        // Delay in minutes between a comment's creation and its visibility to other users (optional)
        public int Delay { get; set; }
        public string About { get; set; } = "";
        // List of ids for the user's submitted stories, polls and comments
        public int[]? Submitted { get; set; }
    }
}