namespace Bhp.SmartContract.Framework.Services.Bhp
{
    public class Iterator<TKey, TValue>
    {
        [Syscall("Bhp.Iterator.Next")]
        public extern bool Next();

        public extern TKey Key
        {
            [Syscall("Bhp.Iterator.Key")]
            get;
        }

        public extern TValue Value
        {
            [Syscall("Bhp.Iterator.Value")]
            get;
        }
    }
}
