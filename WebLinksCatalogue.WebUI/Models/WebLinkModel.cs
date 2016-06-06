using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebLinksCatalogue.WebUI.Models
{
    public class WebLinkModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public int Views { get; set; }
        public string ThumbnailURL { get; set; }
    }
}