namespace NoSqlWrapper.Exceptions
{

    public class NoSqlWrapperException : Exception
    {
        public NoSqlWrapperException(String message)
            : base(message)
        {

        }
        public NoSqlWrapperException(String message, Exception innerException)
            : base(message, innerException)
        {

        }
    }

    public class NoSqlSerializationException : Exception
    {
        public NoSqlSerializationException(String message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
    
}
