using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCommandTest : MonoBehaviour {

	// Use this for initialization
	void Start () {

        MyInvoker myInvoker = new MyInvoker();
        MyCommand command = null;
        command = new ConCommand1(new MyReceiver1(), "你好");
        myInvoker.AddCommand(command);
        command = new ConCommand2(new MyReceiver2(), 999);
        myInvoker.AddCommand(command);

        myInvoker.ExecuteCommand();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
