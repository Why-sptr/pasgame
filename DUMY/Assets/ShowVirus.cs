using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowVirus : MonoBehaviour
{

    public GameObject virus;
    public float timeMinimum, timeMaximum;
    public float positionMinimum, positionMaximum;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ShowingVirus());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator ShowingVirus()
    {
        Instantiate(virus, transform.position + Vector3.right * Random.Range(positionMinimum, positionMaximum)
            , Quaternion.identity);
        yield return new WaitForSeconds(Random.Range(timeMinimum,timeMaximum));
        StartCoroutine(ShowingVirus());
    }
}
