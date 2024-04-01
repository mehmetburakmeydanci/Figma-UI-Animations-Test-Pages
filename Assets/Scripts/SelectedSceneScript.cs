using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class InventoryButtonManager : MonoBehaviour
{
    public Button selectButton;

    void Start()
    {
        selectButton.onClick.AddListener(SelectButtonClickHandler);
    }

    void SelectButtonClickHandler()
    {
        transform.DOScale(0.8f, 0.1f)
            .OnComplete(() => transform.DOScale(1f, 0.1f));

        string sceneToLoad = "InventorySceneSelected";

        SceneManager.LoadScene(sceneToLoad);
    }
}
