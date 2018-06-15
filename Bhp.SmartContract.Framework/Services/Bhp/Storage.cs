using System.Numerics;

namespace Bhp.SmartContract.Framework.Services.Bhp
{
    public static class Storage
    {
        public static extern StorageContext CurrentContext
        {
            [Syscall("Bhp.Storage.GetContext")]
            get;
        }

        [Syscall("Bhp.Storage.Get")]
        public static extern byte[] Get(StorageContext context, byte[] key);

        [Syscall("Bhp.Storage.Get")]
        public static extern byte[] Get(StorageContext context, string key);

        [Syscall("Bhp.Storage.Put")]
        public static extern void Put(StorageContext context, byte[] key, byte[] value);

        [Syscall("Bhp.Storage.Put")]
        public static extern void Put(StorageContext context, byte[] key, BigInteger value);

        [Syscall("Bhp.Storage.Put")]
        public static extern void Put(StorageContext context, byte[] key, string value);

        [Syscall("Bhp.Storage.Put")]
        public static extern void Put(StorageContext context, string key, byte[] value);

        [Syscall("Bhp.Storage.Put")]
        public static extern void Put(StorageContext context, string key, BigInteger value);

        [Syscall("Bhp.Storage.Put")]
        public static extern void Put(StorageContext context, string key, string value);

        [Syscall("Bhp.Storage.Delete")]
        public static extern void Delete(StorageContext context, byte[] key);

        [Syscall("Bhp.Storage.Delete")]
        public static extern void Delete(StorageContext context, string key);

        [Syscall("Bhp.Storage.Find")]
        public static extern Iterator<byte[], byte[]> Find(StorageContext context, byte[] prefix);

        [Syscall("Bhp.Storage.Find")]
        public static extern Iterator<string, byte[]> Find(StorageContext context, string prefix);
    }
}
