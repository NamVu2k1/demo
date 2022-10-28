using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class overload : MonoBehaviour
{
    // Start is called before the first frame update
   public class DemoOverload
   {
        public int Sum(int a, int b)
        {
            return (a + b);
        }
        public float Sum(int a, float b)
        {
            return (a + b);
        }

        public string GetName(string name)
        {
            return name;
        }
        public string GetName(int mssv)
        {
            return mssv.ToString();
        }
   }

    private void Start()
    {
        DemoOverload sv1 = new DemoOverload();
        Debug.Log(sv1.Sum(5, 6));
        Debug.Log(sv1.GetName("nam"));
    }


}
