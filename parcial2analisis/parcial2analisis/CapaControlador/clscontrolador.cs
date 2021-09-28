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

        public DataTable llenartb2()
        {
            OdbcDataAdapter dt = sn.llenartb2();
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        //Llenar un combobox
        public OdbcDataReader llenarcbo()
        {
            string sql = "select * from marca";
            return sn.llenarcbotabla(sql);
        }

        public OdbcDataReader llenarcboproducto()
        {
            string sql = "select * from producto;";
            return sn.llenarcbotabla(sql);
        }

        //Para hacer un insert o un update o un delete
        public void ingresarconsulta(string nombre, string consulta)
        {
            string sql = "insert into linea (nombre, descripcion,idmarca) values ("+'"'+nombre+'"'+","+'"';
            Console.WriteLine(sql);
            sn.insertarconsulta(sql);
        }

        public void ingresarmarca(string nombre, string direccion)
        {
            string sql = "insert into marca (nombre,direccion) values ("+'"'+nombre+'"' +", "+'"'+direccion +'"'+");";
            Console.WriteLine(sql);
            sn.insertarconsulta(sql);
        }

        public void ingresarlinea(string nombre, string descripcion, string codmarca)
        {
            string sql = "insert into linea (nombre, descripcion,id_marca) values (" + '"' + nombre + '"' + "," + '"'+
               descripcion + '"'+","+'"'+codmarca+'"'+");" ;
            Console.WriteLine(sql);
            sn.insertarconsulta(sql);
        }

        public void ingresarproveedor(string nombre, string direccion, string telefono, string email)
        {
            string sql = "insert into proveedores (nombre, direccion,telefono,email)" +
                " values (" + '"' + nombre + '"' + "," + '"' +
               direccion + '"' + "," + '"' + telefono + '"' + "," + '"' +email+'"'+ ");";
            Console.WriteLine(sql);
            sn.insertarconsulta(sql);
        }

        public void eliminarproveedor(string nombre)
        {
            string sql = "DELETE FROM PROVEEDORES WHERE NOMBRE=" + '"' + nombre + '"'+";";
            Console.WriteLine(sql);
            sn.insertarconsulta(sql);
        }
        public void ingresarproducto(string nombre, string descripcion, string linea)
        {
            string sql = "insert into producto (nombre, descripcion,idlinea)" +
                " values (" + '"' + nombre + '"' + "," + '"' +
               descripcion + '"' + "," + '"' + linea + '"' + ");";
            Console.WriteLine(sql);
            sn.insertarconsulta(sql);
        }
        public void eliminarproducto(string nombre)
        {
            string sql = "DELETE FROM PRODUCTO WHERE NOMBRE=" + '"' + nombre + '"' + ";";
            Console.WriteLine(sql);
            sn.insertarconsulta(sql);
        }
    }
}
