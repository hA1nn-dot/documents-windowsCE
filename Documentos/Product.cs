using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Documentos
{
    class Product : IProduct
    {
        private string description {get;set;}
        private string unit;
        private string clave;
        private string amount;
        private string barcode;

        public void setAmount(string _amount) {
            this.amount = _amount;
        }
        public void setClave(string _clave) {
            this.clave = _clave;
        }
        public void setUnit(string _unit) {
            this.unit = _unit;
        }
        public void setDescription(string _description) {
            this.description = _description;
        }
        public void setBarcode(string _barcode) {
            this.barcode = _barcode;
        }

        public string getDescription() {
            return description;
        }
        public string getUnit() {
            return unit;
        }
        public string getClave() {
            return clave;
        }
        public string getAmount() {
            return amount;
        }
        public string getBarcode() {
            return barcode;
        }
        
    }
}
