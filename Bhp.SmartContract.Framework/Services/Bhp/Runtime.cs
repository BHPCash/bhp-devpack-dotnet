namespace Bhp.SmartContract.Framework.Services.Bhp
{
    public static class Runtime
    {
        public static extern TriggerType Trigger
        {
            [Syscall("Bhp.Runtime.GetTrigger")]
            get;
        }

        public static extern uint Time
        {
            [Syscall("Bhp.Runtime.GetTime")]
            get;
        }

        [Syscall("Bhp.Runtime.CheckWitness")]
        public static extern bool CheckWitness(byte[] hashOrPubkey);

        [Syscall("Bhp.Runtime.Notify")]
        public static extern void Notify(params object[] state);

        [Syscall("Bhp.Runtime.Log")]
        public static extern void Log(string message);
    }
}
