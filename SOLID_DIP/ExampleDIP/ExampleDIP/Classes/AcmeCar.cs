using ExampleDIP.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleDIP.Interfaces
{
    public class AcmeCar
    {

        public LockState IsLocked { get; private set; }

        /// <summary>
        /// Logger for state change
        /// </summary>
        public ILoggingState LoggingState{ get; private set; }
        /// <summary>
        /// Logger for exeption occur
        /// </summary>
        public ILoggingException LoggingException { get; private set; }

        /// <summary>
        /// Event for state change
        /// </summary>
        public event StateChanged OnStateChanged;
        /// <summary>
        /// Event for exception occur
        /// </summary>
        public event ExceptionOccur OnExceptionOccur;

        public AcmeCar(ILoggingState loggingState,ILoggingException loggingException)
        {
            LoggingException = loggingException;
            LoggingState = loggingState;
        }

        public void Lock()
        {
            try
            {
                //
                this.IsLocked = LockState.Locked;
                //log state change in computer
                LoggingState.ComputerLogChangeState("CarLocked");

                ///event for state change
                onStateChange("CarLocked");

            }
            catch (Exception)
            {
                ///
                LoggingException.LogExceptionOccurs("There was an error locking the car!");


                ///evnt for exception occur
                onExceptionOccur("There was an error locking the car!"); ;
            }
        }

        public void Unlock()
        {
            try
            {
                //
                this.IsLocked = LockState.Unlocked;
                //log state change in computer
                LoggingState.ComputerLogChangeState("CarUnlocked");

                ///event for state change
                onStateChange("CarUnlocked");
                
            }
            catch (Exception)
            {
                ///
                LoggingException.LogExceptionOccurs("There was an error unlocking the car!");

                ///evnt for exception occur
                onExceptionOccur("There was an error unlocking the car!");
                
            }

        }


        private void onStateChange(string msg)
        {
            if (OnStateChanged != null)
                    OnStateChanged(this, new StateChangedEventArguments("CarUnlocked"));
        }

        private void onExceptionOccur(string msg)
        {
            if (OnExceptionOccur != null)
                    OnExceptionOccur(this, new ExceptionOccurEventArguments("There was an error unlocking the car!"));
        }


    }


    public enum LockState
    {
        Error = 0,
        Locked = 1,
        Unlocked = 2,

    }
}
