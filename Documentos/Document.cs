using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Documentos
{
    class Document
    {
        private static Document documentInstance = null;
        private List<Product> listProducts;
        private string clientName;
        private string documentType;
        private string razonSocial;
        
        private Document()
        {
            if (listProducts != null) {
                listProducts.Clear();
                listProducts = null;
            }

            listProducts = new List<Product>();
            this.clientName = "";
            this.documentType = "";
            this.razonSocial = "";
        }

        public static Document getInstance() {
            if (documentInstance == null)
                documentInstance = new Document();
            return documentInstance;
        }

        public void setClientName(string _clientName) {
            this.clientName = _clientName;
        }
        public void setDocumentType(string _docType) {
            this.documentType = _docType;
        }
        public void setRazonSocial(string _razonSocial) {
            this.razonSocial = _razonSocial;
        }

        public List<Product> getListProducts() {
            return listProducts;
        }

        public int getIndexIsProductExists(string code) {
            int indexProduct = 0;
            foreach (Product producto in getListProducts())
            {
                if (producto.getBarcode() == code || producto.getClave() == code)
                {
                    return indexProduct;
                }
                indexProduct++;
            }
            return -1;
        }

        public string getClientName() {
            return clientName;
        }
        public string getRazonSocial() {
            return razonSocial;
        }
        public string getDocumentType() {
            return documentType;
        }

        public static void destroy() {
            documentInstance = null;
        }
    }
}
