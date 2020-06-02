using System;

namespace Questions
{   
    public static class FlagHelper<T>
        where T : unmanaged, Enum 
    {
        private static readonly Func<T,T,bool> HasFlagInner;
                
        static FlagHelper()
        {
            unsafe
            {
                switch (System.Runtime.InteropServices.Marshal.SizeOf(Enum.GetUnderlyingType(typeof(T))))
                {
                    case sizeof(byte): 
                        HasFlagInner = (a, b) => { var aPtr = (byte*) &a; var bPtr = (byte*) &b; return (*aPtr & *bPtr) != 0; }; 
                        break;
                    case sizeof(short): 
                        HasFlagInner = (a, b) => { var aPtr = (short*) &a; var bPtr = (short*) &b; return (*aPtr & *bPtr) != 0; }; 
                        break;
                    case sizeof(int): 
                        HasFlagInner = (a, b) => { var aPtr = (int*) &a; var bPtr = (int*) &b; return (*aPtr & *bPtr) != 0; }; 
                        break;
                    case sizeof(long): 
                        HasFlagInner = (a, b) => { var aPtr = (long*) &a; var bPtr = (long*) &b; return (*aPtr & *bPtr) != 0; }; 
                        break;
                    default:
                        throw new NotImplementedException($"Unexpected size {sizeof(T)} of type {typeof(T).Name}");
                } 
            }
        }

        public static bool HasFlag(T flags, T flag) => HasFlagInner(flags, flag);
    }
}