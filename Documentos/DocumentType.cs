using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
namespace Documentos
{
    class DocumentType
    {
        private static Dictionary<int, string> docTypes = new Dictionary<int, string>() {
            {3,"Factura"},
            {4,"Remisión"}
        };
        public static void fillDocTypes(ComboBox docTypeComboBox) {
            foreach (string type in docTypes.Values) {
                docTypeComboBox.Items.Add(type);
            }
            docTypeComboBox.SelectedIndex = 0;
        }
        public static int getDocumentTypeID(string typeSearch) {
            foreach (var type in docTypes)
            {
                if (type.Value == typeSearch) return type.Key;
            }
            return -1;
        }
    }
}
