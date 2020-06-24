using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        RedirectToLevel.redirectToLevel = 2;
        RedirectToLevel.nextLevel = 3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
