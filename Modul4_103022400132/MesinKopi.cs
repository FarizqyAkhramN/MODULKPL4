using System;
using System.Collections.Generic;
using System.Text;

namespace Modul4_103022400132
{
    internal class MesinKopi
    {
        public enum State { OFF, STANDBY, BREWING, MAINTENANCE }
        public State currentState;

        public MesinKopi()
        {
            currentState = State.OFF;
        }

        public void AktivasiKondisi(string Kondisi)
        {
            if (currentState == State.OFF && Kondisi == "STANDBY")
            {
                currentState = State.STANDBY;
                Console.WriteLine("Mesin Off berubah menjadi Standby");
            }
            else if (currentState == State.STANDBY && Kondisi == "START_BREW")
            {
                currentState = State.BREWING;
                Console.WriteLine("Mesin Standby berubah menjadi Brewing");
            }
            else if (currentState == State.BREWING && Kondisi == "FINISH_BREW")
            {
                currentState = State.STANDBY;
                Console.WriteLine("Mesin Brewing berubah menjadi Standby");
            }
            else if (currentState == State.STANDBY && Kondisi == "START_MAINTENANCE")
            {
                currentState = State.MAINTENANCE;
                Console.WriteLine("Mesin Standby berubah menjadi Maintenance");
            }
            else if (currentState == State.MAINTENANCE && Kondisi == "FINISH_MAINTENANCE")
            {
                currentState = State.STANDBY;
                Console.WriteLine("Mesin Maintenance berubah menjadi Standby");
            }
            else if (currentState == State.STANDBY && Kondisi == "POWER_OFF")
            {
                currentState = State.OFF;
                Console.WriteLine("Mesin Standby berubah menjadi Off");
            }
            else
            {
                Console.WriteLine("Perubahan state tidak valid");
            }
        }
    }
}