using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    [SerializeField]
    public string nextLevel = "Level 0";

    private GameManager gameManager;

    private void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.layer == 3)
            gameManager.LoadLevel(nextLevel);
    }
}
