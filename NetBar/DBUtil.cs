using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
namespace NetBar
{
    class DBUtil
    {
        public int GetZSG(string sql)
        {
            //创建数据库连接对象
            SqlConnection conn = new SqlConnection("server=.;database=NetBarDB;uid=sa;pwd=123456");
            //启用连接
            conn.Open();
            //创建数据库操作对象
            SqlCommand cmd = new SqlCommand(sql, conn);
            //调用方法执行sql语句
            int row = cmd.ExecuteNonQuery();
            //关闭连接
            conn.Close();
            //返回row
            return row;
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public DataTable GetQuery(string sql)
        {
            //创建数据库连接对象
            SqlConnection conn = new SqlConnection("server=.;database=NetBarDB;uid=sa;pwd=123456");
            //启用数据库
            conn.Open();
            //创建数据库断开式操作对象
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
            //创建数据集对象
            DataSet ds = new DataSet();
            //填充数据集
            sda.Fill(ds);
            conn.Close();
            return ds.Tables[0];
        }
    }
}
