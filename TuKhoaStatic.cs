using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TuKhoaStatic : MonoBehaviour
{
    // Start is called before the first frame update
    public class cat
    {
        private int weight;
        private int height;
        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public int Height
        {
            get { return height; }
            set { height = value; }
        }
        public static int Count = 0;

        public cat()
        {
            weight = 2;
            height = 100;
            Count += 1;
        }
        static cat()
        {
            Debug.Log("phuong thuc khoi tao tinh");
        }
       
    }

    class tienich
    {
   
        public static long LuyThua(int CoSo, int SoMu)
        {
            long KetQua = 1;
            for (int i = 0; i < SoMu; i++)
            {
                KetQua *= CoSo;
            }
            return KetQua;
        }
    }
  
    class MauSac
    {
        public static string MauChuDao;
        static MauSac()
        {
            DateTime now = DateTime.Now;
            switch (now.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    MauChuDao = "Blue";
                    break;
                case DayOfWeek.Tuesday:
                    MauChuDao = "Red";
                    break;
                case DayOfWeek.Wednesday:
                    MauChuDao = "Purple";
                    break;
                case DayOfWeek.Thursday:
                    MauChuDao = "Pink";
                    break;
                case DayOfWeek.Friday:
                    MauChuDao = "Black";
                    break;
                case DayOfWeek.Saturday:
                    MauChuDao = "Green";
                    break;
                case DayOfWeek.Sunday:
                    MauChuDao = "Yellow";
                    break;
            }
        }
       
    }

    private void Start()
    {
        Debug.Log("so meo: " + cat.Count);
        cat BlackCat = new cat();
        Debug.Log("so meo: " + cat.Count);
        cat WhiteCat = new cat();
        Debug.Log("so meo: " + cat.Count);
        Debug.Log("mau chu dao cua hom nay:" + MauSac.MauChuDao);
    }
}
