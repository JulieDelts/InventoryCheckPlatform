﻿
using InventoryCheckPlatform.Core.DTOs;

namespace InventoryCheckPlatform.Core.OutputModels
{
	public class RestaurantOutputModel
	{
		public int Id { get; set; }

		public string Address { get; set; }

		public User Admin { get; set; }

		public List<User> Waiters { get; set; }

		public List<Menu>? Menus { get; set; }

		public List<SpecificProduct>? SpecificProducts { get; set; }
	}
}
