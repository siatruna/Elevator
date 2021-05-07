using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElevatorControl
{
    public class Floors
    {
        // total number of floors the elevator is supposed to travel. 
        private enum FloorsCatered
        {

        }


        //As a user enters and clicks a floor, add in to the Array list.
        //As you add to the array list, keep the list sorted. 
        private ArrayList FloorsTravelled;

        //constructor
        public Floors()
        {

        }

        public ArrayList GetAllFloors()
        {
            return FloorsTravelled;
        }

        public ArrayList AddFloor()
        {
            // add the floor pushed in to the Floors Travelled and keep the list sorted at all times. 
            return FloorsTravelled;
        }
    }
}
