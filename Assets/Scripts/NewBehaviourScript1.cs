using UnityEngine;
using System.Collections;

public class NewBehaviourScript1 : MonoBehaviour
{
    public string die = "die";
    public int[] rir;
    public GameObject testObj;
    public TempStruct tempStruct;
    public TempClass tempClass;
    //public GameObject testObj2;
}

[System.Serializable]
public struct TempStruct
{
    public int b;
    public int c;
}

[System.Serializable]
public class TempClass
{
    public int c;
    public int d;
}