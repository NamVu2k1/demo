using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dictionary : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Dictionary<string, string> myDic = new Dictionary<string, string>();
        myDic.Add("V", "Vu");
        myDic.Add("Va", "Van");
        myDic.Add("Na", "Nam");
        myDic.Remove("V");
        if (myDic.ContainsKey("V")!)
        {
            Debug.Log(1);
        }    
       
        foreach (KeyValuePair<string,string> x in myDic)
        {
            Debug.Log(x.Value + " " + x.Key);
        }    
    }

}
