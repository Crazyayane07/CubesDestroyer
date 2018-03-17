using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    void OnMouseDown()
    {
        Game.score += 1;
        Destroy(gameObject);
    }
}
