using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAcess;
using System.Data;

namespace BusinessLogic
{
    public class NguyenMauPTBUS
    {
        Data data = new Data();
        NguyenMauPTData m_NguyenMauPTData = new NguyenMauPTData();
        public void insert(
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
            //m_NguyenMauPTData.insert(LoaiPTMa, LoaiPTTen);
            m_NguyenMauPTData.insert(
           NguyenMauID,
           NguyenMauTen,
           NhanHieu,
           NangLuc,
           DonVi,
           BDTX,
           TieuTu,
           TrungTu,
           DaiTu,
           NguyenMauChiTiet
            );
        }
        public void update(
            string NguyenMauID,
          string NguyenMauTen,
          string NhanHieu,
          float NangLuc,
          string DonVi,
          float BDTX,
          float TieuTu,
          float TrungTu,
          float DaiTu,
          string NguyenMauChiTiet)
        {
            ///m_NguyenMauPTData.update(LoaiPTMa, LoaiPTTen);
            m_NguyenMauPTData.update(
                  NguyenMauID,
                  NguyenMauTen,
                  NhanHieu,
                  NangLuc,
                  DonVi,
                  BDTX,
                  TieuTu,
                  TrungTu,
                  DaiTu,
                  NguyenMauChiTiet
                );
        }
        public void delete1(string NguyenMauID)
        {
            //m_NguyenMauPTData.delete1(LoaiPTMa);
            m_NguyenMauPTData.delete1(NguyenMauID);
        }
        public DataTable select()
        {
            //return m_NguyenMauPTData.select();
            return m_NguyenMauPTData.select();

        }

        public bool exist(string LoaiPTMa)
        {
            // return m_NguyenMauPTData.exist(LoaiPTMa);
            return true;
        }
        public DataTable selectLoaiPT()
        {
            return m_NguyenMauPTData.selectLoaiPT();
        }
    }
}
