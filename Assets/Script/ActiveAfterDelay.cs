using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveAfterDelay : MonoBehaviour
{
    public List<GameObject> gmbList;

    public float delay;

    void Start()
    {
       foreach(GameObject gmb in gmbList)
        {
            gmb.SetActive(false);
        }

        StartCoroutine(Delay());
    }

    IEnumerator Delay ()
    {
        yield return new WaitForSeconds(delay);
        foreach (GameObject gmb in gmbList)
        {
            gmb.SetActive(true);
        }
    }
}
