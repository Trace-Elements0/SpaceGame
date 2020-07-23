using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class TheMerchant : Characters
    {
        public TheMerchant()
        {
            this.MerchantBag = new List<Products>();
            this.Weapons = new List<Weapons>();
        }

        public int Loot
        {
            get => default;
            set
            {
            }
        }

        public List<Products> MerchantBag
        {
            get => default;
            set
            {
            }
        }

        public List<Weapons> Weapons
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// The Merchants action of space travel
        /// </summary>
        private void Travel()
        {
            throw new System.NotImplementedException();
        }

        public string Win()
        {
            throw new System.NotImplementedException();
        }

        public string Lose()
        {
            throw new System.NotImplementedException();
        }
    }

    public class CopyOfTheMerchant
    {
        public CopyOfTheMerchant()
        {
            throw new System.NotImplementedException();
        }

        public double Loot
        {
            get => default;
            set
            {
            }
        }

        public string MerchantBag
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// The Merchants action of space travel
        /// </summary>
        private void Travel()
        {
            throw new System.NotImplementedException();
        }

        public string Win()
        {
            throw new System.NotImplementedException();
        }

        public string Lose()
        {
            throw new System.NotImplementedException();
        }
    }
}