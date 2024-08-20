using LAB1.Models;
using System.Linq;

namespace CommonHelper.Constant
{

	public static  class BranchConstant
	{
		private static readonly Dictionary<Branch, string> branchDescriptions = new Dictionary<Branch, string>
		{
			{ Branch.IT, "Công nghệ thông tin" },
			{ Branch.BE, "Kinh tế" },
			{ Branch.CE, "Công trình" },
			{ Branch.EE, "Điện điện tử" }
		};

		public static string? TransformBranch(Branch? branch)
		{

			if (branch.HasValue)
			{
				return branchDescriptions.TryGetValue(branch.Value, out string? description) ? description : null;

			}
			return null;
				}
	}
}
