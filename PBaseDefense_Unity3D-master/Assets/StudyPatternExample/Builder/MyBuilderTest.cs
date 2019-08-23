using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBuilderTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
        MyDirector theDirector = new MyDirector();
        MyBuilderProduct product = null;

        theDirector.Construct(new MyConBuilderA());
        product = theDirector.GetResult();
        product.ShowProduct();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
