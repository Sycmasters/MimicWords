using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public List<string> wordsDisplay = new List<string>();
    public static List<string> words = new List<string>();

    private static Game _instance;
    public static Game Instance
    {
        get
        {
            if (_instance == null) { _instance = FindObjectOfType<Game>(); }
            return _instance;
        }
    }

    public void ShowWords ()
    {
        wordsDisplay = words;
    }
}
