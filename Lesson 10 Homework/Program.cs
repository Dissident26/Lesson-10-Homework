using MyLib;

MyList myList = new();
myList.Add(new MyItem(1, "first"));
myList.Add(new MyItem(1, "second"));
myList.Add(new MyItem(1, "third"));
myList.Add(new MyItem(1, "fourth"));
myList.Add(new MyItem(1, "fifth"));
myList.Add(new MyItem(1, "sixth"));
foreach (var item in myList)
{
    Console.WriteLine(item);
}