using UnityEngine;

public class GameManager : MonoBehaviour
{

    enum GameStates {GamePlay, Pause};
    [SerializeField] GameStates  state ;
    private bool hasChanged = false;

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
        if(Input.GetKeyDown(KeyCode.Return))
        {
            state = GameStates.Pause;
            hasChanged = true;
        }
       } 

       else if (state == GameStates.Pause)
       {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            state = GameStates.GamePlay;
            hasChanged = true;
        }
       }
    }

    private void LateUpdate()
    {
        if(hasChanged)
        {
            hasChanged = false;
        

        if (state == GameStates.GamePlay)
        {
            Time.timeScale = 1.0f;
        }
        else if (state == GameStates.Pause)
        {
            Time.timeScale = 0.0f;

        }
        }

    }

}
