using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKDD.DTO
{
    class TieuThuDTO
    {
        private string _matt, _makh, _manv, _madk, _ngaynhap;
        private int _diencu, _dienmoi,_tiendien;

        public string Matt
        {
            get
            {
                return _matt;
            }

            set
            {
                _matt = value;
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

        public string Manv
        {
            get
            {
                return _manv;
            }

            set
            {
                _manv = value;
            }
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

        public string Ngaynhap
        {
            get
            {
                return _ngaynhap;
            }

            set
            {
                _ngaynhap = value;
            }
        }

        public int Diencu
        {
            get
            {
                return _diencu;
            }

            set
            {
                _diencu = value;
            }
        }

        public int Dienmoi
        {
            get
            {
                return _dienmoi;
            }

            set
            {
                _dienmoi = value;
            }
        }

        public int Tiendien
        {
            get
            {
                return _tiendien;
            }

            set
            {
                _tiendien = value;
            }
        }

        public TieuThuDTO()
        {
            this.Matt = "";
            this.Makh = "";
            this.Manv = "";
            this.Madk = "";
            this.Ngaynhap = "";
            this.Diencu = 0;
            this.Dienmoi = 0;
            this.Tiendien = 0;
        }
        public TieuThuDTO(string _matt, string _makh, string _manv, string _madk, string _ngaynhap, int _diencu, int _dienmoi, int _tiendien)
        {
            this.Matt = _matt;
            this.Makh = _makh;
            this.Manv = _manv;
            this.Madk = _madk;
            this.Ngaynhap = _ngaynhap;
            this.Diencu = _diencu;
            this.Dienmoi = _dienmoi;
            this.Tiendien = _tiendien;
        }
    }
}
