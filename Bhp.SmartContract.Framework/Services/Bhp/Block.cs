namespace Bhp.SmartContract.Framework.Services.Bhp
{
    public class Block : Header
    {
        [Syscall("Bhp.Block.GetTransactionCount")]
        public extern int GetTransactionCount();

        [Syscall("Bhp.Block.GetTransactions")]
        public extern Transaction[] GetTransactions();

        [Syscall("Bhp.Block.GetTransaction")]
        public extern Transaction GetTransaction(int index);
    }
}
