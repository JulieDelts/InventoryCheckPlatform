﻿
namespace InventoryCheckPlatform.Core
{
    public class Options
    {
        public static string ConnectionString
        {
            get
            {
                return Environment.GetEnvironmentVariable("RepairsDB");
            }
        }
    }
}