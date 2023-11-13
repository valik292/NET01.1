using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSite
{
    public enum TypeLink
    {
        Unknown, Html, Image, Audio, Video
    }
    class LinkToResource : TranningMaterial
    {
        string URIcontent { get; set; }
        public TypeLink Type { get; set; }
        public LinkToResource(Guid id, string Description, string uricontent, TypeLink type) : base(id, Description)
        {
            if (uricontent == null)
            {
                throw new ArgumentException("Content URI is empty.");
            }
            this.ID = id;
            this.Description = Description;
            this.URIcontent = uricontent;
            this.Type = type;
            this.Description = Description;
        }
    }
}
