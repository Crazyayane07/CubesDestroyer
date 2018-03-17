using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputFieldControl : MonoBehaviour {
    const int DEFAULT_ENEMIES_NUMBER = 10;
    public static int enemies = DEFAULT_ENEMIES_NUMBER;

    public void GetInput(string input)
    {
        enemies = int.Parse(input);
    }

    public static int getEnemiesNumber()
    {
        return enemies;
    }
}
