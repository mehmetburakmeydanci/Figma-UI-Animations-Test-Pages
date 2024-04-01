using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class CraftButtonManager : MonoBehaviour
{
    public Button craftButton;

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

        // "InventorySceneCraft" sahnesine geçildikten 10 saniye sonra başka bir sahneye geçiş yap
        DOVirtual.DelayedCall(10f, () =>
        {
            string nextSceneToLoad = "InventorySceneCantCraft";
            SceneManager.LoadScene(nextSceneToLoad);
        });
    }
}
