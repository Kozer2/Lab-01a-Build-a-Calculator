using System;

namespace Lab_01a_Build_a_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            StartSequence();
        } //end main function
        static void StartSequence()
        {
            Console.WriteLine("Enter a number: ");
            string userNum = Console.ReadLine();
            try
            {
                int userIntNum = Convert.ToInt32(userNum);
                int[] numArray = new int[userIntNum];
                numArray = Populate(numArray);
                /*Populate(numArray);*/
                int sumNum = GetSum(numArray);
                int productNum = GetProduct(numArray, sumNum);
                decimal quotNum = GetQuotient(productNum);

                Console.WriteLine($"Your array size is: {numArray.Length}");
                Console.WriteLine("The Numbers in the array are: " + (String.Join(',', numArray)));
                Console.WriteLine($"The sum of the array is: {sumNum}.");
                int prodNum = productNum / sumNum;
                Console.WriteLine($"{sumNum} * {prodNum} = {productNum} ");
                decimal qNum = productNum / quotNum;
                Console.WriteLine($"{productNum} / {qNum} = {quotNum} ");


            }
            catch (FormatException e)
            {
                Console.WriteLine("You did not enter a number. Starting app Over.");
                StartSequence();
            }
            finally
            {
                Console.WriteLine("Program Complete");
            }

            

        }//end StartSequence function
        static int[] Populate(int[] userNumArray)
        {

            var counterNum = userNumArray.Length;
            int[] numbersArray = new int[counterNum];

            Console.WriteLine(counterNum);

            for (var i = 0; i < userNumArray.Length; i++)
            {
                Console.WriteLine($"Enter a number: {i + 1} of {counterNum}");
                string userNum = Console.ReadLine();
                Console.WriteLine($"You entered: " + userNum);
                int userIntNum = Convert.ToInt32(userNum);

                numbersArray[i] = userIntNum;

            }
            Console.WriteLine("The numbers you entered are: " + (String.Join(',', numbersArray)));
            
            return numbersArray;
        } //end Populate function

        static int GetSum(int[] userIntArr)
        {
            int sum = 0;
            for (int i = 0; i < userIntArr.Length; i++)
            {
                /*Console.WriteLine(userIntArr[i]);*/
                sum += userIntArr[i];
                /*Console.WriteLine($"The sum of the numbers is: {sum}");*/
            }

            if (sum < 20)
            {
                throw new ApplicationException($"The total entered is: {sum} which is lower than 20. ");
            }
            else
            {
                Console.WriteLine($"The sum of the numbers is: {sum}");
                return sum;
            }
        } // end GetSum method

        static int GetProduct(int[] userIntArr, int sum)
        {
            Console.WriteLine("Please enter a number between 1 and the length of the array we created.");
            int product = 0;
            int userNum = Convert.ToInt32(Console.ReadLine());
            /*Console.Write($"The number you entered is: {userNum}.");*/
            product = sum * userIntArr[userNum - 1];
            Console.WriteLine($"The product is: {product}");
            return product;
        } // end Get Product method

        static decimal GetQuotient(int product)
        {
            Console.WriteLine($"Please enter a number to divide {product} by: ");
            int userNum = Convert.ToInt32(Console.ReadLine());
            decimal dividedNum = decimal.Divide(product, userNum);
            Console.WriteLine($"Dividing {product} by {userNum} gives us: {dividedNum}");

            return dividedNum;
        }
    }
}
