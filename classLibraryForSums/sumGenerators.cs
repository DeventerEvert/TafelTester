using System;
using System.Windows;
using System.Diagnostics;



namespace classLibraryForSums
{

    public class randomSumGenerator
    {
        Char[] sumOperator = { '-', '+', '*', '/' };
        Random random = new Random();


        public string generateEasyRandomSum(out int result)
        {

           int  secondSum = random.Next(0, 101);
           int  sum = random.Next(secondSum, 101);

            Char randomOperator = sumOperator[random.Next(0, 2)];

            result = getResults(randomOperator, sum, secondSum);

            return $"{sum} {randomOperator} {secondSum} = ";
        }


        public string generateMediumRandomSum(out int result)

        {
            Char randomOperator = sumOperator[random.Next(0, 3)];

            int secondSum = random.Next(0, 501);
            int sum = random.Next(secondSum, 501);

            if (randomOperator == '*') // Zorg  
            {
                sum = random.Next(0, 51);
                secondSum = random.Next(0, 100);
            }

           result =  getResults(randomOperator, sum, secondSum);

            return $"{sum} {randomOperator} {secondSum} = ";
        }


        public string generateHardRandomSum(out int result)
        {
 
            Char randomOperator = sumOperator[random.Next(sumOperator.Length)];

            int secondSum = random.Next(0, 501);
            int sum = random.Next(secondSum, 501);

            if (randomOperator == '*') // Zorgt ervoor dat * niet te groot kan worden  
            {
                sum = random.Next(0, 51);
                secondSum = random.Next(0, 200);
            }
            else if (randomOperator == '/')
            {
                sum = random.Next(0, 81);
                secondSum = random.Next(0, 81);
            }

            result = getResults(randomOperator, sum, secondSum);

            if (randomOperator == '/')
            {
                int intTemp = result;
                result = sum;
                sum = intTemp;

            }


            Debug.WriteLine($"{sum} {randomOperator} {secondSum} = {result}");
            return $"{sum} {randomOperator} {secondSum} = ";

        }

        private int getResults(Char _randomOperator, int _sum, int _secondsum)
        {
            int result = 0;
            result = (_randomOperator == '+') ? (_sum + _secondsum) :
         (_randomOperator == '-') ? (_sum - _secondsum) :
         (_randomOperator == '*') ? (_sum * _secondsum) :
         (_randomOperator == '/') ? (_sum * _secondsum) :
         0;
            return result;
        }
    }
}


