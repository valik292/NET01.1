using System;
using System.Collections.Generic;
using System.Text;

public enum TypeLink
{
    Unknown, Html, Image, Audio, Video
}

namespace ConsoleApp2
{
    class LinkToResource : TranningMaterial
    {
        string URIcontent { get; set; }
        public TypeLink Type { get; set; }
        public LinkToResource(Guid id, string Description, string uricontent, TypeLink type) : base(id, Description)
        {
            if (uricontent == null)
            {
                throw new ArgumentException("URI контента пустой.");
            }
            this.ID = id;
            this.description = Description;
            this.URIcontent = uricontent;
            this.Type = type;
            this.description = Description;
        }
    }
}
