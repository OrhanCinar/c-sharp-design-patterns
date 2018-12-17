namespace CommandPattern
{
    public class TvRemote
    {
        public static ElectronicDevice GetDevice()
        {
            return new Television();
        }
    }
}
