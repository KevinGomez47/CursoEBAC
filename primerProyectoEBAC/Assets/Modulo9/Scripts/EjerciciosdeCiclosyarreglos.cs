using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EjerciciosdeCiclosyarreglos : MonoBehaviour {
    //Sumando dos arrays unidimensionales
    public Text canvasText;
    public Canvas canvas;
    int[] firtsArray = new int[8];
    int[] secondArray = new int[12];
    int[] thirdArray = new int[12];
    float canvasTextYPos;
    float canvasTextXPos;
    //Concatenando array de strings
    string[] myFrase = new string[] {
        "Es",
        "eso",
        "o",
        "pagar",
        "impuestos"
    };

    //Multiplicando un arreglo bidimensional con uno unidimensional
    int[,] myMatrix = new int[2, 3] {
        { 15, 36, 82 },
        { 56, 97, 40 }
    };
    int[] myVector = new int[3] { 87, 46, 22 };
    int[] myResult = new int[2];
    // Start is called before the first frame update
    void Start()
    {
        //Sumando dos arrays unidimensionales
        canvasTextYPos = canvasText.transform.position.y;
        for (int i = 0; i < 12; i++) {
            secondArray[i] = Random.Range(2, 100);
            if (i < firtsArray.Length) {
                firtsArray[i] = Random.Range(2, 100);
                thirdArray[i] = firtsArray[i] + secondArray[i];
            } else {
                thirdArray[i] = secondArray[i];
            }
            Text tempText = Instantiate(canvasText);
            tempText.transform.SetParent(canvas.transform, false);
            tempText.text = thirdArray[i].ToString();
            tempText.name = $"Ind {i}";
            tempText.transform.position = new Vector3(canvasText.transform.position.x,
                                                      canvasTextYPos -= canvasText.GetComponent<RectTransform>().rect.height,
                                                      canvasText.transform.position.z);
        }

        //Concatenando array de strings
        canvasTextXPos = canvasText.transform.position.x;
        Text tempTextForString = Instantiate(canvasText);
        tempTextForString.transform.SetParent(canvas.transform, false);
        tempTextForString.text = "";
        tempTextForString.verticalOverflow = VerticalWrapMode.Overflow;
        foreach (string x in myFrase) { tempTextForString.text += $"{x} "; };
        tempTextForString.name = "myFrase";
        tempTextForString.transform.position = new Vector3(canvasTextXPos += canvasText.GetComponent<RectTransform>().rect.width,
                                                           canvasText.transform.position.y,
                                                           canvasText.transform.position.z);

        //Multiplicación de matriz por vector
        for(int x = 0; x < myMatrix.GetLength(0); x++) {
            var arraySum = 0;
            for (int y = 0; y < myMatrix.GetLength(1); y++) {
                arraySum += myMatrix[x, y] * myVector[y];
                if(y == myMatrix.GetLength(1) - 1) {
                    myResult[x] = arraySum;
                }
            };
        };

        Text tempTextForMatrix = Instantiate(canvasText);
        tempTextForMatrix.transform.SetParent(canvas.transform, false);
        tempTextForMatrix.text = "Matrix Values are: ";
        tempTextForMatrix.verticalOverflow = VerticalWrapMode.Overflow;
        for(int i = 0; i < myResult.Length; i++) {
            tempTextForMatrix.text += myResult[i];
            if (i == 0) tempTextForMatrix.text += "/";
        }
        tempTextForString.name = "MatrixValues";
        tempTextForMatrix.transform.position = new Vector3(canvasTextXPos += canvasText.GetComponent<RectTransform>().rect.width,
                                                           canvasText.transform.position.y,
                                                           canvasText.transform.position.z);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
