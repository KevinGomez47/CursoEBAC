using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class integers : MonoBehaviour
{
    sbyte miSbyte = 0;
    byte miByte = 0;
    // short miShort = 1;
    // ushort miUShort = 0;
    int miInt = 0;
    uint miUint = 0;
    long miLong = long.MaxValue;
    // ulong miULong = 0;

    // Start is called before the first frame update
    void Start()
    {
        miSbyte = -25;
        miInt = miSbyte;
        print("El valor de mi Sbyte es " + miSbyte);
        print("El valor de mi Int es " + miInt);
        miByte = 200;
        miUint = miByte;
        miUint = (uint)miSbyte;
        print("El valor de mi Uint es " + miUint);
        miLong = long.MaxValue;
        miInt = (int)miLong;
        print("El valor de mi Int es " + miInt);

        int a, b, c;
        float f;
        a = 5;
        b = 10;
        c = a + b;
        print(c);
        c = a - b;
        print(c);
        f = a / b;
        print(f);
        c = a * b;
        print(c);

        miInt = Random.Range(a, b);
        if(miInt % 2 == 0) {
            print("El número " + miInt + " es par");
        } else {
            print("El número " + miInt + " es inpar");
        }
    }

    // Update is called once per frame
    void Update()
    {
        //miLong /= 2;
        //print(miShort);
    }
}
