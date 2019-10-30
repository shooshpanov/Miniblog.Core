namespace Miniblog.Core
{
    public class BlogSettings
    {
        public string Owner { get; set; } = "Magic Micro Computers";
        public int PostsPerPage { get; set; } = 5;
        public int CommentsCloseAfterDays { get; set; } = 10;
    }
}
