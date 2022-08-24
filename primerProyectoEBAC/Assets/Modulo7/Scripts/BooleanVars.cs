using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BooleanVars : MonoBehaviour
{
    //bool var1;
    //bool var2;
    //bool var3;
    int value1;
    int higher = 5;
    int lower = -5;
    enum colorSelection {
        red,
        green,
        blue,
        white,
        grey
    }

    // A B C   OR  AND ((A or B) && C) ((A or B) or C)
    // 1 1 1    1   1          1               1
    // 1 1 0    1   0          0               1
    // 1 0 1    1   0          1               1
    // 1 0 0    1   0          0               1
    // 0 1 1    1   0          1               1
    // 0 1 0    1   0          0               1
    // 0 0 1    1   0          0               1
    // 0 0 0    0   0          0               0

    // Start is called before the first frame update
    void Start()
    {
        //var1 = true;
        //var2 = false;
        //var3 = false;
        //if((var1 || var2) && var3) {
        //    print("Firts operation is false");
        //} else if((var1 || var2) || var3) {
        //    if (var1) print("var1 is true");
        //    print("Second operation is true");
        //} else if ((var3 && var2) || var1) {
        //    print("Therd operacion is true");
        //}

        value1 = Random.Range(lower, higher);

        print(value1);

        //if (value1 < 0) print("value is negative");
        //else if (value1 == 0) print("value is neutral");
        //else print("value is positive");

        //switch (value1) {
        //    case (int)colorSelection.red:
        //        print("The color ir red");
        //        break;
        //    case (int)colorSelection.green when var1:
        //        print("The color ir green");
        //        break;
        //    case (int)colorSelection.blue when var1:
        //        print("The color ir blue");
        //        break;
        //    case (int)colorSelection.white:
        //        print("The color ir white");
        //        break;
        //    case (int)colorSelection.grey:
        //        print("The color ir grey");
        //        break;
        //    default:
        //        print("This value does not exist");
        //        break;
        //}

        // Operador unario
        print((value1 >= 0) ? "Value is positive" : "Value el negative");
        


        //if (var1) {
        //    print("This var is " + var1);
        //    print("Now, you can sleep knowing var1 value");
        //};



        //if(value1 <= 5) {
        //    print("value1 is lower or iquals to 5");
        //};

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
