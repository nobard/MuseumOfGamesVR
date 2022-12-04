using UnityEngine;

public class Cell : MonoBehaviour, ITTTCell
{
    [HideInInspector] public TicTacToeLogic Logic;

    public GameObject PlaceForFigure { get; set; }

    private bool busy = false;
    public void Interaction()
    {
        if(!busy)
        {
            Logic.DoTurn(gameObject);
            busy = true;
        } 
    }
}
