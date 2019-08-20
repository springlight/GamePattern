using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFactoryTest : MonoBehaviour {

    MyProduct theProduct = null;
    MyFactory theFactory = null;
	// Use this for initialization
	void Start () {
        //theFactory = new ConProductAFactory();
        //theProduct = theFactory.FactoryMethod();


        //theFactory = new ConProductBFactory();
        //theProduct = theFactory.FactoryMethod();

        MyGenericFactory<ConProductA> factory = new MyGenericFactory<ConProductA>();
        factory.FactoryMethod();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
