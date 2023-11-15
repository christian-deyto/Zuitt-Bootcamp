using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activity
{
    internal partial class Factory
    {
        private string product;
        private int quantityPerPackaging;

        public Factory() { }
        public Factory(string product, int quantityPerPackaging, bool isInspected)
        {
            this.product = product;
            this.quantityPerPackaging = quantityPerPackaging;
            this.isInspected = true;
        }

        public string Product { get => product; set => product = value; }
        public int QuantityPerPackaging { get => quantityPerPackaging; set => quantityPerPackaging = value; }
    }
}
