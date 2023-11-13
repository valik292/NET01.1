using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSite
{
    public enum Videoformat
    {
        Unknown, Avi, Mp4, Fiv
    }
    public class VideoMaterial : TranningMaterial, IVersionable
    {
        string URIvideo { get; set; }
        string URIimages { get; set; }
        public Videoformat Format { get; set; }
        public byte[] Version { get; set; }
        public VideoMaterial(Guid id, string Description, string urivideo, string uriimages, Videoformat format, byte[] version) : base(id, Description)
        {
            if (urivideo == null)
            {
                throw new ArgumentException("Video content URI is empty.");
            }
            this.ID = id;
            this.Description = Description;
            this.URIvideo = urivideo;
            this.URIimages = uriimages;
            this.Format = format;
            this.Description = Description;
            Version = version;
        }
    }
}
