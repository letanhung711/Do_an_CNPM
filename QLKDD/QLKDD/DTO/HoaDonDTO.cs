using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKDD.DTO
{
    class HoaDonDTO
    {
        private string _mahd, _makh, _matt, _ngaydoccs, _ngaygui, _ngaythutien,_trangthai;
        private int _dot;

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

        public string Ngaydoccs
        {
            get
            {
                return _ngaydoccs;
            }

            set
            {
                _ngaydoccs = value;
            }
        }

        public string Ngaygui
        {
            get
            {
                return _ngaygui;
            }

            set
            {
                _ngaygui = value;
            }
        }

        public string Ngaythutien
        {
            get
            {
                return _ngaythutien;
            }

            set
            {
                _ngaythutien = value;
            }
        }

        public string Trangthai
        {
            get
            {
                return _trangthai;
            }

            set
            {
                _trangthai = value;
            }
        }

        public int Dot
        {
            get
            {
                return _dot;
            }

            set
            {
                _dot = value;
            }
        }

        public HoaDonDTO()
        {
            this.Mahd = "";
            this.Makh = "";
            this.Matt = "";
            this.Ngaydoccs = "";
            this.Ngaygui = "";
            this.Ngaythutien = "";
            this.Trangthai = "";
            this.Dot = 0;
        }
        public HoaDonDTO(string _mahd, string _makh, string _matt, string _ngaydoccs, string _ngaygui, string _ngaythutien, string _trangthai, int _dot)
        {
            this.Mahd = _mahd;
            this.Makh = _makh;
            this.Matt = _matt;
            this.Ngaydoccs = _ngaydoccs;
            this.Ngaygui = _ngaygui;
            this.Ngaythutien = _ngaythutien;
            this.Trangthai = _trangthai;
            this.Dot = _dot;
        }
    }
}
