using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SimpleLevelLoader
{
    public class SceneLoadup : MonoBehaviour
    {
        //need a feature that loads X scene when trigger is collided with
        [SerializeField] private int sceneToLoad;

        private void OnTriggerEnter(Collider other)
        {
            //IF it is the PLAYER that has triggered this event...
            if (other.tag == "Player")
            {
                // LOAD THE SPECIFIED SCENE
                SceneManager.LoadScene(sceneToLoad);
            }
        }
    }
}


