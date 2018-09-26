namespace XamarinClient.Components
{
    public interface IConverter<T, Q>
    {
        Q Content { get; set; }

        T Convert();
    }
}
