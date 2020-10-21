using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reservoir : MonoBehaviour
{

    private double essence;

    public Reservoir() {
        essence = 10;
        Debug.Log("Essence :" + essence);
    }

    public double getEssence() {
        return essence;
    }

    public void setEssence(double valeur) {
        essence = valeur;
    }

    public bool roule(double consommation) {
        if (essence > 0) {
            essence -= consommation;
        }
        return essence > 0;
    }
}
