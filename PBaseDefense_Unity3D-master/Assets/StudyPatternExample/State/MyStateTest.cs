using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyStateTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
        UnitTest();

    }
	
	void UnitTest()
    {
        MyContext myContext = new MyContext();
        myContext.SetState(new ConStateA(myContext));
        myContext.Request(5);
        myContext.Request(15);
        myContext.Request(25);
        myContext.Request(35);
    }
}
