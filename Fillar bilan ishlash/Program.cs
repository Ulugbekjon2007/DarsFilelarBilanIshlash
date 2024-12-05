/*
using System;

var thread = new Thread(()=>CountUp () ) ;
var thread2 = new Thread(() => CountDown());
thread.Start();
thread2.Start ();

Console.WriteLine("Finished The program ");
static void CountUp()
{
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine($"Up => ({Thread.CurrentThread.ManagedThreadId}) : {i}");
    }

}
static void CountDown ()
{
    for (int i = 10; i > 0; i--) {
        Console.WriteLine($"Down => ({Thread.CurrentThread.ManagedThreadId}) : {i}");
    }
}
*/

//using System;
//var threadMakePasta = new Thread(() => MakePasta());

//static void MakePasta ()
//{

//    var thread1 = new Thread(() => MakaChiccken());


//    var thread2 = new Thread(() => BoilSpaghetti());

//    var thread3 = new Thread(() => DesignMeal());

//    var thread4 = new Thread(() => TasteMeal());

//    thread1.Start();
//    thread2.Start();


//    thread1.Join();
//    thread2.Join();

//    thread3.Start();
//    thread4.Start();


//    thread4.Join();


//    static void MakaChiccken()
//    {
//        Thread.Sleep(5000);
//        Console.WriteLine("Tovuq qovurilyapdi !");

//    }
//    static void BoilSpaghetti()
//    {
//        Thread.Sleep(4000);
//        Console.WriteLine("Makaron qaynayapdi !");
//    }
//    static void DesignMeal()
//    {
//        Thread.Sleep(3000);

//        Console.WriteLine("Ovqat Bezatilyapdi !");
//    }
//    static void TasteMeal()
//    {
//        Thread.Sleep(2000);
//        Console.WriteLine("Ovqatning mazzasi tekshirilyapdi ! ");
//    }

//}
//threadMakePasta.Start();

/*
 
public class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 10; i++)
        {
            var thread = new Thread(FillBalanse);
            thread.Start();
        }
    }
    static int Balanse = 0;
    static void Pay()
    {
        for (int i = 0; i <= 10; i++)
        {
            var thread = new Thread(FillBalanse);
            thread.Start();
            Console.WriteLine(Balanse);
        }
    }
    static void FillBalanse()
    {       
        Console.WriteLine(Balanse);
        Balanse += 100;

    }

}

*/


//using System;
//using System.Threading;

//class Program
//{
//    static void Main (string[] args)
//    {
//        Thread thread = new Thread(YordamchiVazifa);
//        thread.Start();

//        for (int i = 0; i < 10; i++)
//        {
//            Console.WriteLine(" Asosiy oqim ishlamoqd ...");
//            Thread.Sleep(1000);
//        }

//    }
//    static void YordamchiVazifa ()
//    {
//        for (int i = 0; i < 10; i++)
//        {
//            Console.WriteLine("Yordamchi thread ishlamoqda ...");
//            Thread.Sleep(1000);
//        }
//    }
//}

/*
using System;
using System.Threading;

class Program
{
    private static object lockObject = new object();
    private static int hisob = 0; 

    static void Main (string[] args)
    {
        Thread thread1 = new Thread(ResursniUzgartirish);
        Thread thread2 = new Thread(ResursniUzgartirish);

        thread1.Start();
        thread2.Start();

        thread1.Join();
        thread2.Join();

        Console.WriteLine($"Oxirgi Hisob qaydnomasi : {hisob}");

    }
    static void ResursniUzgartirish()
    {
        for (int i = 0; i < 10; i++)
        {

            lock (lockObject)
            {
                hisob+= 10;
                Console.WriteLine($" Hisob : {hisob}");
            }
        }
    }
}

    */



//using System;
//using System.Threading;

//class Program
//{
//    static void Main (string[] args)
//    {
//        ThreadPool.QueueUserWorkItem((state) =>
//        {
//            Console.WriteLine("ThreadPoolda ishlayotgan vazifa !");
//            Thread.Sleep (1000);
//            Console.WriteLine("Thread vazifani tugatdi !");

//        });

//        Console.WriteLine("Asosiy oqim tugadi !");

//    }
//}




//Asosiy va yordamchi threadlar
//using System;
//using System.Threading;

//class Program
//{
//    static void Main (string[] args)
//    {
//        Thread thread = new Thread(ChopEtish);
//        thread.Start();

//        Thread thread1 = new Thread(HisobKitob);
//        thread1.Start();

//        for (int i =0; i < 5 ; i++)
//        {
//            Console.WriteLine("Asosiy oqim ishlamoqda ...");
//            Thread.Sleep(1000);
//        }

//    }
//    static void ChopEtish()
//    {
//        for ( int i = 0;  i < 5; i++ )
//        {
//            Console.WriteLine("Matn chop etilmoqda ...");
//            Thread.Sleep(1000);
//        }
//    }
//    static void HisobKitob ()
//    {
//        for ( int i = 0;i < 5;i++ )
//        {
//            Console.WriteLine("Hisob kitob davom etmoqda ...");
//            Thread.Sleep(1000); 

//        }
//    }
//}
/*
//Resurslar bilan ishlashda sinxronizatsiya (lock)
using System;
using System.Runtime.ExceptionServices;
using System.Threading;

class Program
{
    private static object lockObjekt = new object();
    private static int hisob = 0;

    static void Main(string[] args)
    {
        Thread thread1 = new Thread(HisobniUzgartirish);
        Thread thread2 = new Thread(HisobniUzgartirish);

        thread1.Start();
        thread2.Start();

        thread1.Join();
        thread2.Join();

        Console.WriteLine("Oxirgi Hisib Qiymati : " + hisob);
    }
    static void HisobniUzgartirish()
    {
        for (int i = 0; i < 5; i++)
        {
            lock (lockObjekt)
            {
                hisob+=10;
                Console.WriteLine($"Hisob : {hisob}");
                Thread.Sleep(500);

            }
        }
    }
}
*/


////ThreadPool foydalanish 
//using System;
//using System.Threading;

//class Program
//{
//    static void Main (string[] args)
//    {
//        ThreadPool.QueueUserWorkItem(Vazifa1);
//        ThreadPool.QueueUserWorkItem(Vazifa2);

//        Console.WriteLine(" Asosiy oqim ...");
//    }
//    static void Vazifa1(object state)
//    {
//        for ( int i =0; i < 5; i++ )
//        {
//            Console.WriteLine("Vazifa1 ishlamoqda ... ");
//            Thread.Sleep(1000);

//        }
//    }
//    static void Vazifa2(object state)
//    {
//        for (int i = 0; i < 5; i++ )
//        {
//            Console.WriteLine("Vazifa2 ishlamoqda ...");
//            Thread.Sleep(500);

//        }
//    }
//}


//Ko‘p vazifalarni parallel bajarish

using System;
namespace File
{
    internal class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}