using UnityEngine;

public class ArraysScript : MonoBehaviour
{
    private int[] _numbers =  new[] {1, -3, 5, -8, 6, 15, -24 };
    public int countNegative;
    private int _countPositive;

    private void Start()
    {
        foreach (int num in _numbers)
        {
            if (num > 0)
            {
                _countPositive++;
            }
            else
            {
                countNegative++;
            }
        }
        Debug.Log($"Колличество положительных элементов : {_countPositive}");
        
    }
    
}
