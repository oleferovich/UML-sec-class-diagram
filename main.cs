
using System;

// The Process class represents the execution of processes
public class Process
{
    public void CheckProcess()
    {
       public void CheckProcessID()
    {
        
        //The logic for obtaining the process ID can be implemented here
    }
    public void CheckProcessName()
    {
        
        //The logic for getting the process name can be implemented here
    }
    
    public void CheckAccessLevel()
    {
        
        //The logic for getting the process access level can be implemented here
    } 
    }
   
}


public class SecurityManager
{
    public bool CheckAccess()
    {
      // The logic of adding/removing a user, adding/removing a role, getting users can be implemented here
        
        return true;
    }
}


public class Robot
{
    public void IsCredentialsRobot()
    {
       //The logic for obtaining the ID robot, setting a password, and authenticating the robot can be implemented here
    }
}


public class RPASystem
{
    private Process _process;
    private SecurityManager _securityManager;
    private Robot _robot;

    public RPASystem()
    {
        _process = new Process();
        _securityManager = new SecurityManager();
        _robot = new Robot();
    }

    public void Start()
    {
        // Checking access via SecurityManager
        bool hasAccess = _securityManager.CheckProcess();
        if (hasAccess)
        {
            // Execute the process via Process
            _process.Execute();

            // Verifying robot credentials
            _robot.IsCredentialsRobot();
        }
        else
        {
            Console.WriteLine("Access is denied");
        }
    }
}

// Example of using RPASystem
public class Program
{
    public static void Main(string[] args)
    {
        RPASystem rpaSystem = new RPASystem();
        rpaSystem.Start();
    }
}

