using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class IntData : ScriptableObject
{
    public int value;
    public int value2;

    public void ScoreChange(int num)
    {
        value += num;
    }
}
