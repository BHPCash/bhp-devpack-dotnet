namespace Bhp.SmartContract.Framework.Services.Bhp
{
    public class TransactionOutput : IApiInterface
    {
        public extern byte[] AssetId
        {
            [Syscall("Bhp.Output.GetAssetId")]
            get;
        }

        public extern long Value
        {
            [Syscall("Bhp.Output.GetValue")]
            get;
        }

        public extern byte[] ScriptHash
        {
            [Syscall("Bhp.Output.GetScriptHash")]
            get;
        }
    }
}
