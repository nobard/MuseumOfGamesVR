using UnityEngine;

public class Cell : MonoBehaviour, ITTTCell
{
    [HideInInspector] public TicTacToeLogic Logic;

    public GameObject PlaceForFigure { get; set; }

    public void Interaction()
    {
        Logic.DoTurn(gameObject);
    }
}
