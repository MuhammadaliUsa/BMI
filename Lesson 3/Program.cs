namespace Lesson_3
{
    internal class Program
    {
        static void Main(string[] args)
        {


            double BMI,height1, weight, height;
           
            Console.Write("Enter the weight: ");
            double.TryParse(Console.ReadLine(), out weight);
            Console.Write("Enter the height: ");
            double.TryParse(Console.ReadLine(), out height);
            height1 = height/100;
           

            BMI = weight / height1 / height1;
            if (BMI>16&&BMI<18.5)
            {
                Console.WriteLine("Underweight!");
            }
            else if (BMI > 18 && BMI < 25)
            {
                Console.WriteLine("Normal");
            }
            else if (BMI > 25 && BMI < 33)
            {
                Console.WriteLine("Overveight");
            }
            else
            {
                Console.WriteLine("Obesity!");
            }

        }
    }
}