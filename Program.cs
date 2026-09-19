using System;
using QuanLySinhVien;

namespace QuanLySinhVien
{
    class Program
    {
        static void Main(string[] args)
        {
            // Khởi tạo một đối tượng lớp học phần
            ClassSubject csharpClass = new ClassSubject();
            csharpClass.SubID = "IT102";
            csharpClass.Name = "Lập trình nâng cao";
            csharpClass.Teacher = "Teacher A";

            Console.WriteLine($"=== DANH SÁCH SINH VIÊN MÔN: {csharpClass.Name} ===");
            
            // In danh sách sinh viên ban đầu
            foreach (var student in csharpClass.GetStudents())
            {
                student.DisplayInfo();
            }

            // Thử nghiệm tính năng lọc sinh viên qua môn (điều kiện tổng kết >= 8.0)
            Console.WriteLine("\n=== CÁC SINH VIÊN ĐẠT ĐIỂM >= 8.0 ===");
            var passedStudents = csharpClass.getStudentsPassed(8.0);
            foreach (var student in passedStudents)
            {
                student.DisplayInfo();
            }
        }
    }
}