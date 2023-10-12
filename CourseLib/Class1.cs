using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CourseLib
{
    //Schedule class
    public class Schedule
    {
        //time feilds
        public DateTime startTime;
        public DateTime endTime;

        //days of week field list
        public List<DayOfWeek> daysOfWeek = new List<DayOfWeek>();

    }
    //Courses class
    public class Courses
    {
        //sorted list feild
        public SortedList<string, Course> sortedList = new SortedList<string, Course>();

        //corse code field
        //must use try catch for get and set proterties of feild
        public Course this[string courseCode]
        {
            get
            {
                Course returnVal;
                try
                {
                    returnVal = (Course)sortedList[courseCode];
                }
                catch
                {
                    returnVal = null;
                }

                return (returnVal);
            }

            set
            {
                try
                {
                    // we can add to the list using these 2 methods
                    //      sortedList.Add(email, value);
                    sortedList[courseCode] = value;
                }
                catch
                {
                    // an exception will be raised if an entry with a duplicate key is added
                    // duplicate key handling
                }
            }
        }

        //remove course method
        public void Remove(string courseCode)
        {
            //only is not null
            if (courseCode != null)
            {
                sortedList.Remove(courseCode);
            }
        }

        //defult constructor
        public Courses()
        {
            Course thisCourse;
            Schedule thisSchedule;

            Random rand = new Random();

            // generate courses IGME-200 through IGME-299
            for (int i = 200; i < 300; ++i)
            {
                // use constructor to create new course object with code and description
                thisCourse = new Course(($"IGME-{i}"), ($"Description for IGME-{i}"));

                // create a new Schedule object
                thisSchedule = new Schedule();
                for (int dow = 0; dow < 7; ++dow)
                {
                    // 50% chance of the class being on this day of week
                    if (rand.Next(0, 2) == 1)
                    {
                        // add to the daysOfWeek list
                        thisSchedule.daysOfWeek.Add((DayOfWeek)dow);

                        // select random hour of day
                        int nHour = rand.Next(0, 24);

                        // set start and end times of minute duration
                        // select fixed date to allow time calculations
                        thisSchedule.startTime = new DateTime(1, 1, 1, nHour, 0, 0);
                        thisSchedule.endTime = new DateTime(1, 1, 1, nHour, 50, 0);
                    }
                }

                // set the schedule for this course
                thisCourse.schedule = thisSchedule;

                // add this course to the SortedList
                this[thisCourse.courseCode] = thisCourse;
            }
        }
    }

    //course class
    //related to but no derived from other classes
    public class Course
    {
        //feilds
        public string courseCode;
        public string description;
        public string teacherEmail;
        public Schedule schedule;


        //Course constructor
        public Course(string courseCode, string description)
        {
        }

    }

}
