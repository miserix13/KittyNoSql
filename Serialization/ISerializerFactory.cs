namespace NoSqlWrapper.Serialization
{
    public interface ISerializerFactory
    {
        ISerializer<T> Get<T>();
    }
}
