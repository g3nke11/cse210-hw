using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture("John 3 2", "The same came to Jesus by night, and said unto him, Rabbi, we know that thou art a teacher come from God: for no man can do these miracles that thou doest, except God be with him.");
        scripture.Memorize();
    }
}