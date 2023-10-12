using System;
public enum Videoformat
{
    Unknown, Avi, Mp4, Fiv
}
public enum TypeLink
{
    Unknown, Html, Image, Audio, Video
}

public enum LessonType
{
    TextLesson,
    VideoLesson
}
public interface IVersionable
{
    byte[] Version { get; set; } 
}

namespace ConsoleApp2
{
    class TranningLesson : IVersionable, ICloneable
    {
        public System.Guid ID { get; }
        public string dicription;
        public bool hasVideo;
        public byte[] Version { get; set; }
        public TranningLesson()
        { }
        
        public TranningLesson(System.Guid id, string Discription, bool HasVideo, byte[] version)
        {
            if (Discription != null && Discription.Length > 256)
            {
                throw new ArgumentException("Описание превышает 256 символов.");
            }
            if (version.Length > 8)
            {
                throw new ArgumentException("Размер версии больше 8");
            }
            this.ID = id;
            this.dicription = Discription;
            this.hasVideo = HasVideo;
            Version = version;
        }

        private LessonType GetLessonType()
        {
            return hasVideo ? LessonType.VideoLesson : LessonType.TextLesson;
        }
        public override string ToString()
        {
            return dicription;
        }
        public Guid GenerateUniqueID()
        {
            return Guid.NewGuid();
        }
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is TranningLesson))
            {
                return false;
            }
            TranningLesson other = (TranningLesson)obj;

            return ID.Equals(other.ID);
        }
        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }
        public object Clone()
        {
            TranningLesson clone = new TranningLesson(ID, dicription, hasVideo, Version);

            if (Version != null)
            {
                clone.Version = new byte[Version.Length];
                Array.Copy(Version, clone.Version, Version.Length);
            }

            return clone;
        }
    }

    class TextMatirial : TranningLesson
    {
        public string Text;
        public TextMatirial()
        { }

        public TextMatirial(string text, string Discription)
        {
            if (text == null ||  text.Length > 10000)
            {
                throw new ArgumentException("Текст превышает 10000 символов или он пустой.");
            }

            this.Text = text;
            this.dicription = Discription;
        }
    }
    class VidioMaterial : TranningLesson, IVersionable
    {
        string URIvideo;
        string URIimages;
        public Videoformat Format { get; set; }
        public new byte[] Version { get; set; }

        public VidioMaterial(string urivideo, string uriimages, Videoformat format, string Discription,  byte[] version)
        {
            if (urivideo == null)
            {
                throw new ArgumentException("URI видеоконтента пустой.");
            }

            this.URIvideo = urivideo;
            this.URIimages = uriimages;
            this.Format = format;
            this.dicription = Discription;
            Version = version;
        }
    }
    class LinkMatirial : TranningLesson
    {
        string URIcontent;
        public TypeLink Type { get; set; }

        public LinkMatirial(string uricontent, TypeLink type, string Discription)
        {
            if (uricontent == null)
            {
                throw new ArgumentException("URI контента пустой.");
            }

            this.URIcontent = uricontent;
            this.Type = type;
            this.dicription = Discription;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //string text = null;
            //for (int i = 0; i < 10010; i++)
            //{
            //    text = text + "1";
            //}
            //TextMatirial mat = new TextMatirial();
            ////mat.Text = text;
            //TranningLesson lesson = new TranningLesson();


            //Guid id = lesson.GenerateUniqueID();
            //Console.WriteLine(id);
        }
    }
}
