using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoPickup : MonoBehaviour
{
    [SerializeField]private GameObject AmmoText;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            StartCoroutine(AmmoAdded());
        }
    }
    IEnumerator AmmoAdded()
    {
        AmmoText.SetActive(true);
        yield return new WaitForSeconds(1);
        AmmoText.SetActive(false);
    }
}
