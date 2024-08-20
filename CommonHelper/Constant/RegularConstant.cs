using LAB1.Models;

namespace CommonHelper.Constant
{
	public static class RegularConstant
	{
		private static readonly Dictionary<bool, string> RegularDescriptions = new Dictionary<bool, string>
		{
			{ true, "Chính quy" },
			{ false, "Phi chính quy" },

		};

		public static string? TransformRegular(bool regular)
		{
			// Tìm mô tả dựa trên giá trị của enum
			return RegularDescriptions.TryGetValue(regular, out string? description) ? description : null;
		}
	}
}
