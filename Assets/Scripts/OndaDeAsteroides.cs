using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OndaDeAsteroides : MonoBehaviour
{
    public ComportamentoAsteroide prefabAsteroide;
    public int quantosAsteroides = 3;
    void Start()
    {
        for (int i = 0; i < quantosAsteroides; i++)
        {
            float x = Random.Range(-19.6f, 19.6f);
            float y = Random.Range(10.71f,-11.05f);
            Vector3 posicao = new Vector3(x, y, 0.0f);
            Instantiate(prefabAsteroide, posicao, Quaternion.identity);
        }
    }
}