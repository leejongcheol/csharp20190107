using System;
using System.Data.OleDb;
using System.Windows.Forms;
namespace Login
{
    class Common_DB
    {
        // DataBase Connection
        public static OleDbConnection DBConnection()
        {
            OleDbConnection Conn;
            //아래는 오라클용 접속 문자열, data source 애는 tnsnames.ora 파일에
            있는 Alias명을 넣으면 됩니다.
 string ConStr = ("Provider=ORAOLEDB.ORACLE;data source=kaeri;User
       ID = scott; Password = tiger");
        Conn = new OleDbConnection(ConStr);
            return Conn;
        }
        // DataSelect
        public static OleDbDataReader DataSelect(string id, string sql,
       OleDbConnection Conn)
        {
            try
            {
                OleDbCommand myCommand = new OleDbCommand(sql, Conn);
                myCommand.Parameters.Add("@id", OleDbType.Char, 10).Value = id;
                return myCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                //Log File에 출력
                Log.WriteLine("FrmLogin", ex.ToString());
                MessageBox.Show(sql + "\n" + ex.Message, "DataSelect");
                return null;
            }
            finally
            {
                //Log File에 출력
                Log.WriteLine("FrmLogin", “data select ok!”);
                return null;
            }
        }
    }
}