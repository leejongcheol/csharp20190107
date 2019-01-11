using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
namespace OracleDataAdapterTrTest
{
    class Program
    {
        static void Main(string[] args)
        {
             string connString = @"Data Source=(DESCRIPTION =
 (ADDRESS = (PROTOCOL = TCP)(HOST = 192.168.0.27)(PORT = 1521))
 (CONNECT_DATA =
 (SERVER = DEDICATED)
(SERVICE_NAME = topcredu)
 )
 ) ;User Id=scott;Password=tiger";  
            //String connString = "Data Source=topcredu;User Id = scott; Password = tiger";
            String sqlSelect = "SELECT * FROM emp";

            OracleConnection conn = new OracleConnection(connString);
            conn.Open();

            OracleDataAdapter da = new OracleDataAdapter(sqlSelect, conn);
            DataSet ds = new DataSet("EMPLOYEES");

            // load data from the data source into the DataSet
            OracleCommandBuilder cb = new OracleCommandBuilder(da);
            da.Fill(ds, "EMP");
            Console.WriteLine("FILL 건수 : " + ds.Tables["EMP"].Rows.Count);

            // start the transaction
            OracleTransaction tran = conn.BeginTransaction();
            // associate transaction with the data adapter command objects
            da.DeleteCommand = cb.GetDeleteCommand();
            da.InsertCommand = cb.GetInsertCommand();
            da.UpdateCommand = cb.GetUpdateCommand();

            da.DeleteCommand.Transaction = tran;
            da.InsertCommand.Transaction = tran;
            da.UpdateCommand.Transaction = tran;

            // modify
            ds.Tables["EMP"].Rows[0]["ename"] = "0000길동";
            ds.Tables["EMP"].Rows[1]["ename"] = "1111길동";

            //delete
            Console.WriteLine("삭제 대상 : " + ds.Tables["EMP"].Rows[9]["ename"]);
            ds.Tables["EMP"].Rows[9].Delete();

            //insert
            DataRow r = ds.Tables["EMP"].NewRow();
            r[0] = 1119; r[1] = "JCLEE";
            ds.Tables["EMP"].Rows.Add(r);
            try
            {
                ds.AcceptChanges();
                Console.WriteLine(ds.GetXml());
                da.Update(ds, "EMP");
                // commit if successful
                tran.Commit();
                Console.WriteLine("Commit OK~");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                tran?.Rollback();
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
