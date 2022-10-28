using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestClass:MonoBehaviour
{
    // Start is called before the first frame update
   

    // Update is called once per frame
   
    public class Cat
    {
        public double Weight;
        public double Height;
        public Cat()
        {
            Weight = 100;
            Height = 10;
        }
        public Cat(int w, int h)
        {
            Weight = w;
            Height = h;
        }
        public void Info()
        {
            Debug.Log(Height + " " + Weight);
        }
    }
    private void Start()
    {
        Cat BlackCat = new Cat();
        BlackCat.Info();
    }
}
