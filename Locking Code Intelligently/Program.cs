using System;

//ref link:https://www.youtube.com/watch?v=EuZa5qiERWM&list=PLRwVmtr-pp06KcX24ycbC-KkmAISAFKV5&index=22
//ctrl+l -- remove blank line
//ctrl+m+o -- collapse all
//ctrl+k+d -- align all

class PublicRestroom
{
    //object baton = new object();
    object stall1baton = new object();
    object stall2baton = new object();
    public void UseStall1()
    {
        //lock (baton)
        lock (stall1baton)
        {
            Console.WriteLine("In stall 1");
            Thread.Sleep(2000);
        }
    }
    public void UseStall2()
    {
        //lock (baton)
        lock (stall2baton)
        {
            Console.WriteLine("In stall 2");
            Thread.Sleep(2000);
        }
    }
    /*
    public void UseSink1()
    {
        lock (baton)
        {
            Console.WriteLine("In sink 1");
            Thread.Sleep(2000);
        }
    }
    public void UseSink2()
    {
        lock (baton)
        {
            Console.WriteLine("In sink 2");
            Thread.Sleep(2000);
        }
    }*/
}

class MainClass
{
    static void Main()
    {
        var restroom = new PublicRestroom();
        new Thread(restroom.UseStall1).Start();
        new Thread(restroom.UseStall2).Start();
        new Thread(restroom.UseStall1).Start();
        new Thread(restroom.UseStall2).Start();
    }
}