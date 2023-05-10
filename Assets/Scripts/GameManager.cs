using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public string gameScene1 = "GameScene1";
    public string gameScene2 = "GameScene2";

    private int finishCount = 0;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void FinishReached()
    {
        finishCount++;
        if (finishCount % 2 == 0)
        {
            SceneManager.LoadScene(gameScene1);
        }
        else
        {
            SceneManager.LoadScene(gameScene2);
        }
    }
}
