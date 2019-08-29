using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyInvoker
{
    List<MyCommand> myCommands = new List<MyCommand>();
    public void AddCommand(MyCommand theCommand)
    {
        myCommands.Add(theCommand);
    }

    public void ExecuteCommand()
    {
        foreach(MyCommand myCommand in myCommands)
        {
            myCommand.Execute();
        }

        myCommands.Clear();
    }
}
