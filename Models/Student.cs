using System.ComponentModel.DataAnnotations;

namespace LAB1.Models
{
    public class Student
    {
        public int Id { get; set; }//Mã sinh viên
        public byte[]? Avatar { get; set; }

        [Required(ErrorMessage = "Tên không được để trông")]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "Tên tối thiểu 4 ký tự và tối đa 100")]

        public string? Name { get; set; } //Họ tên

        [Required(ErrorMessage = "Email bắt buộc phải được nhập")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@gmail.com", ErrorMessage = "Email không đúng định dạng")]
        public string? Email { get; set; } //Email

        [StringLength(100, MinimumLength = 8, ErrorMessage = "Password tối thiểu 8 ký tự và tối đa 100")]
        [Required(ErrorMessage = "Password không được để trống")]
        [RegularExpression(@"\d+[A-Z]+[a-z]+[@$!%*?&]+", ErrorMessage = "Mật khẩu phải chứa ít nhất một chữ cái viết hoa, một chữ cái viết thường, một chữ số và một ký tự đặc biệt.")]

        public string? Password { get; set; }//Mật khẩu

        [Required(ErrorMessage = "Ngành học không được để trống")]
        public Branch? Branch { get; set; }//Ngành học

        [Required(ErrorMessage = "Gioi tính không được để trống")]
        public Gender? Gender { get; set; }//Giới tính

        public bool IsRegular { get; set; }//Hệ: true-chính quy, false-phi chính quy

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Địa chỉ không được để trống")]
        public string? Address { get; set; }//Địa chỉ

        [Range(typeof(DateTime), "1/1/1963", "12/31/2005", ErrorMessage = "Ngày sinh nằm trong khoảng từ 1/1/1963 đến 31/12/2005")]
        [DataType(DataType.Date, ErrorMessage = "Ngày sinh có định dạng là mm/dd/yyyy")]
        [Required(ErrorMessage = "Ngày sinh không được để trống")]
        public DateTime DateOfBorth { get; set; }//Ngày sinh

        [Range(typeof(double), "0.0", "10.0", ErrorMessage = "Điểm phải là số thực nằm trong khoảng từ 0 đến 10")]
        [Required(ErrorMessage ="Điểm không được để trống")]
        public double? Point { get; set; }
    }
}
