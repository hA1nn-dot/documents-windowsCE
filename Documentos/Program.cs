using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
namespace Documentos.Connection
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [MTAThread]
        static void Main()
        {
            Form1 documentForm = new Form1();
            Application.Run(documentForm);
            
            
        }
    }
}