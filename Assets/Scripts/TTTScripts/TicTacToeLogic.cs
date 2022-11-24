using System.Collections.Generic;
using UnityEngine;

public class TicTacToeLogic : MonoBehaviour
{
    [SerializeField] GameObject CrossPrefab;
    [SerializeField] GameObject CirclePrefab;
    [SerializeField] List<GameObject> Cells;
    

    private void Start()
    {
        foreach(var e in Cells)
        {
            e.GetComponent<Cell>().Logic = this;
        }
    }

    public void DoTurn(GameObject currCell)
    {
        
    }
}
