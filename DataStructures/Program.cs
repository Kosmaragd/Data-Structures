public interface IList<T>
{
    /// <summary>
    /// TODO
    /// </summary>
    /// <param name="index"></param>
    /// <returns></returns>
    public T Get(int index);

    /// <summary>
    /// TODO
    /// </summary>
    /// <param name="element"></param>
    /// <returns></returns>
    public int Add(T element);

    /// <summary>
    /// TODO, offset is 0 to length - 1, etc.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="offset"></param>
    public void Insert(T element, int index);

    /// <summary>
    /// TODO
    /// </summary>
    /// <param name="offset"></param>
    public void Remove(int offset);

    /// <summary>
    /// TODO
    /// </summary>
    /// <param name="element"></param>
    /// <returns></returns>
    public int Find(T element);

    public int Find(T element, int startAt);

    /// <summary>
    /// TODO
    /// </summary>
    /// <returns></returns>
    public int Size();

    /// <summary>
    /// TODO
    /// </summary>
    public void Clear();
}