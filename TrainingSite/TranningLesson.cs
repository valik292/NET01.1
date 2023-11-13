using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSite
{
    public interface IVersionable
    {
        byte[] Version { get; set; }
    }

    public enum LessonType
    {
        TextLesson,
        VideoLesson
    }
    public class TranningLesson : TranningEntity, IVersionable, ICloneable
    {
        public const int VersionLength = 8;
        public byte[] Version { get; set; }
        public List<TranningMaterial> Materials { get; set; }
        public TranningLesson(Guid id, string Description) : base(id, Description)
        {
            this.ID = id;
            this.Description = Description;
        }

        public LessonType GetLessonType()
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
            if (Version.Length > VersionLength || Version == null)
            {
                throw new ArgumentException($"Version size larger than {VersionLength} or is empty");
            }

            TranningLesson clone = new TranningLesson(this.ID, this.Description)
            {
                Version = this.Version != null ? (byte[])this.Version.Clone() : null,
                Materials = this.Materials != null ? new List<TranningMaterial>(this.Materials) : null
            };

            return clone;
        }
    }
}
