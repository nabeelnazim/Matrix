using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class matrix
{
    public int lengthrow;
    public int lengthcol;
    public List<List<int>> list1 = new List<List<int>>();
    public List<int> listToSetRow = new List<int>();
    public List<int> listToSetCol = new List<int>();
    public List<int> listToSwapCols = new List<int>();
    public List<int> listToSwapCols2 = new List<int>();
    public matrix(int[,] ab)
    {
        
        for (int row = 0; row < ab.GetLength(0); row++)
        {

            list1.Add(new List<int>());
            for (int col = 0; col < ab.GetLength(1); col++)
            { 
                list1[row].Add(ab[row, col]);
            }
        }
        lengthrow = ab.GetLength(0);
        lengthcol = ab.GetLength(1);
    }

    
    public void printMatrix()
    {
        string toDisplay = ""    ;
        for (int row = 0; row < list1.Count; row++)
        {
            for (int col = 0; col < list1[0].Count; col++)
            {
                toDisplay+= list1[row][col]+"   ";
            }
            toDisplay +="\n";
        }
        Debug.Log(toDisplay);
    }
    public void setElement(int rownumber,int colnumber, int value)
    {
        list1[rownumber][colnumber] = value;
    }
    public int getElemet(int rownumber,int colnumber)
    {
        return list1[rownumber][colnumber];
    }
    public void insertRow(int[] arr,int rownumber)
    {
        int newrow = rownumber;
        for (int col = 0; col < arr.GetLength(0); col++)
        {
            list1[rownumber].Add(arr[col]);
        }
        printMatrix();
    }
    public void setRow(int rownumber,int[] array)
    {
        for (int col = 0; col < array.GetLength(0); col++)
        {
            listToSetRow.Add(array[col]); //convert array to list
        }
        list1[rownumber] = listToSetRow; //replace row[given number] with the given array
        printMatrix();
    }
    public void setCol(int colnumber, int[] colarray)
    {
        for(int col = 0; col < colarray.GetLength(0); col++)
        {
            listToSetCol.Add(colarray[col]);
        }

        for(int row = 0; row < listToSetCol.Count; row++)
        {
            list1[row][colnumber] = listToSetCol[row];
        }
        printMatrix();
    }
    public void swapRows(int row1,int row2)
    {
        List<int> listToSwapRows = new List<int>(list1[row1]);
        List<int> rowsecnd = new List<int>(list1[row2]);
        list1[row1] = rowsecnd;
        list1[row2] = listToSwapRows;
        printMatrix();
    }
    public void swapCols(int col1, int col2)
    {
        for(int row = 0; row < list1[0].Count; row++)
        {
            listToSwapCols.Add(list1[row][col1]);
            listToSwapCols2.Add(list1[row][col2]);
        }
        for(int row = 0; row < listToSwapCols.Count; row++)
        {
            list1[row][col2] = listToSwapCols[row];
        }
        for (int row = 0; row < listToSwapCols2.Count; row++)
        {
            list1[row][col1] = listToSwapCols2[row];
        }
        printMatrix();
    }
    public void addMatrix(matrix b)
    {
        List<List<int>> c = new List<List<int>>(); 
       
        for (int row = 0; row < b.lengthrow; row++)
        {
            c.Add(new List<int>());
            for (int col = 0; col < b.lengthcol; col++)
            {
                c[row].Add(list1[row][col]+b.list1[row][col]);
            }
        }
       
        for (int row = 0; row < c.Count; row++)
        {
            for (int col = 0; col < c[0].Count; col++)
            {
                Debug.Log(c[row][col]);
                
            }
        }
    }
    public void setMatrix(int number)
    {
        for(int row=0; row < list1[0].Count; row++)
        {
            for(int col = 0; col < list1[1].Count; col++)
            {
                list1[row][col]=number;
            }
        }
        printMatrix();
    }
    public void RowSet(int rownumber, int number)
    {
        for (int col = 0; col < list1.Count; col++)
        {
            list1[rownumber][col] = number;
        }
        
        printMatrix();
    }
    public void ColSet(int colnumber, int number)
    {
        for (int row = 0; row < list1.Count; row++)
        {
            list1[row][colnumber] = number;
        }
        printMatrix();
    }
    public int GetRow(int rownumber)
    {
        List<int> newlist = new List<int>();
        for (int row = 0; row < list1.Count; row++)
        {
            newlist[row] = list1[rownumber][row];
        }
        return newlist[rownumber];
    }
}
