using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{

    public GameController controller;
    AudioSource pointSound;

    private void Awake()
    {
        pointSound = GetComponent<AudioSource>();
    }

    private void Start()
    {   //toda vez que iniciar, procura todos os objetos com script gamecontroller
        controller = FindObjectOfType<GameController>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        pointSound.Play();
        controller.pontuacao++;
        controller.pontuacaoText.text = controller.pontuacao.ToString();

    }

}
