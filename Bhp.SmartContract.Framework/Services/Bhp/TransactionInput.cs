namespace Bhp.SmartContract.Framework.Services.Bhp
{
    public class TransactionInput : IApiInterface
    {
        public extern byte[] PrevHash
        {
            [Syscall("Bhp.Input.GetHash")]
            get;
        }

        public extern ushort PrevIndex
        {
            [Syscall("Bhp.Input.GetIndex")]
            get;
        }
    }
}
