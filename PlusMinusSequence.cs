class PlusMinusSequence
{
    static void Main(string[] args)
    {
        int num = 1;
        while (num < 100)
        {

            num++;
            if (num%2 != 0)
            {
                System.Console.WriteLine("-"+ num);
            }
            else
            {
                System.Console.WriteLine(num);
            }


            

        }


    }



}