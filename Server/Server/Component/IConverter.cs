namespace Server.Component
{
    public interface IConverter<T, Q>
    {
        Q Content { get; set; }

        T Convert();
    }
}
