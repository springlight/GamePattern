using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBriderTest : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        MyRenderEngine render = new MyDirectX();
        MyIShape shape = new MySphere();
        shape.SetRenderEngine(render);
        shape.Draw();
        MyRenderEngine renderOpenGl = new MyOpenGL();
        shape.SetRenderEngine(renderOpenGl);
        shape.Draw();
        
	}
	
	
}
