namespace NoSqlWrapper.Serialization
{
    internal class DefaultSerializerFactory : ISerializerFactory
    {
        public ISerializer<T> Get<T>()
        {
            return new JsonSerializer<T>();
        }
    }
}
