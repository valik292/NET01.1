using System;
using System.Collections.Generic;
using System.Text;

public interface IVersionable
{
    byte[] Version { get; set; }
}

public enum LessonType
{
    TextLesson,
    VideoLesson
}

namespace ConsoleApp2
{
    class TranningLesson : TranningEntity, IVersionable, ICloneable
    {    
        public const int versionLength = 8;  
        public byte[] Version { get; set; }
        public List<TranningMaterial> Materials { get; set; }
        public TranningLesson(Guid id, string Description,  byte[] version) : base(id, Description)
        {          
            if (version.Length > versionLength)
            {
                throw new ArgumentException($"Размер версии больше {versionLength}");
            }
            this.ID = id;
            this.description = Description;
            Version = version;
        }
        private LessonType GetLessonType()
        {
            foreach (TranningMaterial material in Materials)
            {
                if (material is VideoMaterial)
                    return LessonType.VideoLesson;
            }
            return LessonType.TextLesson;
        } 
        public object Clone()
        {
            TranningLesson clone = new TranningLesson(ID, description, Version);
            if (Version != null)
            {
                clone.Version = new byte[Version.Length];
                Array.Copy(Version, clone.Version, Version.Length);
            }
            return clone;
        }
    }
}
