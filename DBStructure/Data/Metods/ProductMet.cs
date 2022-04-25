using System;
using System.Collections.Generic;
using System.Text;
using DBStructure.Data.Exceptions;
using DBStructure.Data.Models;
using DBStructure.Data.Metods;
using System.Linq;
using DBStructure.Data.DAL;

namespace DBStructure.Data.Metods
{
    internal class ProductMet
    {
        StoreDbContext StoreDbContext = new StoreDbContext();
        ProductsMet productsMet = new ProductsMet();

        public void CheckExistsPr(Products product)
        {
            var pr = StoreDbContext.Products.Where(x => x.Name == product.Name).ToList();
            if (pr.Count > 0)
            {
                throw new DataIsAlreadyExistsException("Bu mehsul artiq var!");
            }
            else
            {
                productsMet.AddProduct(product);
            }
        }

        public void CheckPrData(string smth)
        {
            var products = StoreDbContext.Products.Where(x => x.Name.Contains(smth)).ToList();
            if (products.Count > 0)
            {
                productsMet.SearchProduct(smth);
            }
            else
            {
                throw new NotFoundException("Bele product yoxdur!");
            }
        }

        public void CheckPrAvg()
        {
            var products = StoreDbContext.Products.ToList();
            if (products.Count > 0)
            {
                productsMet.GetProductsAVGPrice();
            }
            else
            {
                throw new NotFoundException("Mehsul yoxdur");
            }
        }
    }
}
