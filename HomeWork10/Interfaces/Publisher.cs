namespace HomeWork10.Interfaces;

public interface Publisher
{
    /// <summary>
    /// Добавить подписчика
    /// </summary>
    /// <param name="sub">подписчик</param>
    void Subscribe(Subscriber sub);

    /// <summary>
    /// Убрать подписчика
    /// </summary>
    /// <param name="sub">подписчик</param>
    void Unsubscribe(Subscriber sub);
}
