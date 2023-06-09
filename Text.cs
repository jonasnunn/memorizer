public class Text
{
    private string _text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt";
    private string _name = "Placeholder Name";
    private string[] _wordArray;
    private List<string> _wordList = new List<string>();

    public Text()
    {
        ParseText(_text);
    }

    private void ParseText(string text) //Text to array to list
    {
        _wordArray = text.Split(" ");
        _wordList = _wordArray.ToList();
    }

    public void hideWords() // Hides 5 random words. 
    {
        Random rnd = new Random();
        for (int i = 0; i < 5; i++)
        {
            int randInt = rnd.Next(_wordList.Count);
            
            if (_wordList[randInt] != "_____")
            {
                _wordList.RemoveAt(randInt);
                string blank = "______";
                _wordList.Insert(randInt, blank);
            }
        }
    }

    public void DisplayText() // Display the text from the current word list.
    {
            Console.Clear();
            Console.WriteLine(_name);
            foreach (string word in _wordList)
            {
                Console.Write(word);
                Console.Write(" ");
            }
            Console.WriteLine();
    }
}
