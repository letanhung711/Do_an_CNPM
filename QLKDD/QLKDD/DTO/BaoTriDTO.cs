using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKDD.DTO
{
    class BaoTriDTO
    {
        private string _mapbt, _madk, _manv, _ngaybt, _lydo;
        private int _tienbt;


        public BaoTriDTO()
        {
            this.Mapbt = "";
            this.Madk = "";
            this.Manv = "";
            this.Ngaybt = "";
            this.Lydo = "";
            this.Tienbt = 0;
        }
        public BaoTriDTO(string _mapbt, string _madk, string _manv, string _ngaybt, string _lydo, int _tienbt)
        {
            this.Mapbt = _mapbt;
            this.Madk = _madk;
            this.Manv = _manv;
            this.Ngaybt = _ngaybt;
            this.Lydo = _lydo;
            this.Tienbt = _tienbt;
        }

        public string Lydo
        {
            get
            {
                return _lydo;
            }

            set
            {
                _lydo = value;
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

        public string Mapbt
        {
            get
            {
                return _mapbt;
            }

            set
            {
                _mapbt = value;
            }
        }

        public string Ngaybt
        {
            get
            {
                return _ngaybt;
            }

            set
            {
                _ngaybt = value;
            }
        }

        public int Tienbt
        {
            get
            {
                return _tienbt;
            }

            set
            {
                _tienbt = value;
            }
        }
    }
}
