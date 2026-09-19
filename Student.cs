using System;

namespace QuanLySinhVien
{
    public class Student
    {
        public string StuID { get; set; }
        public string Name { get; set; }
        public double MidPoint { get; set; }
        public double FinalPoint { get; set; }
        public string Email { get; set; }

        public double getSubjectPoint()
        {
            return (MidPoint + FinalPoint) / 2;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {StuID} | Tên: {Name} | Điểm GK: {MidPoint} | Điểm CK: {FinalPoint} | Tổng kết: {getSubjectPoint():0.00} | Email: {Email}");
        }
    }
}