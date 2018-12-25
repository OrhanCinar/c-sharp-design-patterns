namespace InterpretterPattern
{
    public class Context
    {
        string _input;
        int _output;

        public Context(string input)
        {
            _input = input;
        }

        public string Input
        {
            get => _input;
            set => _input = value;
        }

        public int Output
        {
            get => _output;
            set => _output = value;
        }
    }
}
