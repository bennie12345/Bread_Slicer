using UnityEngine;
using System.Collections;

public class BreadController : MonoBehaviour {

    [SerializeField]
    private GameObject _breadSlice;

    private Vector3 rotationSpeed;

    private float minSpeed = 1;
    private float maxSpeed = 5;

    void Start()
    {
        rotationSpeed = new Vector3(Random.Range(minSpeed, maxSpeed), Random.Range(minSpeed, maxSpeed), Random.Range(minSpeed, maxSpeed));
    }

    void Update()
    {
        this.transform.Rotate(rotationSpeed);
        if(this.transform.position.y < -60f)
        {
            Destroy(this.gameObject);
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Player")
        {
            Vector3 tempLoc = this.transform.position;
            Destroy(this.gameObject);
            for(int i = 0; i < 2; i++)
            {
                Instantiate(_breadSlice, tempLoc, Random.rotation);
            }
        }
    }
}
