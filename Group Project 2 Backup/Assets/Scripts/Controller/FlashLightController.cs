using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLightController : MonoBehaviour
{
   /* //bool for detecting if flashlight is on or not
    public bool isOn = false;

    //variable will be used to reference a spotlight in the game
    public GameObject flashLight;

    //failsafe for flashlight logic found in the void Update function
    public bool failSafe = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (isOn == false && failSafe == false)
            {
                failSafe = true;
                flashLight.SetActive(true);
                isOn = true;
                StartCoroutine(FailSafe());
            }
            if (isOn == true && failSafe == false)
            {
                failSafe = true;
                flashLight.SetActive(false);
                isOn = false;
                StartCoroutine(FailSafe());
            }
        }
    }

    IEnumerator FailSafe()
    {
        yeild return new WaitForSeconds(0.25f);
        failSafe = false;
    }*/
}
