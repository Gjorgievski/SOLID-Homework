using System;

public delegate void StateChanged(Object sender, StateChangedEventArguments eventArgs);

public delegate void ExceptionOccur(Object sender, ExceptionOccurEventArguments eventArgs);




public class StateChangedEventArguments : System.EventArgs
{
    
    public string Message { get; private set; }
    
    
    public StateChangedEventArguments (string message)
	{
        this.Message=message;
	}


}


public class ExceptionOccurEventArguments : System.EventArgs
{
    
    public string Message { get; private set; }
    
    
    public ExceptionOccurEventArguments (string message)
	{
        this.Message=message;
	}


}