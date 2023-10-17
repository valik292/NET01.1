using System;
using System.Collections.Generic;
using System.Text;

public enum Videoformat
{
    Unknown, Avi, Mp4, Fiv
}

namespace ConsoleApp2
{
    class VideoMaterial : TranningMaterial, IVersionable
    {
        string URIvideo { get; set; }
        string URIimages { get; set; }
        public Videoformat Format { get; set; }
        public byte[] Version { get; set; }
        public VideoMaterial(Guid id, string Description, string urivideo, string uriimages, Videoformat format, byte[] version) : base(id, Description)
        {
            if (urivideo == null)
            {
                throw new ArgumentException("URI видеоконтента пустой.");
            }
            this.ID = id;
            this.description = Description;
            this.URIvideo = urivideo;
            this.URIimages = uriimages;
            this.Format = format;
            this.description = Description;
            Version = version;
        }
    }
}
