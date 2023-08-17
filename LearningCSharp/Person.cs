namespace HelloWorld
{
    class Person
    {
        private String userName;
        private String mobile;

        public Person()
        {
            userName = "Nobita";
            mobile = "1232456";
        }

        public void display()
        {
            Console.WriteLine(userName);
            Console.WriteLine(mobile);
        }
    }
}