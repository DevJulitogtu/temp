using System;
using System.Collections.Generic;
using System.Text;

namespace CIMobile.Models.Local
{
    public class SearchResult
    {
        public string odatacontext { get; set; }
        public Value[] value { get; set; }
    }

    public class Value
    {
        public float searchscore { get; set; }
        public string content { get; set; }
        public string metadata_storage_content_type { get; set; }
        public int metadata_storage_size { get; set; }
        public DateTime metadata_storage_last_modified { get; set; }
        public string metadata_storage_content_md5 { get; set; }
        public string metadata_storage_name { get; set; }
        public string metadata_storage_path { get; set; }
        public string metadata_title { get; set; }
    }
}
