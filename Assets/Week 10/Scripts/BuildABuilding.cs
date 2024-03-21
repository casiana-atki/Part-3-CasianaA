using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildABuilding : MonoBehaviour
    
{
    public GameObject roof;
    public GameObject left; 
    public GameObject right;
    float interpolation = 8;
    public AnimationCurve animCurve;
    float growthSpeed1;
    float growthSpeed2;
    float growthSpeed3;

    Coroutine buildingScale; 

    void Start()
    {
        if (buildingScale != null)
        {
            StopCoroutine(buildingScale);
        }
        buildingScale = StartCoroutine(CreateBuilding());
    }

    void Update()
    {
        //Controls the growth of the 3 pieces and scales them individually via the 3 growth speeds 
        growthSpeed1 += 0.1f * Time.deltaTime;
        right.transform.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, (interpolation) * growthSpeed1);

        growthSpeed2 += 0.1f * Time.deltaTime;
        left.transform.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, (interpolation) * growthSpeed2);

        growthSpeed3 += 0.1f * Time.deltaTime;
        roof.transform.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, (interpolation) * growthSpeed3);
    }

    IEnumerator CreateBuilding()
    {
        right.transform.localScale = Vector3.zero;
        growthSpeed1 = 0;
        //Since the objects start "off" or inactive, this part will set the 3 pieces to be active and then scale in order
        right.SetActive(true);
        yield return new WaitForSeconds(2f);

        left.transform.localScale = Vector3.zero;
        growthSpeed2 = 0;
        left.SetActive(true);
        yield return new WaitForSeconds(2f);

        roof.transform.localScale = Vector3.zero;
        growthSpeed3 = 0;
        roof.SetActive(true);

    }
}
