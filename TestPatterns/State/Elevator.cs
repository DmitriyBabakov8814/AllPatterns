using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPatterns.State
{
    internal class Elevator
    {
        public IElevatorState ElevatorState
        {
            get;
            set;
        }
        public Elevator(IElevatorState elevatorState)
        {
            ElevatorState = elevatorState;
        }
        public void Up()
        {
            ElevatorState.Up(this);
        }

        public void Down()
        {
            ElevatorState.Down(this);
        }
    }
}
