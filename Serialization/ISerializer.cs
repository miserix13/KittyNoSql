using NoSqlWrapper.Conventions;

namespace NoSqlWrapper.Serialization
{
    public interface ISerializer<T>
    {
        Options Options { get; set; }

        String Serialize(T value);
        T Deserialize(String blob);
    }
}
