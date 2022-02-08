using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simulation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[,] firstarray = new int[2, 2] { {1, 2},{3, 4} };
        int[,] secarray = new int[2, 2] { { 10, 20 }, { 30, 40 } };
        int[] newarray = new int[2] { 1101, 1102 };
        matrix a = new matrix(firstarray);
        matrix b = new matrix(secarray);

        //b.setElement(1, 1, 99);
        //a.printMatrix();
        //a.getElemet(0, 1);
        //a.insertRow(newarray, 0);
        //a.setRow(1, newarray);
        //a.setCol(1, newarray);
        //a.swapRows(0, 1);
        //a.swapCols(0, 1);
        //a.addMatrix(b);
        //a.setMatrix(1);
        //a.RowSet(0, 8);
        a.ColSet(0, 8);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
