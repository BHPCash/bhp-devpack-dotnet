namespace Bhp.SmartContract.Framework.Services.Bhp
{
    public class Account
    {
        public extern byte[] ScriptHash
        {
            [Syscall("Bhp.Account.GetScriptHash")]
            get;
        }

        public extern byte[][] Votes
        {
            [Syscall("Bhp.Account.GetVotes")]
            get;
        }

        [Syscall("Bhp.Account.GetBalance")]
        public extern long GetBalance(byte[] asset_id);
    }
}
