using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKDD.DTO
{
    class KhachHangDTO
    {
        private string maloaikh;
        private string diachi;
        private string madk;
        private string makh;
        private string sdt;
        private string tenkh;

        public KhachHangDTO()
        {
            this.Makh = "";
            this.Tenkh = "";
            this.Sdt = "";
            this.Madk = "";
            this.Diachi = "";
            this.Maloaikh = "";
        }
        public KhachHangDTO(string _makh, string _tenkh, string _sdt, string _madk, string _diachi, string _maloaikh)
        {
            this.Makh = _makh;
            this.Tenkh = _tenkh;
            this.Sdt = _sdt;
            this.Madk = _madk;
            this.Diachi = _diachi;
            this.Maloaikh = _maloaikh;
        }

        public string Diachi
        {
            get
            {
                return diachi;
            }

            set
            {
                diachi = value;
            }
        }

        public string Madk
        {
            get
            {
                return madk;
            }

            set
            {
                madk = value;
            }
        }

        public string Makh
        {
            get
            {
                return makh;
            }

            set
            {
                makh = value;
            }
        }

        public string Sdt
        {
            get
            {
                return sdt;
            }

            set
            {
                sdt = value;
            }
        }

        public string Tenkh
        {
            get
            {
                return tenkh;
            }

            set
            {
                tenkh = value;
            }
        }

        public string Maloaikh
        {
            get
            {
                return maloaikh;
            }

            set
            {
                maloaikh = value;
            }
        }
    }
}
