﻿
using System.ComponentModel.DataAnnotations;

namespace InventoryCheckPlatform.Core.InputModels
{
	public class ExtendedRestaurantInputModel
	{
		public int Id { get; set; }

        [Required(ErrorMessage = "Необходимо ввести адрес.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Необходимо ввести идентификатор администратора.")]
        public int AdminId { get; set; }

        [CustomFileExtensionValidation]
        public string? FileName { get; set; }
    }
}
