namespace Bhp.SmartContract.Framework.Services.Bhp
{
    public class InvocationTransaction : Transaction
    {
        public extern byte[] Script
        {
            [Syscall("Bhp.InvocationTransaction.GetScript")]
            get;
        }
    }
}
