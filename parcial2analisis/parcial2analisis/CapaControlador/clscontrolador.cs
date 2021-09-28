using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using CapaModelo;

namespace CapaControlador
{
    public class clscontrolador
    {
        clssentencias sn = new clssentencias();
        //Llenar una tabla datagrid capa controlador
        public DataTable llenartb1()
        {
            OdbcDataAdapter dt = sn.llenartb1();
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        //Llenar un combobox
        public OdbcDataReader llenarcbo()
        {
            string sql = "show full tables from prototipo_area_compras;";
            return sn.llenarcbotabla(sql);
        }

        //Para hacer un insert o un update o un delete
        public void ingresarconsulta(string nombre, string consulta)
        {
            string sql = "insert into registro_consultas (nombre,consulta) values ( '" + nombre + "', '" + consulta + "') ;";
            Console.WriteLine(sql);
            sn.insertarconsulta(sql);
        }

    }
}
