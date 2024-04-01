using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class ButtonClickHandler : MonoBehaviour
{
    public Button button;

    void Start()
    {
        button.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        transform.DOScale(new Vector3(1.1f, 1.1f, 1.1f), 0.2f)
            .OnComplete(() => LoadGameScene());
    }

    void LoadGameScene()
    {
        SceneManager.LoadScene("GameScene");
    }
}
