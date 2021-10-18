using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpwner : MonoBehaviour
{
    public GameObject ObejectToSpwan;
     PlacementIndecator placementIndecator;
    // Start is called before the first frame update
    void Start()
    {
        placementIndecator = FindObjectOfType<PlacementIndecator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount >0 && Input.touches[0].phase == TouchPhase.Began )
        {
            GameObject obj = Instantiate(ObejectToSpwan, placementIndecator.transform.position, placementIndecator.transform.rotation);
        }
    }
}
