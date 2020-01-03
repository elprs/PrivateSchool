using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool
{
    /// <summary>
    /// Many to many relationship of Trainer - Course Classes
    /// </summary>
    class TrainerCourse
    {
        public Trainer Trainer;
        public Course course;

        public TrainerCourse(Trainer Trainer, Course course)
        {
            this.Trainer = Trainer;
            this.course = course;
            Trainer.Courses.Add(course);
            course.Trainers.Add(Trainer);
        }
    }
}
