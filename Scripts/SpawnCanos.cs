using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCanos : MonoBehaviour
{
    public GameObject cano;
    public float height;
    public float maxTime;

    private float timer = 0f;

    private void Start()
    {
        //aqui é gerado os canos já no start
        GameObject novoCano = Instantiate(cano);
        
        //vai pegar o height e colocar entre um valor negativo e um positivo
        novoCano.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
        Destroy(novoCano, 13f);
    }

    private void Update()
    {
        if (timer > maxTime)
        {
            //aqui é gerado os canos conforme o tempo passa
            GameObject novoCano = Instantiate(cano);

            //vai pegar o height e colocar entre um valor negativo e um positivo
            novoCano.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            
            //aqui o cano é destruído depois de um tempo pra n pesar
            Destroy(novoCano, 13f);
            timer = 0;
        }

        //somando Time.deltaTime o contador reproduz a contagem no tempo da vida real
        timer += Time.deltaTime;

    }

}
