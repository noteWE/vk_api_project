using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VK_API
{
    class JSON_Gift
    {
        public string from_id { get; set; }
        public string message { get; set; }
        public string date { get; set; }

        public Image_Gift gift { get; set; }

        public string privacy { get; set; }
    }

    class Image_Gift
    {
        public string id { get; set; }
        public string thumb_256 { get; set; }
        public string thumb_48 { get; set; }
        public string thumb_96 { get; set; }
    }
}
