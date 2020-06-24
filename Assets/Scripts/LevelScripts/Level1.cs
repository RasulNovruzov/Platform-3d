using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        RedirectToLevel.redirectToLevel = 1;
        RedirectToLevel.nextLevel = 2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
