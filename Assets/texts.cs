using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEditor;

public class texts : MonoBehaviour {
	List<int> data=new List<int>() { 50, 5, 3, 85, 65, 21, 4, 9, 6 };
    //选择排序
    /*public  void Numbers()
	{
		
		for (int i = 0; i <data.Count-1; i++)
		{
			int min = i;
			int temp = data[i];
			for (int j = 1+i; j < data.Count; j++)
			{
				if (data[j]<temp)
				{
					min = j;
					temp = data[j];
				}
			}
			int num = data[min];
			data[min] = data[i];
			data[i] = num;
		}
		for (int i = 0; i < data.Count-1; i++)
		{
			Debug.Log(data[i]);
		}
		
	}*/
    //冒泡排序
    /*public void Numbers()
	{

		for (int i = 0; i < data.Count - 1; i++)
		{
			for (int j = 0; j < data.Count-i-1; j++)
			{
				if (data[j] > data[j+1])
				{
					int num = data[j];
					data[j] = data[j + 1];
					data[j + 1] = num;
				}
			}
		}
		for (int i = 0; i < data.Count - 1; i++)
		{
			Debug.Log(data[i]);
		}

	}*/


    //插入排序

    public void Numbers()
    {

        for (int i = 1; i < data.Count; i++)
        {
            int temp = data[i];
            for (int j = i - 1; j < i; j--)
            {
                if (data[j] > temp)
                {
                    data[j + 1] = data[j];
                    if (j == 0)
                    {
                        data[0] = temp;
                        break;
                    }
                }
                else
                {
                    data[j + 1] = temp;
                    break;
                }
            }
        }
        for (int i = 0; i < data.Count - 1; i++)
        {
            Debug.Log(data[i]);
        }

    }

    //快速排序
    public void Numbers()
	{

	}
	public void Swap(int[] num,int i,int j)
	{
		int temp = num[i];
		num[i] = num[j];
		num[j]=temp;
	}
	void Awake()
	{
		Numbers();
	}
	

}

