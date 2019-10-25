using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public BoardManager boardManager;

    private int level = 3;

    //para que lo primero que se haga sea inicializar el tablero
    private void Awake()
    {
        boardManager.SceneSetup(level);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
