using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
namespace Documentos.Connection
{
    class SQLFunction
    {
        SQLConnection conn = SQLConnection.getInstance();
        Document document = Document.getInstance();
        bool documentFound = false;
        public void searchDocumentByBarcode(string documentID){
            string commandString = string.Format("SELECT C.NOMBRE,C.RAZON_SOCIAL,TD.TIPO,P.PRODUCTO,P.NOMBRE,PP.CODIGO_BARRAS,DD.CANTIDAD,U.ABREVIACION FROM DOCUMENTOS as Doc\n" +
                            "INNER JOIN DETALLE_DOCUMENTOS as DD on Doc.NUMERO_DOCUMENTO = DD.NUMERO_DOCUMENTO\n" +
                            "INNER JOIN PRODUCTOS as P on P.ID = DD.PRODUCTO\n" +
                            "INNER JOIN UNIDADES as U on U.ID = DD.UNIDAD_MEDIDA\n" +
                            "INNER JOIN PRODUCTOS_PRECIOS as PP on PP.PRODUCTO = DD.PRODUCTO and PP.UNIDAD_MEDIDA_EQUIVALENCIA = DD.UNIDAD_MEDIDA\n" +
                            "INNER JOIN CLIENTES as C on C.ID = Doc.CLIENTE\n" +
                            "INNER JOIN TIPO_DOCUMENTOS as TD on TD.ID = Doc.TIPO_DOCTO\n" +
                            "where Doc.ID = {0}"
                            , documentID);
            SqlCommand command = new SqlCommand(commandString,conn.getSqlConnection());
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) {
                documentFound = true;
                document.setClientName(reader[0].ToString());
                document.setRazonSocial(reader[1].ToString());
                document.setDocumentType(reader[2].ToString());
                
                Product producto = new Product();
                producto.setClave(reader[3].ToString());
                producto.setDescription(reader[4].ToString());
                producto.setBarcode(reader[5].ToString());
                producto.setAmount(reader[6].ToString());
                producto.setUnit(reader[7].ToString());

                document.getListProducts().Add(producto);
            }
            reader.Close();
            if (!documentFound) throw new Exception("Documento no encontrado");

        }

        public void getDocumetByDocumentNumber(string documentID, int documentType)
        {
            string commandString = string.Format("SELECT C.NOMBRE,C.RAZON_SOCIAL,TD.TIPO,P.PRODUCTO,P.NOMBRE,PP.CODIGO_BARRAS,DD.CANTIDAD,U.ABREVIACION FROM DOCUMENTOS as Doc\n" +
                            "INNER JOIN DETALLE_DOCUMENTOS as DD on Doc.NUMERO_DOCUMENTO = DD.NUMERO_DOCUMENTO\n" +
                            "INNER JOIN PRODUCTOS as P on P.ID = DD.PRODUCTO\n" +
                            "INNER JOIN UNIDADES as U on U.ID = DD.UNIDAD_MEDIDA\n" +
                            "INNER JOIN PRODUCTOS_PRECIOS as PP on PP.PRODUCTO = DD.PRODUCTO and PP.UNIDAD_MEDIDA_EQUIVALENCIA = DD.UNIDAD_MEDIDA\n" +
                            "INNER JOIN CLIENTES as C on C.ID = Doc.CLIENTE\n" +
                            "INNER JOIN TIPO_DOCUMENTOS as TD on TD.ID = Doc.TIPO_DOCTO\n" +
                            "where Doc.NUMERO_DOCUMENTO like '%{0}' and Doc.TIPO_DOCTO = {1}"
                            , documentID,documentType);
            SqlCommand command = new SqlCommand(commandString, conn.getSqlConnection());
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                documentFound = true;
                document.setClientName(reader[0].ToString());
                document.setRazonSocial(reader[1].ToString());
                document.setDocumentType(reader[2].ToString());

                Product producto = new Product();
                producto.setClave(reader[3].ToString());
                producto.setDescription(reader[4].ToString());
                producto.setBarcode(reader[5].ToString());
                producto.setAmount(reader[6].ToString());
                producto.setUnit(reader[7].ToString());

                document.getListProducts().Add(producto);
            }
            reader.Close();
            if (!documentFound) throw new Exception("Documento no encontrado");
        }
    }
}
