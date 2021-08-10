using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace Biblioteca
{
    public static class Excel
    {
        public static event Informador EventoInformarExportacion;
        public static void ExportarExcel(DataGridView tabla)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);
            try
            {
                foreach (DataGridViewColumn col in tabla.Columns)
                {
                    excel.Cells[1, col.Index+1] = col.Name;
                    foreach (DataGridViewRow fila in tabla.Rows)
                    {
                        excel.Cells[fila.Index+2, col.Index+1] = fila.Cells[col.Index].Value;
                    }
                }
            }
            catch (Exception Ex)
            {
                EventoInformarExportacion.Invoke(Ex.Message);
            }
            EventoInformarExportacion.Invoke("Se Exportaron los datos");
            excel.Visible = true;
        }
    }
}
