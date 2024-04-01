using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class ButtonAnimationAndSceneTransition : MonoBehaviour
{
    public Button inventoryButton; 

    void Start()
    {
        
        inventoryButton.onClick.AddListener(ClickHandler);
    }

    void ClickHandler()
    {
        
        transform.DOScale(0.8f, 0.1f) 
            .OnComplete(() => transform.DOScale(1f, 0.1f)); 

        
        string sceneToLoad = "InventoryScene";

       
        SceneManager.LoadScene(sceneToLoad);
    }
}

