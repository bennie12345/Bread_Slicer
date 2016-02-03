using UnityEngine;
using System.Collections;

public class BreadSpawner : MonoBehaviour {

    [SerializeField]
    private GameObject baguette;
    private Vector3 throwForce = new Vector3(0, 30, 0);

    void Start()
    {
        InvokeRepeating("SpawnBread", 0.5f, Random.Range(1,4));
    }

    void SpawnBread()
    {
        for (byte i = 0; i < Random.Range(1,3); i++)
        {
            GameObject Bread = Instantiate(baguette, new Vector3(Random.Range(10, 30), Random.Range(-25, -35), -32), Random.rotation) as GameObject;
            Bread.GetComponent<Rigidbody>().AddForce(throwForce, ForceMode.Impulse);
        }
    }

}
