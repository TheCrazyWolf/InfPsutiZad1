using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfPsuti
{
    internal class Controller
    {
        private double _current;

        public Controller(object current)
        {
            _current = (double) current;
            Calc();
        }

        protected Int16 CurrentInt16;
        protected Int32 CurrentInt32;
        protected Int64 CurrentInt64;
        protected SByte CurrentSbyte;
        protected Byte CurrentByte;

        protected void Calc()
        {
            CurrentInt16 = (Int16)_current;
            CurrentInt32 = (Int32)_current;
            CurrentInt64 = (Int64)_current;
            CurrentSbyte = (SByte)_current;
            CurrentByte = (Byte)_current;
        }


        public override string ToString()
        {
            string text = $"Число {_current} \n" +
                $"INT16 {CurrentInt16} \n" +
                $"INT32 {CurrentInt32} \n" +
                $"INT64 {CurrentInt64} \n" +
                $"SBYTE {CurrentSbyte} \n" +
                $"BYTE {CurrentByte}";

            return text;
        }
    }
}
