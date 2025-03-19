namespace _3_14_1
{
    public delegate void TickEventHandler(object sender, EventArgs e);

    // 定义响铃事件委托
    public delegate void AlarmEventHandler(object sender, EventArgs e);

    // 闹钟类
    public class AlarmClock
    {
        private int alarmTime;
        private int currentTime = 0;

        public event TickEventHandler Tick;
        public event AlarmEventHandler Alarm;
        public AlarmClock(int alarmTime)
        {
            this.alarmTime = alarmTime;
        }
        public void Start()
        {
            while (true)
            {
                OnTick();
                currentTime++;

                if (currentTime == alarmTime)
                {
                    OnAlarm();
                    break;
                }
            }
        }
        protected virtual void OnTick()
        {
            Tick?.Invoke(this, EventArgs.Empty);
        }
        protected virtual void OnAlarm()
        {
            Alarm?.Invoke(this, EventArgs.Empty);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Console.WriteLine("请输入闹钟的响铃时间:");
            string s = "";
            s = Console.ReadLine();
            n = int.Parse(s);
            AlarmClock clock = new AlarmClock(n);
            clock.Tick += (sender, e) =>
            {
                Console.WriteLine("滴答");
            };
            clock.Alarm += (sender, e) =>
            {
                Console.WriteLine("响铃");
            };
            clock.Start();
        }
    }
}
