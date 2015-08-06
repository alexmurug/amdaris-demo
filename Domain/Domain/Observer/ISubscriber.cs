namespace Domain.Domain.Observer
{
    public interface ISubscriber
    {
        void Update(Course course);
    }
}