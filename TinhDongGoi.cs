using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TinhDongGoi : MonoBehaviour
{
    class sinhvien
    {
        private string mssv;
        private string hoten;
        private double diemtoan;
        private double diemvan;
        private double diemly;
        public double DiemLy
        {
            get { return diemly; }
            set { diemly = value; }
        }
        public void InThongTin()
        {
            double DTB = (diemtoan + diemvan) / 2;
            Debug.Log("sinh vien " + hoten + "diem tb:" + DTB);
        }
    }
    private void Start()
    {
        sinhvien sv1 = new sinhvien();
        sv1.DiemLy = 10;
        Debug.Log("diem ly " + sv1.DiemLy);
    }

}
