using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCompositeTest : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        MyIComponent theRoot = new MyComposite("Root");
        theRoot.Add(new MyLeaf("叶子111"));
        theRoot.Add(new MyLeaf("叶子222"));

        MyIComponent theChild1 = new MyComposite("子节点1");
        theChild1.Add(new MyLeaf("子节点1的叶子1"));
        theChild1.Add(new MyLeaf("子节点2的叶子2"));

        theRoot.Add(theChild1);
        theRoot.Operation();

        MyLeaf myLeaf = new MyLeaf("111");
        myLeaf.Add(new MyLeaf("2222"));
        myLeaf.Operation();
    }
	
	
}
