using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Configuration;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace SDMIS
{
    class OleDbHelp
    {
        //数据库连接语句
        private static string conStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\App_Data\\db_sdmis.mdb";
        //
        public static OleDbConnection conn = new OleDbConnection(conStr);
        #region 执行sql语句，返回一个DataTable。GetDataTable(string sql,params OleDbParameter[] paras)
        /// <summary>
        /// 执行sql语句，返回一个DataTable
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="paras"></param>
        /// <returns>dt</returns>
        public static DataTable GetDataTable(string sql,params OleDbParameter[] paras)
        {
            try
            {
                conn.Open();
                OleDbCommand comm = new OleDbCommand(sql,conn);
                foreach (OleDbParameter para in paras)
                {
                    comm.Parameters.Add(para);
                }
                OleDbDataAdapter da = new OleDbDataAdapter(comm);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comm.Parameters.Clear();
                conn.Close();
                return dt;
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.Message,"提示");
                //throw new Exception(ex.ToString());
                conn.Close();
                throw;
            }
        }
        #endregion

        #region 执行sql语句，返回第一行第一列。selectExecute(string sql, params OleDbParameter[] paras)
        /// <summary>
        /// 执行sql语句，返回第一行第一列
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public static object selectExecute(string sql, params OleDbParameter[] paras)
        {
            try
            {
                //conn.Open();
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                OleDbCommand comm = new OleDbCommand(sql, conn);
                foreach (OleDbParameter para in paras)
                {
                    comm.Parameters.Add(para);
                }
                object flag = comm.ExecuteScalar();
                comm.Parameters.Clear();
                conn.Close();
                return flag;
            }
            catch (Exception)
            {
                conn.Close();
                throw;
            }
        }
        #endregion

        #region 执行sql语句，返回受影响的行数。Execute(string sql, params OleDbParameter[] paras)
        /// <summary>
        /// 执行sql语句，返回受影响的行数
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public static int Execute(string sql, params OleDbParameter[] paras)
        {
            try
            {
                conn.Open();
                OleDbCommand comm = new OleDbCommand(sql, conn);
                foreach (OleDbParameter para in paras)
                {
                    comm.Parameters.Add(para);
                }
                int flag = comm.ExecuteNonQuery();
                comm.Parameters.Clear();
                conn.Close();
                return flag;
            }
            catch (Exception)
            {
                conn.Close();
                throw;
            }
        }
        #endregion

        #region 执行sql语句，返回一个OleDbDataReader。GetOleDbDataReader(string sql, params OleDbParameter[] paras)
        /// <summary>
        /// 执行sql语句，返回一个OleDbDataReader
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public static OleDbDataReader GetOleDbDataReader(string sql, params OleDbParameter[] paras)
        {
            try
            {
                conn.Open();
                OleDbCommand comm = new OleDbCommand(sql, conn);
                foreach (OleDbParameter para in paras)
                {
                    comm.Parameters.Add(para);
                }
                OleDbDataReader dr = comm.ExecuteReader(CommandBehavior.CloseConnection);
                comm.Parameters.Clear();
                return dr;
            }
            catch (Exception)
            {
                conn.Close();
                throw;
            }
        }
        #endregion
    }
}
