using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static ClassLibrary.Enumerations;

namespace ClassLibrary
{

    public class Product
    {
        public int Price { get; set; }
        public ProductTypes ProductType { get; set; }
    }

    //public int Price
    //{
    //    get => default;
    //    set
    //    {
    //    }
    //}

    //public int Name
    //{
    //    get => default;
    //    set
    //    {
    //    }
    //}

    //public void IncreaseLoot()
    //{
    //    throw new System.NotImplementedException();
    //}

    //public void DecreaseLoot()
    //{
    //    throw new System.NotImplementedException();
    //}
}