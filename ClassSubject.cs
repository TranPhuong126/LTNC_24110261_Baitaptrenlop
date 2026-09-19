using System;
using System.Collections.Generic;

namespace QuanLySinhVien
{
    public class ClassSubject
    {
        public string SubjectID { get; set; }
        public string Name { get; set; }
        public string HocKi { get; set; }
        public string Teacher { get; set; }
        
        // Danh sách sinh viên thuộc lớp học phần này
        public List<Student> ListSTU { get; set; } = new List<Student>();

        // Thêm sinh viên vào lớp
        public void AddStudent(Student student)
        {
            ListSTU.Add(student);
        }

        public void DisplaySubjectInfo()
        {
            Console.WriteLine($"\n--- Lớp học phần: {Name} ({SubjectID}) ---");
            Console.WriteLine($"Học kỳ: {HocKi} | Giảng viên: {Teacher}");
            Console.WriteLine("Danh sách sinh viên trong lớp:");
            foreach (var stu in ListSTU)
            {
                stu.DisplayInfo();
            }
        }
    }
}