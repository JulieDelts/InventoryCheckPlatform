using System.ComponentModel.DataAnnotations;

namespace InventoryCheckPlatform.Core
{
	public class RoleValidationAttribute : ValidationAttribute
	{
		List<string> validRoles = new() { "администратор ресторана", "логист", "системный администратор", "официант" };

		public RoleValidationAttribute()
		{
			ErrorMessage = "Допустимые роли: системный администратор, администратор ресторана, логист, официант.";
		}

		public override bool IsValid(object? roleName)
		{
			if (roleName == null || roleName.ToString() == "") return false;

			var role = (string)roleName;

			return validRoles.Contains(role);
		}
	}
}
