namespace DP20Memento
{
    interface IOriginator
    {
        void Load(Memento memento);
        Memento Save();
    }
}
