using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pourDrink : MonoBehaviour
{
    public GameObject CokeStream;
    public Transform cokeCan;
    public Transform canTop;

    private bool isPouring = false;
    private bool pourCheck;
    public float canMidHeight;
    public float canTopHeight;

    // Update is called once per frame
    private void Update()
    {
        canMidHeight = cokeCan.position.y;
        canTopHeight = canTop.position.y;

        if ((canTopHeight - canMidHeight) > 0)
        {
            pourCheck = true;
        }
        else
        {
            pourCheck = false;
        }

        if (isPouring != pourCheck)
        {
            isPouring = pourCheck;

            if (isPouring)
            {
                CokeStream.SetActive(true);
            }
            else
            {
                CokeStream.SetActive(false);
            }
        }
    }
}
