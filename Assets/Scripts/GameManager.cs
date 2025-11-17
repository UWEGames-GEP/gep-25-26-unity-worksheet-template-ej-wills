using UnityEngine;

public class GameManager : MonoBehaviour
{

    public enum GameStates {GamePlay, Pause};
    public GameStates  state ;
  

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        state = GameStates.GamePlay;


    }

    // Update is called once per frame
    void Update()
    {
    //    if(state == GameStates.GamePlay)
    //    {
    //     if(Input.GetKeyDown(KeyCode.Return))
    //     {
    //         state = GameStates.Pause;
          
    //     }
    //    } 

    //    else if (state == GameStates.Pause)
    //    {
    //     if(Input.GetKeyDown(KeyCode.Return))
    //     {
    //         state = GameStates.GamePlay;
            
    //     }
    //    }
    }


    public void PauseOption()
    {
        if(state == GameStates.GamePlay)
       {
            state = GameStates.Pause;
           
       } 

       else if (state == GameStates.Pause)
       {
            state = GameStates.GamePlay;
       }
    }

    private void LateUpdate()
    {

        switch(state)
        {
            case GameStates.GamePlay:
                Time.timeScale = 1.0f;
                break;

            case GameStates.Pause:
                Time.timeScale = 0.0f;
                break;
        }


        

    }
}
