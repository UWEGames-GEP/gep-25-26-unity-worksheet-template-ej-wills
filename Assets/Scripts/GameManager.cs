using UnityEngine;

public class GameManager : MonoBehaviour
{

    enum GameStates {GamePlay, Pause};
    [SerializeField] GameStates  state ;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        state = GameStates.GamePlay;


    }

    // Update is called once per frame
    void Update()
    {
       if(state == GameStates.GamePlay)
       {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            state = GameStates.Pause;
        }
       } 

       else if (state == GameStates.Pause)
       {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            state = GameStates.GamePlay;
        }
       }
    }
}
