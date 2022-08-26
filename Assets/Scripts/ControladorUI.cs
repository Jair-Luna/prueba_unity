using UnityEngine;
using UnityEngine.UI;

public class ControladorUI : MonoBehaviour
{

    public static ControladorUI instance;
    
    public Image hambreImage;
    public Image energiaImage;
    public Image saludImage;
    public Image aseoImage;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else Debug.LogWarning("Mas de un controlador de UI en la escena");
    }

    public void updateImages(int hambre, int energia, int salud, int aseo)
    {         
        hambreImage.fillAmount = (float) hambre / 100;
        energiaImage.fillAmount = (float) energia / 100;
        saludImage.fillAmount = (float) salud / 100;
        aseoImage.fillAmount = (float) aseo / 100;
    }

}
