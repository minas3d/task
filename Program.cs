namespace task
{
    internal class Program
    {

        public static void additiem(List<int> mylist)
        {

            Console.WriteLine("plese enter numper to add");
            int x = Convert.ToInt32(Console.ReadLine());
            bool add2 = false;
            for (int i = 0; i < mylist.Count; i++)
            {
                if (x == mylist[i])
                {
                    Console.WriteLine("You cannot add this item because it has already been added before.");
                    add2 = true;
                }
            }
            if (!add2)
            {
                mylist.Add(x);
            }
            Console.WriteLine("==============================================================");

        }


        public static void print(List<int> mylist)
        {
            Console.WriteLine("The items in the list are:");

            for (int i = 0; i < mylist.Count; i++)
            {
                Console.WriteLine(mylist[i]);
            }


        }
        public static void cheack_empty_or_no(List<int> mylist)
        {
            if (mylist.Count == 0)
            {
                Console.WriteLine("The list is empty. Press the 'A' key to add items.");
            }
            else
            {
                print(mylist);
            }
            Console.WriteLine("==============================================================");
        }
        public static double meaan(List<int> mylist)
        {


            double sum = 0;
            for (int i = 0; i < mylist.Count; i++)
            {
                sum += mylist[i];

            }
            double mean = sum / mylist.Count;


            return mean;
        }
        public static int smallest(List<int> mylist)
        {
            int smallest = mylist[0];
            for (int i = 1; i < mylist.Count; i++)
            {
                if (mylist[i] < smallest)
                {
                    smallest = mylist[i];
                }

            }
            return smallest;
        }
        public static int largest(List<int> mylist)
        {
            int largest = mylist[0];
            for (int i = 1; i < mylist.Count; i++)
            {

                if (mylist[i] > largest)
                {
                    largest = mylist[i];
                }

            }
            return largest;
        }
        public static void desinding(List<int> mylist)
        {
            for (int i = 0; i < mylist.Count; i++)
            {
                int max = i;
                for (int j = i; j < mylist.Count; j++)
                {
                    if (mylist[j] > mylist[max])
                        max = j;
                }

                int temp = mylist[i];
                mylist[i] = mylist[max];
                mylist[max] = temp;

            }



        }
        public static void Asinding(List<int> mylist)
        {
            for (int i = 0; i < mylist.Count - 1; i++)
            {
                int mini = i;
                for (int j = i; j < mylist.Count; j++)
                {
                    if (mylist[j] < mylist[mini])
                        mini = j;
                }

                int temp = mylist[i];
                mylist[i] = mylist[mini];
                mylist[mini] = temp;

            }

        }
        public static int found(List<int> mylist)
        {
            int found3 = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < mylist.Count; i++)
            {
                if (mylist[i] == found3)
                {
                    return i;
                }

            }
            return -1;

        }
        static void Main(string[] args)
        {

            List<int> mylist = new List<int>();
            while (true)
            {
                Console.WriteLine("Please choose the operation you want");
                Console.WriteLine(" A - add");
                Console.WriteLine(" p - print ");
                Console.WriteLine(" M - mean ");
                Console.WriteLine(" S - smallist ");
                Console.WriteLine(" L - largest ");
                Console.WriteLine(" F - found ");
                Console.WriteLine(" C - clear  ");
                Console.WriteLine(" D  -sort Descending");
                Console.WriteLine(" E - sort Acscending");
                Console.WriteLine(" Q - Quit ");
                char your_choice = Convert.ToChar(Console.ReadLine());
                if (your_choice == 'Q')
                    break;

                switch (your_choice)
                {
                    case 'A':
                        additiem(mylist);
                        break;

                    case 'P':
                        cheack_empty_or_no(mylist);
                        break;

                    case 'M':

                        Console.WriteLine($" the average is = {meaan(mylist)}");
                        Console.WriteLine("==============================================================");
                        break;

                    case 'S':

                        Console.WriteLine($"the smallest is = {smallest(mylist)}");
                        Console.WriteLine("==============================================================");
                        break;

                    case 'L':

                        Console.WriteLine($"the largest is = {largest(mylist)}");
                        Console.WriteLine("==============================================================");

                        break;

                    case 'F':


                        Console.WriteLine("enter your number yo need to found it ");
                        int index = found(mylist);
                        if (index >= 0)
                        { Console.WriteLine($"This number was found at index {index}"); }
                        else
                        {
                            Console.WriteLine("not found ");
                        }
                        Console.WriteLine("==============================================================");
                        break;

                    case 'C':

                        mylist.Clear();
                        Console.WriteLine("OK your list is now empty");
                        Console.WriteLine("==============================================================");
                        break;

                    case 'D':
                        Console.WriteLine("Sorting the items in descending order is:");
                        desinding(mylist);
                        print(mylist);
                        Console.WriteLine("==============================================================");
                        break;

                    case 'E':

                        Console.WriteLine("Sorting the items in ascending order is:");
                        Asinding(mylist);
                        print(mylist);

                        Console.WriteLine("==============================================================");
                        break;

                    default:
                        Console.WriteLine("This operation is not available");
                        Console.WriteLine("==============================================================");
                        break;

                }

            }
        }
    }
}
