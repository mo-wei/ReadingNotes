delegate void EventHandler();

interface Subject
{
    void Notify();

    string SubjectState { get; set; }
}