using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace Alarm
{
    public delegate void Alarm_Clock_Handler(DateTime time);
    class AlarmClock
    {
        public static DateTime setted_time;
        public AlarmClock(DateTime time)
        {
            setted_time = time;
        }
        public static void OnAlarming(DateTime nowtime)
        {
            if (nowtime.Hour ==Setted_time.Hour && nowtime.Minute == Setted_time.Minute && nowtime.Second == Setted_time.Second)
            {
                Console.WriteLine("时间到了！");
            }
        }
        public static void OnTick(DateTime time)
        {
            Console.WriteLine(time + "DiDa");
        }

        public static DateTime Setted_time { get => setted_time; set => setted_time = value; }
    }
    class EventArg
    {
        public event Alarm_Clock_Handler Alarming;
        public event Alarm_Clock_Handler Tick;
        public void ChangeTime()
        {
            Timer t = new Timer(1000);
            t.Elapsed += new System.Timers.ElapsedEventHandler(theout);
            t.AutoReset = true;
            t.Enabled = true;
            t.Start();
            Console.Read();
        }
        public void theout(object source, System.Timers.ElapsedEventArgs e)
        {
            DateTime start = DateTime.Now;
            if (Alarming != null) { Alarming(start); }
            if (Tick != null) { Tick(start); }
        }
      
    }
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now =  new DateTime(2020,9,20,14,44,02) ;
            AlarmClock alarmClock = new AlarmClock(now);
            Alarm_Clock_Handler tick = new Alarm_Clock_Handler(AlarmClock.OnTick);
            Alarm_Clock_Handler alarm = new Alarm_Clock_Handler(AlarmClock.OnAlarming);
            EventArg eventArg = new EventArg();
            eventArg.Alarming +=alarm;
            eventArg.Tick += tick;
            eventArg.ChangeTime();
            
        } 
    }
}
