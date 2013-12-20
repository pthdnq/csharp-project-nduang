using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DataAcess
{
  public  class NguyenMauPTData
    {
      Data data = new Data();
      LoaiPTData m_LoaiPTData = new LoaiPTData();
      public bool insert(
          string NguyenMauID, 
          string NguyenMauTen, 
          string NhanHieu, 
          float NangLuc, 
          string DonVi ,
          float BDTX,
          float TieuTu,
          float TrungTu,
          float DaiTu, 
          string NguyenMauChiTiet
          )
      {

          int retval;
          SqlConnection con = data.getConnect();
          con.Open();
          SqlCommand cmd = new SqlCommand();
          cmd.Connection = con;
          cmd.CommandType = CommandType.StoredProcedure;
          cmd.CommandText = "sp_insert_NguyenMauPT";
          cmd.Parameters.Add("NguyenMauID", SqlDbType.NVarChar).Value = NguyenMauID;
          cmd.Parameters.Add("NguyenMauTen", SqlDbType.NVarChar).Value = NguyenMauTen;
          cmd.Parameters.Add("NhanHieu", SqlDbType.NVarChar).Value = NhanHieu;
          cmd.Parameters.Add("NangLuc", SqlDbType.Float).Value = NangLuc;
          cmd.Parameters.Add("DonVi", SqlDbType.NVarChar).Value = DonVi;
          cmd.Parameters.Add("BDTX", SqlDbType.Float).Value = BDTX;
          cmd.Parameters.Add("TieuTu", SqlDbType.Float).Value = TieuTu;
          cmd.Parameters.Add("TrungTu", SqlDbType.Float).Value = TrungTu;
          cmd.Parameters.Add("DaiTu", SqlDbType.Float).Value = DaiTu;
          cmd.Parameters.Add("NguyenMauChiTiet", SqlDbType.NVarChar).Value = NguyenMauChiTiet;
          retval = cmd.ExecuteNonQuery();
          cmd.Dispose();
          con.Close();
          return retval > 0;
      }
      public bool update(
            string NguyenMauID,
          string NguyenMauTen,
          string NhanHieu,
          float NangLuc,
          string DonVi,
          float BDTX,
          float TieuTu,
          float TrungTu,
          float DaiTu,
          string NguyenMauChiTiet

          )
      {

          int retval;
          SqlConnection con = data.getConnect();
          con.Open();
          SqlCommand cmd = new SqlCommand();
          cmd.Connection = con;
          cmd.CommandType = CommandType.StoredProcedure;
          cmd.CommandText = "sp_update_NguyenMauData";
          cmd.Parameters.Add("NguyenMauID", SqlDbType.NVarChar).Value = NguyenMauID;
          cmd.Parameters.Add("NguyenMauTen", SqlDbType.NVarChar).Value = NguyenMauTen;
          cmd.Parameters.Add("NhanHieu", SqlDbType.NVarChar).Value = NhanHieu;
          cmd.Parameters.Add("NangLuc", SqlDbType.Float).Value = NangLuc;
          cmd.Parameters.Add("DonVi", SqlDbType.NVarChar).Value = DonVi;
          cmd.Parameters.Add("BDTX", SqlDbType.Float).Value = BDTX;
          cmd.Parameters.Add("TieuTu", SqlDbType.Float).Value = TieuTu;
          cmd.Parameters.Add("TrungTu", SqlDbType.Float).Value = TrungTu;
          cmd.Parameters.Add("DaiTu", SqlDbType.Float).Value = DaiTu;
          cmd.Parameters.Add("NguyenMauChiTiet", SqlDbType.NVarChar).Value = NguyenMauChiTiet;
          retval = cmd.ExecuteNonQuery();
          cmd.Dispose();
          con.Close();
          return retval > 0;
      }
      public bool delete1(string NguyenMauID)
      {
          int retval;
          SqlConnection con = data.getConnect();
          con.Open();
          SqlCommand cmd = new SqlCommand();
          cmd.Connection = con;
          cmd.CommandType = CommandType.StoredProcedure;
          cmd.CommandText = "sp_delete_NguyenMauData";
          cmd.Parameters.Add("NguyenMauID", SqlDbType.NVarChar).Value = NguyenMauID;
          retval = cmd.ExecuteNonQuery();
          cmd.Dispose();
          con.Close();
          return retval > 0;
      }
      public DataTable select()
      {
          SqlConnection con = data.getConnect();
          con.Open();
          SqlCommand cmd = new SqlCommand();
          cmd.Connection = con;
          cmd.CommandType = CommandType.StoredProcedure;
          cmd.CommandText = "sp_select_NguyenMauPT";
          //retval = cmd.ExecuteNonQuery();
          DataTable dtb;
          try
          {
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataSet ds = new DataSet();
              da.Fill(ds, "NguyenMauPT");
              dtb = ds.Tables["NguyenMauPT"];
          }
          catch (System.Exception ex)
          {
              return null;
          }
          return dtb;
      }
      public DataTable selectLoaiPT()
      {
         return m_LoaiPTData.select();
      }
    }
}
