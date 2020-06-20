﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasPolyDanCol
{
    public class KaryawanHarian : Karyawan
    {
        public double UpahPerJam { get; set; }
        public double JumlahJamKerja { get; set; }

        public override double Gaji()
        {
            double Total = UpahPerJam * JumlahJamKerja;
            return Total;
        }
    }
}
