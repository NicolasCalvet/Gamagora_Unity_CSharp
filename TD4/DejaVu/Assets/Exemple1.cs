using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exemple1 : MonoBehaviour
{
    public int identifiant;
    int x;
    void Start() {
        identifiant = 3;
        x = 1;
    }

    void Update() {
        Debug.Log("Identifiant : " + identifiant);
        Debug.Log("X : " + x);
    }
}
