using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLearningLibrary
{
    public class OnlineLearningRepo
    {
        Department deptobj = new Department();
        Courses courseobj = new Courses();
        Instructor instructorobj = new Instructor();
        public void addDept(string depname)
        {
            using(var db= new OnlineLearningContext())
            {
                deptobj.deptname = depname;
                db.departments.Add(deptobj);
                db.SaveChanges();
            }
        }
        public void displaydept()
        {
            using(var db=new OnlineLearningContext())
            {
                foreach(var item in db.departments)
                {
                    Console.WriteLine(item.deptid+" "+item.deptname);
                }
            }
        }
        
        public void deleteDept(int id)
        {

        }

        public void addInstructor(Instructor newInstructor)
        {
            using(var db=new OnlineLearningContext())
            {
                db.instructors.Add(newInstructor);
                db.SaveChanges();
                //instructorobj.fname = newInstructor.fname;
                //instructorobj.lname = newInstructor.lname;
                //instructorobj.age = newInstructor.age;
                //instructorobj.sex = newInstructor.sex;

            }
        }

        public void displayInstructor()
        {
            using (var db= new OnlineLearningContext())
            {
                foreach(var item in db.instructors)
                {
                    Console.WriteLine(item.instructorid + " " + item.fname + " " + item.lname + " " + item.sex + " " + item.age + " " + item.yrsOfExp);


                }
            }
        }
        public void addCourse(Courses newCourse)
        {
            using(var db=new OnlineLearningContext())
            {
                courseobj.coursename = newCourse.coursename;
                courseobj.price = newCourse.price;
                courseobj.rating = newCourse.rating;
                deptobj = db.departments.Find(newCourse.deptid);
                courseobj.department = deptobj;
                instructorobj = db.instructors.Find(newCourse.instructorid);
                courseobj.instructor = instructorobj;
                db.Courses.Add(courseobj);
                db.SaveChanges();
            }
        }

        public void displayCourse()
        {
            using(var db=new OnlineLearningContext())
            {
                var res = db.Courses.Include(x => x.department);
                var result = res.Include(y => y.instructor);
                foreach(var item in result)
                {
                    Console.WriteLine(item.courseid + " " + item.coursename + " " + item.price + " " + item.rating + " " + item.department.deptname + " " + item.instructor.fname);
                }
            }

        }

        
        public void deleteCourse(int id)
        {

        }

    }
}
