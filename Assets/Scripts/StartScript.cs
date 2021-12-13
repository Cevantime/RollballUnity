using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour
{
    public GameObject ballPrefab;
    // Start is called before the first frame update
    void Start()
    {
        ResetBall();
    }

    public void ResetBall()
    {
        // Instanciation de la balle à partir du prefab de balle
        GameObject ball = Instantiate<GameObject>(ballPrefab);

        // Placement de la balle au niveau du carré bleu
        ball.transform.position = transform.position;
        ball.transform.Translate(Vector3.up * 0.505f);
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
