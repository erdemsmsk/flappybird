using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boruspawner : MonoBehaviour
{

    public Birdy Birdscpript;
    public GameObject borular;
    public float height;
    public float time;


    private void Start()
    {
        StartCoroutine(spawnObject(time));
    }

    public IEnumerator spawnObject( float time)
    {

        while (!Birdscpript.isDead) 
        {

            Instantiate(borular, new Vector3(3, Random.Range(-height, height),0), Quaternion.identity);

            yield return new WaitForSeconds(1f);
        }
        

    }

}
