using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTrigger : MonoBehaviour
{
    [SerializeField] private string GameScene;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("player°¡ ºÎ‹HÈû");
            SceneManager.LoadScene(GameScene);
        }
        Debug.Log(other.gameObject.name);
    }
}
