namespace InterfaceActions
{
    public interface INotifycation<T>

    {
        bool Send(T obj);
    }
}