using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOEDAS : MonoBehaviour
{
    public GameObject Door;

    void OnTriggerEnter(Collider col)
    {
        Door.SetActive(false);
        Destroy(this.gameObject);

    }
}
