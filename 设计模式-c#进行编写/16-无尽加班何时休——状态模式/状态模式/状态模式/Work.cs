using System;
using System.Collections.Generic;
using System.Text;
using 状态模式.状态类;
namespace 状态模式
{
    public class Work
    {
        private State currentState;
        public Work()
        {
            currentState = new ForenoonState();
        }

        private double hour;
        public double Hour
        {
            get { return hour; }
            set { hour = value; }
        }
        private bool finished = false;
        public bool Finished
        {
            get { return finished; }
            set { finished = value; }
        }

        public void SetState(State state)
        {
            currentState = state;
        }

        public void WriteProgram()
        {
            currentState.WriteProgram(this);
        }

    }
}
