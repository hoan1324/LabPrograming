namespace LAB1.Models
{
    public class Student
    {
        public int Id { get; set; }//Mã sinh viên
        public string? Name { get; set; } //Họ tên  
        public string? Email { get; set; } //Email
        public string? Password { get; set; }//Mật khẩu
        public Branch? Branch { get; set; }
        public Gender? Gender { get; set; }//Giới tính
        public bool IsRegular { get; set; }//Hệ: truc-chính qui,
        public string? Address { get; set; }//Địa chi
        public DateTime DateOfBorth { get; set; }//Ngày sinh
        public byte[]? Avatar { get; set; }
    }
}
