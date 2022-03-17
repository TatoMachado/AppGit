using System.Collections.Generic;

namespace AppGit.Models
{
    public class Search
    {
        public int total_count { get; set; }
        public bool incomplete_results { get; set; }
        public List<Repo> items { get; set; }

    }
}
