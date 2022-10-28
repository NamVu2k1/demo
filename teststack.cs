using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teststack : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ArrayList MyArray = new ArrayList();
        MyArray.Add(5);
        MyArray.Add(9);
        MyArray.Add(10);
       
        Stack MyStack3 = new Stack(MyArray);
        Stack stk = new Stack();
        stk.Push(1);
        stk.Push(2);
        stk.Push(3);
        stk.Pop();

        foreach (var x in stk)
        {
            Debug.Log(x);
        }
        
        Debug.Log(stk.Count);
        Debug.Log(MyStack3.Count);

        Stack<string> myStackString = new Stack<string>();
        myStackString.Push("11");

        Stack<int> myStackSInt1 = new Stack<int>();
        myStackSInt1.Push(1);
        myStackSInt1.Push(2);
        


       
       
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
