namespace HomeWork10.Interfaces;
public interface Subscriber
{
    /// <summary>
    /// Послать уведомление
    /// </summary>
    /// <param name="data"></param>
    void Update(Data data);
}
