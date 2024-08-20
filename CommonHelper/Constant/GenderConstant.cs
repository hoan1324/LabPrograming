using LAB1.Models;

namespace CommonHelper.Constant
{
	public class GenderConstant
	{
		private static readonly Dictionary<Gender, string> GenderDescriptions = new Dictionary<Gender, string>
		{
			{ Gender.Male, "Nam" },
			{ Gender.Female, "Nữ" },
			
		};

		public static string? TransformGender(Gender? Gender)
		{
			if (Gender.HasValue)
			{
				return GenderDescriptions.TryGetValue(Gender.Value, out string? description) ? description : null;

			}
			return null;
			// Tìm mô tả dựa trên giá trị của enum
		}
	}
}
