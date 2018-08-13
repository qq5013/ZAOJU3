﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTDataAccess.DBUtility;//Please add references
namespace FTDataAccess.DAL
{
    /// <summary>
    /// 数据访问类:ProductSizeCfgModel
    /// </summary>
    public partial class ProductSizeCfgDal
    {
        public ProductSizeCfgDal()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string productCataCode)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ProductSizeCfg");
            strSql.Append(" where productCataCode=@productCataCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@productCataCode", SqlDbType.NVarChar,50)			};
            parameters[0].Value = productCataCode;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(FTDataAccess.Model.ProductSizeCfgModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ProductSizeCfg(");
            strSql.Append("cataSeq,productCataCode,productHeight,mark,packageSize,productName,gasName,baseSizeLevel,facePanelSize,tag1,tag2,tag3,tag4,tag5)");
            strSql.Append(" values (");
            strSql.Append("@cataSeq,@productCataCode,@productHeight,@mark,@packageSize,@productName,@gasName,@baseSizeLevel,@facePanelSize,@tag1,@tag2,@tag3,@tag4,@tag5)");
            SqlParameter[] parameters = {
					new SqlParameter("@cataSeq", SqlDbType.Int,4),
					new SqlParameter("@productCataCode", SqlDbType.NVarChar,50),
					new SqlParameter("@productHeight", SqlDbType.Int,4),
					new SqlParameter("@mark", SqlDbType.NVarChar,200),
					new SqlParameter("@packageSize", SqlDbType.NVarChar,50),
					new SqlParameter("@productName", SqlDbType.NVarChar,50),
					new SqlParameter("@gasName", SqlDbType.NVarChar,20),
					new SqlParameter("@baseSizeLevel", SqlDbType.Int,4),
					new SqlParameter("@facePanelSize", SqlDbType.Int,4),
					new SqlParameter("@tag1", SqlDbType.NVarChar,50),
					new SqlParameter("@tag2", SqlDbType.NVarChar,50),
					new SqlParameter("@tag3", SqlDbType.NVarChar,50),
					new SqlParameter("@tag4", SqlDbType.NVarChar,50),
					new SqlParameter("@tag5", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.cataSeq;
            parameters[1].Value = model.productCataCode;
            parameters[2].Value = model.productHeight;
            parameters[3].Value = model.mark;
            parameters[4].Value = model.packageSize;
            parameters[5].Value = model.productName;
            parameters[6].Value = model.gasName;
            parameters[7].Value = model.baseSizeLevel;
            parameters[8].Value = model.facePanelSize;
            parameters[9].Value = model.tag1;
            parameters[10].Value = model.tag2;
            parameters[11].Value = model.tag3;
            parameters[12].Value = model.tag4;
            parameters[13].Value = model.tag5;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(FTDataAccess.Model.ProductSizeCfgModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ProductSizeCfg set ");
            strSql.Append("cataSeq=@cataSeq,");
            strSql.Append("productHeight=@productHeight,");
            strSql.Append("mark=@mark,");
            strSql.Append("packageSize=@packageSize,");
            strSql.Append("productName=@productName,");
            strSql.Append("gasName=@gasName,");
            strSql.Append("baseSizeLevel=@baseSizeLevel,");
            strSql.Append("facePanelSize=@facePanelSize,");
            strSql.Append("tag1=@tag1,");
            strSql.Append("tag2=@tag2,");
            strSql.Append("tag3=@tag3,");
            strSql.Append("tag4=@tag4,");
            strSql.Append("tag5=@tag5");
            strSql.Append(" where productCataCode=@productCataCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@cataSeq", SqlDbType.Int,4),
					new SqlParameter("@productHeight", SqlDbType.Int,4),
					new SqlParameter("@mark", SqlDbType.NVarChar,200),
					new SqlParameter("@packageSize", SqlDbType.NVarChar,50),
					new SqlParameter("@productName", SqlDbType.NVarChar,50),
					new SqlParameter("@gasName", SqlDbType.NVarChar,20),
					new SqlParameter("@baseSizeLevel", SqlDbType.Int,4),
					new SqlParameter("@facePanelSize", SqlDbType.Int,4),
					new SqlParameter("@tag1", SqlDbType.NVarChar,50),
					new SqlParameter("@tag2", SqlDbType.NVarChar,50),
					new SqlParameter("@tag3", SqlDbType.NVarChar,50),
					new SqlParameter("@tag4", SqlDbType.NVarChar,50),
					new SqlParameter("@tag5", SqlDbType.NVarChar,50),
					new SqlParameter("@productCataCode", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.cataSeq;
            parameters[1].Value = model.productHeight;
            parameters[2].Value = model.mark;
            parameters[3].Value = model.packageSize;
            parameters[4].Value = model.productName;
            parameters[5].Value = model.gasName;
            parameters[6].Value = model.baseSizeLevel;
            parameters[7].Value = model.facePanelSize;
            parameters[8].Value = model.tag1;
            parameters[9].Value = model.tag2;
            parameters[10].Value = model.tag3;
            parameters[11].Value = model.tag4;
            parameters[12].Value = model.tag5;
            parameters[13].Value = model.productCataCode;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

       
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string productCataCode)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ProductSizeCfg ");
            strSql.Append(" where productCataCode=@productCataCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@productCataCode", SqlDbType.NVarChar,50)			};
            parameters[0].Value = productCataCode;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string cataSeqlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ProductSizeCfg ");
            strSql.Append(" where cataSeq in (" + cataSeqlist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        //public FTDataAccess.Model.ProductSizeCfgModel GetModel(int cataSeq)
        //{

        //    StringBuilder strSql = new StringBuilder();
        //    strSql.Append("select  top 1 cataSeq,productCataCode,productHeight,mark,packageSize,productName from ProductSizeCfg ");
        //    strSql.Append(" where cataSeq=@cataSeq");
        //    SqlParameter[] parameters = {
        //            new SqlParameter("@cataSeq", SqlDbType.Int,4)
        //    };
        //    parameters[0].Value = cataSeq;

        //    FTDataAccess.Model.ProductSizeCfgModel model = new FTDataAccess.Model.ProductSizeCfgModel();
        //    DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
        //    if (ds.Tables[0].Rows.Count > 0)
        //    {
        //        return DataRowToModel(ds.Tables[0].Rows[0]);
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public FTDataAccess.Model.ProductSizeCfgModel GetModel(string productCataCode)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 cataSeq,productCataCode,productHeight,mark,packageSize,productName,gasName,baseSizeLevel,facePanelSize,tag1,tag2,tag3,tag4,tag5 from ProductSizeCfg ");
            strSql.Append(" where productCataCode=@productCataCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@productCataCode", SqlDbType.NVarChar,50)			};
            parameters[0].Value = productCataCode;


            FTDataAccess.Model.ProductSizeCfgModel model = new FTDataAccess.Model.ProductSizeCfgModel();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public FTDataAccess.Model.ProductSizeCfgModel DataRowToModel(DataRow row)
        {
            FTDataAccess.Model.ProductSizeCfgModel model = new FTDataAccess.Model.ProductSizeCfgModel();
            if (row != null)
            {
                if (row["cataSeq"] != null && row["cataSeq"].ToString() != "")
                {
                    model.cataSeq = int.Parse(row["cataSeq"].ToString());
                }
                if (row["productCataCode"] != null)
                {
                    model.productCataCode = row["productCataCode"].ToString();
                }
                if (row["productHeight"] != null && row["productHeight"].ToString() != "")
                {
                    model.productHeight = int.Parse(row["productHeight"].ToString());
                }
                if (row["mark"] != null)
                {
                    model.mark = row["mark"].ToString();
                }
                if (row["packageSize"] != null)
                {
                    model.packageSize = row["packageSize"].ToString();
                }
                if (row["productName"] != null)
                {
                    model.productName = row["productName"].ToString();
                }
                if (row["gasName"] != null)
                {
                    model.gasName = row["gasName"].ToString();
                }
                if (row["baseSizeLevel"] != null && row["baseSizeLevel"].ToString() != "")
                {
                    model.baseSizeLevel = int.Parse(row["baseSizeLevel"].ToString());
                }
                if (row["facePanelSize"] != null && row["facePanelSize"].ToString() != "")
                {
                    model.facePanelSize = int.Parse(row["facePanelSize"].ToString());
                }
                if (row["tag1"] != null)
                {
                    model.tag1 = row["tag1"].ToString();
                }
                if (row["tag2"] != null)
                {
                    model.tag2 = row["tag2"].ToString();
                }
                if (row["tag3"] != null)
                {
                    model.tag3 = row["tag3"].ToString();
                }
                if (row["tag4"] != null)
                {
                    model.tag4 = row["tag4"].ToString();
                }
                if (row["tag5"] != null)
                {
                    model.tag5 = row["tag5"].ToString();
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select cataSeq,productCataCode,productHeight,mark,packageSize,productName,gasName,baseSizeLevel,facePanelSize,tag1,tag2,tag3,tag4,tag5 ");
            strSql.Append(" FROM ProductSizeCfg ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by packageSize,cataSeq");
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" cataSeq,productCataCode,productHeight,mark,packageSize,productName,gasName,baseSizeLevel,facePanelSize,tag1,tag2,tag3,tag4,tag5 ");
            strSql.Append(" FROM ProductSizeCfg ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }


        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM ProductSizeCfg ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.cataSeq desc");
            }
            strSql.Append(")AS Row, T.*  from ProductSizeCfg T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /*
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        {
            SqlParameter[] parameters = {
                    new SqlParameter("@tblName", SqlDbType.VarChar, 255),
                    new SqlParameter("@fldName", SqlDbType.VarChar, 255),
                    new SqlParameter("@PageSize", SqlDbType.Int),
                    new SqlParameter("@PageIndex", SqlDbType.Int),
                    new SqlParameter("@IsReCount", SqlDbType.Bit),
                    new SqlParameter("@OrderType", SqlDbType.Bit),
                    new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
                    };
            parameters[0].Value = "ProductSizeCfg";
            parameters[1].Value = "cataSeq";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  BasicMethod
        #region  ExtensionMethod
      
        #endregion  ExtensionMethod
    }
}

