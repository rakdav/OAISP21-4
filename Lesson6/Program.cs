try
{
    // Console.Write("Введите x:");
    // int x=int.Parse(Console.ReadLine());
    // double y;
//     if (x >= 0) y = x;
//     else y = -x;
//     Console.WriteLine($"|{x}|={y}");
    // if((x > -5)&&(x< 3)) Console.WriteLine("Принадлежит");
    // else Console.WriteLine("Не принадлежит");
    // if(x%10==3||x/10==3) Console.WriteLine("Входит");
    // else Console.WriteLine("Не входит");
    // if(x>0) y=Math.Sin(x*x);
    // else y=1-2*Math.Sin(x*x);
    // Console.WriteLine($"y={y:F3}");   
    // if(x<4) Console.WriteLine("I");
    // else Console.WriteLine("II");
  //  Console.WriteLine((x<4)?"I":"II");
//   Console.Write("Введите a:");
//   double a = double.Parse(Console.ReadLine());
//   Console.Write("Введите b:");
//   double b = double.Parse(Console.ReadLine());
//   Console.Write("Введите c:");
//   double c = double.Parse(Console.ReadLine());
//   double D = b * b - 4 * a * c;
//   if (D > 0)
//   {
//       double x1=(-b+Math.Sqrt(D))/(2 * a);
//       double x2=(-b-Math.Sqrt(D))/(2 * a);
//       Console.WriteLine($"x1={x1:F2}, x2={x2:F2}");
//   }
//   else if (D == 0)
//   {
//       double x = -b / (2 * a);
//       Console.WriteLine($"x={x:F2}");
//   }
//   else Console.WriteLine("Корней нет");
    Console.Write("Введите x:");
    double x = double.Parse(Console.ReadLine());
    Console.Write("Введите y:");
    double y = double.Parse(Console.ReadLine());
    Console.Write("Введите радиус окружности:");
    double R = double.Parse(Console.ReadLine());
    if(x*x+y*y<R*R) Console.WriteLine("Принадлежит");
    else Console.WriteLine("Не принадлежит");
 }
catch
{
    Console.WriteLine("Введите правильные данные");
}
