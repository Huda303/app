 class Probl12{
    public static void Total(){
      Console.WriteLine("your name");
      string m = Console.ReadLine();
      Console.WriteLine("Roll Number");
      int n = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Input the marks of Physics");
      int x = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Input the marks Chemistry");
      int y = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Input the marks Computer Application");
      int z = Convert.ToInt32(Console.ReadLine());
     // ارجاع الاسم و الرقم و 
          int total = x + y + z;
          double pers = total/3;
                Console.WriteLine("your total is " + total);
                Console.WriteLine("your Percentage  is " + pers);
            if (pers >= 80)
            {
                                Console.WriteLine("First");
            }
            else if(pers >= 70 && pers < 80) 
            {
                Console.WriteLine("second");
            }
            else if(pers >= 50 && pers < 70) 
            {
                Console.WriteLine("third");
            }

          else
          {
                Console.WriteLine("failed");
          }


    }
}