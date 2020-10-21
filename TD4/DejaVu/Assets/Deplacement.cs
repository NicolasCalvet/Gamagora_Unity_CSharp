using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deplacement : MonoBehaviour
{
    [Range(0, 20)]
    public float speed;
    public float acceleration;

    private Reservoir reservoir;

    public double consommation = 0.1;

    void Start() {
        reservoir = new Reservoir();
    }

    // Update is called once per frame
    void Update()
    {

        float horizontal = Input.GetAxis("Vertical");

        if (horizontal > 0) {
            speed += acceleration;
        } else if (horizontal < 0) {
            speed -= acceleration;
        }

        if (reservoir.roule(consommation * Time.deltaTime * speed)) { // consommation per second depending on the speed
            Vector3 vecteur = new Vector3(0, 0, 1);
            gameObject.transform.position += Time.deltaTime * speed * vecteur;
        }
    }
}
