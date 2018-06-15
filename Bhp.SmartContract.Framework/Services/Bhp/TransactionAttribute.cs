namespace Bhp.SmartContract.Framework.Services.Bhp
{
    public class TransactionAttribute : IApiInterface
    {
        public extern byte Usage
        {
            [Syscall("Bhp.Attribute.GetUsage")]
            get;
        }

        public extern byte[] Data
        {
            [Syscall("Bhp.Attribute.GetData")]
            get;
        }
    }
}
