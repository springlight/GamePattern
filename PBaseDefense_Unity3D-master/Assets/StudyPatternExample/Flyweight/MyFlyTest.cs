using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFlyTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
        MyFlyweightFactor myFactory = new MyFlyweightFactor();
        myFactory.GetFlyweight("1", "共享组件1111");
        myFactory.GetFlyweight("2", "共享组件222");
        myFactory.GetFlyweight("3", "共享组件333");

        myFactory.GetFlyweight("1", "").Operator();

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
