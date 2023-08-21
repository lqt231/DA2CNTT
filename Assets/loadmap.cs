using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using ThunderWire.Helpers;
namespace HFPS.Systems
{
public class loadmap : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("SceneLoader2");
    }
}
}