using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace CRM356Connector
{
    class DataAccess
    {

        public static string ConnString = string.Empty;

    
        #region When Table Structure Was change
        public static void StructureWaschange(string TableName)
        {
            string CloumnName = string.Empty;
            SqlConnection conn = new SqlConnection(ConnString);
            conn.Open();
            SqlCommand cmd;
            using (conn)
            {
                try
                {
                    CloumnName = " Drop PROCEDURE " + TableName + "_SP";
                    cmd = new SqlCommand(CloumnName, conn);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    DataAccess.Error(e.Message, e.HResult, CloumnName);
                }

                try
                {
                    CloumnName = " Drop Type " + TableName + "_type_table ";
                    cmd = new SqlCommand(CloumnName, conn);
                    cmd.ExecuteNonQuery();

                }
                catch (Exception e)
                {
                    DataAccess.Error(e.Message, e.HResult, CloumnName);
                }
                try
                {
                    CloumnName = " Drop Table " + TableName;
                    cmd = new SqlCommand(CloumnName, conn);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    DataAccess.Error(e.Message, e.HResult, CloumnName);
                }


            }
        }
        #endregion

        #region CreatingTypetable
        public static void CreatingTypetable(List<string> prop, string TableTypeName)
        {
            LogicalName.Table = TableTypeName + " Table_Type";
            string CloumnName = HelpingFuns.GetTableStructure(prop);
            SqlConnection conn = new SqlConnection(ConnString);
            conn.Open();
            using (conn)
            {
                CloumnName = " IF TYPE_ID(N'" + TableTypeName + "_type_table') IS NULL \n begin \n CREATE TYPE " + TableTypeName + "_type_table AS TABLE (\n" + CloumnName + "\n) \n end";
                SqlCommand cmd = new SqlCommand(CloumnName, conn);
                cmd.ExecuteNonQuery();
            }
        }
        #endregion

        #region PROCEDURE_CHECK
        public static bool PROCEDURE_CHECK(string PROCEDUREname)
        {
            int newProdID = 0;
            SqlConnection conn = new SqlConnection(ConnString);
            conn.Open();
            using (conn)
            {

                SqlCommand cmd = new SqlCommand("SELECT count(1) FROM sys.objects WHERE type = 'P' AND name = '" + PROCEDUREname + "'", conn);
                object result = cmd.ExecuteScalar();
                newProdID = (result == null ? newProdID : Convert.ToInt32(result));

                if (newProdID > 0)
                    return false;
                else
                    return true;
            }
        }
        #endregion

        #region Table_CHECK
        public static bool Table_CHECK(string tablename)
        {
            int newProdID = 0;
            SqlConnection conn = new SqlConnection(ConnString);
            conn.Open();
            using (conn)
            {

                SqlCommand cmd = new SqlCommand("select count(1) from INFORMATION_SCHEMA.TABLES where TABLE_NAME=N'" + tablename + "'", conn);
                object result = cmd.ExecuteScalar();
                newProdID = (result == null ? newProdID : Convert.ToInt32(result));

                if (newProdID > 0)
                    return true;
                else
                    return false;
            }
        }
        #endregion

        #region Create_PROCEDURE
        public static void Create_PROCEDURE(IList<string> prop, string TableName)
        {
            LogicalName.Table = TableName + " Table_Name";
            string PROCEDURE_NAME = TableName + "_SP";
            if (PROCEDURE_CHECK(PROCEDURE_NAME))
            {

                string CloumnName = HelpingFuns.GetTableStructure(prop);
                SqlConnection conn = new SqlConnection(ConnString);
                conn.Open();
                using (conn)
                {
                    PROCEDURE_NAME = "CREATE PROCEDURE " + PROCEDURE_NAME + "\n @" + TableName + "_var  " + TableName + "_type_table readonly \n AS \n BEGIN \n \n SET NOCOUNT ON; \n if NOT EXISTS  (select 1 from INFORMATION_SCHEMA.TABLES where TABLE_NAME=N'" + TableName + "') \n BEGIN \n CREATE TABLE [dbo].[" + TableName + "] \n (\n" + CloumnName + "\n) \n END \n INSERT INTO [dbo].[" + TableName + "] \n select * from @" + TableName + "_var \n END";

                    SqlCommand cmd = new SqlCommand(PROCEDURE_NAME, conn);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region DATA_SET
        public static void DATA_SET(dynamic dynObj, List<string> prop, List<string> props, string TABLE_NAME)
        {
            //CreateTableType();
            LogicalName.Table = TABLE_NAME + " Data_Entry";
            SqlConnection conn = new SqlConnection(ConnString);

            conn.Open();
            using (conn)
            {
                int count = dynObj.value.Count;
                SqlCommand cmd;
                if (Table_CHECK(TABLE_NAME))
                {
                    cmd = new SqlCommand(" truncate table " + TABLE_NAME + "", conn);
                    cmd.ExecuteNonQuery();
                }
                DataTable dt = new DataTable();
                dt.Clear();
                for (int i = 0; i < props.Count; i++)
                {
                    string[] Array = props[i].Split(':');

                    props[i] = Array.Length != 1 ? Array[0] + " " + HelpingFuns.SQLColumnType(Array[1]) : Array[0];

                }

                for (int i = 0; i < prop.Count; i++)
                {
                    dt.Columns.Add(prop[i]);
                }

                for (int i = 0; i < count; i++)
                {
                    DataRow _Ars = dt.NewRow();
                    List<object> ValuesProp = HelpingFuns.VALUEProperty(dynObj.value[i]);
                    DateTime date;
                    String AA = "";

                    for (int y = 0; y < prop.Count; y++)
                    {
                        if (props[y].EndsWith("datetime  NULL") && ValuesProp[y] != null)
                        {
                            date = DateTime.Parse((string)ValuesProp[y], CultureInfo.CreateSpecificCulture("en-GB"));
                            AA =  string.Format("{0:yyyy-MM-dd HH:mm:ss.fff}", date);
                        }

                        _Ars[prop[y]] =

                        props[y].EndsWith("int NULL") ? ValuesProp[y] == null ? null : (int?)Convert.ToInt32(ValuesProp[y]) :
                        props[y].EndsWith("bigint NULL") ? ValuesProp[y] == null ? null : (int?)Convert.ToInt64(ValuesProp[y]) :
                        props[y].EndsWith("bit NULL") ? ValuesProp[y] == null ? null : (bool?)Convert.ToBoolean(ValuesProp[y]) :
                        // props[y].EndsWith("datetime  NULL") ? ValuesProp[y] == null ? null : (DateTime?)Convert.ToDateTime((string)ValuesProp[y]) :
                        props[y].EndsWith("datetime  NULL") ? ValuesProp[y] == null ? null : (DateTime?)DateTime.Parse((string)AA) :
                        props[y].EndsWith("float NULL") ? ValuesProp[y] == null ? null : (float?)float.Parse((string)ValuesProp[y]) :
                        props[y].EndsWith("Money NULL") ? ValuesProp[y] == null ? null : (int?)Convert.ToInt64(ValuesProp[y]) :
                        ValuesProp[y];
                    }

                    dt.Rows.Add(_Ars);
                }

                cmd = new SqlCommand(TABLE_NAME + "_SP", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue(TABLE_NAME + "_Var", dt);
                cmd.ExecuteNonQuery();
            }
        }
        #endregion

        #region FilteredStringMap
        public static void FilteredStringMap(DataTable dynObj, string TABLE_NAME, string onetime)
        {
            //CreateTableType();
            SqlConnection conn = new SqlConnection(ConnString);
            conn.Open();
            using (conn)
            {

                SqlCommand cmd;
                if (Table_CHECK(TABLE_NAME))
                {
                    cmd = new SqlCommand("delete FROM " + TABLE_NAME + " where [FilteredViewName] = '" + onetime + "'", conn);
                    cmd.ExecuteNonQuery();
                }
                cmd = new SqlCommand(TABLE_NAME + "_SP", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue(TABLE_NAME + "_Var", dynObj);
                cmd.ExecuteNonQuery();
            }
        }
        #endregion

        #region ERROR       
        public static void Error(string ErrorSrting, int ErrorCode, string OnError)
        {            //CreateTableType(); 
            String dateMy = Convert.ToString(DateTime.Now);
            dateMy = DateTime.Parse(dateMy, CultureInfo.CreateSpecificCulture("en-GB")).ToString("yyyy-MM-dd HH:mm:ss.fff");
            ErrorSrting = ErrorSrting.Replace("'", "''");
            SqlConnection conn = new SqlConnection(ConnString);
            conn.Open();
            using (conn)
            {
                SqlCommand cmd;
                cmd = new SqlCommand("INSERT INTO [dbo].[ErrorLog]([ErrorMessage],[date],[ErrorCode],[OnError])VALUES('" + ErrorSrting + "','" + dateMy + "'," + ErrorCode + ",'" + OnError + "')", conn);
                cmd.ExecuteNonQuery();
            }
        }
        #endregion
    }
}
