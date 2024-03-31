using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SahneGecis : MonoBehaviour
{
    public void sahneyiAc(string SecondScene)
    {
       SceneManager.LoadScene("SecondScene");
    }
}
