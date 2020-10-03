namespace TreehouseDefense
{
    class TreehouseDefenseException : System.Exception
    {
        public TreehouseDefenseException()
        {

        }
        public TreehouseDefenseException(string message) : base(message)
        {

        }
    }
    class OutrOfBoundsException : TreehouseDefenseException
    {
        public OutrOfBoundsException()
        {

        }
        public OutrOfBoundsException(string message) : base(message)
        {

        }
    }

}