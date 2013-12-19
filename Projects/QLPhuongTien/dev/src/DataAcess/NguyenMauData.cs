using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DataAcess
{
  public  class NguyenMauData
    {
      Data data = new Data();
      public bool insert(string NguyenMauID, string NguyenMauTen, string NhanHieu, string NangLuc, string DonVi ,string BDTX, string TieuTu , string TrungTu , string DaiTu , string NguyenMauChiTiet)
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
          cmd.Parameters.Add("NangLuc", SqlDbType.NVarChar).Value = NangLuc;
          cmd.Parameters.Add("DonVi", SqlDbType.NVarChar).Value = DonVi;
          cmd.Parameters.Add("BDTX", SqlDbType.NVarChar).Value = BDTX;
          cmd.Parameters.Add("TieuTu", SqlDbType.NVarChar).Value = TieuTu;
          cmd.Parameters.Add("TrungTu", SqlDbType.NVarChar).Value = TrungTu;
          cmd.Parameters.Add("DaiTu", SqlDbType.NVarChar).Value = DaiTu;
          cmd.Parameters.Add("NguyenMauChiTiet", SqlDbType.NVarChar).Value = NguyenMauChiTiet;
          retval = cmd.ExecuteNonQuery();
          cmd.Dispose();
          con.Close();
          return retval > 0;
      }
      public bool update(string NguyenMauID, string NguyenMauTen, string NhanHieu, string NangLuc, string DonVi, string BDTX, string TieuTu, string TrungTu, string DaiTu, string NguyenMauChiTiet)
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
          cmd.Parameters.Add("NangLuc", SqlDbType.NVarChar).Value = NangLuc;
          cmd.Parameters.Add("DonVi", SqlDbType.NVarChar).Value = DonVi;
          cmd.Parameters.Add("BDTX", SqlDbType.NVarChar).Value = BDTX;
          cmd.Parameters.Add("TieuTu", SqlDbType.NVarChar).Value = TieuTu;
          cmd.Parameters.Add("TrungTu", SqlDbType.NVarChar).Value = TrungTu;
          cmd.Parameters.Add("DaiTu", SqlDbType.NVarChar).Value = DaiTu;
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
    }
}
