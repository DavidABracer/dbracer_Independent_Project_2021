using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformAttach : MonoBehaviour
{

    public GameObject ThirdPersonCharacter;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == ThirdPersonCharacter)
        {

            ThirdPersonCharacter.transform.parent = transform;
        }

    }
    private void OnTriggerExit(Collider other)

    {
        if (other.gameObject == ThirdPersonCharacter)
        {
            ThirdPersonCharacter.transform.parent = null;
        }


    }
}



