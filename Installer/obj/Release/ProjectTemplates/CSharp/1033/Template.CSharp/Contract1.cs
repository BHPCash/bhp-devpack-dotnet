using Bhp.SmartContract.Framework;
using Bhp.SmartContract.Framework.Services.Bhp;
using System;
using System.Numerics;

namespace $safeprojectname$
{
	public class Contract1 : SmartContract
{
    public static bool Main(string operation, object[] args)
    {
        Storage.Put(Storage.CurrentContext, "Hello", "World");
        return true;
    }
}
}

