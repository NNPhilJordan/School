using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            var database = new DataContext();    //setup a connector
            // list them all
            Console.WriteLine("List Them All");
            var students = database.Students.ToList();
            foreach(var student in students) 
            {
              Console.WriteLine($"{student.Id} : {student.FirstName} : {student.LastName} : {student.Age} : {student.GrYear}");  
            }

           //Given a student Name show their grades
           var query =  database.Students.Join(database.Grades,
                        students => students.Id,
                        grades => grades.StudentId,
                        (students, grades) => new { StudentName = students.LastName,
                                                    StudentCourse = grades.CourseName,
                                                    StudentGrade = grades.GradeVal   } ) ;           
 
            foreach(var val in query) {
            Console.WriteLine("Student Last Name : {0}   CourseName : {1}    Grade: {2}",
                            val.StudentName, val.StudentCourse, val.StudentGrade  ) ;           
            }
          // Given a student's name find their average grade among all their courses
            
            var xxGPA  = from s1 in database.Students  
                         join j1 in database.Grades on s1.Id equals j1.StudentId
                         group  j1 by s1.LastName into groupies 
                         select new { sName= groupies.Key,
                                      GPA = groupies.Average(x  => x.GradeVal) } ;                                     
           
                                                           
 
            foreach(var val in xxGPA) {
                Console.WriteLine(val);
            }                  

          // Find the student with the highest average grade
          var MaxGPA  = from s1 in database.Students  
                         join j1 in database.Grades on s1.Id equals j1.StudentId
                         group  j1 by s1.LastName into groupies 
                         select new { sName= groupies.Key,
                                      GPA = groupies.Average(x  => x.GradeVal) } ;                                     
           
                                                           
 
            foreach(var val in MaxGPA) {
                Console.WriteLine(val);
            }                  
          // Find the student that took the most number of courses
          // Find a student that didn't take any courses
          // Count the number of Freshmen
          // Find the average grade for all Sophomores
            
        }
    }
}
