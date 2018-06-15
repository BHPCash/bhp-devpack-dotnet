namespace Bhp.SmartContract.Framework.Services.Bhp
{
    public class Asset
    {
        public extern byte[] AssetId
        {
            [Syscall("Bhp.Asset.GetAssetId")]
            get;
        }

        public extern byte AssetType
        {
            [Syscall("Bhp.Asset.GetAssetType")]
            get;
        }

        public extern long Amount
        {
            [Syscall("Bhp.Asset.GetAmount")]
            get;
        }

        public extern long Available
        {
            [Syscall("Bhp.Asset.GetAvailable")]
            get;
        }

        public extern byte Precision
        {
            [Syscall("Bhp.Asset.GetPrecision")]
            get;
        }

        public extern byte[] Owner
        {
            [Syscall("Bhp.Asset.GetOwner")]
            get;
        }

        public extern byte[] Admin
        {
            [Syscall("Bhp.Asset.GetAdmin")]
            get;
        }

        public extern byte[] Issuer
        {
            [Syscall("Bhp.Asset.GetIssuer")]
            get;
        }

        [Syscall("Bhp.Asset.Create")]
        public static extern Asset Create(byte asset_type, string name, long amount, byte precision, byte[] owner, byte[] admin, byte[] issuer);

        [Syscall("Bhp.Asset.Renew")]
        public extern uint Renew(byte years);
    }
}
