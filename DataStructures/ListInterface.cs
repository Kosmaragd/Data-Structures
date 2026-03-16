/// <summary>
/// This interface holds all the essential methods,
/// all Lists or ArrayLists utilize for an execution 
/// of a list
/// </summary>
/// <typeparam name="T"></typeparam>
public interface IList<T>
{
    /// <summary>
    /// Get element from the 
    /// selected index of the list.
    /// </summary>
    /// <param name="index"></param>
    /// <returns></returns>
    public T Get(int index);

    /// <summary>
    /// Adds an element to the end of the list.
    /// </summary>
    /// <param name="element"></param>
    /// <returns></returns>
    public int Add(T element);

    /// <summary>
    /// Inserts an element to the selected index.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="offset"></param>
    public void Insert(T element, int index);

    /// <summary>
    /// Removes an element from the list
    /// at the selected index.
    /// </summary>
    /// <param name="offset"></param>
    public void Remove(int offset);

    /// <summary>
    /// Searches for the selected element in 
    /// the list.
    /// </summary>
    /// <param name="element"></param>
    /// <returns></returns>
    public int Find(T element);

    /// <summary>
    /// Searches for the selected element in the 
    /// list, starting from the specified index.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="startAt"></param>
    /// <returns></returns>
    public int Find(T element, int startAt);

    /// <summary>
    /// Returns the size of the current
    /// List
    /// </summary>
    /// <returns></returns>
    public int Size();

    /// <summary>
    /// Removes all the elements
    /// of the list
    /// </summary>
    public void Clear();
}