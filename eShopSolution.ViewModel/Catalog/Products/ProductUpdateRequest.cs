﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.ViewModel.Catalog.Products
{
    public class ProductUpdateRequest
    {
        public int ID { get; set; }
        public int ProductId { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }

        public string Details { set; get; }
        public string SeoDescription { set; get; }
        public string SeoTitle { set; get; }

        public string SeoAlias { get; set; }
        public string LanguageId { set; get; }
        public IFormFile ThumbnailImage { get; set; }
    }
}
