using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoysGameCenter
{
    public class Console
    {
        private byte startSecond, startMinute, startHour;
        //private byte nowSecond, nowMinute, nowHour;
        private byte finishMinute, finishSecond, finishHour;
        private byte finalSecond, finalMinute, finalHour;
        private byte price = 30;
        private byte[] AC = { 0, 15 }; // AC = additionalController
        private float cost;
        private float totalCost;
        private int[] totalTime = { 0, 0, 0 };
        private bool enabled = false;
        private byte increaseTime = 0;
        public sbyte[] devTimer = { 0, 0, 0 };
        //FinalText finalText = new FinalText();
        public void start()
        {
            startHour = (byte)DateTime.Now.TimeOfDay.Hours;
            startMinute = (byte)DateTime.Now.TimeOfDay.Minutes;
            startSecond = (byte)DateTime.Now.TimeOfDay.Seconds;

            this.enabled = true;
        }


        public void priceSetter(byte price) { this.price = price; }
        
        public void ACNumberSetter(byte number) { this.AC[0] = number; }// AC = additionalController
        
        public void ACPriceSetter(byte price) { this.AC[1] = price; }// AC = additionalController
        
        
        public void finish()
        {
            finishHour = (byte)DateTime.Now.TimeOfDay.Hours;
            finishMinute = (byte)DateTime.Now.TimeOfDay.Minutes;
            finishSecond = (byte)DateTime.Now.TimeOfDay.Seconds;

            //-------------------------------------------------------------------------------------//

            if (finishMinute < startMinute)
            {
                finishHour -= 1;
                finishMinute += 60;
            }
            finalHour = (byte)(finishHour - startHour);
            if (finishSecond < startSecond)
            {
                finishMinute -= 1;
                finishSecond += 60;
            }
            finalMinute = (byte)((finishMinute - startMinute) + increaseTime);

            finalSecond = (byte)((finishSecond - startSecond));

            //-------------------------------------------------------------------------------------//

            
             cost = ((finalHour * (price + (AC[0] * AC[1])) / 1f)
                + (finalMinute * (price + (AC[0] * AC[1])) / 60f)
                + (finalSecond * (price + (AC[0] * AC[1])) / 3600));


            //-------------------------------------------------------------------------------------//


            totalCost += cost;

            totalTime[0] += finalHour;
            totalTime[1] += finalMinute;
            totalTime[2] += finalSecond;


            this.enabled = false;

            for (int i = 0; i < this.devTimer.Length; i++)
            {
                this.devTimer[i] = 0;
            }

            string behindHour = " ", behindMinute = " : ", behindSecond = " : " ,
                behindSHour = " ", behindSMinute = " : ", behindSSecond = " : " ,
                behindFHour = " ", behindFMinute = " : ", behindFSecond = " : " ,
                additionalController = "" ;

            if (finalHour < 10) { behindHour += "0"; }
            if (finalMinute < 10) { behindMinute += "0"; }
            if (finalSecond < 10) { behindSecond += "0"; }

            if (startHour < 10) { behindSHour += "0"; }
            if (startMinute < 10) { behindSMinute += "0"; }
            if (startSecond < 10) { behindSSecond += "0"; }

            if (finishHour < 10) { behindFHour += "0"; }
            if (finishMinute < 10) { behindFMinute += "0"; }
            if (finishSecond < 10) { behindFSecond += "0"; }

            switch (AC[0])
            {
                case (0):
                    additionalController = "1or2 Controller(s)";
                    break;

                case (1):
                    additionalController = "3 Controllers";
                    break;

                case (2):
                    additionalController = "4 Controllers";
                    break;
            }
            MessageBox.Show(behindSHour + startHour + behindSMinute + startMinute + behindSSecond + startSecond + 
                "  ~  " + behindFHour + finishHour + behindFMinute + finishMinute + behindFSecond + finishSecond + "\n" +
                "Time :" + behindHour + finalHour.ToString() + behindMinute + finalMinute + behindSecond + finalSecond + "\n" +
                additionalController + "\nCost : " + cost);

        }
        public bool enabledGetter()
        {
            return (this.enabled);
        }

        public void increaseTimeSetter(byte increseTime)
        {
            this.increaseTime = increseTime;
        }
        //public string showTime()
        //{
        //    nowHour = (byte)DateTime.Now.TimeOfDay.Hours;
        //    nowMinute = (byte)DateTime.Now.TimeOfDay.Minutes;
        //    nowSecond = (byte)DateTime.Now.TimeOfDay.Seconds;
        //    if (nowMinute < startMinute)
        //    {
        //        nowMinute += 60;
        //        nowHour -= 1;
        //    }
        //    byte hourTimer = (byte)(nowHour - startHour);
        //    if (nowSecond < startSecond)
        //    {
        //        nowMinute -= 1;
        //        nowSecond += 60;
        //    }
        //    byte minuteTimer = (byte)(nowMinute - startMinute);
        //    byte secondTimer = (byte)(nowSecond - startSecond);

        //    return (hourTimer + ":" + minuteTimer + ":" + secondTimer);
        //}
        public void ending()
        {
            //finalText.saveText("total time : " + totalTime[0] + ":" + totalTime[1] + ":" + totalTime[2] + "\n"
            //    + "total cost = " + totalCost);
        }

        public Console() { }
    }
}
