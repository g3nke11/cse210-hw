using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture("John 3 2", "The same came to Jesus by night, and said unto him, Rabbi, we know that thou art a teacher come from God: for no man can do these miracles that thou doest, except God be with him.");
        // scripture.Memorize();

        Scripture_Memorizer memorizer = new Scripture_Memorizer("John 3 2", "The same came to Jesus by night, and said unto him, Rabbi, we know that thou art a teacher come from God: for no man can do these miracles that thou doest, except God be with him.");
        memorizer.AddScripture("John 3 3","Jesus answered and said unto him, Verily, verily, I say unto thee, Except a man be born again, he cannot see the kingdom of God.");
        memorizer.AddScripture("John 3 4","Nicodemus saith unto him, How can a man be born when he is old? can he enter the second time into his mother’s womb, and be born?");
        memorizer.AddScripture("John 3 5","Jesus answered, Verily, verily, I say unto thee, Except a man be born of water and of the Spirit, he cannot enter into the kingdom of God.");
        memorizer.MemorizeRandom();
    }
}