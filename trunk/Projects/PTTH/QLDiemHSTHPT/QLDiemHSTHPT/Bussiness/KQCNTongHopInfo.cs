using System;
using System.Collections.Generic;
using System.Text;

namespace QLDiemHSTHPT.Bussiness
{
   public class KQCNTongHopInfo
    {
        private HocSinhInfo m_HocSinh;
        public HocSinhInfo HocSinh
        {
            get { return m_HocSinh; }
            set { m_HocSinh = value; }
        }

        private LopInfo m_Lop;
        public LopInfo Lop
        {
            get { return m_Lop; }
            set { m_Lop = value; }
        }

        private NamHocInfo m_NamHoc;
        public NamHocInfo NamHoc
        {
            get { return m_NamHoc; }
            set { m_NamHoc = value; }
        }

        private HocLucInfo m_HocLuc;
        public HocLucInfo HocLuc
        {
            get { return m_HocLuc; }
            set { m_HocLuc = value; }
        }

        private HanhKiemInfo m_HanhKiem;
        public HanhKiemInfo HanhKiem
        {
            get { return m_HanhKiem; }
            set { m_HanhKiem = value; }
        }

        private float m_DTBCaNam;
        public float DTBCaNam
        {
            get { return m_DTBCaNam; }
            set { m_DTBCaNam = value; }
        }

        private KetQuaInfo m_KetQua;
        public KetQuaInfo KetQua
        {
            get { return m_KetQua; }
            set { m_KetQua = value; }
        }
    }
}
