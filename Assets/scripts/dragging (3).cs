using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
//using static UnityEditor.Experimental.GraphView.GraphView;


public class NewBehaviourScript : MonoBehaviour
{
    //intial values
    static int state = 0;
    static int a = 0;
    static int counterMove;
    static Image[] marked = new Image[9];
    public Image Y, Z;
    private static EventTrigger stop;

    //Canvas shapes
    public Image obj0, obj1, obj2, obj3, obj4, obj5, obj6, obj7, obj8;
    public GameObject overPanel;
    public TextMeshProUGUI overText;

    //Canvas Words 
    public GameObject obj0Btn, obj1Btn, obj2Btn, obj3Btn, obj4Btn, obj5Btn, obj6Btn, obj7Btn, obj8Btn;
    public Button playerX, playerO;
    //Canvas XO images & pos
    public Image XO1, XO2, XO3, XO4, XO5, XO6, XO7, XO8, XO9, X, O;
    private Vector3 XO1pos, XO2pos, XO3pos, XO4pos, XO5pos, XO6pos, XO7pos, XO8pos, XO9pos;
    private Vector3 obj0Btnpos, obj1Btnpos, obj2Btnpos, obj3Btnpos, obj4Btnpos, obj5Btnpos, obj6Btnpos, obj7Btnpos, obj8Btnpos;



    // Audios
    public AudioSource BG;
    public AudioSource right;
    public AudioSource wrong;
    public AudioSource S1,S2, S3, S4, S5, S6, S7, S8, S9,winner_,Draw;
    


    // Start is called before the first frame update


    void Start()
    {
        //intialize position of words
        obj0Btnpos = obj0Btn.transform.position;
        obj1Btnpos = obj1Btn.transform.position;
        obj2Btnpos = obj2Btn.transform.position;
        obj3Btnpos = obj3Btn.transform.position;
        obj4Btnpos = obj4Btn.transform.position;
        obj5Btnpos = obj5Btn.transform.position;
        obj6Btnpos = obj6Btn.transform.position;
        obj7Btnpos = obj7Btn.transform.position;
        obj8Btnpos = obj8Btn.transform.position;
        //intialize overPanel
        overPanel.SetActive(false);
        //X O color
        playerX.image.color = Color.green;



        //BackGround Sound
        BG.Play();
    }
    
    //drag with mouse functions
    public void dragobj0()
    {
        obj0Btn.transform.position = Input.mousePosition;
    }
    public void dragobj1()
    {
        obj1Btn.transform.position = Input.mousePosition;
    }
    public void dragobj2()
    {
        obj2Btn.transform.position = Input.mousePosition;
    }
    public void dragobj3()
    {
        obj3Btn.transform.position = Input.mousePosition;
    }
    public void dragobj4()
    {
        obj4Btn.transform.position = Input.mousePosition;
    }
    public void dragobj5()
    {
        obj5Btn.transform.position = Input.mousePosition;
    }
    public void dragobj6()
    {
        obj6Btn.transform.position = Input.mousePosition;
    }
    public void dragobj7()
    {
        obj7Btn.transform.position = Input.mousePosition;
    }
    public void dragobj8()
    {
        obj8Btn.transform.position = Input.mousePosition;
    }

    //Drop words functions
    public void dropobj0()
    {
        float Distance = Vector3.Distance(obj0Btn.transform.position, obj0.transform.position);
        if (Distance < 50)
        {
            obj0Btn.transform.position = X.transform.position;
            a = 0;
            play(a);
            right.Play();
            S1.Play();

        }
        else
        {
            obj0Btn.transform.position = obj0Btnpos;
            wrong.Play();
        }
    }
    public void dropobj1()
    {
        float Distance = Vector3.Distance(obj1Btn.transform.position, obj1.transform.position);
        if (Distance < 50)
        {
            obj1Btn.transform.position = X.transform.position;
            a = 1;
            play(a);
            right.Play();
            S2.Play();

        }
        else
        {
            obj1Btn.transform.position = obj1Btnpos;
            wrong.Play();

        }
    }
    public void dropobj2()
    {
        float Distance = Vector3.Distance(obj2Btn.transform.position, obj2.transform.position);
        if (Distance < 50)
        {
            obj2Btn.transform.position = X.transform.position;
            a = 2;
            play(a);
            right.Play();
            S3.Play();

        }
        else
        {
            obj2Btn.transform.position = obj2Btnpos;
            wrong.Play();

        }
    }
    public void dropobj3()
    {
        float Distance = Vector3.Distance(obj3Btn.transform.position, obj3.transform.position);
        if (Distance < 50)
        {
            obj3Btn.transform.position = X.transform.position;
            a = 3;
            play(a);
            right.Play();
            S4.Play();

        }
        else
        {
            obj3Btn.transform.position = obj3Btnpos;
            wrong.Play();

        }
    }
    public void dropobj4()
    {
        float Distance = Vector3.Distance(obj4Btn.transform.position, obj4.transform.position);
        if (Distance < 50)
        {
            obj4Btn.transform.position = X.transform.position;
            a = 4;
            play(a);
            right.Play();
            S5.Play();

        }
        else
        {
            obj4Btn.transform.position = obj4Btnpos;
            wrong.Play();

        }
    }
    public void dropobj5()
    {
        float Distance = Vector3.Distance(obj5Btn.transform.position, obj5.transform.position);
        if (Distance < 50)
        {
            obj5Btn.transform.position = X.transform.position;
            a = 5;
            play(a);
            right.Play();
            S6.Play();

        }
        else
        {
            obj5Btn.transform.position = obj5Btnpos;
            wrong.Play();

        }
    }
    public void dropobj6()
    {
        float Distance = Vector3.Distance(obj6Btn.transform.position, obj6.transform.position);
        if (Distance < 50)
        {
            obj6Btn.transform.position = X.transform.position;
            a = 6;
            play(a);
            right.Play();
            S7.Play();

        }
        else
        {
            obj6Btn.transform.position = obj6Btnpos;
            wrong.Play();

        }
    }
    public void dropobj7()
    {
        float Distance = Vector3.Distance(obj7Btn.transform.position, obj7.transform.position);
        if (Distance < 50)
        {
            obj7Btn.transform.position = X.transform.position;
            a = 7;
            play(a);
            right.Play();
            S8.Play();

        }
        else
        {
            obj7Btn.transform.position = obj7Btnpos;
            wrong.Play();

        }
    }
    public void dropobj8()
    {
        float Distance = Vector3.Distance(obj8Btn.transform.position, obj8.transform.position);
        if (Distance < 50)
        {
            obj8Btn.transform.position = X.transform.position;
            a = 8;
            play(a);
            right.Play();
            S9.Play();

        }
        else
        {
            obj8Btn.transform.position = obj8Btnpos;
            wrong.Play();

        }
    }
    //play X or O
    public void play(int A)
    {
        counterMove++;
        Image[] XO = { XO1, XO2, XO3, XO4, XO5, XO6, XO7, XO8, XO9 };
        Image[] parts = { obj0, obj1, obj2, obj3, obj4, obj5, obj6, obj7, obj8 };

        //Intial state for marked array
        for (int i = 0; i < marked.Length; i++)
        {
            if (marked[0] == null || marked[1] == null || marked[2] == null || marked[3] == null || marked[4] == null || marked[5] == null || marked[6] == null || marked[7] == null || marked[8] == null)
            {
                marked[0] = Z;
                marked[1] = Y;
                marked[2] = Z;
                marked[3] = Y;
                marked[4] = Y;
                marked[5] = Z;
                marked[6] = Z;
                marked[7] = Z;
                marked[8] = Y;
            }
        }
        //Set X or O
        switch (state)
        {

            case 0:
                // Set X 
                playerX.image.color = playerX.colors.normalColor;
                playerO.image.color = Color.green;
                if (XO[A].transform.position != parts[A].transform.position && XO[A].transform.position != parts[A].transform.position)
                {
                   
                   

                    state = 1;
                    XO[A].sprite = X.sprite;
                    XO[A].transform.position = parts[A].transform.position;
                    marked[A] = XO[A];
                    if (checkWinner() == true)
                    {
                        SetGameEnd(0);
                    }
                    else if (checkWinner() == false && counterMove == 9)
                    {
                        SetGameEnd(2);
                    }
                }
                break;
            case 1:
                playerX.image.color = Color.green;
                playerO.image.color = playerO.colors.normalColor;
                //Set O
                if (XO[A].transform.position != parts[A].transform.position && XO[A].transform.position != parts[A].transform.position)
                {
                    

                    state = 0;
                    XO[A].sprite = O.sprite;
                    XO[A].transform.position = parts[A].transform.position;
                    marked[A] = XO[A];
                    if (checkWinner())
                    {
                        SetGameEnd(1);
                    }
                    else if (checkWinner() == false && counterMove == 9)
                    {
                        SetGameEnd(2);
                    }
                }
                break;
        }

    }

    //Check win or draw
    private bool checkWinner()
    {
        // Check rows
        for (int i = 0; i < 9; i += 3)
        {
            if (marked[i].sprite == marked[i + 1].sprite && marked[i + 1].sprite == marked[i + 2].sprite)
            {
                return true; // Row is marked with the same sign
            }
        }

        // Check columns
        for (int i = 0; i < 3; i++)
        {
            if (marked[i].sprite == marked[i + 3].sprite && marked[i + 3].sprite == marked[i + 6].sprite)
            {
                return true; // Column is marked with the same sign
            }
        }

        // Check diagonals
        if (marked[0].sprite == marked[4].sprite && marked[4].sprite == marked[8].sprite)
        {
            return true; // Left-top to right-bottom diagonal
        }
        if (marked[2].sprite == marked[4].sprite && marked[4].sprite == marked[6].sprite)
        {
            return true; // Right-top to left-bottom diagonal
        }

        return false;
    }

    //GameEnd
    private void SetGameEnd(int winner)
    {
        if (winner == 0)
        {
            SetPanelStatus("Player X Wins!");
            winner_.Play();
        } else if (winner == 1)
        {
            SetPanelStatus("Player O Wins!");
            winner_.Play();

        }
        else if (winner == 2)
        {
            SetPanelStatus("It's A Draw");
            Draw.Play();
        }
    }

    //Disable dragging after game ending
    private void Disabled()
    {
       GameObject [] dragged = {obj0Btn, obj1Btn, obj2Btn, obj3Btn, obj4Btn, obj5Btn, obj6Btn, obj7Btn, obj8Btn};
       for (int i = 0; i < dragged.Length; i++)
        {
            stop = dragged[i].GetComponent<EventTrigger>();
            stop.enabled = false;
        }
    }

    //Restart Game Button on click
    public void ResetGame()
    {
        //gameEnded = false;
        state = 0;
        ResetBoard();
    }
    //Reset Board
    private void ResetBoard()
    {
        GameObject[] dragged = { obj0Btn, obj1Btn, obj2Btn, obj3Btn, obj4Btn, obj5Btn, obj6Btn, obj7Btn, obj8Btn };
        Image[] XO = { XO1, XO2, XO3, XO4, XO5, XO6, XO7, XO8, XO9 };
        Image[] parts = { obj0, obj1, obj2, obj3, obj4, obj5, obj6, obj7, obj8 };
        GameObject[] buttonsReset = { obj0Btn, obj1Btn, obj2Btn, obj3Btn, obj4Btn, obj5Btn, obj6Btn, obj7Btn, obj8Btn };
        Vector3[] originalPositions = { obj0Btnpos, obj1Btnpos, obj2Btnpos, obj3Btnpos, obj4Btnpos, obj5Btnpos, obj6Btnpos, obj7Btnpos, obj8Btnpos };
        // Move all the game pieces back to their original positions
        for (int i = 0; i < 9; i++)
        {
            XO[i].transform.position = Z.transform.position;
            buttonsReset[i].transform.position = originalPositions[i];
            marked[i] = null;
            stop = dragged[i].GetComponent<EventTrigger>();
            stop.enabled = true;
        }
        overPanel.SetActive(false);
        counterMove = 0;
        playerX.image.color = Color.green;
        playerO.image.color = Color.green;
    }

    //show Text winner
    public void SetPanelStatus(string value)
    {
        overPanel.SetActive(true);
        overText.text = value;
        Disabled();
    }

    //home
    public void GoHome()
    {
        Application.LoadLevel("Maininterface");
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
