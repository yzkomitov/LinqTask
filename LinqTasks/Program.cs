namespace LinqTasks;

internal class Program
{
    static void Main(string[] args)
    {
        // ========== 1.1 ==========
        List<int> numbers = new() { 3, 1, 2, 3, 4, 1, 2, 5, 8, 20, 234, 3, 4 };
        List<int> uniqueNumbers = null;

        // ========== 1.2 ==========
        List<int> last7 = null;

        // ========== 1.3 ==========
        double average = 0;

        // ========== 2 ==========
        string[] wordArr = @"Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum".Split(' ', StringSplitOptions.RemoveEmptyEntries);
        List<string> sortedWords = null;

        // ========== 3 ==========
        string[] acceptedValues = ["a", "b", "f", "g", "y", "x", "z"];
        List<string> list = new List<string> { "a", null, "b", null, "c", null, null, "d", "e", null, "b", null, "c", "a", null, "f", null, "c", "a", null, "b", null, "c", null, null, "y", "e", null };
        List<string> acceptedFromList = null;

        // ========== 4 ==========
        List<Intern> interns = new()
        {
            new Intern(){ Name = "John", PhoneNumbers = new List<string> { "123321", "444456", "555789" } },
            new Intern(){ Name = "Mary", PhoneNumbers = new List<string> { "133323" } },
            new Intern(){ Name = "Peter", PhoneNumbers = new List<string> { "122223", "456777" } },
            new Intern(){ Name = "Chasey", PhoneNumbers = new List<string> { "123333", "456123", "788889" } },
        };

        List<string> phoneNumbers = null;

        // ========== 5 ==========
        List<string> input1 = new() { "a", "b", "f", "g", "y", "x", "z", "a", "z", "y", "g", "y", "x", "z", "a", "b", "f", "g", "y", "x", "z", "a", "b", "f", "g", "y", "x", "z", "y", "x", "z", "a", "z", "y", "g", "y", "x", "z", "a" };
        List<string> output1 = null;

        // ========== 6 ==========
        // expected result ["a", "b", "g", "y", "z", "a", "y", "g", "x", "z",...]
        List<string> input2 = new() { "a", "b", "f", "g", "y", "x", "z", "a", "z", "y", "g", "y", "x", "z", "a", "b", "f", "g", "y", "x", "z", "a", "b", "f", "g", "y", "x", "z", "y", "x", "z", "a", "z", "y", "g", "y", "x", "z", "a" };
        List<string> other = null;

        // ========== 7 ==========
        List<List<string>> arr = new()
        {
            new(){ "bla", "bla", "blabla" },
            new(){ "131313", "2", "lorem" },
            new(){ "test" },
            new(){ "131313", "2" },
        };
        List<string> arrRes = null;

        // ========== 8 ==========
        List<string> arr1 = new() { "bla", "bla", "blabla", "131313", "2", "lorem", null, "test", "131313", "2" };
        List<string> res7 = null;

        // ========== 9.1 ==========
        List<decimal> l1 = new() { 1, 2, 3.14M, 4, 5, 6, 7, 8, 9, 10 };
        List<decimal> l2 = new() { 10, 7, 8, 9 };
        List<decimal> l3 = new() { 9, 3.14M, 8, 7, 1 };

        List<decimal> res8 = null;

        // ========== 9.2 ==========
        List<decimal> res9 = null;

        // ========== 10 =========
        List<string> c1 = new() { "bla", "bla", "blabla", "131313", "2", "lorem", null, "test", "131313", "2" };
        List<string> c2 = new() { null, "131313", "2", "lorem", "bla", "bla", "blabla", "test", "131313", "2" };

        bool areEqual1 = false;

        // ========== 11 =========
        List<string> drinkMe = new() { "Beer", "Whiskey", "Beer", "Beer", "Water", "Wine", "Wine", "Boza" };
        Dictionary<string, int> res11 = null;

        // ========== 12 =========
        var input = "2-10,14,18,20-24";
        List<int> res12 = null;
    }

    public class Intern
    {
        public string Name { get; set; }
        public List<string> PhoneNumbers { get; set; }
    }
}