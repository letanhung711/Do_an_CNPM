using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKDD.DTO
{
    class NhanVienDTO
    {
        private string _MaNV, _MK, _TenNV, _NgaySinh, _GioiTinh, _DiaChi, _SDT, _MaCV;

        public NhanVienDTO()
        {
            this.MaNV = "";
            this.MK = "";
            this.TenNV = "";
            this.NgaySinh = "";
            this.GioiTinh = "";
            this.DiaChi = "";
            this.SDT = "";
            this.MaCV = "";
        }

        public NhanVienDTO(string _MaNV, string _MK, string _TenNV, string _NgaySinh, string _GioiTinh, string _DiaChi, string _SDT, string _MaCV)
        {
            this.MaNV = _MaNV;
            this.MK = _MK;
            this.TenNV = _TenNV;
            this.NgaySinh = _NgaySinh;
            this.GioiTinh = _GioiTinh;
            this.DiaChi = _DiaChi;
            this.SDT = _SDT;
            this.MaCV = _MaCV;
        }

        public string DiaChi
        {
            get
            {
                return _DiaChi;
            }

            set
            {
                _DiaChi = value;
            }
        }

        public string GioiTinh
        {
            get
            {
                return _GioiTinh;
            }

            set
            {
                _GioiTinh = value;
            }
        }

        public string MaCV
        {
            get
            {
                return _MaCV;
            }

            set
            {
                _MaCV = value;
            }
        }

        public string MaNV
        {
            get
            {
                return _MaNV;
            }

            set
            {
                _MaNV = value;
            }
        }

        public string MK
        {
            get
            {
                return _MK;
            }

            set
            {
                _MK = value;
            }
        }

        public string NgaySinh
        {
            get
            {
                return _NgaySinh;
            }

            set
            {
                _NgaySinh = value;
            }
        }

        public string SDT
        {
            get
            {
                return _SDT;
            }

            set
            {
                _SDT = value;
            }
        }

        public string TenNV
        {
            get
            {
                return _TenNV;
            }

            set
            {
                _TenNV = value;
            }
        }
    }
}
