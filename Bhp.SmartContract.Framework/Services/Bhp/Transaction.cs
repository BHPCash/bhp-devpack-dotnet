namespace Bhp.SmartContract.Framework.Services.Bhp
{
    public class Transaction : IScriptContainer
    {
        public extern byte[] Hash
        {
            [Syscall("Bhp.Transaction.GetHash")]
            get;
        }

        public extern byte Type
        {
            [Syscall("Bhp.Transaction.GetType")]
            get;
        }

        [Syscall("Bhp.Transaction.GetAttributes")]
        public extern TransactionAttribute[] GetAttributes();

        [Syscall("Bhp.Transaction.GetInputs")]
        public extern TransactionInput[] GetInputs();

        [Syscall("Bhp.Transaction.GetOutputs")]
        public extern TransactionOutput[] GetOutputs();

        [Syscall("Bhp.Transaction.GetReferences")]
        public extern TransactionOutput[] GetReferences();

        [Syscall("Bhp.Transaction.GetUnspentCoins")]
        public extern TransactionOutput[] GetUnspentCoins();
    }
}
