
using Microsoft.EntityFrameworkCore;
using System;
namespace codeFirstExampleNew
{
    internal class Program
    {
        public static HospitalManagementContext context = new HospitalManagementContext();
        public static PatientDetails p = new PatientDetails();
        public static DoctorDetails d = new DoctorDetails();

        static void Main()
        {
            //addDocdetails();
            //displaydoc();
            addpatients();
            displaypatient();

        }

        public static void addpatients()
        {
            using(var db= new HospitalManagementContext())
            {
                Console.WriteLine("ENter patient name: ");
                p.name = Console.ReadLine();
                Console.WriteLine("Enter doc id: ");
                int id = int.Parse(Console.ReadLine());
                d=db.Doctors.Find(id);
                p.doctor = d;
                db.Patients.Add(p);
                db.SaveChanges();
            }
        }

        public static void addDocdetails()
        {
            using (var db = new HospitalManagementContext())
            {
                Console.WriteLine("ENter doc name and spec: ");
                d.docname = Console.ReadLine();
                d.specialization = Console.ReadLine();
                db.Doctors.Add(d);
                db.SaveChanges();

            }
        }
        public static void displaydoc()
        {

            foreach(var item in context.Doctors)
                {
                Console.WriteLine(item.docid + " " + item.docname + " " + item.specialization);
                }
        }

        public static void displaypatient()
        {
            using(var db = new HospitalManagementContext())
            {
                var res = db.Patients.Include(x => x.doctor);
            foreach (var item in res)
                {
                    Console.WriteLine(item.id + " " + item.name + " " + item.doctor.docname + " "+item.doctor.docid);
                }
            }
           
        }
    }
}

