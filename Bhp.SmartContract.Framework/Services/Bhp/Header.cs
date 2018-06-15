namespace Bhp.SmartContract.Framework.Services.Bhp
{
    public class Header : IScriptContainer
    {
        public extern byte[] Hash
        {
            [Syscall("Bhp.Header.GetHash")]
            get;
        }

        public extern uint Version
        {
            [Syscall("Bhp.Header.GetVersion")]
            get;
        }

        public extern byte[] PrevHash
        {
            [Syscall("Bhp.Header.GetPrevHash")]
            get;
        }

        public extern byte[] MerkleRoot
        {
            [Syscall("Bhp.Header.GetMerkleRoot")]
            get;
        }

        public extern uint Timestamp
        {
            [Syscall("Bhp.Header.GetTimestamp")]
            get;
        }

        public extern uint Index
        {
            [Syscall("Bhp.Header.GetIndex")]
            get;
        }

        public extern ulong ConsensusData
        {
            [Syscall("Bhp.Header.GetConsensusData")]
            get;
        }

        public extern byte[] NextConsensus
        {
            [Syscall("Bhp.Header.GetNextConsensus")]
            get;
        }
    }
}
