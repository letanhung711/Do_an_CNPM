using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKDD.DTO
{
    class HopDongDTO
    {
        private string _madk, _ngaykyhd, _ngayhieuluc;
        private string _mahd, _ngayki, _makh;

        public HopDongDTO()
        {
            this.Madk = "";
            this.Ngaykyhd = "";
            this.Ngayhieuluc = "";
            this.Mahd = "";
            this.Ngayki = "";
            this.Makh = "";
        }
        public HopDongDTO(string _madk, string _ngaykyhd, string _ngayhieuluc, string _mahd, string _ngayki, string _makh)
        {
            this.Madk = _madk;
            this.Ngaykyhd = _ngaykyhd;
            this.Ngayhieuluc = _ngayhieuluc;
            this.Mahd = _mahd;
            this.Ngayki = _ngayki;
            this.Makh = _makh;
        }

        public string Madk
        {
            get
            {
                return _madk;
            }

            set
            {
                _madk = value;
            }
        }

        public string Mahd
        {
            get
            {
                return _mahd;
            }

            set
            {
                _mahd = value;
            }
        }

        public string Makh
        {
            get
            {
                return _makh;
            }

            set
            {
                _makh = value;
            }
        }

        public string Ngayhieuluc
        {
            get
            {
                return _ngayhieuluc;
            }

            set
            {
                _ngayhieuluc = value;
            }
        }

        public string Ngayki
        {
            get
            {
                return _ngayki;
            }

            set
            {
                _ngayki = value;
            }
        }

        public string Ngaykyhd
        {
            get
            {
                return _ngaykyhd;
            }

            set
            {
                _ngaykyhd = value;
            }
        }
    }
}
