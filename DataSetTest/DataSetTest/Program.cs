using System;
using System.Data;
using System.Data.OleDb;
class DatasetExample{
    public static void Main()    {
        OLEDB();
    }
    public static void OLEDB()    {
        string cnString = @"Provider=OraOLEDB.Oracle;data source=topcredu;User ID=scott;Password=tiger";
        OleDbConnection OleCn = new OleDbConnection(cnString);
        OleCn.Open();
        string sql = "SELECT * FROM emp";
        try
        {
            OleDbCommand OleCmd = new OleDbCommand(sql, OleCn);
            OleDbDataAdapter OleDa = new OleDbDataAdapter(OleCmd);
            DataSet ds = new DataSet();

            OleDa.Fill(ds, "Test");

            OleCn.Close();
            DataTable dt = ds.Tables["Test"];

            Console.Write("\n\n");
            foreach (DataColumn hdr in dt.Columns)
            {
                Console.Write("{0, -10}\t", hdr.ColumnName);
            }
            Console.WriteLine("\n---------------------------------------------------");
            foreach (DataRow dtr in dt.Rows)
            {
                foreach (DataColumn dtc in dt.Columns)
                {
                    Console.Write("{0, -10}", dtr[dtc.ColumnName].ToString().Trim());
                    Console.Write("\t");
                }
                Console.Write("\n");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e);
        }
    }
}