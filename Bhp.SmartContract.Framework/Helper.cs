﻿using Bhp.VM;
using System;
using System.Numerics;

namespace Bhp.SmartContract.Framework
{
    public static class Helper
    {
        [Nonemit]
        public extern static BigInteger AsBigInteger(this byte[] source);

        [Nonemit]
        public extern static byte[] AsByteArray(this BigInteger source);

        [Nonemit]
        public extern static byte[] AsByteArray(this string source);

        [Nonemit]
        public extern static string AsString(this byte[] source);

        [OpCode(OpCode.CAT)]
        public extern static byte[] Concat(this byte[] first, byte[] second);

        [NonemitWithConvert(ConvertMethod.HexToBytes)]
        public extern static byte[] HexToBytes(this string hex);

        [OpCode(OpCode.SUBSTR)]
        public extern static byte[] Range(this byte[] source, int index, int count);

        [OpCode(OpCode.LEFT)]
        public extern static byte[] Take(this byte[] source, int count);

        [Nonemit]
        public extern static Delegate ToDelegate(this byte[] source);

        [NonemitWithConvert(ConvertMethod.ToScriptHash)]
        public extern static byte[] ToScriptHash(this string address);

        [Syscall("Bhp.Runtime.Serialize")]
        public extern static byte[] Serialize(this object source);

        [Syscall("Bhp.Runtime.Deserialize")]
        public extern static object Deserialize(this byte[] source);
    }
}
