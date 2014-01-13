using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DataAcess
{
    
   public class TimKiemData
    {
       Data data = new Data();
       PhuongTienData m_PhuongTienData = new PhuongTienData();
       NguyenMauPTData m_NguyenMauPTData = new NguyenMauPTData();
       LoaiPTData m_LoaiPT = new LoaiPTData();
       public DataTable timKiemonFormMain(string LoaiPTMa, string NhanHieu, string NangLuc)
       {
           SqlConnection con = data.getConnect();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("LoaiPTMa", SqlDbType.NVarChar).Value = LoaiPTMa;
            cmd.Parameters.Add("NhanHieu", SqlDbType.NVarChar).Value = NhanHieu;
            float NangLuc_ = float.Parse(NangLuc);
            cmd.Parameters.Add("NangLuc", SqlDbType.Float).Value = NangLuc_;
           
            cmd.CommandText = "sp_TimKiem_Info";        
            //retval = cmd.ExecuteNonQuery();
            DataTable dtb;
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "PhuongTien111");
                dtb = ds.Tables["PhuongTien111"];
            }
            catch (System.Exception ex)
            {  
                return null;
            }
            return dtb;
       }
       public DataTable selectNhanHieu()
       {
           return m_NguyenMauPTData.select();
       }
       public DataTable selectLoaiPT()
       {
           return m_LoaiPT.select();
       }
       public DataTable selectNangLucByLoaiPT(string LoaiPTMa)
       {
           SqlConnection con = data.getConnect();
           con.Open();
           SqlCommand cmd = new SqlCommand();
           cmd.Connection = con;
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.Parameters.Add("LoaiPTMa", SqlDbType.NVarChar).Value = LoaiPTMa;
           cmd.CommandText = "selectNangLucByLoaiPT";
           //retval = cmd.ExecuteNonQuery();
           DataTable dtb;
           try
           {
               SqlDataAdapter da = new SqlDataAdapter(cmd);
               DataSet ds = new DataSet();
               da.Fill(ds, "PhuongTien111");
               dtb = ds.Tables["PhuongTien111"];
           }
           catch (System.Exception ex)
           {
               return null;
           }
           return dtb;
       }
    }
}
