using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallisticCalcs
{
    class Ballistic
    {

        public double flightRange = 0;

        public double maxHeight = 0;

        public double flightTime = 0;

        public double throwAngle = 0;

        public double startSpeed = 0;

        public double gravityAcceleration = 0;
        
        public Ballistic calculate ()
        {
            if (this.startSpeed == 0) this.calcStartSpeed();

            if (this.throwAngle == 0) this.calcThrowAngle();

            this.calcFlightRange();

            this.calcMaxHeight();

            this.calcFlightTime();

            return this;
        }

        private void calcFlightRange()
        {
            this.flightRange = ((Math.Pow(this.startSpeed, 2) / this.gravityAcceleration) * Math.Abs(Math.Sin(2 * this.throwAngle)));
        }

        private void calcMaxHeight()
        {
            this.maxHeight = (Math.Pow(this.startSpeed, 2) / (2 * this.gravityAcceleration)) * Math.Pow(Math.Abs(Math.Sin(this.throwAngle)), 2);
        }

        private void calcFlightTime()
        {
            this.flightTime = ((2 * this.startSpeed * Math.Abs(Math.Sin(this.throwAngle))) / this.gravityAcceleration);
        }

        private void calcStartSpeed()
        {
            // TODO start speed calc
        }

        private void calcThrowAngle()
        {
            // TODO throw speed calc
        }


        public double FlightRange
        {
            get { return flightRange; }
            set { flightRange = value; }
        }

        public double MaxHeight
        {
            get { return maxHeight; }
            set { maxHeight = value; }
        }

        public double FlightTime
        {
            get { return flightTime; }
            set { flightTime = value; }
        }

        public double ThrowAngle
        {
            get { return throwAngle; }
            set { throwAngle = value; }
        }

        public double StartSpeed
        {
            get { return startSpeed; }
            set { startSpeed = value; }
        }

        public double GravityAcceleration
        {
            get { return gravityAcceleration; }
            set { gravityAcceleration = value; }
        }

    }
}
