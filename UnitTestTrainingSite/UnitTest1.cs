using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainingSite;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestTrainingSite
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGenerateUniqueID()
        {
            // Arrange
            Guid id = new Guid();
            TranningEntity Entity = new TranningEntity(id, "ID_1");
            Guid generatedGuid1, generatedGuid2;

            // Act
            generatedGuid1 = Entity.GenerateUniqueID();
            generatedGuid2 = Entity.GenerateUniqueID();

            // Assert
            Assert.AreNotEqual(generatedGuid1, generatedGuid2, "Generated GUIDs should be unique.");

        }

        [TestMethod]
        public void TestToString()
        {
            // Arrange
            Guid id = new Guid();
            TranningEntity Entity = new TranningEntity(id, "ID_1");

            // Act
            string str1 = "ID_1";
            string str2 = Entity.ToString();

            // Assert
            Assert.AreEqual(str1, str2, "Descriptions should be equal.");

        }
        [TestMethod]
        public void TestEquals()
        {
            // Arrange
            Guid id = new Guid();
            TranningEntity Entity1 = new TranningEntity(id, "ID_1");
            TranningEntity Entity2 = new TranningEntity(id, "ID_2");

            // Act
           

            // Assert
            //Assert.IsTrue(Entity1.Equals(Entity2));
            Assert.IsFalse(Entity1.Equals(Entity2));

        }
        [TestMethod]
        public void TestGetLessonType()
        {
            Guid id = new Guid();
            byte[] Version = { 1, 2, 3 };
            //VideoMaterial material1 = new VideoMaterial(id, "ID_1", "https://www.youtube.com/watch?v=dQw4w9WgXcQ", "https://www.youtube.com/watch?v=dQw4w9WgXcQ", Videoformat.Mp4, Version);
            TranningLesson lesson = new TranningLesson(id, "ID_2");
            lesson.Materials = new List<TranningMaterial>
            {
            new VideoMaterial(id, "ID_1", "https://www.youtube.com/watch?v=dQw4w9WgXcQ", "https://www.youtube.com/watch?v=dQw4w9WgXcQ", Videoformat.Mp4, Version)
            };
            // Act
            LessonType result = lesson.GetLessonType();

            // Assert
            Assert.IsTrue(result.Equals(LessonType.VideoLesson));

        }
        [TestMethod]
        public void TestLessonClone()
        {
            var lesson = new TranningLesson(Guid.NewGuid(), "ID_1");
            lesson.Version = new byte[] {1, 2 ,3};
            lesson.Materials = new List<TranningMaterial>
            {
            new VideoMaterial(Guid.NewGuid(), "ID_12345", "https://www.youtube.com/watch?v=dQw4w9WgXcQ", "https://www.youtube.com/watch?v=dQw4w9WgXcQ", Videoformat.Mp4, null)
            };
            // Act
            TranningLesson clonedLesson = (TranningLesson)lesson.Clone();

            // Assert
            Assert.AreEqual(clonedLesson.Version[0], lesson.Version[0]);
            Assert.AreEqual(clonedLesson.Version[1], lesson.Version[1]);
            Assert.AreEqual(clonedLesson.Version[2], lesson.Version[2]);
            Assert.AreEqual(clonedLesson.Materials[0].Description, lesson.Materials[0].Description);
        }
    }
}
