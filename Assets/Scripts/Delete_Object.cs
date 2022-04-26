using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete_Object : MonoBehaviour
{
    public AudioClip moneySound;
    private void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.CompareTag("money"))
        {
            AudioSource.PlayClipAtPoint(moneySound, transform.position, .2f);
            other.gameObject.SetActive(false);
        }
    }
}
