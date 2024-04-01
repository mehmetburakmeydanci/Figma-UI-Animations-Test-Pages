using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class CantCraftScript : MonoBehaviour
{
    public Button craftButton;
    public float delayTime = 10f;

    void Start()
    {
        craftButton.onClick.AddListener(CraftButtonClickHandler);
    }

    void CraftButtonClickHandler()
    {
        transform.DOScale(0.8f, 0.1f)
            .OnComplete(() => transform.DOScale(1f, 0.1f));

        string sceneToLoad = "InventorySceneCraft";

        SceneManager.LoadScene(sceneToLoad);

        
        Invoke("LoadNextSceneAfterDelay", delayTime);
    }

    void LoadNextSceneAfterDelay()
    {
        string sceneToLoad = "InventorySceneCantCraft";
        SceneManager.LoadScene(sceneToLoad);
    }
}
