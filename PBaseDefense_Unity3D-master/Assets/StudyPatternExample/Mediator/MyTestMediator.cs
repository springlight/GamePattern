using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyTestMediator : MonoBehaviour {

	// Use this for initialization
	void Start () {
        MyConcreteMediator p = new MyConcreteMediator();
        ConColleageOne c1 = new ConColleageOne(p);
        ConColleageTwo c2 = new ConColleageTwo(p);

        p.SetM1(c1);
        p.SetM2(c2);

        c1.Action();
        c2.Action();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
