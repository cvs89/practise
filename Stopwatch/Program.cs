using System;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var sWatch = new Stopwatch();
                sWatch.Start();
                //sWatch.Start();
                var wTime = sWatch.Stop();
                Console.WriteLine("Watch runtime : {0}", wTime);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }

    class Stopwatch
    {
        private const bool V = false;
        private DateTime _statTime;
        private DateTime _stopTime;
        private bool watchswitch;
        private const string V1 = "Watch can be start multipal times, you have to stop the watch and then start again";

        public Stopwatch()
        {
            watchswitch = V;
        }
        public void Start()
        {
            if(this.watchswitch == true)
            {
                
                throw new InvalidOperationException(V1);
            }

            this._statTime = DateTime.Now;
            this.watchswitch = true;
            Console.WriteLine("Start time : {0}", this._statTime);

        }
        public TimeSpan Stop()
        {
            this._stopTime = DateTime.Now;
            Console.WriteLine("Stop time : {0}", this._stopTime);
            return this._stopTime.Subtract(this._stopTime);
        }
    }
}
