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

    //temp
    bool temp = true;
    public void DoTurn(GameObject currCell)
    {
        if(temp)
        {
            Instantiate(CrossPrefab, currCell.transform.position, new Quaternion());
            temp = false;
        }
        else
        {
            Instantiate(CirclePrefab, currCell.transform.position, new Quaternion());
            temp = true;
        }   
    }
}
