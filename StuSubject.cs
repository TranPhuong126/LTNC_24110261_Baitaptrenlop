namespace QuanLySinhVien
{
    public class StuSubject
    {
        public string StudentID { get; set; }
        public string SubjectID { get; set; }

        public StuSubject(string studentId, string subjectId)
        {
            StudentID = studentId;
            SubjectID = subjectId;
        }
    }
}