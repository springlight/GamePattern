using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBuilderProduct
{
    private List<string> m_Part = new List<string>();
    public MyBuilderProduct() { }

    public void AddPart(string part)
    {
        m_Part.Add(part);
    }

    public void ShowProduct()
    {
        foreach(string part in m_Part)
        {
            Debug.LogError("part--->" + part);
        }
    }
}
