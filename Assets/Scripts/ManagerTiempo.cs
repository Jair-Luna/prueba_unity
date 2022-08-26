using UnityEngine;

public class ManagerTiempo : MonoBehaviour
{

    public static float horaJuego;
    public float hourLength;

    private void Update()
    {
        if(horaJuego <= 0)
        {
            horaJuego = hourLength;
        }
        else
        {
            horaJuego -= Time.deltaTime;
        }
    }
}
