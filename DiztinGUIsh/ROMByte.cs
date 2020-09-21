﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiztinGUIsh
{
    public class ROMByte
    {
        protected bool Equals(ROMByte other)
        {
            return Rom == other.Rom && DataBank == other.DataBank && DirectPage == other.DirectPage && XFlag == other.XFlag && MFlag == other.MFlag && TypeFlag == other.TypeFlag && Arch == other.Arch && Point == other.Point;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((ROMByte) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = Rom.GetHashCode();
                hashCode = (hashCode * 397) ^ DataBank.GetHashCode();
                hashCode = (hashCode * 397) ^ DirectPage;
                hashCode = (hashCode * 397) ^ XFlag.GetHashCode();
                hashCode = (hashCode * 397) ^ MFlag.GetHashCode();
                hashCode = (hashCode * 397) ^ (int) TypeFlag;
                hashCode = (hashCode * 397) ^ (int) Arch;
                hashCode = (hashCode * 397) ^ (int) Point;
                return hashCode;
            }
        }

        public byte Rom { get; set; } // never serialize this, read from ROM on load. for copyright reasons.
        public byte DataBank { get; set; }
        public int DirectPage { get; set; }
        public bool XFlag { get; set; }
        public bool MFlag { get; set; }
        public Data.FlagType TypeFlag { get; set; }
        public Data.Architechture Arch { get; set; }
        public Data.InOutPoint Point { get; set; }
    }
}
