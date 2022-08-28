using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EjerciciosVariablesMod8 : MonoBehaviour
{
    int myInt;
    float myFloat = 1.0f;
    float myFloatForCastingOne = 9.5f;
    float myFloatForCastingTwo = 8.6f;
    int myIntForCasting;
    public float firstFloat = 0.1234f;
    public float secondFloat = 0.5678f;
    float floatResult;
    public string myString = "White";
    public Text myFloatOnCanvas;
    public Text myIntOnCanvas;
    public Text myUintOnCanvas;
    public Text isEvenOrOdd;
    public MeshRenderer cubeForModule;
    public MeshRenderer cubeForString;
    public Text FloatToStringOnCanvas;
    string myName = "Kevin Gomez Gallegos";
    public Text MyNameInParts;
    string firstNumber = "3856";
    string secondNumber = "1536";
    public Text TryParseValue;
    public string onlyEvenChars = "Default text for modulo operation";
    public Text onlyEvenOnCanvas;
    public string stringToCut = "Default text for cut operation";
    public Text stringToCutOnCanvas;
    // Start is called before the first frame update
    void Start()
    {
        float myFloatResult = myFloatForCastingOne * myFloatForCastingTwo;
        myIntForCasting = (int)myFloatResult;
        myUintOnCanvas.text = $"Explicit Casting {myIntForCasting}";
        var name = myName.Substring(0, 5);
        var middleName = myName.Substring(6, 5);
        var lastName = myName.Substring(12);
        MyNameInParts.text = $"My name is\n{name} {middleName} {lastName}";
        string[] myNameList = myName.Split(' ');
        foreach(var i in myNameList) {
            Debug.Log(i);
        }
        if (int.TryParse(firstNumber.ToString(), out int firstStringNumber) &&
            int.TryParse(secondNumber.ToString(), out int secondStringNumber)) {
            TryParseValue.text = $"Try Parse Value {firstStringNumber * secondStringNumber}";
        } else {
            TryParseValue.text = $"Try Parse Value fail";
        }
        for (int i = 0; i < onlyEvenChars.Length; i++) {
            if (i == 0) onlyEvenOnCanvas.text += "\n";
            if (i % 2 == 0) onlyEvenOnCanvas.text += onlyEvenChars[i];
        }
        stringToCut = stringToCut.Substring(5);
        stringToCutOnCanvas.text = $"Cut five chars\n{stringToCut}";
    }

    // Update is called once per frame
    void Update()
    {
        myInt += 1;
        myIntOnCanvas.text = $"Int on Update {myInt}";

        if (myInt % 2 == 0) {
            isEvenOrOdd.text = "This number is even";
            cubeForModule.material.color = Color.white;
        } else {
            isEvenOrOdd.text = "This number is odd";
            cubeForModule.material.color = Color.black;
        }

        switch (myString) {
            case "Magenta":
                cubeForString.material.color = Color.magenta;
                break;
            case "Black":
                cubeForString.material.color = Color.black;
                break;
            case "Red":
                cubeForString.material.color = Color.red;
                break;
            case "Blue":
                cubeForString.material.color = Color.blue;
                break;
            case "Green":
                cubeForString.material.color = Color.green;
                break;
            case "Cyan":
                cubeForString.material.color = Color.cyan;
                break;
            case "Yellow":
                cubeForString.material.color = Color.yellow;
                break;
            default:
                cubeForString.material.color = Color.white;
                break;
        }

        floatResult = firstFloat * secondFloat;
        FloatToStringOnCanvas.text = $"Float To String {floatResult.ToString("N4")}";
    }

    void FixedUpdate() {
        myFloat *= 1.1f;
        myFloatOnCanvas.text = $"Float on FixedUpdate {myFloat}";
    }
}
