namespace NoSqlWrapper.Dependencies
{
    public interface IDateTimeProvider
    {
        DateTime Now { get; }
    }
    public class DefaultDateTimeProvider:IDateTimeProvider 
    {
        public DateTime Now
        {
            get { return DateTime.Now; }
        }
    }
}
