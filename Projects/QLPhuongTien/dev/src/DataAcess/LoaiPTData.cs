﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DataAcess
{
   
   public class LoaiPTData
    {
       Data data = new Data();
       public bool insert(string LoaiPTMa, string LoaiPTTen)
       {

           int retval;
           SqlConnection con = data.getConnect();
           con.Open();
           SqlCommand cmd = new SqlCommand();
           cmd.Connection = con;
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.CommandText = "sp_insert_LoaiPTData";
           cmd.Parameters.Add("LoaiPTMa", SqlDbType.NVarChar).Value = LoaiPTMa;
           cmd.Parameters.Add("LoaiPTTen", SqlDbType.NVarChar).Value = LoaiPTTen;
           retval = cmd.ExecuteNonQuery();
           cmd.Dispose();
           con.Close();
           return retval > 0;
       }
       public bool update(string LoaiPTMa, string LoaiPTTen)
       {

           int retval;
           SqlConnection con = data.getConnect();
           con.Open();
           SqlCommand cmd = new SqlCommand();
           cmd.Connection = con;
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.CommandText = "sp_update_LoaiPTData";
           cmd.Parameters.Add("LoaiPTMa", SqlDbType.NVarChar).Value = LoaiPTMa;
           cmd.Parameters.Add("LoaiPTTen", SqlDbType.NVarChar).Value = LoaiPTTen;
           retval = cmd.ExecuteNonQuery();
           cmd.Dispose();
           con.Close();
           return retval > 0;
       }
       public bool delete1(string LoaiPTMa)
       {
           int retval;
           SqlConnection con = data.getConnect();
           con.Open();
           SqlCommand cmd = new SqlCommand();
           cmd.Connection = con;
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.CommandText = "sp_delete_LoaiPTData";
           cmd.Parameters.Add("LoaiPTMa", SqlDbType.NVarChar).Value = LoaiPTMa;
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
           cmd.CommandText = "sp_select_LoaiPTData";
           //retval = cmd.ExecuteNonQuery();
           DataTable dtb;
           try
           {
               SqlDataAdapter da = new SqlDataAdapter(cmd);
               DataSet ds = new DataSet();
               da.Fill(ds, "LoaiPT");
               dtb = ds.Tables["LoaiPT"];
           }
           catch (System.Exception ex)
           {
               return null;
           }
           return dtb;

       }
    }
}