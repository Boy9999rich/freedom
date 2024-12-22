namespace ConsoleApp7
{
    public interface IMyList<B>
    {
        void AddItem(B item);
        B GetItemAt(int index);
        void RemoveItemAt(int index);
        void AddItemsRange(B[] nums);
        void ReplaceAllItems(B oddElement, B newElement);
        int GetItemIndex(B item);
        int GetCount();
        int GetCapacity();
        bool contains(B item);
        void Clear();
        B[] ToArray();
        void insert(int index, B item);
        void Reverse();
        B[] GetRange(int startIndex, int EndIndex);
        void Sort();
        int GetLastIndex(B item);
        void InsertAt(int index, B item);
        void SortAsSelected();
        void SortAsBubble();

    }
}