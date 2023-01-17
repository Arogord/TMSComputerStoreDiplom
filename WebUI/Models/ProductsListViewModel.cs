﻿using Abststract.common.Entities;

namespace WebUI.Models
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product>? Products { get; set; }
        //public PagingInfo PagingInfo { get; set; }
        public string CurrentCategory { get; set; }
    }
}
