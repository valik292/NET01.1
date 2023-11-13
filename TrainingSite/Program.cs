using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSite
{
    class Program
    {
        static void Main(string[] args)
        {
            var lesson = new TranningLesson(Guid.NewGuid(), "ID_1");
            lesson.Version = new byte[] { 1, 2, 3 };

            // Act
            TranningLesson clonedLesson = (TranningLesson)lesson.Clone();

            Console.WriteLine(clonedLesson.Version);
            Console.WriteLine(lesson.Version);

        }
    }
}
