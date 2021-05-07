using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElevatorControl
{
    public class Elevator
    {
        //Floors available for the elevator to travel. 
        private int Floor;

        //The current floor the elevator is present. Defaults to zero. 
        private int CurrentFloor;

        //The direction in which the elevator needs to go. By default, value is Rest. 
        private enum ElevatorDirection
        {
            Up,
            Down,
            Wait,
            Rest
        }

        //Constructor
        public Elevator()
        {

        }

        //call to go up.
        public void GoUp()
        {
            this.CurrentFloor += 1;
        }

        //call to go down the elevator. 
        public void GoDown()
        {
            this.CurrentFloor -= 1;
        }

        //Requesting an elevator from any floor to any floor. 
        public void RequestElevator(int floorOfRequest, int destinationFloor)
        {
            if (destinationFloor > floorOfRequest)
            {
                while (floorOfRequest != CurrentFloor)
                {
                    this.GoDown();
                }
            }
            else
            {
                while (floorOfRequest != CurrentFloor)
                {
                    this.GoUp();
                }
            }

        }

        // person pushes button and this method is called. 
        public void ElevatorTravel(int destinationFloor)
        {
            //using above logic, make sure to check the current floor and if 
            //current floor iss greater than destination floor, then move the elevator down else up. 
        }



    }
}
