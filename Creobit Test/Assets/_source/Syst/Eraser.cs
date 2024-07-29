using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eraser : MonoBehaviour
{
    public void EraseClicker()
    {
        PlayerPrefs.SetInt("Points", 0);
    }
    public void EraseWalker()
    {
        PlayerPrefs.SetInt("Score", 0);
    }
}
