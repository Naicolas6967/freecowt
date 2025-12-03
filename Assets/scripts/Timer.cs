using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI textoTimer;
    [SerializeField] float tempoRestante;

    // Update is called once per frame
    void Update()
    {
     if (tempoRestante > 0)
        {
            tempoRestante = tempoRestante - Time.deltaTime;

        }
    
    else
    {
    tempoRestante = 0;
    //CabouOJogo();
    textoTimer.color = Color.yellow;

    }
int minutos = Mathf.FloorToInt(tempoRestante / 60);
int segundos = Mathf.FloorToInt(tempoRestante % 60);
textoTimer.text = string.Format("{0:00}:{1:00}", minutos, segundos);


    }
}
