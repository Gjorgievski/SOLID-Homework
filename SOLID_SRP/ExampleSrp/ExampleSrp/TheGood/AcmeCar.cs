using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSrp.TheGood
{
    public class AcmeCar
    {
        /// <summary>
        /// Logger for logging exeptions
        /// </summary>
        public LogException LogException { get; set; }
        /// <summary>
        /// Logger for logging state channging
        /// </summary>
        public LogState LogState { get; set; }

        public LockState IsLocked { get; private set; }

        public void Lock()
        {
            try
            {
                //
                this.IsLocked = LockState.Locked;
                //log state change in computer
                LogState.ComputerLogChangeState("CarLocked");

            }
            catch (Exception)
            {
                ///logging exception
                LogException.ExceptionOccurs("There was an error locking the car!");
            }
        }

        public void Unlock()
        {
            try
            {
                //
                this.IsLocked = LockState.Unlocked;
                //log state change in computer
                LogState.ComputerLogChangeState("CarUnlocked");
                
            }
            catch (Exception)
            {
                ///loggin exception
                LogException.ExceptionOccurs("There was an error unlocking the car!");
            }

        }
    }

    public enum LockState
    {
        Error = 0,
        Locked = 1,
        Unlocked = 2,

    }
}
