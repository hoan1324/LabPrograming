using CommonHelper.Constant;
using LAB1.Models;
using LAB1.Models.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LAB1.Controllers
{
	public class StudentController : Controller
	{
		private List<Student> _students;
		private readonly IUploadFileService _uploadFile;
		public StudentController(IUploadFileService uploadFile)
		{
			_uploadFile = uploadFile;
			_students = new List<Student>() {
				new Student()
				{
					Id = 101,
					Name = "Quốc Nam",
					Branch = Branch.IT,
					Gender = Gender.Male,
					IsRegular = true,
					Address = "A1-2018",
					Email = "nam@g.com",
				},
				new Student()
				{
					Id =102,
					Name = "Phạm Viêth",
					Branch = Branch.CE,
					Gender = Gender.Female,
					IsRegular =false,
					Address = "Hà Đông",
					Email = "pv@g.com",
				},
				new Student()
				{
					Id = 103,
					Name = "Văn Hoàn",
					Branch = Branch.EE,
					Gender = Gender.Male,
					IsRegular = false,
					Address = "Hà Nội",
					Email = "hoan@mail.com",
				},
				new Student()
				{
					Id =104,
					Name = "Văn Quang",
					Branch = Branch.BE,
					Gender = Gender.Female,
					IsRegular = true,
					Address = "Bắc Ninh",
					Email = "nvq@mail.com",

				}
			};
		}
		public IActionResult Index()
		{
			return View(_students);
		}
		public IActionResult Create()
		{
			ViewBag.AllGenders = Enum.GetValues(typeof(Gender)).Cast<Gender>().ToList();
			ViewBag.AllBranches = Enum.GetValues(typeof(Branch)).Cast<Branch>().ToList();
            return View();
		}
		[HttpPost]
		public async Task<IActionResult> Create(Student student,IFormFile AvatarFile)
		{
			if (ModelState.IsValid) {
                if (AvatarFile != null)
                {
                    if (AvatarFile != null && AvatarFile.Length > 0 && !ImageContentTypeConst.ContentTypes.Any(item => item == AvatarFile.ContentType))
                    {
                        TempData["ErrorMessage"] = "File phải là ảnh";
                        return View();
                    }
                    student.Avatar = await _uploadFile.UploadFile(AvatarFile);

                }
                student.Id = (_students.Last().Id) + 1;
                _students.Add(student);
                TempData["SuccessMessage"] = "Tạo mới thành công";
                return View("Index", _students);
            }
            ViewBag.AllGenders = Enum.GetValues(typeof(Gender)).Cast<Gender>().ToList();
            ViewBag.AllBranches = Enum.GetValues(typeof(Branch)).Cast<Branch>().ToList();
            return View();
        }
	}
}
