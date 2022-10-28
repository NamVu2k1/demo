using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testLinkedList : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LinkedList<string> cacbaihoc = new LinkedList<string>();
        cacbaihoc.AddFirst("Bài học 3");   // thêm vào đầu danh sach
        cacbaihoc.AddLast("Bài học 4");    // thêm vào cuối
                                           // cacbaihoc.AddFirst("Bài học 2");
        cacbaihoc.AddFirst("Bài học 1");
        LinkedListNode<string> node = cacbaihoc.First;
        cacbaihoc.AddAfter(cacbaihoc.Find("Bài học 1"), "bai hoc 2");
        foreach (var bh in cacbaihoc)
        {
            Debug.Log(bh);
        }
        node = node.Previous;
        Debug.Log(node.Value) ;


       
        
        List<int> mylst = new List<int>();
        mylst.Add(1);
        mylst.Add(2);
        mylst.Add(3);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
